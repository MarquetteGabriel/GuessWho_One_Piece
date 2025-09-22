// <copyright file="AgeData.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace GuessWhoOnePiece.Model.DataEntries
{
    internal static partial class DataControl
    {
        /// <summary>Extract age from text.</summary>
        /// <param name="input">Text.</param>
        /// <returns>The new age.</returns>
        internal static int ExtractPatternAge(string input, string characterName)
        {
            var matchChoice = Regexs.ExtractPatternAgeRegex().Match(input);

            if (!matchChoice.Success)
                return 0;

            string ageText = matchChoice.Groups[0].Value;
            ageText = Regexs.SquareBracketsBountyRegex().Replace(ageText, " ");
            ageText = Regex.Replace(ageText, @"(?<=\()[^)]*\d+[^)]*(?=\))", m =>
            {
                return Regex.Replace(m.Value, @"\d+", "").Trim();
            });

            string? specificAge = null;          
            specificAge = ExtractSpecificAge(ageText, characterName);
            
            if (specificAge != null)
            {
                if (specificAge == "0")
                    return 0;
                else
                    ageText = specificAge;
            }

            var listAge = Regexs.ExtractAgeRegex().Matches(ageText);
            var maxAge = 0;

            foreach (Match match in listAge)
            {
                string age = match.Value;

                age = age
                    .Replace(" ans", "", StringComparison.OrdinalIgnoreCase)
                    .Replace(" ", "", StringComparison.OrdinalIgnoreCase)
                    .Replace("an", "", StringComparison.OrdinalIgnoreCase);

                if(AvoidErrors(age))
                    continue;   

                if (int.TryParse(age, out int ageValue))
                    maxAge = Math.Max(maxAge, ageValue);
            }

            return maxAge;
        }

        /// <summary>Check if there is text that indicate to not count this number.</summary>
        /// <param name="age">String that contains an age.</param>
        /// <returns>True if this text has not to count.</returns>
        private static bool AvoidErrors(string age)
        {
            return (age.Contains("(espércedevie", StringComparison.Ordinal) || 
                age.Contains("s'ilétaitvivt", StringComparison.Ordinal) || 
                age.Contains("(estimation", StringComparison.Ordinal));
        }

        /// <summary>Extract text age for specific characters.</summary>
        /// <param name="ageText">Text age.</param>
        /// <param name="characterName">Name of the character.</param>
        /// <returns>The nex text.</returns>
        private static string? ExtractSpecificAge(string ageText, string characterName)
        {
            foreach (var splitAge in Regex.Split(ageText, @":"))
            {
                if (ExtractBaskervillAge(splitAge, characterName) != null)
                    return splitAge;

                if (ExtractMozuKiwi(splitAge, characterName) != null)
                    return splitAge;

                if (MonthList.Any(splitAge.Contains))
                    return "0";
            }

            return null;
        }

        /// <summary>Extract text age for Baskerville (Bas, And, Kerville).</summary>
        /// <param name="splitAge">Text age.</param>
        /// <param name="characterName">Name of the character.</param>
        /// <returns>The nex text.</returns>
        private static string? ExtractBaskervillAge(string splitAge, string characterName)
        {
            if (splitAge.Contains("And", StringComparison.Ordinal) && characterName.Equals("Bas", StringComparison.Ordinal))
                return splitAge;
            else if (splitAge.Contains("Kerville", StringComparison.Ordinal) && characterName.Equals("And", StringComparison.Ordinal))
                return splitAge;
            else if (splitAge.Contains(@"Anniversaire", StringComparison.Ordinal) && characterName.Equals("Kerville", StringComparison.Ordinal))
                return splitAge;
            else
                return null;
        }

        /// <summary>Extract text age for Mozu and Kiwi (Mozu, Kiwi).</summary>
        /// <param name="splitAge">Text age.</param>
        /// <param name="characterName">Name of the character.</param>
        /// <returns>The nex text.</returns>
        private static string? ExtractMozuKiwi(string splitAge, string characterName)
        {
            if (splitAge.Contains("Mozu", StringComparison.Ordinal) && characterName.Equals("Kiwi", StringComparison.Ordinal))
                return splitAge;
            else if (splitAge.Contains("Anniversaire", StringComparison.Ordinal) && characterName.Equals("Mozu", StringComparison.Ordinal))
                return splitAge;
            else
                return null;
        }
    }
}
