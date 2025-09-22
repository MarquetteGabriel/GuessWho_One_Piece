// <copyright file="Z_Database.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.CsvManager;
using GuessWhoOnePiece.Model.DataEntries;
using GuessWhoOnePiece.Model.Resources;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.Tests.DataBase
{
    public class Z_Database
    {
        private ControlRoom controlRoom;
        private const string Unknown = "Unknown";
        private const string LocalPath = "C:\\Users\\Gabriel Marquette\\AppData\\Local\\Packages\\com.companyname.guesswhoonepiece_9zz4h110yvjzm\\LocalState\\";
        Mock mockFileService = new Mock<IFileServiceReader>();
        public Z_Database()
        {
            controlRoom = new ControlRoom();
        }

        [SkippableFact]
        public async Task Zabo()
        {
            var character = "Zabo";
            var characterLink = ControlRoom.SetCharacterLink(character); 
            var mockFileService = new Mock<IFileServiceReader>(); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zabo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zadie()
        {
            var character = "Zadie";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zadie", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zala()
        {
            var character = "Zala";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zala / Miss Doublefinger", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(155, result.FirstAppearance);
            Assert.Equal(Crew.BaroqueWorks, result.Crew);
            Assert.Equal("35 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Zambai()
        {
            var character = "Zambai";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zambai", result!.Name);
            Assert.Equal(35, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(324, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zangirimaru()
        {
            var character = "Zangirimaru";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zangirimaru", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zanki()
        {
            var character = "Zanki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zanki", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zeff()
        {
            var character = "Zeff";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zeff", result!.Name);
            Assert.Equal(67, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(43, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zeo()
        {
            var character = "Zeo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zeo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(611, result.FirstAppearance);
            Assert.Equal(Crew.NewFishmenCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Zepo()
        {
            var character = "Zepo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zepo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zeus()
        {
            var character = "Zeus";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zeus", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zodia()
        {
            var character = "Zodia";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zodia", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zott()
        {
            var character = "Zott";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zott", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zucca()
        {
            var character = "Zucca";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zucca", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Zunesh()
        {
            var character = "Zunesh";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Zunesh", result!.Name);
            Assert.Equal(1000, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(802, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

    }
}
