// <copyright file="Character.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.AnswerModel;

namespace GuessWhoOnePiece.Model.Characters
{
    /// <summary>Represents a character.</summary>
    /// <param name="name">Name of the character.</param>
    /// <param name="devilFruit">Character has devil fruit.</param>
    /// <param name="bounty">Bounty of the character.</param>
    /// <param name="firstAppearance">Chapter where the character appears.</param>
    /// <param name="type">The character type.</param>
    /// <param name="alive">The character is alive or not.</param>
    /// <param name="age">The age of the character.</param>
    /// <param name="crew">The crew of the character.</param>
    /// <param name="picture">The picture of the character.</param>
    /// <param name="level">The level of popularity of the character.</param>
    public class Character(
        string name,
        bool devilFruit,
        string bounty,
        int firstAppearance,
        string type,
        bool alive,
        int age,
        string crew,
        string picture,
        int level)
    {

        #region Private declarations
    
        public string Name { get; set; } = name;
        public bool DevilFruit { get; set; } = devilFruit;
        public string Bounty { get; set; } = bounty;
        public int FirstAppearance { get; set; } = firstAppearance;
        public string Type { get; set; } = type;
        public bool Alive { get; set; } = alive;
        public int Age { get; set; } = age;
        public string Crew { get; set; } = crew;
        public string Picture { get; set; } = picture;
        public int Level { get; set; } = level;

        public AnswerStateList? AnswerStateList { get; set; } = new();
        public AnswerImageLink? AnswerImageLink { get; set; } = new();

        #endregion

    }
}
