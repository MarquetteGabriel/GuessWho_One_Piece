/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.GameData;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Locale;
import java.util.Objects;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.util.regex.PatternSyntaxException;

public class ExtractorPattern
{
    private static final List<String> pirateTypeList = Arrays.asList("Pirate", "Pirates", "Bandit",
            "Bandits", "Charlotte", "Big Mom", "Flotte de Happou", "Clan", "Moria", "Équipage",
            "Edward", "César", "Equipage", "Mihawk", "Thriller", "Mads", "New Comer Land",
            "Spiders Café");
    private static final List<String> navyTypeList = Arrays.asList("Marine", "Marines", " Marines", "Cipher Pol",
            "Souverain", "Conseil des 5 doyens", "CP-AIGIS0", "Gouvernement", "Impel", "Navy's Crew", "Juge");
    private static final List<String> revoTypeList = Arrays.asList("Armée Révolutionnaire",
            "Révolutionnaires", "armée révolutionnaire", "Revolutionary's Crew", "Armée de la Liberté");


    static String extractPattern(String input, String pattern) {
        try
        {
            Pattern regex = Pattern.compile(pattern);
            Matcher matcher = regex.matcher(input);
            if (matcher.find()) {
                return matcher.group(1);
            }
            return "";
        }
        catch (IndexOutOfBoundsException | PatternSyntaxException ignored)
        {
            return "";
        }

    }

    static String extractPatternBounty(String input)
    {
        Pattern regex = Pattern.compile("Prime : (.*?)(Statut|Anniversaire|Âge)");
        Matcher matcher = regex.matcher(input);
        long maxBounty = 0;
        if(matcher.find())
        {
            if(matcher.group(1) != null)
            {
                if(!matcher.group(1).contains("Inconnue") && !matcher.group(1).contains("Aucune"))
                {
                    String text = matcher.group(1).replaceAll("(?<!\\])\\s", ".").replaceAll(";", " ").replaceAll("\\(", "");
                    text = text.replaceAll("\\[.*?\\]", "").replaceAll(",", ".").replaceAll("\\(.*?\\)", "");
                    String[] bountys = text.split("\\s+");
                    for (String bounty : bountys)
                    {
                        maxBounty = Math.max(maxBounty, Long.parseLong(bounty.replaceAll("\\.", "")));

                    }
                }
            }
        }

        if(maxBounty == 0)
        {
            return "";
        }
        else
        {
            return String.valueOf(maxBounty);
        }
    }

    static String fixBounty(String bounty, String type)
    {
        for (String navyType : navyTypeList)
        {
            if (type.contains(navyType)) {
                type = "Navy";
                break;
            }
        }

        if(type.equals("Navy") || type.equals("Citizen"))
        {
            return "0";
        }
        else if(bounty.equals("") || bounty.equals("Inconnue") || bounty.equals("Aucune"))
        {
            return "Unknown";
        }
        else
        {
            double numBounty = Double.parseDouble(bounty);
            if(numBounty >= 1_000_000_000)
            {
                return String.format(Locale.getDefault() ,"%.3f Md", numBounty / 1_000_000_000).replaceAll("[,.]0+ Md", " Md");
            }
            else if (numBounty >= 1_000_000)
            {
                return String.format(Locale.getDefault(), "%.3f Mi", numBounty / 1_000_000).replaceAll("[,.]0+ Mi", " Mi");
            }
            else
            {
                return bounty;
            }
        }
    }

    static String fixType(String value, String crew)
    {
        if(crew.contains("Celestial Dragons"))
        {
            return "Navy";
        }
        else if (value.contains("Dragon Celestes")) {
            return value;
        }

        for (String pirateType : pirateTypeList)
        {
            if (crew.contains(pirateType)) {
                value = "Pirate";
                break;
            }
        }
        for (String navyType : navyTypeList)
        {
            if (crew.contains(navyType)) {
                value = "Navy";
                break;
            }
        }
        for (String revoType : revoTypeList)
        {
            if (crew.contains(revoType)) {
                value = "Revolutionary";
                break;
            }
        }

        return value;
    }

    static String fixCrew(String rawCrew, String type)
    {
        rawCrew = rawCrew.replaceAll("\\s+$", "");
        if(rawCrew.startsWith("CP"))
        {
            return "Cipher Pol";
        }
        else if(rawCrew.isEmpty())
        {
            return type;
        }
        else if (type.equals("Citizen"))
        {
            return "Citizen";
        }
        else
        {
            switch (rawCrew)
            {
                case "Dragon Celestes":
                    return "Celestial Dragons";
                case "Revolutionary":
                    return "Revolutionary's Crew";
                case "Marine":
                case "Marines":
                case " Marines":
                    return "Navy's Crew";
                case "Subordonné de L'Équipage de Barbe Blanche":
                    return "L'Équipage de Barbe Blanche";
                case "La Grande Flotte du Chapeau de Paille":
                case "Alliance de l'Équipage du Chapeau de Paille":
                case "Flotte de Happou":
                case "L'Équipage d'Idéo":
                case "Erbaf":
                case "L'Équipage des Magnifiques Pirates":
                case "L'Équipage d'Ideo":
                    return "Allié de L'Équipage du Chapeau de Paille";
                case "Équipage de Big Mom":
                case "Famille Charlotte":
                    return "L'Équipage de Big Mom";
                case "Spiders Café":
                case "Spider's Café":
                    return "Baroque Works";
                case "Capitaine de l'Equipage de Caribou" :
                    return "L'Équipage de Caribou";
                case "L'Équipage de Barbe Brune(dissout)":
                case "César Clown":
                case "César Clown (espionnage)":
                case "L'Équipage du New Age":
                    return "L'Équipage de Don Quichotte Doflamingo";
                case "L'Équipage des Pirates Volants":
                    return "L'Équipage des Nouveaux Hommes-Poissons";
                case "L'Équipage du Firetank" :
                    return "L'Équipage du Fire Tank";
                case "Gecko Moria" :
                case "Hogback":
                case "Dracule Mihawk":
                    return "Thriller Bark";
                case "Alliance Baggy et Alvida":
                case "L'Équipage du Clown":
                    return "Cross Guild";
                case "L'Équipage du Capitaine Usopp":
                    return "Citizen";
                default:
                    return rawCrew;
            }
        }
    }

