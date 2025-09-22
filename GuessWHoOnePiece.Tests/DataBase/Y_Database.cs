// <copyright file="Y_Database.cs">
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
    public class Y_Database
    {
        private ControlRoom controlRoom;
        private const string Unknown = "Unknown";
        private const string LocalPath = "C:\\Users\\Gabriel Marquette\\AppData\\Local\\Packages\\com.companyname.guesswhoonepiece_9zz4h110yvjzm\\LocalState\\";
        Mock mockFileService = new Mock<IFileServiceReader>();
        public Y_Database()
        {
            controlRoom = new ControlRoom();
        }

        [SkippableFact]
        public async Task Yama()
        {
            var character = "Yama";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yama", result!.Name);
            Assert.Equal(45, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(254, result.FirstAppearance);
            Assert.Equal(Crew.EnerCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Yamakaji()
        {
            var character = "Yamakaji";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yamakaji", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yamato()
        {
            var character = "Yamato";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yamato", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(971, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yame()
        {
            var character = "Yame";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yame", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yamenahare()
        {
            var character = "Yamenahare";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yamenahare", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yamon()
        {
            var character = "Yamon";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yamon", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yaneno_Chinode()
        {
            var character = "Yaneno Chinode";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yaneno Chinode", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(1074, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yarisugi()
        {
            var character = "Yarisugi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yarisugi", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yarle()
        {
            var character = "Yarle";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yarle", result!.Name);
            Assert.Equal(408, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(866, result.FirstAppearance);
            Assert.Equal(Crew.GiantsCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Yasopp()
        {
            var character = "Yasopp";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yasopp", result!.Name);
            Assert.Equal(47, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(1, result.FirstAppearance);
            Assert.Equal(Crew.ShanksCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Yatappe()
        {
            var character = "Yatappe";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yatappe", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yazaemon()
        {
            var character = "Yazaemon";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yazaemon", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(931, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yokan()
        {
            var character = "Yokan";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yokan", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yokozuna()
        {
            var character = "Yokozuna";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yokozuna", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yomo()
        {
            var character = "Yomo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yomo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yonka()
        {
            var character = "Yonka";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yonka", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yonka_n2()
        {
            var character = "Yonka n°2";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yonka n°2", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

[SkippableFact]
        public async Task York()
        {
            var character = "York";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("York", result!.Name);
            Assert.Equal(16, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(1062, result.FirstAppearance);
            Assert.Equal(Crew.GouvernementMondial, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Yorki()
        {
            var character = "Yorki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yorki", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yorle()
        {
            var character = "Yorle";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yorle", result!.Name);
            Assert.Equal(344, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(866, result.FirstAppearance);
            Assert.Equal(Crew.GiantsCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Yosaku()
        {
            var character = "Yosaku";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yosaku", result!.Name);
            Assert.Equal(26, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(42, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yoshimoto()
        {
            var character = "Yoshimoto";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yoshimoto", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yotsubane()
        {
            var character = "Yotsubane";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yotsubane", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yu()
        {
            var character = "Yu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yu", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yui()
        {
            var character = "Yui";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yui", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yuki()
        {
            var character = "Yuki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yuki", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yukichi_Skull()
        {
            var character = "Yukichi Skull";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yukichi Skull", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Yurikah()
        {
            var character = "Yurikah";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Yurikah", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

    }
}
