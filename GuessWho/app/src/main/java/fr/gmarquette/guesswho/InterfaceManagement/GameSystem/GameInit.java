/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.InterfaceManagement.GameSystem;

import android.content.Context;

import java.util.List;
import java.util.Random;
import java.util.concurrent.ExecutionException;

import fr.gmarquette.guesswho.GameData.Database.CallDAOAsync;
import fr.gmarquette.guesswho.GameData.Database.Characters;

public class GameInit extends Thread
{
    CallDAOAsync callDAOAsync;
    private final Random rand = new Random();

    public GameInit(Context context) {
        callDAOAsync = new CallDAOAsync(context);
    }

    public Characters getCharacterToFound(List<String> characterNameList) throws InterruptedException
    {
        int id = rand.nextInt(characterNameList.size());
        try {
            return callDAOAsync.getCharacterFromNameAsync(characterNameList.get(id)).get();
        } catch (ExecutionException e) {
            return null;
        }
    }

}