    static String extractPatternCrew(Element text)
    {
        try
        {
            List<String> affiliationCharacter = new ArrayList<>();
            Elements affiliations = text.select(".pi-data-value > a");
            for (Element affiliation : affiliations)
            {
                String affilationText = affiliation.text();
                if((affiliation.nextElementSibling() != null) && (affiliation.nextElementSibling().text().contains("anciennement") || affiliation.nextElementSibling().text().contains("temporairement") ||
                affiliation.nextElementSibling().text().contains("dissous")))
                {
                    String smallText = affiliation.nextElementSibling().text();
                    affilationText += smallText;
                }
                affiliationCharacter.add(affilationText);
            }

            for(String affiliation : affiliationCharacter)
            {
                affiliation = affiliation.replaceAll("\\[.*?]\\s*$", "");
                if(!affiliation.contains("anciennement") && !affiliation.contains("temporairement") && !affiliation.contains("dissous"))
                {
                    return affiliation;
                }
            }
            return "Citizen";
        }
        catch (Exception e)
        {
            return "Citizen";
        }
    }

    static int extractPatternAge(String input)
    {
        Matcher matcherChoice = Pattern.compile("Âge : (.*?) Voix | Âge : (.*?) Taille").matcher(input);
        int maxAge = 0;
        if(matcherChoice.find())
        {
            String textAge = matcherChoice.group(0);
            if(textAge.contains("lors de sa mort") || textAge.contains("lors du décès"))
            {
                Matcher matcher = Pattern.compile("(\\d+\\s)?\\d+ ans \\(lors d").matcher(input);
                while ((matcher.find()))
                {
                    maxAge = Math.max(maxAge, Integer.parseInt(Objects.requireNonNull(matcher.group(0)).replaceAll("\\D", "")));
                }
            }
            else
            {
                textAge = textAge.replaceAll("\\s", "").replaceAll("\\(.*?\\)", " ").replaceAll("\\[.*?\\]", " ");
                String[] ages = textAge.split("[\\D+]");
                for (String age : ages)
                {
                    if(!age.isEmpty())
                    {
                        maxAge = Math.max(maxAge, Integer.parseInt(age));
                    }
                }
            }
        }
        return maxAge;
    }

    static String extractPatternType(Element text)
    {
        try
        {
            List<String> typeCharacter = new ArrayList<>();
            String[] types = text.select(".pi-data-value").html().split("<br>|<p>|<a>");
            for(String type : types)
            {
                Document docSmallDatas = Jsoup.parse(type);
                String smallText = docSmallDatas.select("small").text();
                type = Jsoup.parse(type).text().replaceAll("\\(.*?\\)", "").trim() + smallText;
                typeCharacter.addAll(Arrays.asList(type.split("[;,]")));
            }
            typeCharacter.removeIf(String::isEmpty);

            String type = "Citizen";
            for(String typeData : typeCharacter)
            {
                typeData = typeData.replaceAll("\\[.*?]\\s*$", "");
                if(!typeData.contains("anciennement") && !typeData.contains("temporairement"))
                {
                    if (typeData.contains("Dragons Celestes") || typeData.contains("Dragons Célestes")
                            || typeData.contains("Nobles Mondiaux"))
                    {
                        type = "Dragon Celestes";
                        break;
                    }

                    for (String pirateType : pirateTypeList)
                    {
                        if (typeData.contains(pirateType)) {
                            type = "Pirate";
                            break;
                        }
                    }
                    for (String navyType : navyTypeList)
                    {
                        if (typeData.contains(navyType) && !typeData.contains("Prisonnier")) {
                            type = "Navy";
                            break;
                        }
                    }
                    for (String revoType : revoTypeList)
                    {
                        if (typeData.contains(revoType)) {
                            type = "Revolutionary";
                            break;
                        }
                    }

                    if(typeData.isEmpty())
                    {
                        type = "Citizen";
                    }
                }
            }
            return type;
        }
        catch (Exception e)
        {
            return "Citizen";
        }
    }

    static String extractExceptions(String character)
    {
        switch (character)
        {
            case "Chadros Higelyges":
                return "Barbe Brune";
            case "Jabra":
                return "Jabura";
            case "Tama":
                return "Kurozumi Tama";
            case "Kaku (Wano)":
                return "Kaku";
            case "Enel":
                return "Ener";
            case "Buckingham Stussy":
                return "Bakkin";
            default :
                return character;
        }
    }

    static String extractExceptionsPopularity(String character)
    {
        if (character.contains("Don Quichotte"))
        {
            return character.replace("Don Quichotte", "Donquixote");
        }
        else if(character.contains("Alber"))
        {
            return "King";
        }
        else if (character.contains("Linlin"))
        {
            return "Big Mom";
        }
        else if(character.contains("Galdino"))
        {
            return "Mr 3";
        }
        else if(character.contains("Marshall D. Teach"))
        {
            return "Barbe Noire";
        }
        else if(character.contains("Edward Newgate"))
        {
            return "Barbe Blanche";
        }
        else
        {
            return character;
        }
    }
}
