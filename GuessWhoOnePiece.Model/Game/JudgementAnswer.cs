// <copyright file="JudgementAnswer.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;

namespace GuessWhoOnePiece.Model.Game
{
    public class JudgementAnswer(Character character)
    {
        private Character _character = character;
        public bool IsAlive(Character guessedCharacter) => guessedCharacter.Alive == _character.Alive;
        
        public bool HasEatenDevilFruit(Character guessedCharacter) => guessedCharacter.DevilFruit == _character.DevilFruit;
        
        public BountyType WantedBounty(Character guessedCharacter) => BountyFac.WhatBounty(guessedCharacter, _character);
        
        public bool IsSameName(Character guessedCharacter) => guessedCharacter.Name.Equals(_character.Name);
        
        public bool WhatOccupation(Character guessedCharacter) => guessedCharacter.Type.Equals(_character.Type);
        
        public bool WhatCrew(Character guessedCharacter) => guessedCharacter.Crew.Equals(_character.Crew);

        public ChapterType IsNewer(Character guessedCharacter)
        {
            var diff = guessedCharacter.FirstAppearance - _character.FirstAppearance;
            return diff switch
            {
                < 0 => ChapterType.NewerChapter, // Arrow up
                > 0 => ChapterType.PreviousChapter, // Arrow down
                _ => ChapterType.SameChapter // Make it green
            };
        }

        public AgeType IsOlder(Character guessedCharacter)
        {
            var diff = guessedCharacter.Age - _character.Age;
            return diff switch
            {
                < 0 => AgeType.Younger, // Arrow Up
                > 0 => AgeType.Older, // Arrow down
                _ => AgeType.Equal // Make it green
            };
        }

        public void SetCharacter(Character newCharacter)
        {
            _character = newCharacter;
        }
    }
}

