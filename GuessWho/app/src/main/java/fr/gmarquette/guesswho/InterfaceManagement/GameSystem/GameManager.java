/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameSystem;

import fr.gmarquette.guesswho.GameData.Database.Characters;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.BountyManager.BountyFactory;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.BountyManager.BountyType;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.EnumsDatas.AgeType;
import fr.gmarquette.guesswho.InterfaceManagement.GameSystem.EnumsDatas.ChapterType;

public class GameManager
{
    public static boolean isAlive(Characters characters, Characters characterSearched)
    {
        return (characters.isAlive() == characterSearched.isAlive());
    }

    public static boolean hasEatenDevilFruit(Characters characters, Characters characterSearched)
    {
        return (characters.hasDevilFruit() == characterSearched.hasDevilFruit());
    }

    public static BountyType lookingForBounty(Characters characters, Characters characterSearched)
    {
        return BountyFactory.whatBounty(characters, characterSearched);
    }

    public static boolean isSameName(Characters characters, Characters characterSearched)
    {
        return (characters.getName().equals(characterSearched.getName()));
    }

    public static ChapterType getAppearanceDiff(Characters characters, Characters characterSearched)
    {
        int diff = characters.getFirstAppearance() - characterSearched.getFirstAppearance();
        if(diff < 0)
        {
            return ChapterType.NEWER_CHAPTER; // Arrow above
        }
        else if(diff > 0)
        {
            return ChapterType.PREVIOUS_CHAPTER; // Arrow down
        }
        else
        {
            return ChapterType.SAME_CHAPTER; // Make it green
        }
    }

    public static boolean getType(Characters characters, Characters characterSearched)
    {
        return (characters.getType().equals(characterSearched.getType()));
    }

    public static AgeType getAge(Characters characters, Characters characterSearched)
    {
        int diff = characters.getAge() - characterSearched.getAge();
        if(diff < 0)
        {
            return AgeType.YOUNGER; // Arrow above
        }
        else if(diff > 0)
        {
            return AgeType.OLDER; // Arrow down
        }
        else
        {
            return AgeType.EQUAL; // Make it green
        }
    }

    public static boolean getCrew(Characters characters, Characters characterSearched)
    {
        return characters.getCrew().equals(characterSearched.getCrew());
    }


}
