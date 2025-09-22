// <copyright file="B_Database.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.DataEntries;
using System.Threading.Tasks;
using GuessWhoOnePiece.Model.CsvManager;
using Moq;
using GuessWhoOnePiece.Model.Resources;

namespace GuessWhoOnePiece.Tests.DataBase
{
    public class B_Database
    {
        private readonly ControlRoom controlRoom;
        private const string Unknown = "Unknown";
        private const string LocalPath = "C:\\Users\\Gabriel Marquette\\AppData\\Local\\Packages\\com.companyname.guesswhoonepiece_9zz4h110yvjzm\\LocalState\\";
        public B_Database()
        {
            controlRoom = new ControlRoom();
        }

        [SkippableFact]
        public async Task Babanuki()
        {
            var character = "Babanuki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Babanuki", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Babe()
        {
            var character = "Babe";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Babe / Mr. 4", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(160, result.FirstAppearance);
            Assert.Equal(Crew.BaroqueWorks, result.Crew);
            Assert.Equal("3,2 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Baby5()
        {
            var character = "Baby 5";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Baby 5", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(682, result.FirstAppearance);
            Assert.Equal(Crew.MugiwaraAllies, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bacura()
        {
            var character = "Bacura";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bacura", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Baggaley()
        {
            var character = "Baggaley";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Baggaley", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Baggy()
        {
            var character = "Baggy";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Baggy", result!.Name);
            Assert.Equal(39, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(9, result.FirstAppearance);
            Assert.Equal(Crew.CrossGuild, result.Crew);
            Assert.Equal("3,189 Md", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bakezo()
        {
            var character = "Bakezo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bakezo", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bakkin()
        {
            var character = "Bakkin";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bakkin / Buckingham Stussy", result!.Name);
            Assert.Equal(76, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(802, result.FirstAppearance);
            Assert.Equal(Crew.WeebleCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BanDedessinee()
        {
            var character = "Ban Dedessinée";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ban Dedessinée", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Banchi()
        {
            var character = "Banchi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Banchi", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bankina()
        {
            var character = "Bankina";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bankina", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bankuro()
        {
            var character = "Bankuro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bankuro", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Banra()
        {
            var character = "Banra";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Banra", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Banzaburo()
        {
            var character = "Banzaburo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Banzaburo", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bao()
        {
            var character = "Bao";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bao", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BaoHuang()
        {
            var character = "Bao Huang";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bao Huang", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BarbeBrune()
        {
            var character = "Barbe Brune";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Barbe Brune / Chadros Higelyges", result!.Name);
            Assert.Equal(45, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(581, result.FirstAppearance);
            Assert.Equal(Crew.DoflamingoCrew, result.Crew);
            Assert.Equal("80,06 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BarbeRose()
        {
            var character = "Barbe Rose";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Barbe Rose", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bariete()
        {
            var character = "Bariete";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bariete", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Barrel()
        {
            var character = "Barrel";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Barrel", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Barry()
        {
            var character = "Barry";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Barry", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BartholomewKuma()
        {
            var character = "Bartholomew Kuma";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bartholomew Kuma", result!.Name);
            Assert.Equal(47, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(233, result.FirstAppearance);
            Assert.Equal(Crew.RevolutionaryArmy, result.Crew);
            Assert.Equal("296 Mi", result.Bounty);
            Assert.Equal("Revolutionary", result.Type);
        }

        [SkippableFact]
        public async Task Bartolomeo()
        {
            var character = "Bartolomeo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bartolomeo", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(705, result.FirstAppearance);
            Assert.Equal(Crew.MugiwaraAllies, result.Crew);
            Assert.Equal("200 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bas()
        {
            var character = "Bas";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bas", result!.Name);
            Assert.Equal(48, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(379, result.FirstAppearance);
            Assert.Equal(Crew.GouvernementMondial, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task BasilHawkins()
        {
            var character = "Basil Hawkins";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Basil Hawkins", result!.Name);
            Assert.Equal(31, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(498, result.FirstAppearance);
            Assert.Equal(Crew.HawkinsCrew, result.Crew);
            Assert.Equal("320 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Basilic()
        {
            var character = "Basilic";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Basilic", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bastille()
        {
            var character = "Bastille";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bastille", result!.Name);
            Assert.Equal(38, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(553, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Batchee()
        {
            var character = "Batchee";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Batchee", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Batman()
        {
            var character = "Batman";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Batman", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BattsSamouraï()
        {
            var character = "Batts Samouraï";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Batts Samouraï", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Baxcon()
        {
            var character = "Baxcon";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Baxcon", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BeeAnne()
        {
            var character = "Bee Anne";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bee Anne", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BeerVI()
        {
            var character = "Beer VI";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Beer VI", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Belladonna()
        {
            var character = "Belladonna";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Belladonna", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bellamy()
        {
            var character = "Bellamy";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bellamy", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(222, result.FirstAppearance);
            Assert.Equal(Crew.DoflamingoCrew, result.Crew);
            Assert.Equal("195 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bellett()
        {
            var character = "Bellett";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bellett", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Belmer()
        {
            var character = "Belmer";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Belmer", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task BeloBetty()
        {
            var character = "Belo Betty";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Belo Betty", result!.Name);
            Assert.Equal(34, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(904, result.FirstAppearance);
            Assert.Equal(Crew.RevolutionaryArmy, result.Crew);
            Assert.Equal("457 Mi", result.Bounty);
            Assert.Equal("Revolutionary", result.Type);
        }

        [SkippableFact]
        public async Task BenBeckman()
        {
            var character = "Ben Beckman";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ben Beckman", result!.Name);
            Assert.Equal(50, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(1, result.FirstAppearance);
            Assert.Equal(Crew.ShanksCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bentham()
        {
            var character = "Bentham";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bentham / Mr. 2", result!.Name);
            Assert.Equal(32, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(129, result.FirstAppearance);
            Assert.Equal(Crew.NewComerLand, result.Crew);
            Assert.Equal("32 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bepo()
        {
            var character = "Bepo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bepo", result!.Name);
            Assert.Equal(22, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(498, result.FirstAppearance);
            Assert.Equal(Crew.LawCrew, result.Crew);
            Assert.Equal("1500", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Big_Pan()
        {
            var character = "Big Pan";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Big Pan", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BillyPirate()
        {
            var character = "Billy (Pirate)";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Billy (Pirate)", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bimine()
        {
            var character = "Bimine";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bimine", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bingo()
        {
            var character = "Bingo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bingo", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bishamon()
        {
            var character = "Bishamon";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bishamon", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(931, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Biyo()
        {
            var character = "Biyo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Biyo", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bizarre()
        {
            var character = "Bizarre";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bizarre", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BlackBack()
        {
            var character = "Black Back";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Black Back", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BlackMaria()
        {
            var character = "Black Maria";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Black Maria", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(978, result.FirstAppearance);
            Assert.Equal(Crew.KaidoCrew, result.Crew);
            Assert.Equal("480 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Blamenco()
        {
            var character = "Blamenco";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Blamenco", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Blenheim()
        {
            var character = "Blenheim";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Blenheim", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Blondie()
        {
            var character = "Blondie";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Blondie", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BlueFan()
        {
            var character = "Blue Fan";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Blue Fan", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BlueGilly()
        {
            var character = "Blue Gilly";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Blue Gilly", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(706, result.FirstAppearance);
            Assert.Equal(Crew.MugiwaraAllies, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bluegrass()
        {
            var character = "Bluegrass";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bluegrass", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bluejam()
        {
            var character = "Bluejam";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bluejam", result!.Name);
            Assert.Equal(42, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(584, result.FirstAppearance);
            Assert.Equal(Crew.BluejamCrew, result.Crew);
            Assert.Equal("14,3 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Blueno()
        {
            var character = "Blueno";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Blueno", result!.Name);
            Assert.Equal(32, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(325, result.FirstAppearance);
            Assert.Equal(Crew.CipherPol, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Blumarine()
        {
            var character = "Blumarine";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Blumarine", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BoaHancock()
        {
            var character = "Boa Hancock";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Boa Hancock", result!.Name);
            Assert.Equal(31, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(489, result.FirstAppearance);
            Assert.Equal(Crew.Kujas, result.Crew);
            Assert.Equal("1,659 Md", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BoaMarigold()
        {
            var character = "Boa Marigold";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Boa Marigold", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(516, result.FirstAppearance);
            Assert.Equal(Crew.Kujas, result.Crew);
            Assert.Equal("40 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BoaSandersonia()
        {
            var character = "Boa Sandersonia";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Boa Sandersonia", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(516, result.FirstAppearance);
            Assert.Equal(Crew.Kujas, result.Crew);
            Assert.Equal("40 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bobbin()
        {
            var character = "Bobbin";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bobbin", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BobbyFunk()
        {
            var character = "Bobby Funk";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bobby Funk", result!.Name);
            Assert.Equal(33, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(704, result.FirstAppearance);
            Assert.Equal(Crew.Assassin, result.Crew);
            Assert.Equal("36 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bobomba()
        {
            var character = "Bobomba";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bobomba", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bogart()
        {
            var character = "Bogart";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bogart", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bomba()
        {
            var character = "Bomba";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bomba", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BombaMarine()
        {
            var character = "Bomba (Marine)";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bomba (Marine)", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Bongo()
        {
            var character = "Bongo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bongo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BonkPanchi()
        {
            var character = "Bonk Panchi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bonk Panchi", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Boo()
        {
            var character = "Boo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Boo", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Boogie()
        {
            var character = "Boogie";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Boogie", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Borsalino()
        {
            var character = "Borsalino";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Borsalino / Kizaru", result!.Name);
            Assert.Equal(58, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(504, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task BossdelaForet()
        {
            var character = "Boss de la Forêt";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Boss de la Forêt", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BossdesTunnels()
        {
            var character = "Boss des Tunnels";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Boss des Tunnels", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task BourbonJr()
        {
            var character = "Bourbon Jr";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bourbon Jr", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Braham()
        {
            var character = "Braham";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Braham", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(249, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Brahm()
        {
            var character = "Brahm";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brahm", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Brannew()
        {
            var character = "Brannew";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brand new", result!.Name);
            Assert.Equal(56, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(96, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Brew()
        {
            var character = "Brew";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brew", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Briscola()
        {
            var character = "Briscola";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Briscola", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Brocca()
        {
            var character = "Brocca";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brocca", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Brogy()
        {
            var character = "Brogy";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brogy", result!.Name);
            Assert.Equal(160, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(116, result.FirstAppearance);
            Assert.Equal(Crew.GiantsCrew, result.Crew);
            Assert.Equal("1,8 Md", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Brontosaurus()
        {
            var character = "Brontosaurus";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brontosaurus", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Brook()
        {
            var character = "Brook";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brook", result!.Name);
            Assert.Equal(90, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(442, result.FirstAppearance);
            Assert.Equal(Crew.MugiwaraCrew, result.Crew);
            Assert.Equal("383 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Brululu()
        {
            var character = "Brululu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Brululu", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bubblegum()
        {
            var character = "Bubblegum";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bubblegum", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Buche()
        {
            var character = "Buche";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Buche", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Buchi()
        {
            var character = "Buchi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Buchi", result!.Name);
            Assert.Equal(23, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(31, result.FirstAppearance);
            Assert.Equal(Crew.BlackCatCrew, result.Crew);
            Assert.Equal("7 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Buddle()
        {
            var character = "Buddle";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Buddle", result!.Name);
            Assert.Equal(75, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(12, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Buffalo()
        {
            var character = "Buffalo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Buffalo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(692, result.FirstAppearance);
            Assert.Equal(Crew.DoflamingoCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Buhikku()
        {
            var character = "Buhikku";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Buhikku", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Building_Snake()
        {
            var character = "Building Snake";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Building Snake", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bulldog()
        {
            var character = "Bulldog";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bulldog", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bunbuku()
        {
            var character = "Bunbuku";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bunbuku", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bungo()
        {
            var character = "Bungo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bungo", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bunny_Joe()
        {
            var character = "Bunny Joe";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bunny Joe", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Bushon()
        {
            var character = "Bushon";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Bushon", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Busshiri()
        {
            var character = "Busshiri";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Busshiri", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Byron()
        {
            var character = "Byron";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Byron", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(501, result.FirstAppearance);
            Assert.Equal(Crew.Pirate, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }
    }
}
