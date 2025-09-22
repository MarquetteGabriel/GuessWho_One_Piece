// <copyright file="TypeData.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Resources;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GuessWhoOnePiece.Model.DataEntries
{
    internal static partial class DataControl
    {
        /// <summary>Extract type from text.</summary>
        /// <param name="text">Text.</param>
        /// <returns>The new type.</returns>
        internal static string ExtractPatternType(HtmlNode text, string crew)
        {
            if (crew.Equals(Crew.Citizen))
                return Resources.Strings.Citizen;
            if (crew.Equals(Crew.RevolutionaryArmy))
                return Resources.Strings.RevolutionaryType;
            if (PirateTypeList.Any(crew.Contains))
                return Resources.Strings.PirateType;

            var typeCharacters = new List<string>();
            var types = text.SelectNodes(".//*[contains(@class, 'pi-data-value')]")
                .Select(node => node.InnerText)
                .SelectMany(html => Regexs.SplitPatternType().Split(html))
                .ToArray();

            foreach (var type in types)
            {
                var docSmallDatas = new HtmlDocument();
                docSmallDatas.LoadHtml(type);
                var smallText = docSmallDatas.DocumentNode.SelectSingleNode("//small")?.InnerText ?? "";
                var cleanedType = Regexs.ContentBetweenBracketsRegex().Replace(type, "").Trim() + smallText;
                typeCharacters.AddRange(cleanedType.Split(new[] { ";", "," }, StringSplitOptions.RemoveEmptyEntries));
            }

            var filteredTypeCharacters = typeCharacters
                .Select(typeData => typeData.Replace("\\[.*?]\\s*$", "", StringComparison.OrdinalIgnoreCase))
                .Where(typeData => !typeData.Contains("anciennement", StringComparison.OrdinalIgnoreCase) &&
                                    !typeData.Contains("temporairement", StringComparison.OrdinalIgnoreCase));

            var celestialDragons = filteredTypeCharacters.FirstOrDefault(typeData => dragonCelestesKeywords.Any(keyword => typeData.Contains(keyword, StringComparison.OrdinalIgnoreCase)));
            if(celestialDragons != null)
                return Resources.Strings.CelestialDragons;
            else
                return Resources.Strings.NavyType;
        }
    }
}
