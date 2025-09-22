// <copyright file="ControlRoom.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.CsvManager;

namespace GuessWhoOnePiece.Model.DataEntries
{
    /// <summary>Represents the control of threads for web call.</summary>
    public partial class ControlRoom
    {
        private IReadOnlyList<string> _characterNameList = new List<string>();

        private const int MAX_PROGRESS_DATA = 70;
        private const int MAX_PROGRESS_POPULARITY = 30;

        public int CharacterCount
        {
            get => _characterNameList.Count;
        }


        /// <summary>Generate threads to get data.</summary>
        /// <returns>The complete list of characters.</returns>
        public async Task<IReadOnlyCollection<Character>> GenerateThreads(IFileServiceReader fileServiceReader)
        {
            _characterNameList = await CharacterNameListManager.ReceivedCharactersList();

            var charactersList = new ConcurrentBag<Character>();
            
            await Parallel.ForEachAsync(_characterNameList, async (characterName, _) =>
            {
                var character = await DataForCharacter(SetCharacterLink(characterName), characterName, fileServiceReader);
                if (character != null)
                    charactersList.Add(character);
            });

            IReadOnlyCollection<Character> characterList = new List<Character>(charactersList.ToList());
            charactersList.Clear();

            characterList = await Popularity.SetPopularity(_characterNameList, characterList);
            return characterList;
        }

        /// <summary>Set the link to find a character on the fandom.</summary>
        /// <param name="characterName">The character to find.</param>
        /// <returns>The link of the character.</returns>
        public static Uri SetCharacterLink(string characterName)
        {
            var urlCharacter = characterName.Replace(" ", "_", StringComparison.OrdinalIgnoreCase).Trim();
            var matcher = Regexs.CharacterLinkRegex().Match(urlCharacter);
            if (matcher.Success)
            {
                urlCharacter = matcher.Groups[1].Value;
            }

            const string urlFandom = "https://onepiece.fandom.com/fr/wiki/";
            return new Uri(urlFandom + urlCharacter);
        }

        public int Percentage
        {
            get
            {
                if (CharacterCount == 0)
                    return CharacterCount;

                int percentage = (int)((double)CountPercentage / CharacterCount * MAX_PROGRESS_DATA);
                return (CountPercentage < CharacterCount) ? percentage : Popularity.CountPopularity / CountPercentage * MAX_PROGRESS_POPULARITY + MAX_PROGRESS_DATA;
            }
        }
    }
}

