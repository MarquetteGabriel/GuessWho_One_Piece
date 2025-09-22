// <copyright file="LevelToValue.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System;

namespace GuessWhoOnePiece.Model.Converts
{
    /// <summary>Represents the conversion from a Level difficulty to an int value.</summary>
    internal static class LevelToValue
    {
        /// <summary>Represents the conversion from a Level difficulty to an int value.</summary>
        /// <param name="value">The value to convert.</param>
        /// <returns>The level of difficulty.</returns>
        internal static LevelDifficulty GetLevelDifficultyByValue(int value)
        {
            foreach (LevelDifficulty levelDiffculty in Enum.GetValues(typeof(LevelDifficulty)))
            {
                if((int) levelDiffculty == value)
                    return levelDiffculty;
            }

            return LevelDifficulty.Error;
        }
    }
}

