/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.GameData;

import android.content.Context;

import org.apache.commons.text.similarity.CosineSimilarity;
import org.apache.commons.text.similarity.LevenshteinDistance;
import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;

import java.io.IOException;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Objects;
import java.util.concurrent.CopyOnWriteArrayList;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import fr.gmarquette.guesswho.GameData.Database.Characters;
import fr.gmarquette.guesswho.GameData.Database.DAO;
import fr.gmarquette.guesswho.GameData.Database.DataBase;

public class ImportDataManager
{
    /*
    Variables //TODO:
     */
    final Integer NUMBER_OF_LEVELS = 2;
    public final List<String> characterNameList = new ArrayList<>();
    private final List<String> listPopularity = new ArrayList<>();
    private final CopyOnWriteArrayList<Characters> charactersList = new CopyOnWriteArrayList<>();
    private List<String> completedNameList = new ArrayList<>();
    private int countPercentage, countLevels;

    /*
    Singleton definition
     */
    private ImportDataManager() {}
    private static class ImportDataManagerHolder
    {
        private final static ImportDataManager instance = new ImportDataManager();
    }
    public static ImportDataManager getInstance()
    {
        return ImportDataManager.ImportDataManagerHolder.instance;
    }


    /*
    Manage the import
     */
    public void importManager(Context context)
    {
        ExecutorService executorService = Executors.newSingleThreadExecutor();

        executorService.submit(() -> {
            countPercentage = countLevels = 0;
            getListOfCharacters();
            completedNameList = characterNameList;
            multiImport();
            countPercentage = characterNameList.size();
            calculatePopularityForCharacter();
            addCharacterToDataBase(context);
        });
        executorService.shutdown();
    }

    private void multiImport()
    {
        for (String character : characterNameList)
        {
            ExecutorService executorService = Executors.newSingleThreadExecutor();
            executorService.submit(() -> getDatasForEachCharacter(character));
            executorService.shutdown();
            try {
                Thread.sleep(65);
            } catch (InterruptedException e) {
                throw new RuntimeException(e);
            }
        }
    }

    /*
    Import Datas from websites (Api update later)
     */
    void getListOfCharacters()
    {
        try {
            String url_fandom_listcharacter = "https://onepiece.fandom.com/fr/wiki/Liste_des_Personnages_Canon";
            Document doc = Jsoup.connect(url_fandom_listcharacter).get();
            Elements tables = Jsoup.parse(doc.getElementsByClass("tabber wds-tabber").html()).select("table.wikitable");

            for (Element table : tables)
            {
                if (table != null)
                {
                    Elements rows = table.select("tr");
                    for (Element row : rows) {
                        Elements columns = row.select("td");
                        if (columns.size() >= 6) {
                            String character = ExtractorPattern.extractExceptions(columns.get(1).text());
                            characterNameList.add(character);
                        }
                    }
                }
            }
        } catch (IOException ignored) {

        }
    }

    /*
    Get datas for each character
     */
    void getDatasForEachCharacter(String character)
    {
        try {
            String url_character = character.replace(" ", "_").trim();
            Pattern pattern = Pattern.compile("(.+)_\\(.*\\)");
            Matcher matcher = pattern.matcher(url_character);
            if (matcher.matches()) {
                url_character = matcher.group(1);
            }
            String url_fandom = "https://onepiece.fandom.com/fr/wiki/";
            String url = url_fandom + url_character;

            Element typeElement = null, crewElement = null;
            Document doc = Jsoup.connect(url).get();
            String class_characterData = "pi-item pi-group pi-border-color";
            String characterData = doc.getElementsByClass(class_characterData).text();
            String class_fruit = "portable-infobox pi-background pi-border-color pi-theme-char pi-layout-default";
            String fruitElement = doc.getElementsByClass(class_fruit).text();
            String class_type = "pi-item pi-data pi-item-spacing pi-border-color";
            String class_picture = "pi-navigation pi-item-spacing pi-secondary-font";
            String pictureElement = doc.getElementsByClass(class_picture).select("img").attr("src");
            Elements bountyTypeCrewElements = doc.getElementsByClass(class_type);

            for (Element bountyTypeCrewElement : bountyTypeCrewElements) {
                String dataSource = bountyTypeCrewElement.attr("data-source");

                if (dataSource.equals("occupation")) {
                    typeElement = bountyTypeCrewElement;
                }
                else if (dataSource.equals("affiliation")) {
                    crewElement = bountyTypeCrewElement;
                }
            }

            String crew = ExtractorPattern.extractPatternCrew(crewElement);
            boolean fruit = fruitElement.contains("Fruit du Démon");
            String type = ExtractorPattern.fixType(ExtractorPattern.extractPatternType(typeElement), crew);
            String bounty = ExtractorPattern.fixBounty(ExtractorPattern.extractPatternBounty(characterData).replaceAll("[.,\\s]", "").trim(), type);
            int chapter = Integer.parseInt(ExtractorPattern.extractPattern(characterData, "Chapitre (\\d+)"));
            boolean alived = !ExtractorPattern.extractPattern(characterData, "Statut : (Vivant|Décédé)").equals("Décédé");
            int age = ExtractorPattern.extractPatternAge(characterData);
            crew = ExtractorPattern.fixCrew(crew, type);
            type = ExtractorPattern.fixType(type, crew);

            Characters characters = new Characters(character, fruit, bounty, chapter, type, alived,
                    age, crew, pictureElement, NUMBER_OF_LEVELS + 1);
            charactersList.add(characters);
            countPercentage++;

            if(countPercentage > characterNameList.size())
            {
                countPercentage = characterNameList.size();
            }
            
        } catch (IOException e) {
            Thread.currentThread().interrupt();
            countPercentage++;
        }
    }
    
