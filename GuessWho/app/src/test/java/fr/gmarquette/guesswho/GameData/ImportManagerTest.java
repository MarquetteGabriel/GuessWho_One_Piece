/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.GameData;

import static org.junit.Assert.assertEquals;

import org.jsoup.Jsoup;
import org.jsoup.nodes.Document;
import org.jsoup.nodes.Element;
import org.jsoup.select.Elements;
import org.junit.Test;

import java.io.IOException;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

import fr.gmarquette.guesswho.GameData.Database.Characters;

public class ImportManagerTest {

    @Test
    public void extractValuesFromFandomTest() {
        String character = "Piment";
        Characters characters = getDatasForEachCharacter(character);

        assert characters != null;
        assertEquals(characters.getName(), "Zunesh");
        assertEquals(characters.getAge(), 1000);
        assertEquals(characters.getBounty(), "0");
        assertEquals(characters.getType(), "Citizen");
        assertEquals(characters.getLevel(), ImportDataManager.getInstance().NUMBER_OF_LEVELS + 1);
        assertEquals(characters.getCrew(), "Citizen");
        assertEquals(characters.getFirstAppearance(), 802);
    }

    private Characters getDatasForEachCharacter(String character)
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
            Elements bountyTypeCrewElements = doc.getElementsByClass(class_type);
            String class_picture = "pi-navigation pi-item-spacing pi-secondary-font";
            String pictureElement = doc.getElementsByClass(class_picture).select("img").attr("src");

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

            return new Characters(character, fruit, bounty, chapter, type, alived, age, crew, pictureElement , 2 + 1);

        } catch (IOException e) {
            return null;
        }
    }
}