// <copyright file="Popularity.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.DataEntries.Picture;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.Model.DataEntries
{
    /// <summary>Represent the definition of the popularity for each character.</summary>
    public static class Popularity
    {
        private static readonly Uri UrlLevels = new("http://www.volonte-d.com/details/popularite.php");

        private const double AcceptanceCritera = 0.7;

        private const string FilterTd = "td";
        private const string FilterTr = "tr";
        private const string FilterTable = "table";
        private const string FilterAlias = "alias";

        private const string ReplaceCharacter = @"\s*\(.*?\)";

        private const string FilterPopularity = "//*[contains(@class, 'gallery') and contains(@class, 'clearfix')]";

        private const string Alber = "Alber";
        private const string Linlin = "Linlin";
        private const string Galdino = "Galdino";
        private const string MarshallDTeach = "Marshall D. Teach";
        private const string EdwardNewgate = "Edward Newgate";
        private const string DonQuichotte = "Don Quichotte";

        private const string Donquixote = "Donquixote";
        private const string King = "King";
        private const string BigMom = "Big Mom";
        private const string Mr3 = "Mr 3";
        private const string BarbeNoire = "Barbe Noire";
        private const string BarbeBlanche = "Barbe Blanche";

        private static int _countPopularity;

        public static int CountPopularity
        {
            get => _countPopularity;
        }

        /// <summary>Set the popularity of characters.</summary>
        /// <param name="characterNameList">List of characters.</param>
        internal static async Task<IReadOnlyCollection<Character>> SetPopularity(IReadOnlyList<string> characterNameList, IReadOnlyCollection<Character> characterList)
        {
            var table = await SetTablePopularity();
            List<string> ListPopularity = new(characterList.Count);

            var rows = table.SelectNodes(FilterTr);
            for (var index = 1; index < rows.Count; index++)
            {
                var cols = rows[index].SelectNodes(FilterTd);
                ListPopularity.Add(cols[1].InnerText.Trim());
            }
            rows.Clear();

            var levelLimit = ListPopularity.Count % ControlRoom.NumberOfLevels;
            foreach (var character in characterNameList)
            {
                string tempCharacterName = character.Contains(FilterAlias, StringComparison.Ordinal)
                    ? character.Replace(ReplaceCharacter, string.Empty, StringComparison.OrdinalIgnoreCase) : character;
                int position = SetPosition(tempCharacterName, ListPopularity);

                foreach (var characters in characterList)
                {
                    if (!characters.Name.Equals(tempCharacterName, StringComparison.Ordinal))
                        continue;

                    characters.Level = Math.Clamp(SetLevel(position, levelLimit), 0, ControlRoom.NumberOfLevels - 1);
                }

                _countPopularity++;
            }

            return characterList;
        }

        private static async Task<HtmlNode> SetTablePopularity()
        {
            var web = new HtmlWeb();
            var doc = await web.LoadFromWebAsync(UrlLevels.ToString());
            var elements = doc.DocumentNode.SelectNodes(FilterPopularity);
            return elements.Last().SelectNodes(FilterTable).LastOrDefault()!;
        }

        private static int SetLevel(int position, int levelLimit)
        {
            for (var i = ControlRoom.NumberOfLevels; i >= 1; i--)
            {
                if (position > levelLimit * i)
                    continue;

                return i - 1;
            }

            return levelLimit;
        }

        static int SetPosition(string characterName, List<string> listCharacter)
        {
            var position = listCharacter.IndexOf(characterName);

            if (position != -1)
                return position;

            var newCharacter = GetSimilarCharacter(characterName, listCharacter);

            return newCharacter == null ? listCharacter.Count : listCharacter.IndexOf(newCharacter);
        }

        static string? GetSimilarCharacter(string character, IReadOnlyList<string> ListPopularity)
        {
            foreach (var popularityCharacter in ListPopularity)
            {
                character = ExtractExceptionsPopularity(character);
                if (PictureManager.CalculateMatchPercentage(popularityCharacter, character) > AcceptanceCritera)
                    return popularityCharacter;
            }

            return null;
        }

        /// <summary>Change value for specific character for popularity ranking.</summary>
        /// <param name="character">The name of the character.</param>
        /// <returns>The new character name.</returns>
        internal static string ExtractExceptionsPopularity(string character)
        {
            if (character.Contains(DonQuichotte, StringComparison.OrdinalIgnoreCase))
                return character.Replace(DonQuichotte, Donquixote, StringComparison.OrdinalIgnoreCase);

            if (character.Contains(Alber, StringComparison.OrdinalIgnoreCase))
                return King;

            if (character.Contains(Linlin, StringComparison.OrdinalIgnoreCase))
                return BigMom;

            if (character.Contains(Galdino, StringComparison.OrdinalIgnoreCase))
                return Mr3;

            if (character.Contains(MarshallDTeach, StringComparison.OrdinalIgnoreCase))
                return BarbeNoire;

            if (character.Contains(EdwardNewgate, StringComparison.OrdinalIgnoreCase))
                return BarbeBlanche;

            return character;
        }
    }
}
