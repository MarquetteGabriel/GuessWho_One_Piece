// <copyright file="GuesserTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.CsvManager;
using System.Collections.Generic;
using System.Reflection;
using System.Threading.Tasks;
using GuessWhoOnePiece.Model.Game;
using Pose;

namespace GuessWhoOnePiece.Tests.Game
{
    /// <summary>Test class "GuesserTest".</summary>
    public class GuesserTest
    {
        #region SetCharacterToFind Tests
        
        [Fact]
        public void Test_SetCharacterToFind()
        {
            var listCharacters = new List<Character>()
            {
                new ("Monkey D. Luffy", true, "3 Md", 1, "Pirate", true, 19, "Mugiwara's Crew", "", 0),
                new ("Roronoa Zoro", false, "2 Md", 2, "Pirate", true, 21, "Mugiwara's Crew", "", 0),
                new ("Nami", false, "330 Mi", 3, "Pirate", true, 20, "Mugiwara's Crew", "", 0),
                new ("Usopp", false, "500 Mi", 4, "Pirate", true, 19, "Mugiwara's Crew", "", 0),
            };
            var result = Guesser.SetCharacterToFind(listCharacters);

            Assert.NotNull(result);
            Assert.IsType<Character>(result);
        }

        #endregion

        #region RandomizeNumer Tests

        [Fact]
        public void Test_RandomizeNumber()
        {
            int maxNumber = 10;
            var method = typeof(Guesser).GetMethod("RandomizeNumber", BindingFlags.NonPublic | BindingFlags.Static);

            Assert.NotNull(method);

            var result = method.Invoke(null, new object[] { maxNumber });

            Assert.NotNull(result);
            Assert.True((int) result >= 0);
            Assert.True((int)result < maxNumber);
        }

        #endregion
    }
}

