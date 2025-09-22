// <copyright file="Enums.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

namespace GuessWhoOnePiece.Model
{
    /// <summary>The age gap of a character and another.</summary>
    public enum AgeType
    {
        Younger = 0,
        Equal = 1,
        Older = 2,
    }
    
    /// <summary>The chapter gap of a character and another.</summary>
    public enum ChapterType
    {
        PreviousChapter = 0,
        SameChapter = 1,
        NewerChapter = 2,
    }
    
    /// <summary>The bounty gap of a character and another.</summary>
    public enum BountyType 
    {
        Lower = 0,
        Upper = 1,
        Equal = 2,
        WrongUnknown = 3,
        Error = 4
    }

    /// <summary>The level gap of a character and another.</summary>
    public enum LevelDifficulty
    {
        Easy = 0,
        Medium = 1,
        Hard = 2,
        Error = 3
    }
    
    /// <summary>The state of the answer.</summary>
    public enum AnswerState
    {
        Correct = 0, 
        Wrong = 1, 
        NotAnswered = 2,
    }

    public enum IndexMenuTabBar
    {
        Characters = 1,
        Game = 2,
        Settings = 3,
    }
}
