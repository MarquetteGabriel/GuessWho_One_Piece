/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.GameData.Characters;

import java.util.ArrayList;
import java.util.List;

import fr.gmarquette.guesswho.GameData.Database.Characters;

public class InitialiseDatabase
{
    private final List<Characters> listCharacters = new ArrayList<>();

    public List<Characters> getDatabaseValues()
    {
        listCharacters.addAll(Pirates.getPirates());
        listCharacters.addAll(WorldGovernment.getWorldGovernment());
        listCharacters.addAll(Citizens.getCitizens());
        listCharacters.addAll(RevolutionaryArmy.getRevolutionary());

        return listCharacters;
    }

    public void ClearList()
    {
        this.listCharacters.clear();
    }

}
