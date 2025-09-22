// <copyright file="A_Database.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.CsvManager;
using GuessWhoOnePiece.Model.DataEntries;
using Moq;
using System.Threading.Tasks;
using GuessWhoOnePiece.Model.Resources;

namespace GuessWhoOnePiece.Tests.DataBase
{
    public class A_Database
    {
        private ControlRoom controlRoom;
        private const string Unknown = "Unknown";
        private const string LocalPath = "C:\\Users\\Gabriel Marquette\\AppData\\Local\\Packages\\com.companyname.guesswhoonepiece_9zz4h110yvjzm\\LocalState\\";

        public A_Database()
        {
            controlRoom = new ControlRoom();
        }

        [SkippableFact]
        public async Task AO()
        {
            var character = "A.O";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var mockFileService = new Mock<IFileServiceReader>();
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("A.O", result!.Name);
            Assert.Equal(25, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(456, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Abdullah()
        {
            var character = "Abdullah";
            var characterLink = ControlRoom.SetCharacterLink(character); 
            var mockFileService = new Mock<IFileServiceReader>(); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found"); 
            Assert.Equal("Abdullah", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Absalom()
        {
            var character = "Absalom";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Absalom", result!.Name);
            Assert.Equal(36, result.Age);
            Assert.False(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(444, result.FirstAppearance);
            Assert.Equal(Crew.ThrillerBark, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Acilia()
        {
            var character = "Acilia";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Acilia", result!.Name);
            Assert.Equal(22, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Adele()
        {
            var character = "Adele";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Adele", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AgatheToulive()
        {
            var character = "Agathe Toulive";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Agathe Toulive", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AgentChocolat()
        {
            var character = "Agent Chocolat";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Agent Chocolat", result!.Name);
            Assert.Equal(26, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Aggie68()
        {
            var character = "Aggie 68";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aggie 68", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Agotogi()
        {
            var character = "Agotogi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Agotogi", result!.Name);
            Assert.Equal(31, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Agsilly()
        {
            var character = "Agsilly";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Agsilly", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Aguio()
        {
            var character = "Aguio";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aguio", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AhhoDesunenIX()
        {
            var character = "Ahho Desunen IX";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ahho Desunen IX", result!.Name);
            Assert.Equal(32, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AhhoZurako()
        {
            var character = "Ahho Zurako";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ahho Zurako", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Ahiru()
        {
            var character = "Ahiru";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ahiru", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Aisa()
        {
            var character = "Aisa";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aisa", result!.Name);
            Assert.Equal(11, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(249, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Akehende()
        {
            var character = "Akehende";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");      
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Akehende", result!.Name);
            Assert.Equal(31, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AkudaiKanzaburo()
        {
            var character = "Akudai Kanzaburo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Akudai Kanzaburo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Akumai()
        {
            var character = "Akumai";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Akumai", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AlHed()
        {
            var character = "Al Hed";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Al Hed", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Aladdin()
        {
            var character = "Aladdin";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aladdin", result!.Name);
            Assert.Equal(46, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(620, result.FirstAppearance);
            Assert.Equal(Crew.SunPiratesCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Alber()
        {
            var character = "Alber";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Alber", result!.Name);
            Assert.Equal(47, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(920, result.FirstAppearance);
            Assert.Equal(Crew.KaidoCrew, result.Crew);
            Assert.Equal("1,39 Md", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Albion()
        {
            var character = "Albion";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Albion", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Ally()
        {
            var character = "Ally";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ally", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Alpagaman()
        {
            var character = "Alpagaman";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Alpagaman", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Alpha()
        {
            var character = "Alpha";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Alpha", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Alvida()
        {
            var character = "Alvida";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Alvida", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(2, result.FirstAppearance);
            Assert.Equal(Crew.CrossGuild, result.Crew);
            Assert.Equal("5 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Amadob()
        {
            var character = "Amadob";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Amadob", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Amazon()
        {
            var character = "Amazon";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Amazon", result!.Name);
            Assert.Equal(79, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(238, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task An_Zengaiina()
        {
            var character = "An Zengaiina";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("An Zengaiina", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task And()
        {
            var character = "And";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("And", result!.Name);
            Assert.Equal(53, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(379, result.FirstAppearance);
            Assert.Equal(Crew.GouvernementMondial, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Andre()
        {
            var character = "Andre";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Andre", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Anjoh()
        {
            var character = "Anjoh";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Anjoh", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Ankoro()
        {
            var character = "Ankoro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ankoro", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Antonio()
        {
            var character = "Antonio";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Antonio", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Aphelandra()
        {
            var character = "Aphelandra";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aphelandra", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Aramaki()
        {
            var character = "Aramaki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aramaki / Ryokugyû", result!.Name);
            Assert.Equal(41, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(713, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task AremoGanmi()
        {
            var character = "Aremo Ganmi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aremo Ganmi", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Arlong()
        {
            var character = "Arlong";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Arlong", result!.Name);
            Assert.Equal(41, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(69, result.FirstAppearance);
            Assert.Equal(Crew.ArlongCrew, result.Crew);
            Assert.Equal("20 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Arrow()
        {
            var character = "Arrow";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Arrow", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Arthur()
        {
            var character = "Arthur";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Arthur", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AruyutayanV()
        {
            var character = "Aruyutayan V";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aruyutayan V", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Asahija()
        {
            var character = "Asahija";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Asahija", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Asashichi()
        {
            var character = "Asashichi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Asashichi", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AshuraDoji()
        {
            var character = "Ashura Doji";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ashura Doji", result!.Name);
            Assert.Equal(56, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(921, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Aswa()
        {
            var character = "Aswa";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Aswa", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Atagoyama()
        {
            var character = "Atagoyama";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Atagoyama", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Atlas()
        {
            var character = "Atlas";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Atlas", result!.Name);
            Assert.Equal(16, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(1062, result.FirstAppearance);
            Assert.Equal(Crew.GouvernementMondial, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Atmos()
        {
            var character = "Atmos";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Atmos", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Attach()
        {
            var character = "Attach";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Attach", result!.Name);
            Assert.Equal(29, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AvaloPizarro()
        {
            var character = "Avalo Pizarro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Avalo Pizarro", result!.Name);
            Assert.Equal(42, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(575, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal("100 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task AyeseMar()
        {
            var character = "Ayesé Mar";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ayesé Mar", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Azuki()
        {
            var character = "Azuki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Azuki", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(567, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }
    }
}

