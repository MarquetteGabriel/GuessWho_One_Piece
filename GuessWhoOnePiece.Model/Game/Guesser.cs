// <copyright file="Guesser.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GuessWhoOnePiece.Model.Game
{
    public static class Guesser
    {
        public static Character SetCharacterToFind(IList<Character> listCharacters)
        {
            var index = RandomizeNumber(listCharacters.Count);
            return listCharacters[index];
        }

        private static int RandomizeNumber(int maxNumber)
        {
            return RandomNumberGenerator.GetInt32(maxNumber);
        }
    }
}

