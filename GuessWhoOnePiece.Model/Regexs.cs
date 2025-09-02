// <copyright file="Regexs.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System.Text.RegularExpressions;

namespace GuessWhoOnePiece.Model
{
    public static partial class Regexs
    {
        [GeneratedRegex(@"Prime\s*:(.*?)(?=(Statut|Anniversaire|Âge|$))")]
        public static partial Regex ExtractPatternBountyRegex();

        [GeneratedRegex(@"\[\d+\]")]
        public static partial Regex SquareBracketsBountyRegex();

        [GeneratedRegex(@"\d+")]
        public static partial Regex BountyValueRegex();

        [GeneratedRegex(@"Âge(\s)?:(.*?)(Anniversaire|Taille|Voix)")]
        public static partial Regex ExtractPatternAgeRegex();

        [GeneratedRegex(@"(\d+\s)?\d+(an)?(ans)?(\sans)?(\s\(espérance de vie)?(\s\(s'il était vivant\))?(\s\(estimation)?")]
        public static partial Regex ExtractAgeRegex();

        [GeneratedRegex(@"\[.*?]\s*$")]
        public static partial Regex ExtractRedirectLinkFromBracketsRegex();

        [GeneratedRegex(@"<br>|<p>|<a>")]
        public static partial Regex SplitPatternType();

        [GeneratedRegex(@"\(.*?\)")]
        public static partial Regex ContentBetweenBracketsRegex();

        [GeneratedRegex(@"(.+)_\(.*\)")]
        public static partial Regex CharacterLinkRegex();
    }


}
