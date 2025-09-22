// <copyright file="DataControl.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Resources;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace GuessWhoOnePiece.Model.DataEntries
{
    /// <summary>Represents the management of data given by web scrap.</summary>
    internal static partial class DataControl
    {
        /// <summary>List of cases that are Pirates.</summary>
        private static readonly HashSet<string> PirateTypeList = new(StringComparer.OrdinalIgnoreCase)
        {
          "Pirate", "Pirates", "Bandit", "Bandits", "Charlotte", "Big Mom", "Flotte de Happou", "Clan", "Moria",
          "Équipage", "Edward", "César", "Equipage", "Mihawk", "Thriller", "Mads", "New Comer Land", "Spiders Café", 
          "Baroque Works", "Blue Jam", "Assassin", "Zo", "Kujas", "Cross Guild", "Ligue des Primates", "Grand Corsaire"
        };

        /// <summary>List of cases that are Navy.</summary>
        private static readonly HashSet<string> NavyTypeList = new(StringComparer.OrdinalIgnoreCase)
        {
            "Marine", "Marines", " Marines", "Cipher Pol", "Souverain", "Conseil des 5 doyens", "CP-AIGIS0",
            "Gouvernement", "Impel", "Navy's Crew", "Juge", "Dragon Celestes", "CP9", "Seraphim", "CP6", "CP7", 
            "Celestial Dragons", "Cinq Doyens", "Vegapunk"
        };

        /// <summary>List of cases that are Revolutioanry.</summary>
        private static readonly HashSet<string> RevoTypeList = new(StringComparer.OrdinalIgnoreCase)
        {
            "Armée Révolutionnaire", "Révolutionnaires", "armée révolutionnaire", "Revolutionary's Crew",
            "Armée de la Liberté","Revolutionary's Army"
        };

        /// <summary>List of cases that are Celestial dragons.</summary>
        private static readonly HashSet<string> dragonCelestesKeywords = new(StringComparer.OrdinalIgnoreCase)
        {
            "Dragons Celestes", "Dragons Célestes","Nobles Mondiaux"
        };

        /// <summary>List of months.</summary>
        private static readonly HashSet<string> MonthList = new(StringComparer.OrdinalIgnoreCase)
        {
            "Janvier", "Février", "Mars", "Avril", "Mai", "Juin", "Juillet", 
            "Août", "Septembre", "Octobre", "Novembre", "Décembre"
        };

        private static readonly Dictionary<string, string> CrewMapping = new Dictionary<string, string>
        {
            { "L'Équipage du Firetank", Crew.BegeCrew },
            { "Subordonné de L'Équipage de Barbe Blanche", Crew.NewgateCrew },
            { "Capitaine de l'Equipage de Caribou", Crew.CaribouCrew },
            { "Punk Hazard", Crew.KaidoCrew },
            { "Neutre", Crew.Pirate },
            { "L'Équipage des Pirates Volants", Crew.NewFishmenCrew},
            { "Grand Corsaire", Crew.WeebleCrew},
            { "L'Équipage des Pirates Roger", Crew.RogerCrew }
        };

        private static readonly Dictionary<string, string> CharacterNameMappings = new()
        {
            { "Aramaki", "Aramaki / Ryokugyû" },
            { "Brannew", "Brand new" },
            { "Borsalino", "Borsalino / Kizaru" },
            { "Bentham", "Bentham / Mr. 2" },
            { "Barbe Brune", "Barbe Brune / Chadros Higelyges" },
            { "Bakkin", "Bakkin / Buckingham Stussy" },
            { "Babe", "Babe / Mr. 4" },
            { "Edward Newgate", "Edward Newgate / Barbe Blanche" },
            { "Edward Weevil", "Edward Weeble" },
            { "Charlotte Linlin", "Charlotte Linlin / Big Mom" },
            { "Daz Bones", "Daz Bones / Mr. 1" },
            { "Drophy", "Drophy / Miss Merry Christmas" },
            { "Galdino", "Galdino / Mr. 3" },
            { "Kiku", "Kiku / Kikunojo" },
            { "Marianne", "Marianne / Miss GoldenWeek" },
            { "Marshall D. Teach", "Marshall D. Teach / Barbe Noire" },
            { "Mikita", "Mikita / Miss Valentine" },
            { "Zala", "Zala / Miss Doublefinger" },
            { "Sakazuki", "Sakazuki / Akainu" }
        };

        private static readonly HashSet<string> ThrillerBark = new(StringComparer.OrdinalIgnoreCase)
        { 
            "Gecko Moria", "Hogback", "Dracule Mihawk" 
        };

        private static readonly HashSet<string> NavyCrew = new(StringComparer.OrdinalIgnoreCase)
        { 
            "Marine", "Marines", " Marines"
        };
        
        private static readonly HashSet<string> BigMomCrew = new(StringComparer.OrdinalIgnoreCase)
        { 
            "Équipage de Big Mom", "Famille Charlotte"
        };
        
        private static readonly HashSet<string> BaroqueWorks = new(StringComparer.OrdinalIgnoreCase)
        { 
            "Spiders Café", "Spider's Café" 
        };
        
        private static readonly HashSet<string> CrossGuild = new(StringComparer.OrdinalIgnoreCase)
        { 
            "Alliance Baggy et Alvida", "L'Équipage du Clown", "Alliance Baggy et Alvida/Les Pirates d'Expédition" 
        };

        private static readonly HashSet<string> DonQuichotte = new(StringComparer.OrdinalIgnoreCase)
        {
            "L'Équipage de Barbe Brune", "L'Équipage du New Age", "César Clown"
        };
        
        private static readonly HashSet<string> AlliedMugiwaraCrew = new(StringComparer.OrdinalIgnoreCase)
        { 
            "La Grande Flotte du Chapeau de Paille", "Alliance de l'Équipage du Chapeau de Paille", "Flotte de Happou",
            "L'Équipage d'Idéo", "Erbaf", "L'Équipage des Magnifiques Pirates", "L'Équipage d'Ideo", "Famille Chinjao" ,
            "Grande Flotte du Chapeau de Paille"
        };
        
        private static readonly HashSet<string> CitizenCrew = new(StringComparer.OrdinalIgnoreCase)
        { 
            "L'Équipage du Capitaine Usopp", "Voleurs d'Atamayama", "Zou", "Pays de Wa", "Phare du Cap des Jumeaux",
            "Clan des D.", "Principauté de Mokomo", "Alabasta", "Takoyaki 8", "Royaume maléfique de Black Drum",
            "Alliance des Ninjas-Pirates-Minks-Samouraïs", "Baratie", "Bar de l'Arnaque" 
        };

        /// <summary>Extract data from specific pattern.</summary>
        /// <param name="input">Text to extract.</param>
        /// <param name="pattern">Pattern which select data.</param>
        /// <returns>The text extraced.</returns>
        internal static string ExtractPattern(string input, string pattern)
        {
            var match = Regex.Match(input, pattern);
            return match.Success ? match.Groups[1].Value : "";
        }        

        /// <summary>Change charater name to accept more possibilites.</summary>
        internal static string ExceptionForCharacterName(string characterName)
        {
            return CharacterNameMappings.TryGetValue(characterName, out var mappedName)
                ? mappedName
                : characterName;
        }
    }
}
