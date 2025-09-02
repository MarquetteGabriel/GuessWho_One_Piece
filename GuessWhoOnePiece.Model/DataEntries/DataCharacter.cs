// <copyright file="DataCharacter.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.CsvManager;
using GuessWhoOnePiece.Model.DataEntries.Picture;
using GuessWhoOnePiece.Model.Resources;
using HtmlAgilityPack;
using System;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.Model.DataEntries
{
    public partial class ControlRoom
    {
        /// <summary>Number of levels.</summary>
        internal const int NumberOfLevels = 2;

        private static readonly SemaphoreSlim ImageDownloadSemaphore = new SemaphoreSlim(1);

        private static readonly HtmlWeb Web = new() { OverrideEncoding = Encoding.UTF8 };

        private const string OccupationValue = "occupation";
        private const string AffiliationValue = "affiliation";
        private const string Dead = "Décédé";
        private const string Death = "Mort";

        private const string ClassCharacterData = "pi-item pi-group pi-border-color";
        private const string ClassFruit = "portable-infobox pi-background pi-border-color pi-theme-char pi-layout-default";
        private const string ClassType = "pi-item pi-data pi-item-spacing pi-border-color";

        // Filters.
        private const string FilterCharacterData = $"//*[contains(@class, '{ClassCharacterData}')]";
        private const string FilterDevilFruit = $"//*[contains(@class, '{ClassFruit}')]";
        private const string FilterPicture = $"//*[contains(@class, 'image')]//a";
        private const string FilterBounty = $"//*[contains(@class, '{ClassType}')]";
        private const string FilterAlived = @"Statut\s:(Vivant|Décédé|Mort)";
        private const string FilterChapter = "Chapitre (\\d+)";

        // Exceptions Message.
        private const string ExceptionMessage = "No character data";
        private const string ExceptionMessageChapter = "Invalid Chapter";
        private const string ExceptionMessageAge = "No age for the chracter";

        // MemoryLeak avoided on resx.
        private const string Citizen = "Citizen";
        private const string FruitDuDemon = "Fruit du Démon";
        private const string CelestialDragons = "Celestial Dragons";
        private const string Navy = "Navy";
        private const string Vegapunk = "Vegapunk";

        private const string Space = " ";
        private const string DataSource = "data-source";

        /// <summary>Percentage of advencement for loading characters.</summary>
        private int _countPercentage;

        public int CountPercentage
        {
            get => _countPercentage;
        }

        /// <summary>Get data for a specific character from its fandom page.</summary>
        /// <param name="url">The url of the character.</param>
        /// <param name="characterName">The name of the character.</param>
        /// <returns>The character.</returns>
        public async Task<Character?> DataForCharacter(Uri url, string characterName, IFileServiceReader fileServiceReader)
        {
            try
            {
                var doc = await Web.LoadFromWebAsync(url.ToString());

                var characterData = CleanWebHtmlString(doc.DocumentNode.SelectSingleNode(FilterCharacterData)?.InnerText)
                     ?? throw new InvalidOperationException(ExceptionMessage);

                // Age part.
                var age = DataControl.ExtractPatternAge(characterData, characterName);
                if (age == 0)
                    throw new InvalidOperationException(ExceptionMessageAge);

                // Chapter Part.
                var chapterString = DataControl.ExtractPattern(characterData, FilterChapter);
                var chapter = !string.IsNullOrEmpty(chapterString) ? int.Parse(chapterString) : throw new InvalidOperationException(ExceptionMessageChapter);
                if (characterName.Equals("Demalo Black", StringComparison.Ordinal))
                    chapter = 598;

                var pictureElements = doc.DocumentNode.SelectNodes(FilterPicture);

                var bountyTypeCrewElements = doc.DocumentNode.SelectNodes(FilterBounty) ?? throw new InvalidOperationException(ExceptionMessage);

                // Get the fruit devil.
                bool fruit = GetDevilFruitValue(doc);
                doc = null;

                // Get the picture.
                Task<string>? pictureDownloadTask = null;
                if (pictureElements != null)
                {
                    var pictureElement = PictureManager.GetPictureLink(pictureElements);
                    pictureElement = CleanWebHtmlString(pictureElement);

                    pictureDownloadTask = Task.Run(async () =>
                    {
                        await ImageDownloadSemaphore.WaitAsync();
                        try
                        {
                            return await PictureManager.DownloadImageAsync(pictureElement, characterName, fileServiceReader);
                        }
                        finally
                        {
                            ImageDownloadSemaphore.Release();
                            pictureElements = null;
                            pictureElement = null;
                        }
                    });
                }

                // Crew part.
                (var crew, var type) = GetCrewType(bountyTypeCrewElements, characterName);

                // Alived part.
                var alivedString = DataControl.ExtractPattern(characterData, FilterAlived);
                var alived = !alivedString.Equals(Dead) && !alivedString.Equals(Death);

                // Bounty part.
                var bounty = DataControl.ExtractPatternBounty(characterData, type, characterName);
                characterData = null;

                // Change Name.
                characterName = DataControl.ExceptionForCharacterName(characterName);

                // Get picture path.
                string picturePath = string.Empty;
                if (pictureDownloadTask != null)
                    picturePath = await pictureDownloadTask;

                // Add characters.
                var characters = new Character(characterName, fruit, bounty, chapter, type, alived, age, crew, picturePath, NumberOfLevels + 1);
                _countPercentage++;

                if (_countPercentage > _characterNameList.Count)
                {
                    _countPercentage = _characterNameList.Count;
                }

                return characters;
            }
            catch (InvalidOperationException)
            {
                _countPercentage++;
                return null;
            }
        }

        private static bool GetDevilFruitValue(HtmlDocument doc)
        {
            var fruitElement = CleanWebHtmlString(doc.DocumentNode.SelectSingleNode(FilterDevilFruit)?.InnerText)
                    ?? throw new InvalidOperationException(ExceptionMessage);
            return fruitElement.Contains(FruitDuDemon, StringComparison.OrdinalIgnoreCase);
        }

        private static (string, string) GetCrewType(HtmlNodeCollection bountyTypeCrewElements, string characterName)
        {
            var (crewElement, typeElement) = GetCrewTypeElement(bountyTypeCrewElements);
            crewElement ??= bountyTypeCrewElements.FirstOrDefault(element => element.InnerHtml.Contains(OccupationValue, StringComparison.OrdinalIgnoreCase));
            typeElement ??= bountyTypeCrewElements.FirstOrDefault(element => element.InnerHtml.Contains(AffiliationValue, StringComparison.OrdinalIgnoreCase));
            bountyTypeCrewElements.Clear();

            var crew = crewElement == null ? Citizen : DataControl.ExtractCrew(crewElement, characterName);
            var type = typeElement == null ? Citizen : DataControl.ExtractPatternType(typeElement, crew);

            if (type.Equals(CelestialDragons))
            {
                crew = CelestialDragons;
                type = Navy;
            }
            if (crew == Vegapunk)
                crew = Crew.Navy;

            return (crew, type);
        }

        private static (HtmlNode?, HtmlNode?) GetCrewTypeElement(HtmlNodeCollection bountyTypeCrewElements)
        {
            HtmlNode? typeElement = null;
            HtmlNode? crewElement = null;

            foreach (var bountyTypeCrewElement in bountyTypeCrewElements)
            {
                var dataSource = bountyTypeCrewElement.GetAttributeValue(DataSource, string.Empty);

                if (dataSource == OccupationValue)
                    typeElement = bountyTypeCrewElement;

                if (dataSource == AffiliationValue)
                    crewElement = bountyTypeCrewElement;

                if (typeElement != null && crewElement != null)
                    return (crewElement, typeElement);
            }

            return (crewElement, typeElement);
        
        }

        /// <summary>Clean string from web and html format.</summary>
        /// <param name="webString">String to clean.</param>
        /// <returns>The string cleaned.</returns>
        private static string CleanWebHtmlString(string? webString) => webString != null ? WebUtility.HtmlDecode(webString).Replace("\n", string.Empty, StringComparison.OrdinalIgnoreCase)
            .Replace("\t", string.Empty, StringComparison.OrdinalIgnoreCase) : string.Empty;
    }
}
