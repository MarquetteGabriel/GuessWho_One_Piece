// <copyright file="SelectAnswer.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;

namespace GuessWhoOnePiece.Model.Game
{
    /// <summary>Represents the select of answers.</summary>
    /// <param name="charcaterSearched">Character searched by the user.</param>
    public class SelectAnswer(Character charcaterSearched)
    {
        /// <summary>Instance of JudgementAnswer.</summary>
        private readonly JudgementAnswer _judgementAnswer = new(charcaterSearched);

        /// <summary>Select Answer for the character.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        public Character SelectAnswerCharacter(Character character)
        {
            character = SelectAnswerAlive(character);
            character = SelectAnswerAge(character);
            character = SelectAnswerType(character);
            character = SelectAnswerChapter(character);
            character = SelectAnswerBounty(character);
            character = SelectAnswerCrew(character);
            character = SelectAnswerName(character);
            character = SelectAnswerDevilFruit(character);
            return character;
        }

        /// <summary>Select the answer for the Alive state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        private Character SelectAnswerAlive(Character character)
        {
            var answerAlive = _judgementAnswer.IsAlive(character);
            character.AnswerStateList!.Alive = AnswerResult.SetAnswerStateBoolean(answerAlive);
            character.AnswerImageLink!.Alive = DefinePictures.SetAlivePicture(answerAlive);
            return character;
        }

        /// <summary>Select the answer for the Age state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <return>The character updated.</returns>
        private Character SelectAnswerAge(Character character)
        {
            var answerAge = _judgementAnswer.IsOlder(character);
            character.AnswerStateList!.Age = AnswerResult.SetAnswerStateAgeType(answerAge);
            character.AnswerImageLink!.Age = DefinePictures.SetAgePicture(answerAge);
            return character;
        }

        /// <summary>Select the answer for the Type state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        private Character SelectAnswerType(Character character)
        {
            var answerType = _judgementAnswer.WhatOccupation(character);
            character.AnswerStateList!.Type = AnswerResult.SetAnswerStateBoolean(answerType);
            character.AnswerImageLink!.Type = DefinePictures.SetTypePicture(character.Type);
            return character;
        }

        /// <summary>Select the answer for the Chapter state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        private Character SelectAnswerChapter(Character character)
        {
            var answerChapter = _judgementAnswer.IsNewer(character);
            character.AnswerStateList!.FirstAppearance = AnswerResult.SetAnswerStateChapterType(answerChapter);
            character.AnswerImageLink!.FirstAppearance = DefinePictures.SetChapterPicture(answerChapter);
            return character;
        }

        /// <summary>Select the answer for the Bounty state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        private Character SelectAnswerBounty(Character character)
        {
            var answerBounty = _judgementAnswer.WantedBounty(character);
            character.AnswerStateList!.Bounty = AnswerResult.SetAnswerStateBountyType(answerBounty);
            character.AnswerImageLink!.Bounty = DefinePictures.SetBountyPicture(answerBounty);
            return character;
        }

        /// <summary>Select the answer for the Crew state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        private Character SelectAnswerCrew(Character character)
        {
            var answerCrew = _judgementAnswer.WhatCrew(character);
            character.AnswerStateList!.Crew = AnswerResult.SetAnswerStateBoolean(answerCrew);
            character.AnswerImageLink!.Crew = DefinePictures.SetCrewPictures(character.Crew);
            return character;
        }

        /// <summary>Select the answer for the Name state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        private Character SelectAnswerName(Character character)
        {
            var answerName = _judgementAnswer.IsSameName(character);
            character.AnswerStateList!.Name = AnswerResult.SetAnswerStateBoolean(answerName);
            character.AnswerImageLink!.Name = string.Empty;
            return character;
        }

        /// <summary>Select the answer for the DevilFruit state.</summary>
        /// <param name="character">Character enter by the user.</param>
        /// <returns>The character updated.</returns>
        private Character SelectAnswerDevilFruit(Character character)
        {
            var answerDevilFruit = _judgementAnswer.HasEatenDevilFruit(character);
            character.AnswerStateList!.DevilFruit = AnswerResult.SetAnswerStateBoolean(answerDevilFruit);
            character.AnswerImageLink!.DevilFruit = DefinePictures.SetDevilFruitPicture(answerDevilFruit);
            return character;
        }

        /// <summary>Set the character to find.</summary>
        /// <param name="character">Character enter by the user.</param>
        internal void SetCharacter(Character character)
        {
            _judgementAnswer.SetCharacter(character);
        }
    }
}