    /*
    Define level for character
     */
    private void calculatePopularityForCharacter()
    {
        try {
            String url_levels = "http://www.volonte-d.com/details/popularite.php";
            Document doc = Jsoup.connect(url_levels).get();
            Elements elements = doc.getElementsByClass("gallery clearfix");
            if(elements.last() != null)
            {
                Elements tables = Objects.requireNonNull(elements.last()).select("table");
                if(!tables.isEmpty())
                {
                    Element table = tables.last();
                    if (table != null)
                    {
                        Elements rows = table.select("tr");
                        for (int i = 1; i < rows.size(); i++)
                        {
                            Element row = rows.get(i);
                            Elements cols = row.select("td");
                            listPopularity.add(cols.get(1).text());
                        }
                    }
                }
            }

            for (String character : characterNameList) {
                String tempCharacterName = character;
                if(tempCharacterName.contains("alias"))
                {
                    tempCharacterName = character.replaceAll("\\s*\\(.*?\\)", "");
                }
                int position = listPopularity.indexOf(tempCharacterName);

                if (position == -1) {
                    String newCharacter = getMatcher(tempCharacterName);
                    position = listPopularity.indexOf(newCharacter);
                    if(position == -1)
                    {
                        position = listPopularity.size();
                    }
                }

                for (Characters characters : charactersList) {
                    if (characters.getName().equals(character)) {
                        for (int i = NUMBER_OF_LEVELS; i >= 1; i--) {
                            if (position <= 200 * i) {
                                characters.setLevel(i-1);
                            }
                        }

                        if(characters.getLevel() == NUMBER_OF_LEVELS + 1)
                        {
                            characters.setLevel(NUMBER_OF_LEVELS - 1);
                        }
                    }
                }
                countLevels++;
            }
        } catch (IOException ignored) {
        }
    }

    private String getMatcher(String character)
    {
        String newCharacter = "";
        double meilleureRessemblance = 0.0;
        String texteRessemblant = null;
        for (String popularityCharacter : listPopularity)
        {
            character = ExtractorPattern.extractExceptionsPopularity(character);
            double ressemblance = calculateSimilarity(character, popularityCharacter);

            if (ressemblance >= 0.6 && ressemblance > meilleureRessemblance) {
                meilleureRessemblance = ressemblance;
                texteRessemblant = popularityCharacter;
            }
        }

        if(texteRessemblant != null)
        {
            newCharacter = texteRessemblant;
        }
        else
        {
            for (String popularityCharacter : listPopularity)
            {
                LevenshteinDistance levenshteinDistance = new LevenshteinDistance();
                int distance = levenshteinDistance.apply(character, popularityCharacter);
                int seuilDistance = 6;
                if (distance <= seuilDistance) {
                    newCharacter = popularityCharacter;
                }
            }
        }
        return newCharacter;
    }

    private static double calculateSimilarity(String texte1, String texte2) {
        String[] termes1 = texte1.split(" ");
        String[] termes2 = texte2.split(" ");
        Map<CharSequence, Integer> vector1 = new HashMap<>();
        Map<CharSequence, Integer> vector2 = new HashMap<>();
        for (String terme : termes1)
        {
            vector1.put(terme, 1);
        }
        for (String terme : termes2)
        {
            vector2.put(terme, 1);
        }
        CosineSimilarity cosSimilarity = new CosineSimilarity();
        return cosSimilarity.cosineSimilarity(vector1, vector2);
    }

    /*
    Add all characters to the database
     */
    void addCharacterToDataBase(Context context)
    {
        DAO dao =  DataBase.getInstance(context).dao();

        for (Characters character : charactersList) {
            if(character.getAge() != 0)
            {
                Characters characterExist = dao.getCharacterFromName(character.getName());
                if (characterExist != null)
                {
                    dao.deleteCharacter(characterExist);
                }

                dao.addCharacter(character);
            }
            else
            {
                charactersList.remove(character);
                characterNameList.remove(character.getName());
            }
        }
        countLevels++;
    }

    public List<String> getNameList()
    {
        return this.completedNameList;
    }

    public int getAvancement(int max)
    {
        float avancementCharacter = ((countPercentage/(float) max)*70);
        float avancementLevels = ((countLevels/((float) max + 1)) *30);
        return (int) (avancementCharacter + avancementLevels);
    }
}
