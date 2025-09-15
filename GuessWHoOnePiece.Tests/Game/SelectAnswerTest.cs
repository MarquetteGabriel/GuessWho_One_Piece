// <copyright file="SelectAnswerTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessWhoOnePiece.Model.Game;

namespace GuessWhoOnePiece.Tests.Game
{
    public class SelectAnswerTest
    {
        [Fact]
        public void Test_SelectAnswerCharacter()
        {
            var characterSearched = new Character("Monkey D. Luffy", true, "3 Md", 1, "Pirate", true, 19, "Straw Hat Pirates", "", 0);
            var character = new Character("Roronoa Zoro", false, "2 Md", 1, "Pirate", true, 21, "Straw Hat Pirates", "", 0);

            var selectAnswer = new SelectAnswer(characterSearched);
            selectAnswer.SelectAnswerCharacter(character);

            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.Alive);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.Age);
            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.Type);
            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.FirstAppearance);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.Bounty);
            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.Crew);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.Name);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.DevilFruit);
        }

        [Fact]
        public void Test_SetSelectAnswerCharacter()
        {
            var characterSearched = new Character("Monkey D. Luffy", true, "3 Md", 1, "Pirate", true, 19, "Straw Hat Pirates", "", 0);
            var character = new Character("Roronoa Zoro", false, "2 Md", 1, "Pirate", true, 21, "Straw Hat Pirates", "", 0);

            var selectAnswer = new SelectAnswer(characterSearched);
            selectAnswer.SetCharacter(characterSearched);
            selectAnswer.SelectAnswerCharacter(character);

            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.Alive);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.Age);
            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.Type);
            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.FirstAppearance);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.Bounty);
            Assert.Equal(Model.AnswerState.Correct, character.AnswerStateList!.Crew);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.Name);
            Assert.Equal(Model.AnswerState.Wrong, character.AnswerStateList!.DevilFruit);
        }
    }
}
