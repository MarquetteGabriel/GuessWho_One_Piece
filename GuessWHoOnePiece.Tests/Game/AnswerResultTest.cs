// <copyright file="AnswerResultTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model;
using GuessWhoOnePiece.Model.Game;

namespace GuessWhoOnePiece.Tests.Game;

/// <summary>Test class "AnswerResult".</summary>
public class AnswerResultTest
{
    #region SetAnswerStateBoolean Tests

    /// <summary>Test SetAnswerStateBoolean with true value.</summary>
    [Fact]
    public void Test_SetAnswerStateBoolean_Correct()
    {
        var result = AnswerResult.SetAnswerStateBoolean(true);
        Assert.Equal(AnswerState.Correct, result);
    }

    /// <summary>Test SetAnswerStateBoolean with false value.</summary>
    [Fact]
    public void Test_SetAnswerStateBoolean_Wrong()
    {
        var result = AnswerResult.SetAnswerStateBoolean(false);
        Assert.Equal(AnswerState.Wrong, result);
    }

    #endregion

    #region SetAnswerStateChapterType Tests

    /// <summary>Test SetAnswerStateChapterType with Previous chapter value.</summary>
    [Fact]
    public void Test_SetAnswerStateChapterType_Previous()
    {
        var result = AnswerResult.SetAnswerStateChapterType(ChapterType.PreviousChapter);
        Assert.Equal(AnswerState.Wrong, result);
    }

    /// <summary>Test SetAnswerStateChapterType with Newer chapter value.</summary>
    [Fact]
    public void Test_SetAnswerStateChapterType_Newer()
    {
        var result = AnswerResult.SetAnswerStateChapterType(ChapterType.NewerChapter);
        Assert.Equal(AnswerState.Wrong, result);
    }

    /// <summary>Test SetAnswerStateChapterType with Same chapter value.</summary>
    [Fact]
    public void Test_SetAnswerStateChapterType_Same()
    {
        var result = AnswerResult.SetAnswerStateChapterType(ChapterType.SameChapter);
        Assert.Equal(AnswerState.Correct, result);
    }

    #endregion

    #region SetAnswerStateBountyType Tests

    /// <summary>Test SetAnswerStateBountyType with Lower value.</summary>
    [Fact]
    public void Test_SetAnswerStateBountyType_Lower()
    {
        var result = AnswerResult.SetAnswerStateBountyType(BountyType.Lower);
        Assert.Equal(AnswerState.Wrong, result);
    }

    /// <summary>Test SetAnswerStateBountyType with Upper value.</summary>
    [Fact]
    public void Test_SetAnswerStateBountyType_Upper()
    {
        var result = AnswerResult.SetAnswerStateBountyType(BountyType.Upper);
        Assert.Equal(AnswerState.Wrong, result);
    }

    /// <summary>Test SetAnswerStateBountyType with Equal value.</summary>
    [Fact]
    public void Test_SetAnswerStateBountyType_Equal()
    {
        var result = AnswerResult.SetAnswerStateBountyType(BountyType.Equal);
        Assert.Equal(AnswerState.Correct, result);
    }

    /// <summary>Test SetAnswerStateBountyType with Unknown value.</summary>
    [Fact]
    public void Test_SetAnswerStateBountyType_Unknown()
    {
        var result = AnswerResult.SetAnswerStateBountyType(BountyType.WrongUnknown);
        Assert.Equal(AnswerState.NotAnswered, result);
    }

    #endregion

    #region SetAnswerStateAgeType Tests

    /// <summary>Test SetAnswerStateAgeType with Younger value.</summary>
    [Fact]
    public void Test_SetAnswerStateAgeType_Younger()
    {
        var result = AnswerResult.SetAnswerStateAgeType(AgeType.Younger);
        Assert.Equal(AnswerState.Wrong, result);
    }

    /// <summary>Test SetAnswerStateAgeType with Older value.</summary>
    [Fact]
    public void Test_SetAnswerStateAgeType_Older()
    {
        var result = AnswerResult.SetAnswerStateAgeType(AgeType.Older);
        Assert.Equal(AnswerState.Wrong, result);
    }

    /// <summary>Test SetAnswerStateAgeType with Equal value.</summary>
    [Fact]
    public void Test_SetAnswerStateAgeType_Equal()
    {
        var result = AnswerResult.SetAnswerStateAgeType(AgeType.Equal);
        Assert.Equal(AnswerState.Correct, result);
    }

    #endregion
}
