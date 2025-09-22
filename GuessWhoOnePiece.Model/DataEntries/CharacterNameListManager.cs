// <copyright file="CharacterNameListManager.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using HtmlAgilityPack;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.Model.DataEntries
{
    public static class CharacterNameListManager
    {
        /// <summary>Url of the list of characters in the One Piece Fandom.</summary>
        private const string UrlFandomListCharacter = "https://onepiece.fandom.com/fr/wiki/Liste_des_Personnages_Canon";

        /// <summary>Instance of HtmlWeb.</summary>
        private static readonly HtmlWeb Web = new() { OverrideEncoding = Encoding.UTF8 };

        // Filter area.
        private const string TableFilter = "//div[contains(@class, 'tabber wds-tabber')]//table[contains(@class, 'wikitable')]";
        private const string RowFilter = "//tr";
        private const string LinkFilter = "td[2]/a";

        /// <summary>Dictionary of characterNameMapping.</summary>
        private static readonly ImmutableDictionary<string, string> CharacterNameMapping = ImmutableDictionary.CreateRange(
        [
            KeyValuePair.Create("Chadros Higelyges", "Barbe Brune"),
            KeyValuePair.Create("Jabra", "Jabura"),
            KeyValuePair.Create("Tama", "Kurozumi Tama"),
            KeyValuePair.Create("Kaku (Wano)", "Kaku"),
            KeyValuePair.Create("Enel", "Ener"),
            KeyValuePair.Create("Buckingham Stussy", "Bakkin"),
        ]);

        /// <summary>Get the list of character from the fandom webpage and add each character into a list.</summary>
        /// <returns>A list with all of characters.</returns>
        public static async Task<IReadOnlyList<string>> ReceivedCharactersList()
        {
            var rows = await SelectRows();
            var CharacterNameList = new List<string>(rows.Count);

            foreach (HtmlNode row in rows)
            {
                HtmlNode link = row.SelectSingleNode(LinkFilter);
                if (link == null)
                    continue;

                string character = ExtractExceptions(link.InnerHtml.Trim());

                if (character == "Smoothie")
                    continue;

                CharacterNameList.Add(character);
            }

            rows.Clear();

            return CharacterNameList;
        }

        /// <summary>Select rows from file.</summary>
        /// <returns>The collection of rows.</returns>
        private static async Task<HtmlNodeCollection> SelectRows()
        {
            var doc = await Web.LoadFromWebAsync(UrlFandomListCharacter).ConfigureAwait(false);
            var table = doc.DocumentNode.SelectSingleNode(TableFilter);
            return table.SelectNodes(RowFilter);
        }

        /// <summary>Change value for specific character.</summary>
        /// <param name="character">The name of the character.</param>
        /// <returns>The new character name.</returns>
        internal static string ExtractExceptions(string character)
        {
            return CharacterNameMapping.TryGetValue(character, out var result) ? result : character;
        }
    }
}
