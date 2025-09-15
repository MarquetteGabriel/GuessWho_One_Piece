// <copyright file="CurrentCharacterServiceTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Services;

namespace GuessWhoOnePiece.Tests.Services
{
    public class CurrentCharacterServiceTest
    {
        [Fact]
        public void Test_CurrentCharacterService()
        {
            var character1 = new Character("Monkey D. Luffy", true, "3 Md", 1, "Pirate", true, 19, "Straw Hat Pirates", "", 0);
            var character2 = new Character("Roronoa Zoro", false, "2 Md", 1, "Pirate", true, 21, "Straw Hat Pirates", "", 0);

            var CCS = new CurrentCharacterService();
            CCS.CurrentCharacter = character1;

            Assert.Equal(character1, CCS.CurrentCharacter);

            CCS.CurrentCharacter = character2;
            Assert.Equal(character2, CCS.CurrentCharacter);
        }
    }
}
