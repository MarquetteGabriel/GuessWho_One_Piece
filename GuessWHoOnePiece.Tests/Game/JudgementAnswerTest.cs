// <copyright file="JudgementAnswerTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model;
using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.Game;
using GuessWhoOnePiece.Model.Resources;

namespace GuessWhoOnePiece.Tests.Game
{
    public class JudgementAnswerTest
    {
        private Character characterDefaut;
        private Character character1;
        private Character character3;
        private Character character4;
        private Character character5;
        private Character character6;
        private Character character7;
        private JudgementAnswer judgmentAnswer;

        public JudgementAnswerTest()
        {
            characterDefaut = new Character("Charlotte Katakuri", true, "1,049 Md", 849, "Pirate", true, 48, "Big Mom Crew", "", 0);
            character1 = new Character ("Monkey D. Luffy", true, "3 Md", 1, "Pirate", true, 19, "Straw Hat Pirates", "", 0);
            character3 = new Character("Portgas D. Ace", false, "550 Mi", 1080, "Pirate", false, 20, "Spade Pirates", "", 0);
            character4 = new Character("Ener", true, "Unknown", 220, "Pirate", true, 40, "Ener Crew", "", 0);
            character5 = new Character("Kizaru", true, "0", 350, "Navy", true, 53, Crew.Navy, "", 0);
            character6 = new Character("Marsh@ll D. Teach", true, "13 ez", -1, "Touriste", false, -3, "Crew", "", 5);
            character7 = new Character("Tony Tony Chopper", true, "5000", 141, "Pirate", true, 17, "Straw Hat Pirates", "", 0);
            judgmentAnswer = new JudgementAnswer(characterDefaut);
        }

        #region IsAlive Tests

        [Fact]
        public void Test_IsAlive()
        {
            var result = judgmentAnswer.IsAlive(character3);
            Assert.False(result);

            result = judgmentAnswer.IsAlive(character1);
            Assert.True(result);    
        }

        #endregion

        #region HasEatenDevilFruit Tests

        [Fact]
        public void Test_HasEatenDevilFruit()
        {
            var result = judgmentAnswer.HasEatenDevilFruit(character3);
            Assert.False(result);

            result = judgmentAnswer.HasEatenDevilFruit(character1);
            Assert.True(result);
        }

        #endregion

        #region WantedBounty Tests

        [Fact]
        public void Test_WantedBounty()
        {
            var result = judgmentAnswer.WantedBounty(character1);
            Assert.Equal(BountyType.Lower, result);

            result = judgmentAnswer.WantedBounty(character3);
            Assert.Equal(BountyType.Upper, result);

            result = judgmentAnswer.WantedBounty(characterDefaut);
            Assert.Equal(BountyType.Equal, result);

            result = judgmentAnswer.WantedBounty(character4);
            Assert.Equal(BountyType.WrongUnknown, result);
        }

        [Fact] 
        public void Test_WantedBounty_CharacterSearchUnkown()
        {
            judgmentAnswer.SetCharacter(character4);
            var result = judgmentAnswer.WantedBounty(characterDefaut);
            Assert.Equal(BountyType.WrongUnknown, result);

            result = judgmentAnswer.WantedBounty(character4);
            Assert.Equal(BountyType.Equal, result);
            judgmentAnswer.SetCharacter(characterDefaut);
        }

        [Fact]
        public void Test_WantedBounty_CharacterUnkown()
        {
            var result = judgmentAnswer.WantedBounty(character6);
            Assert.Equal(BountyType.WrongUnknown, result);
        }

        [Fact]
        public void Test_WantedBounty_CharacterSearchUnkownAndCharacterUnkown()
        {
            judgmentAnswer.SetCharacter(character3);
            var result = judgmentAnswer.WantedBounty(characterDefaut);
            Assert.Equal(BountyType.Lower, result);
            judgmentAnswer.SetCharacter(characterDefaut);
        }

        [Fact]
        public void Test_WantedBounty_CharacterFullBounty()
        {
            var result = judgmentAnswer.WantedBounty(character7);
            Assert.Equal(BountyType.Upper, result);

            judgmentAnswer.SetCharacter(character7);
            result = judgmentAnswer.WantedBounty(characterDefaut);
            Assert.Equal(BountyType.Lower, result);

            judgmentAnswer.SetCharacter(characterDefaut);
        }

        #endregion

        #region IsSameName Tests

        [Fact]
        public void Test_IsSameName()
        {
            var result = judgmentAnswer.IsSameName(character1);
            Assert.False(result);

            result = judgmentAnswer.IsSameName(characterDefaut);
            Assert.True(result);
        }

        #endregion

        #region WhatOccupation Tests

        [Fact]
        public void Test_WhatOccupation()
        {
            var result = judgmentAnswer.WhatOccupation(character1);
            Assert.True(result);

            result = judgmentAnswer.WhatOccupation(character5);
            Assert.False(result);
        }

        #endregion

        #region WhatCrew Tests

        [Fact]
        public void Test_WhatCrew()
        {
            var result = judgmentAnswer.WhatCrew(characterDefaut);
            Assert.True(result);

            result = judgmentAnswer.WhatCrew(character1);
            Assert.False(result);
        }

        #endregion

        #region IsNewer Tests

        [Fact]
        public void Test_IsNewer()
        {
            var result = judgmentAnswer.IsNewer(character1);
            Assert.Equal(ChapterType.NewerChapter, result);

            result = judgmentAnswer.IsNewer(character3);
            Assert.Equal(ChapterType.PreviousChapter, result);

            result = judgmentAnswer.IsNewer(characterDefaut);
            Assert.Equal(ChapterType.SameChapter, result);
        }

        #endregion

        #region IsOlder Tests

        [Fact]
        public void Test_IsOlder()
        {
            var result = judgmentAnswer.IsOlder(character1);
            Assert.Equal(AgeType.Younger, result);

            result = judgmentAnswer.IsOlder(character5);
            Assert.Equal(AgeType.Older, result);

            result = judgmentAnswer.IsOlder(characterDefaut);
            Assert.Equal(AgeType.Equal, result);
        }

        #endregion
    }
}

