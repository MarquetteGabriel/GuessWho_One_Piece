﻿using GuessWhoOnePiece.Model.DataEntries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.Tests.DataBase
{
    public class D_Database
    {

        private ControlRoom controlRoom;
        private const string Unknown = "Unknown";
        public D_Database()
        {
            controlRoom = new ControlRoom();
        }

        [SkippableFact]
        public async Task D_Dachoman()
        {
            var character = "Dachoman";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dachoman", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daddy_Dee()
        {
            var character = "Daddy Dee";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daddy Dee", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dagama()
        {
            var character = "Dagama";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dagama", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daidalos()
        {
            var character = "Daidalos";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daidalos", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daifugo()
        {
            var character = "Daifugo";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daifugo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daigin()
        {
            var character = "Daigin";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daigin", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daikoku()
        {
            var character = "Daikoku";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daikoku", result!.Name);
            Assert.Equal(42, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(931, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daikon()
        {
            var character = "Daikon";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daikon", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daisy()
        {
            var character = "Daisy";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daisy", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dalmatian()
        {
            var character = "Dalmatian";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dalmatian", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dalton()
        {
            var character = "Dalton";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dalton", result!.Name);
            Assert.Equal(35, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(132, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Damask()
        {
            var character = "Damask";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Damask", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dame_Arbre()
        {
            var character = "Dame Arbre";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dame Arbre", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daruma()
        {
            var character = "Daruma";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daruma", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(611, result.FirstAppearance);
            Assert.Equal("L'Équipage des Nouveaux Hommes-Poissons", result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Davy_Jones()
        {
            var character = "Davy Jones";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Davy Jones", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Daz_Bones()
        {
            var character = "Daz Bones";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Daz Bones / Mr. 1", result!.Name);
            Assert.Equal(31, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(160, result.FirstAppearance);
            Assert.Equal("Cross Guild", result.Crew);
            Assert.Equal("75 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Delacuaji()
        {
            var character = "Delacuaji";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Delacuaji", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dellinger()
        {
            var character = "Dellinger";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dellinger", result!.Name);
            Assert.Equal(16, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(702, result.FirstAppearance);
            Assert.Equal("L'Équipage de Don Quichotte Doflamingo", result.Crew);
            Assert.Equal("15 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Demalo_Black()
        {
            var character = "Demalo Black";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Demalo Black", result!.Name);
            Assert.Equal(36, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(598, result.FirstAppearance);
            Assert.Equal("Faux Équipage du Chapeau de Paille", result.Crew);
            Assert.Equal("26 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Den()
        {
            var character = "Den";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Den", result!.Name);
            Assert.Equal(62, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(616, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Denjiro()
        {
            var character = "Denjiro";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Denjiro", result!.Name);
            Assert.Equal(47, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(919, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Devil_Dias()
        {
            var character = "Devil Dias";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Devil Dias", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Diamante()
        {
            var character = "Diamante";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Diamante", result!.Name);
            Assert.Equal(45, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(700, result.FirstAppearance);
            Assert.Equal("L'Équipage de Don Quichotte Doflamingo", result.Crew);
            Assert.Equal("99 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Didit()
        {
            var character = "Didit";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Didit", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Diesel()
        {
            var character = "Diesel";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Diesel", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Diez_Barrels()
        {
            var character = "Diez Barrels";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Diez Barrels", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Disc_J()
        {
            var character = "Disc J";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Disc J", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Disco()
        {
            var character = "Disco";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Disco", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dive()
        {
            var character = "Dive";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dive", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dobby_Ibadonbo()
        {
            var character = "Dobby Ibadonbo";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dobby Ibadonbo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Doberman()
        {
            var character = "Doberman";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Doberman", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dobon()
        {
            var character = "Dobon";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dobon", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Doc_Q()
        {
            var character = "Doc Q";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Doc Q", result!.Name);
            Assert.Equal(28, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(223, result.FirstAppearance);
            Assert.Equal("L'Équipage de Barbe Noire", result.Crew);
            Assert.Equal("72 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Dogra()
        {
            var character = "Dogra";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dogra", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dogya()
        {
            var character = "Dogya";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dogya", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Doha_Ittanka_II()
        {
            var character = "Doha Ittanka II";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Doha Ittanka II", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Doll()
        {
            var character = "Doll";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Doll", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Doma()
        {
            var character = "Doma";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Doma", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Domino()
        {
            var character = "Domino";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Domino", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Domo_kun()
        {
            var character = "Domo-kun";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Domo-kun", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Don_Quichotte_Doflamingo()
        {
            var character = "Don Quichotte Doflamingo";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Don Quichotte Doflamingo", result!.Name);
            Assert.Equal(41, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(233, result.FirstAppearance);
            Assert.Equal("L'Équipage de Don Quichotte Doflamingo", result.Crew);
            Assert.Equal("340 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Don_Quichotte_Homing()
        {
            var character = "Don Quichotte Homing";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Don Quichotte Homing", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Don_Quichotte_Mjosgard()
        {
            var character = "Don Quichotte Mjosgard";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Don Quichotte Mjosgard", result!.Name);
            Assert.Equal(35, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(625, result.FirstAppearance);
            Assert.Equal("Celestial Dragons", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Navy", result.Type);
        }

        [SkippableFact]
        public async Task D_Don_Quichotte_Rossinante()
        {
            var character = "Don Quichotte Rossinante";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Don Quichotte Rossinante", result!.Name);
            Assert.Equal(26, result.Age);
            Assert.False(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(749, result.FirstAppearance);
            Assert.Equal("L'Équipage de Don Quichotte Doflamingo", result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Donannoyo()
        {
            var character = "Donannoyo";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Donannoyo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Donovan()
        {
            var character = "Donovan";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Donovan", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Donquino()
        {
            var character = "Donquino";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Donquino", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Doran()
        {
            var character = "Doran";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Doran", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Doringo()
        {
            var character = "Doringo";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Doringo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dorry()
        {
            var character = "Dorry";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dorry", result!.Name);
            Assert.Equal(160, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(116, result.FirstAppearance);
            Assert.Equal("L'Équipage des Géants", result.Crew);
            Assert.Equal("1,8 Md", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Dosun()
        {
            var character = "Dosun";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dosun", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(611, result.FirstAppearance);
            Assert.Equal("L'Équipage des Nouveaux Hommes-Poissons", result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Dotaku()
        {
            var character = "Dotaku";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dotaku", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Dracule_Mihawk()
        {
            var character = "Dracule Mihawk";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dracule Mihawk", result!.Name);
            Assert.Equal(43, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(50, result.FirstAppearance);
            Assert.Equal("Cross Guild", result.Crew);
            Assert.Equal("3,59 Md", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Dragon_Numéro_Treize()
        {
            var character = "Dragon Numéro Treize";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Dragon Numéro Treize", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Draw()
        {
            var character = "Draw";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Draw", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Drip()
        {
            var character = "Drip";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Drip", result!.Name);
            Assert.Equal(24, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(598, result.FirstAppearance);
            Assert.Equal("Faux Équipage du Chapeau de Paille", result.Crew);
            Assert.Equal(Unknown, result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Drophy()
        {
            var character = "Drophy";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Drophy / Miss Merry Christmas", result!.Name);
            Assert.Equal(51, result.Age);
            Assert.True(result.Alive);
            Assert.True(result.DevilFruit);
            Assert.Equal(160, result.FirstAppearance);
            Assert.Equal("Baroque Works", result.Crew);
            Assert.Equal("14 Mi", result.Bounty);
            Assert.Equal("Pirate", result.Type);
        }

        [SkippableFact]
        public async Task D_Drug_Peclo()
        {
            var character = "Drug Peclo";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Drug Peclo", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Du_Feld()
        {
            var character = "Du Feld";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Du Feld", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Ducky_Bree()
        {
            var character = "Ducky Bree";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Ducky Bree", result!.Name);
            Assert.Equal(30, result.Age);
            Assert.False(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(77, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

        [SkippableFact]
        public async Task D_Duval()
        {
            var character = "Duval";
            var characterLink = ControlRoom.SetCharacterLink(character);
            var result = await controlRoom.DataForCharacter(characterLink, character);

            Skip.If(result == null, "Character not found");
            Assert.Equal("Duval", result!.Name);
            Assert.Equal(25, result.Age);
            Assert.True(result.Alive);
            Assert.False(result.DevilFruit);
            Assert.Equal(491, result.FirstAppearance);
            Assert.Equal("Citizen", result.Crew);
            Assert.Equal("0", result.Bounty);
            Assert.Equal("Citizen", result.Type);
        }

    }
}
