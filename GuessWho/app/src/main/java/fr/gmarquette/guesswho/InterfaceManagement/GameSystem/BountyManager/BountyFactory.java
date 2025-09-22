/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameSystem.BountyManager;

import fr.gmarquette.guesswho.GameData.Database.Characters;

public class BountyFactory {
    private static final String NoBounty = "Unknown";

    public static BountyType whatBounty(Characters characters, Characters characterSearched)
    {
        String bountyCharacter = characters.getBounty();
        String bountyCharacterSearched = characterSearched.getBounty();

        if(bountyCharacterSearched.contains(NoBounty))
        {
            if(bountyCharacter.contains(NoBounty))
            {
                return BountyType.EQUAL;
            }
            else
            {
                return BountyType.WRONG_UNKNOWN;
            }
        }
        else
        {
            if(bountyCharacter.contains(NoBounty))
            {
                return BountyType.WRONG_UNKNOWN;
            }
            else {
                float bounty = Float.parseFloat(bountyCharacter.replaceAll("[^\\d.]", ""));
                float bountySearched = Float.parseFloat(bountyCharacterSearched.replaceAll("[^\\d.]", ""));

                if (bountyCharacter.contains("Md") && bountyCharacterSearched.contains("Mi")) {
                    bounty *= 1000;
                } else if (bountyCharacter.contains("Mi") && bountyCharacterSearched.contains("Md")) {
                    bountySearched *= 1000;
                }
                else if(bountyCharacter.contains("Md") && (!bountyCharacterSearched.contains("Md") && !bountyCharacterSearched.contains("Mi")))
                {
                    bounty *= 1000000000;
                }
                else if(bountyCharacter.contains("Mi") && (!bountyCharacterSearched.contains("Md") && !bountyCharacterSearched.contains("Mi")))
                {
                    bounty *= 1000000;
                }
                else if(bountyCharacterSearched.contains("Md") && (!bountyCharacter.contains("Md") && !bountyCharacter.contains("Mi")))
                {
                    bountySearched *= 1000000000;
                }
                else if(bountyCharacterSearched.contains("Mi") && (!bountyCharacter.contains("Md") && !bountyCharacter.contains("Mi")))
                {
                    bountySearched *= 1000000;
                }

                float diff = bounty - bountySearched;

                if (diff < 0) {
                    return BountyType.UPPER;
                } else if (diff > 0) {
                    return BountyType.LOWER;
                } else {
                    return BountyType.EQUAL;
                }
            }
        }
    }
}
