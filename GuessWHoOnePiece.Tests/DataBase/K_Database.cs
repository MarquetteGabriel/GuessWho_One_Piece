// <copyright file="K_Database.cs">
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
    public class K_Database
    {
        private ControlRoom controlRoom;
        private const string Unknown = "Unknown";
        private const string LocalPath = "C:\\Users\\Gabriel Marquette\\AppData\\Local\\Packages\\com.companyname.guesswhoonepiece_9zz4h110yvjzm\\LocalState\\";
        Mock mockFileService = new Mock<IFileServiceReader>();
        public K_Database()
        {
            controlRoom = new ControlRoom();
        }

        [SkippableFact]
        public async Task Kabu()
        {
            var character = "Kabu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kabu", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kadar()
        {
            var character = "Kadar";
            var characterLink = ControlRoom.SetCharacterLink(character); 
            var mockFileService = new Mock<IFileServiceReader>(); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kadar", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kagero()
        {
            var character = "Kagero";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kagero", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kagikko()
        {
            var character = "Kagikko";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kagikko", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kaicho_Pinky()
        {
            var character = "Kaicho Pinky";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kaicho Pinky", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kaidou()
        {
            var character = "Kaidou";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kaidou", result!.Name);
            Assert.Equal(59, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(795, result.FirstAppearance);
            Assert.Equal(Crew.KaidoCrew, result.Crew);
            Assert.Equal("4,6111 Md", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kairen()
        {
            var character = "Kairen";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kairen", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kairiken()
        {
            var character = "Kairiken";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kairiken", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kairiki_Destroyers()
        {
            var character = "Kairiki Destroyers";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kairiki Destroyers", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kairo_Kureyo()
        {
            var character = "Kairo Kureyo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kairo Kureyo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kaku()
        {
            var character = "Kaku";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kaku", result!.Name);
            Assert.Equal(25, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(323, result.FirstAppearance);
            Assert.Equal(Crew.CipherPol, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Kakukaku()
        {
            var character = "Kakukaku";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kakukaku", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kakunoshin()
        {
            var character = "Kakunoshin";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kakunoshin", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kalgara()
        {
            var character = "Kalgara";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kalgara", result!.Name);
            Assert.Equal(39, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(286, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kalifa()
        {
            var character = "Kalifa";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kalifa", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(323, result.FirstAppearance);
            Assert.Equal(Crew.CipherPol, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Kamakiri()
        {
            var character = "Kamakiri";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kamakiri", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(249, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kamekichi()
        {
            var character = "Kamekichi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kamekichi", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kamijiro()
        {
            var character = "Kamijiro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kamijiro", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kaneshiro()
        {
            var character = "Kaneshiro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kaneshiro", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kanezenny()
        {
            var character = "Kanezenny";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kanezenny", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kangourou_Zèbre()
        {
            var character = "Kangourou-Zèbre";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kangourou-Zèbre", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kapoty()
        {
            var character = "Kapoty";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kapoty", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kappa()
        {
            var character = "Kappa";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kappa", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Karasu()
        {
            var character = "Karasu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Karasu", result!.Name);
            Assert.Equal(47, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(593, result.FirstAppearance);
            Assert.Equal(Crew.RevolutionaryArmy, result.Crew);
            Assert.Equal("400 Mi", result.Bounty);
            Assert.Equal("Revolutionary", result.Type);
        }

        [SkippableFact]
        public async Task Karma()
        {
            var character = "Karma";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Karma", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(553, result.FirstAppearance);
            Assert.Equal(Crew.NewgateCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Karoo()
        {
            var character = "Karoo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Karoo", result!.Name);
            Assert.Equal(16, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(109, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Karsee()
        {
            var character = "Karsee";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Karsee", result!.Name);
            Assert.Equal(156, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(377, result.FirstAppearance);
            Assert.Equal(Crew.GiantsCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kasa()
        {
            var character = "Kasa";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kasa", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kasagoba()
        {
            var character = "Kasagoba";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kasagoba", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kashigami()
        {
            var character = "Kashigami";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kashigami", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Katsuzo()
        {
            var character = "Katsuzo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Katsuzo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kawamatsu()
        {
            var character = "Kawamatsu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kawamatsu", result!.Name);
            Assert.Equal(41, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(921, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kaya()
        {
            var character = "Kaya";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kaya", result!.Name);
            Assert.Equal(19, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(23, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kazekage()
        {
            var character = "Kazekage";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kazekage", result!.Name);
            Assert.Equal(43, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(931, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kazenbo()
        {
            var character = "Kazenbo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kazenbo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kebi()
        {
            var character = "Kebi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kebi", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kechatch()
        {
            var character = "Kechatch";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kechatch", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Keith()
        {
            var character = "Keith";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Keith", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kelly_Funk()
        {
            var character = "Kelly Funk";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kelly Funk", result!.Name);
            Assert.Equal(36, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(704, result.FirstAppearance);
            Assert.Equal(Crew.Assassin, result.Crew);
            Assert.Equal("57 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kentarôs()
        {
            var character = "Kentarôs";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kentarôs", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kerville()
        {
            var character = "Kerville";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kerville", result!.Name);
            Assert.Equal(42, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(379, result.FirstAppearance);
            Assert.Equal(Crew.GouvernementMondial, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Kibagaeru()
        {
            var character = "Kibagaeru";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kibagaeru", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kibin()
        {
            var character = "Kibin";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kibin", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kief()
        {
            var character = "Kief";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kief", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kikipatsu()
        {
            var character = "Kikipatsu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kikipatsu", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kiku()
        {
            var character = "Kiku";
            var characterLink = ControlRoom.SetCharacterLink(character); 
            var mockFileService = new Mock<IFileServiceReader>(); 
            mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv");
            mockFileService.Setup(pp => pp.GetPicturePath).Returns(LocalPath + "Images");
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kiku / Kikunojo", result!.Name);
            Assert.Equal(22, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(913, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kikyo()
        {
            var character = "Kikyo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kikyo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Killer()
        {
            var character = "Killer";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Killer", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(498, result.FirstAppearance);
            Assert.Equal(Crew.KidCrew, result.Crew);
            Assert.Equal("200 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kimel()
        {
            var character = "Kimel";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kimel", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kinbo()
        {
            var character = "Kinbo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kinbo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kinderella()
        {
            var character = "Kinderella";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kinderella", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kinemon()
        {
            var character = "Kinemon";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kinemon", result!.Name);
            Assert.Equal(36, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(656, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task King_Baum()
        {
            var character = "King Baum";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("King Baum", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kinga()
        {
            var character = "Kinga";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kinga", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kingdew()
        {
            var character = "Kingdew";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kingdew", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kinoko()
        {
            var character = "Kinoko";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kinoko", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kirinkodanuki()
        {
            var character = "Kirinkodanuki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kirinkodanuki", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kirintauros()
        {
            var character = "Kirintauros";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kirintauros", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kisegawa()
        {
            var character = "Kisegawa";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kisegawa", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kitetsu()
        {
            var character = "Kitetsu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kitetsu", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kitton()
        {
            var character = "Kitton";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kitton", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kiwi()
        {
            var character = "Kiwi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kiwi", result!.Name);
            Assert.Equal(22, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(329, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Koala()
        {
            var character = "Koala";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Koala", result!.Name);
            Assert.Equal(23, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(622, result.FirstAppearance);
            Assert.Equal(Crew.RevolutionaryArmy, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Revolutionary", result.Type);
        }

        [SkippableFact]
        public async Task Kobee()
        {
            var character = "Kobee";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kobee", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Koby()
        {
            var character = "Koby";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Koby", result!.Name);
            Assert.Equal(18, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(2, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Koda()
        {
            var character = "Koda";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Koda", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Koito()
        {
            var character = "Koito";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Koito", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kojuro()
        {
            var character = "Kojuro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kojuro", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kokoro()
        {
            var character = "Kokoro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kokoro", result!.Name);
            Assert.Equal(72, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(322, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Komachiyo()
        {
            var character = "Komachiyo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Komachiyo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Komane()
        {
            var character = "Komane";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Komane", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kombu()
        {
            var character = "Kombu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kombu", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Komir()
        {
            var character = "Komir";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Komir", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kong()
        {
            var character = "Kong";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kong", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kop()
        {
            var character = "Kop";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kop", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kotatsu()
        {
            var character = "Kotatsu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kotatsu", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kotetsu()
        {
            var character = "Kotetsu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kotetsu", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kotori()
        {
            var character = "Kotori";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kotori", result!.Name);
            Assert.Equal(27, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(261, result.FirstAppearance);
            Assert.Equal(Crew.EnerCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kourbett()
        {
            var character = "Kourbett";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kourbett", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Koyama()
        {
            var character = "Koyama";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Koyama", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Koza()
        {
            var character = "Koza";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Koza", result!.Name);
            Assert.Equal(22, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(163, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Koze()
        {
            var character = "Koze";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Koze", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kozuki_Hiyori()
        {
            var character = "Kozuki Hiyori";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kozuki Hiyori", result!.Name);
            Assert.Equal(26, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(909, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kozuki_Momonosuke()
        {
            var character = "Kozuki Momonosuke";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kozuki Momonosuke", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(684, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kozuki_Oden()
        {
            var character = "Kozuki Oden";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kozuki Oden", result!.Name);
            Assert.Equal(39, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(920, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kozuki_Sukiyaki()
        {
            var character = "Kozuki Sukiyaki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Kozuki Sukiyaki", result!.Name);
            Assert.Equal(81, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(911, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kozuki_Toki()
        {
            var character = "Kozuki Toki";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kozuki Toki", result!.Name);
            Assert.Equal(36, result.Age);
            Assert.False(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(919, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Krap()
        {
            var character = "Krap";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Krap", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Krieg()
        {
            var character = "Krieg";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Krieg", result!.Name);
            Assert.Equal(44, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(45, result.FirstAppearance);
            Assert.Equal(Crew.DonKriegCrew, result.Crew);
            Assert.Equal("17 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kujaku()
        {
            var character = "Kujaku";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kujaku", result!.Name);
            Assert.Equal(26, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(966, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Kukai()
        {
            var character = "Kukai";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kukai", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kumacy()
        {
            var character = "Kumacy";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kumacy", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kumadori()
        {
            var character = "Kumadori";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kumadori", result!.Name);
            Assert.Equal(36, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(375, result.FirstAppearance);
            Assert.Equal(Crew.CipherPol, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task Kumadori_Yamanbako()
        {
            var character = "Kumadori Yamanbako";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kumadori Yamanbako", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kumaé()
        {
            var character = "Kumaé";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kumaé", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kumagoro()
        {
            var character = "Kumagoro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kumagoro", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kuni()
        {
            var character = "Kuni";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kuni", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kunyun()
        {
            var character = "Kunyun";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kunyun", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kureha()
        {
            var character = "Kureha";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kureha", result!.Name);
            Assert.Equal(141, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(134, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kuro()
        {
            var character = "Kuro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kuro", result!.Name);
            Assert.Equal(35, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(23, result.FirstAppearance);
            Assert.Equal(Crew.BlackCatCrew, result.Crew);
            Assert.Equal("16 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kurokoma()
        {
            var character = "Kurokoma";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurokoma", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kuromarimo()
        {
            var character = "Kuromarimo";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kuromarimo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(131, result.FirstAppearance);
            Assert.Equal(Crew.WapolCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kuroobi()
        {
            var character = "Kuroobi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kuroobi", result!.Name);
            Assert.Equal(38, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(69, result.FirstAppearance);
            Assert.Equal(Crew.ArlongCrew, result.Crew);
            Assert.Equal("9 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kurosawa()
        {
            var character = "Kurosawa";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurosawa", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kurotsuru()
        {
            var character = "Kurotsuru";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurotsuru", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kurozumi_Higurashi()
        {
            var character = "Kurozumi Higurashi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurozumi Higurashi", result!.Name);
            Assert.Equal(85, result.Age);
            Assert.False(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(965, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kurozumi_Kanjuro()
        {
            var character = "Kurozumi Kanjuro";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurozumi Kanjuro", result!.Name);
            Assert.Equal(34, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(700, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kurozumi_Orochi()
        {
            var character = "Kurozumi Orochi";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurozumi Orochi", result!.Name);
            Assert.Equal(54, result.Age);
            Assert.False(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(927, result.FirstAppearance);
            Assert.Equal(Crew.KaidoCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kurozumi_Semimaru()
        {
            var character = "Kurozumi Semimaru";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurozumi Semimaru", result!.Name);
            Assert.Equal(83, result.Age);
            Assert.False(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(965, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kurozumi_Tama()
        {
            var character = "Kurozumi Tama";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kurozumi Tama", result!.Name);
            Assert.Equal(8, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(911, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kuzan()
        {
            var character = "Kuzan";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kuzan", result!.Name);
            Assert.Equal(49, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(303, result.FirstAppearance);
            Assert.Equal(Crew.TeachCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kyros()
        {
            var character = "Kyros";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kyros", result!.Name);
            Assert.Equal(44, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(702, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kyuin()
        {
            var character = "Kyuin";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kyuin", result!.Name);
            Assert.Equal(20, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(755, result.FirstAppearance);
            Assert.Equal(Crew.DoflamingoCrew, result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task Kyuji()
        {
            var character = "Kyuji";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kyuji", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal(Crew.Citizen, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task Kyukyu()
        {
            var character = "Kyukyu";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);


            Skip.If(result == null, "Character not found");
            Assert.Equal("Kyukyu", result!.Name);
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
