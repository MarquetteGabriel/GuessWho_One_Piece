// <copyright file="X_Database.cs">
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
    public class X_Database
    {
        private ControlRoom controlRoom;
        private const string LocalPath = "C:\\Users\\Gabriel Marquette\\AppData\\Local\\Packages\\com.companyname.guesswhoonepiece_9zz4h110yvjzm\\LocalState\\";

        public X_Database()
        {
            controlRoom = new ControlRoom();
        }

        [SkippableFact]
        public async Task XDrake()
        {
            var character = "X Drake";
            var characterLink = ControlRoom.SetCharacterLink(character); var mockFileService = new Mock<IFileServiceReader>(); mockFileService.Setup(pp => pp.GetCsvPath).Returns(LocalPath + "Characters.csv"); 
            var result = await controlRoom.DataForCharacter(characterLink, character, mockFileService.Object);

            Skip.If(result == null, "Character not found");
            Assert.Equal("X Drake", result!.Name);
            Assert.Equal(33, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(498, result.FirstAppearance);
            Assert.Equal(Crew.Navy, result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }
    }
}
