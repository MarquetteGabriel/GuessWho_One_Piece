// <copyright file="DataControlTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.DataEntries;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using System;

namespace GuessWhoOnePiece.Tests.DataEntries
{
    public class DataControlTest
    {
        #region ExtractPattern Tests

        [Fact]
        public void Test_ExtractPattern()
        {
            var textInput = "InformationsNom Japonais :さらへび先生Nom Romanisé :Sarahebi-senseiPremière Apparition:Chapitre 919 ; Épisode 909[1]Affiliations :L'Équipage aux Cent BêtesOccupations :Gifter,[2] Enseignante[1]Statut :VivanteVoix Japonaise :Yuka Komatsu Fruit du DémonNom Japonais :Smile du serpent[3]Type :SMILE";
            var pattern = "Chapitre (\\d+)";
            var result = DataControl.ExtractPattern(textInput, pattern);
            Assert.Equal("919", result);
        }

        [Fact]
        public void Test_ExtractPatternEmpty()
        {
            var textInput = "";
            var pattern = "Chapitre (\\d+)";
            var result = DataControl.ExtractPattern(textInput, pattern);
            Assert.Equal("", result);
        }

        #endregion

        #region ExtractExceptions Tests

        [Fact]
        public void Test_ExtractExceptions_Unchanged()
        {
            var character = "Monkey D. Luffy";
            var result = CharacterNameListManager.ExtractExceptions(character);
            Assert.Equal("Monkey D. Luffy", result);
        }

        [Fact]
        public void Test_ExtractExceptions_BBrune()
        {
            var character = "Chadros Higelyges";
            var result = CharacterNameListManager.ExtractExceptions(character);
            Assert.Equal("Barbe Brune", result);
        }

        [Fact]
        public void Test_ExtractExceptions_Jabura()
        {
            var character = "Jabra";
            var result = CharacterNameListManager.ExtractExceptions(character);
            Assert.Equal("Jabura", result);
        }

        [Fact]
        public void Test_ExtractExceptions_Tama()
        {
            var character = "Tama";
            var result = CharacterNameListManager.ExtractExceptions(character);
            Assert.Equal("Kurozumi Tama", result);
        }

        [Fact]
        public void Test_ExtractExceptions_Kaku()
        {
            var character = "Kaku (Wano)";
            var result = CharacterNameListManager.ExtractExceptions(character);
            Assert.Equal("Kaku", result);
        }

        [Fact]
        public void Test_ExtractExceptions_Ener()
        {
            var character = "Enel";
            var result = CharacterNameListManager.ExtractExceptions(character);
            Assert.Equal("Ener", result);
        }

        [Fact]
        public void Test_ExtractExceptions_Bakkin()
        {
            var character = "Buckingham Stussy";
            var result = CharacterNameListManager.ExtractExceptions(character);
            Assert.Equal("Bakkin", result);
        }

        #endregion

        #region ExtractExceptionsPopularity Tests

        [Fact]
        public void Test_ExtractExceptionsPopularity_Unchanged()
        {
            var character = "Monkey D. Luffy";
            var result = Popularity.ExtractExceptionsPopularity(character);
            Assert.Equal("Monkey D. Luffy", result);
        }

        [Fact]
        public void Test_ExtractExceptionsPopularity_DonQuichotte()
        {
            var character = "Don Quichotte Dofflamingo";
            var result = Popularity.ExtractExceptionsPopularity(character);
            Assert.Equal("Donquixote Dofflamingo", result);
        }

        [Fact]
        public void Test_ExtractExceptionsPopularity_King()
        {
            var character = "Alber";
            var result = Popularity.ExtractExceptionsPopularity(character);
            Assert.Equal("King", result);
        }

        [Fact]
        public void Test_ExtractExceptionsPopularity_Linlin()
        {
            var character = "Charlotte Linlin";
            var result = Popularity.ExtractExceptionsPopularity(character);
            Assert.Equal("Big Mom", result);
        }

        [Fact]
        public void Test_ExtractExceptionsPopularity_Galdino()
        {
            var character = "Galdino";
            var result = Popularity.ExtractExceptionsPopularity(character);
            Assert.Equal("Mr 3", result);
        }

        [Fact]
        public void Test_ExtractExceptionsPopularity_Teach()
        {
            var character = "Marshall D. Teach";
            var result = Popularity.ExtractExceptionsPopularity(character);
            Assert.Equal("Barbe Noire", result);
        }

        [Fact]
        public void Test_ExtractExceptionsPopularity_Newgate()
        {
            var character = "Edward Newgate";
            var result = Popularity.ExtractExceptionsPopularity(character);
            Assert.Equal("Barbe Blanche", result);
        }

        #endregion
    }
}
