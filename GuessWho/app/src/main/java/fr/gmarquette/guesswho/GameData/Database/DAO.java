/*
 *
 * @brief Copyright (c) 2023 Gabriel Marquette
 *
 * Copyright (c) 2023 Gabriel Marquette. All rights reserved.
 *
 */

package fr.gmarquette.guesswho.GameData.Database;

import androidx.room.Dao;
import androidx.room.Delete;
import androidx.room.Insert;
import androidx.room.OnConflictStrategy;
import androidx.room.Query;

import java.util.List;

@Dao
public interface DAO{

    @Insert(onConflict = OnConflictStrategy.REPLACE)
    void addCharacter(Characters characters);

    @Delete
    void deleteCharacter(Characters characters);

    @Query("SELECT picture FROM Characters")
    List<String> getAllPictures();

    @Query("SELECT level FROM Characters")
    List<Integer> getAllLevels();

    @Query("SELECT * FROM Characters WHERE name LIKE:name")
    Characters getCharacterFromName(String name);


    @Query("SELECT name FROM Characters")
    List<String> getAllNames();
}
