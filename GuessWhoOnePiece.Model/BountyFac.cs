// <copyright file="BountyFac.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using System;

namespace GuessWhoOnePiece.Model
{
    /// <summary>Represents the manage of bounties before being printed.</summary>
    public static class BountyFac
    {
        /// <summary>Int to get millions real values.</summary>
        internal const int MillionsDollarsValue = 1_000_000;

        /// <summary>Int to get billions real values.</summary>
        internal const int BillionsDollarsValue = 1_000_000_000;

        /// <summary>Get the bounty and return how is the current bounty among the other one.</summary>
        /// <param name="characters">The character entered.</param>
        /// <param name="characterSearched">The character to find.</param>
        /// <returns>The position of the bounty.</returns>
        public static BountyType WhatBounty(Character characters, Character characterSearched)
        {
            var bountyCharacter = characters.Bounty;
            var bountyCharacterSearched = characterSearched.Bounty;

            if (bountyCharacterSearched.Contains(Resources.Strings.Unknown))
                return bountyCharacter.Contains(Resources.Strings.Unknown) ? BountyType.Equal : BountyType.WrongUnknown;

            if (bountyCharacter.Contains(Resources.Strings.Unknown))
                return BountyType.WrongUnknown;

            float bountyCharacterValue;
            float bountyCharacterSearchedValue;

            try
            {
                bountyCharacterValue = float.Parse(bountyCharacter.Replace("Md", "", StringComparison.OrdinalIgnoreCase)
                               .Replace("Mi", "", StringComparison.OrdinalIgnoreCase).Replace(" ", "", StringComparison.OrdinalIgnoreCase));
                bountyCharacterSearchedValue = float.Parse(bountyCharacterSearched.Replace("Md", "", StringComparison.OrdinalIgnoreCase)
                    .Replace("Mi", "", StringComparison.OrdinalIgnoreCase).Replace(" ", "", StringComparison.OrdinalIgnoreCase));
            }
            catch (FormatException)
            {
                return BountyType.WrongUnknown;
            }
                
            if (bountyCharacter.Contains("Mi"))
                bountyCharacterValue *= MillionsDollarsValue;
            else if (bountyCharacter.Contains("Md"))
                bountyCharacterValue *= BillionsDollarsValue;
            else
            {
                // Empty on purpose.
            }

            if (bountyCharacterSearched.Contains("Mi"))
                bountyCharacterSearchedValue *= MillionsDollarsValue;
            else if (bountyCharacterSearched.Contains("Md"))
                bountyCharacterSearchedValue *= BillionsDollarsValue;
            else
            {
                // Empty on purpose.
            }

            var diff = bountyCharacterValue - bountyCharacterSearchedValue;

            if (diff < 0)
            {
                return BountyType.Upper;
            }

            return diff > 0 ? BountyType.Lower : BountyType.Equal;
        }
    }
}
