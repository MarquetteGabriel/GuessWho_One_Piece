// <copyright file="LevelToValueTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model;
using GuessWhoOnePiece.Model.Converts;

namespace GuessWhoOnePiece.Tests.Converts
{
    /// <summary>Test class "LevelToValue".</summary>
    public class LevelToValueTest
    {
        #region GetLevelDifficultyByValue Tests

        /// <summary>Test with value at 0.</summary>
        [Fact]
        public void Test_GetLevelDifficultyByValue_ValueEasy()
        {
            int value = 0;
            var result = LevelToValue.GetLevelDifficultyByValue(value);
            Assert.Equal(LevelDifficulty.Easy, result);
        }

        /// <summary>Test with value at 1.</summary>
        [Fact]
        public void Test_GetLevelDifficultyByValue_ValueMedium()
        {
            int value = 1;
            var result = LevelToValue.GetLevelDifficultyByValue(value);
            Assert.Equal(LevelDifficulty.Medium, result);
        }

        /// <summary>Test with value at 2.</summary>
        [Fact]
        public void Test_GetLevelDifficultyByValue_ValueHard()
        {
            int value = 2;
            var result = LevelToValue.GetLevelDifficultyByValue(value);
            Assert.Equal(LevelDifficulty.Hard, result);
        }

        /// <summary>Test with value out of bounds positive.</summary>
        [Fact]
        public void Test_GetLevelDifficultyByValue_ValueOutOfBoundsPositive()
        {
            int value = 3;
            var result = LevelToValue.GetLevelDifficultyByValue(value);
            Assert.Equal(LevelDifficulty.Error, result);
        }

        /// <summary>Test with value out of bounds negative.</summary>
        [Fact]
        public void Test_GetLevelDifficultyByValue_ValueOutOfBoundsNegative()
        {
            int value = -1;
            var result = LevelToValue.GetLevelDifficultyByValue(value);
            Assert.Equal(LevelDifficulty.Error, result);
        }

        #endregion
    }
}
