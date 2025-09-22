// <copyright file="DefinePicturesTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model;
using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.Game;
using GuessWhoOnePiece.Model.Resources;

namespace GuessWhoOnePiece.Tests.Game;

/// <summary>Test class "DefinePictures".</summary>
public class DefinePicturesTest
{
    #region SetAgePicture Tests

    /// <summary>Test SetAgePicture with Younger value.</summary>
    [Fact]
    public void Test_SetAgePicture_Younger()
    {
        var result = DefinePictures.SetAgePicture(AgeType.Younger);
        Assert.Equal(PicturesAlbum.ArrowUp, result);
    }

    /// <summary>Test SetAgePicture with Older value.</summary>
    [Fact]
    public void Test_SetAgePicture_Older()
    {
        var result = DefinePictures.SetAgePicture(AgeType.Older);
        Assert.Equal(PicturesAlbum.ArrowDown, result);
    }

    /// <summary>Test SetAgePicture with Equal value.</summary>
    [Fact]
    public void Test_SetAgePicture_Equal()
    {
        var result = DefinePictures.SetAgePicture(AgeType.Equal);
        Assert.Equal(string.Empty, result);
    }

    #endregion

    #region SetChapterPicture Tests

    /// <summary>Test SetChapterPicture with Previous value.</summary>
    [Fact]
    public void Test_SetChapterPicture_Previous()
    {
        var result = DefinePictures.SetChapterPicture(ChapterType.PreviousChapter);
        Assert.Equal(PicturesAlbum.ArrowDown, result);
    }

    /// <summary>Test SetChapterPicture with Newer value.</summary>
    [Fact]
    public void Test_SetChapterPicture_Newer()
    {
        var result = DefinePictures.SetChapterPicture(ChapterType.NewerChapter);
        Assert.Equal(PicturesAlbum.ArrowUp, result);
    }

    /// <summary>Test SetChapterPicture with Same value.</summary>
    [Fact]
    public void Test_SetChapterPicture_Same()
    {
        var result = DefinePictures.SetChapterPicture(ChapterType.SameChapter);
        Assert.Equal(string.Empty, result);
    }

    #endregion

    #region SetTypePicture Tests

    /// <summary>Test SetTypePicture with Pirate value.</summary>
    [Fact]
    public void Test_SetTypePicture_Pirate()
    {
        var result = DefinePictures.SetTypePicture("Pirate");
        Assert.Equal(PicturesAlbum.Pirates, result);
    }

    /// <summary>Test SetTypePicture with Revolutionary value.</summary>
    [Fact]
    public void Test_SetTypePicture_Revolutionary()
    {
        var result = DefinePictures.SetTypePicture("Revolutionary");
        Assert.Equal(PicturesAlbum.Revolutionary, result);
    }

    /// <summary>Test SetTypePicture with Navy value.</summary>
    [Fact]
    public void Test_SetTypePicture_Navy()
    {
        var result = DefinePictures.SetTypePicture("Navy");
        Assert.Equal(PicturesAlbum.Navy, result);
    }

    /// <summary>Test SetTypePicture with Citizen value.</summary>
    [Fact]
    public void Test_SetTypePicture_Citizen()
    {
        var result = DefinePictures.SetTypePicture("Citizen");
        Assert.Equal(PicturesAlbum.Citizen, result);
    }

    /// <summary>Test SetTypePicture with unknown value.</summary>
    [Fact]
    public void Test_SetTypePicture_Unknown()
    {
        var result = DefinePictures.SetTypePicture("Unknown");
        Assert.Equal(string.Empty, result);
    }

    #endregion

    #region SetBountyPicture Tests

    /// <summary>Test SetBountyPicture with Lower value.</summary>
    [Fact]
    public void Test_SetBountyPicture_Lower()
    {
        var result = DefinePictures.SetBountyPicture(BountyType.Lower);
        Assert.Equal(PicturesAlbum.ArrowDown, result);
    }

    /// <summary>Test SetBountyPicture with Upper value.</summary>
    [Fact]
    public void Test_SetBountyPicture_Upper()
    {
        var result = DefinePictures.SetBountyPicture(BountyType.Upper);
        Assert.Equal(PicturesAlbum.ArrowUp, result);
    }

    /// <summary>Test SetBountyPicture with Equal value.</summary>
    [Fact]
    public void Test_SetBountyPicture_Equal()
    {
        var result = DefinePictures.SetBountyPicture(BountyType.Equal);
        Assert.Equal(string.Empty, result);
    }

    /// <summary>Test SetBountyPicture with WrongUnknown value.</summary>
    [Fact]
    public void Test_SetBountyPicture_WrongUnknown()
    {
        var result = DefinePictures.SetBountyPicture(BountyType.WrongUnknown);
        Assert.Equal(string.Empty, result);
    }

    /// <summary>Test SetBountyPicture with unknown value.</summary>
    [Fact]
    public void Test_SetBountyPicture_Unknown()
    {
        var result = DefinePictures.SetBountyPicture((BountyType)999);
        Assert.Equal(string.Empty, result);
    }

    #endregion

    #region SetAlivePicture Tests

    /// <summary>Test SetAlivePicture with true value.</summary>
    [Fact]
    public void Test_SetAlivePicture_Alive()
    {
        var result = DefinePictures.SetAlivePicture(true);
        Assert.Equal(PicturesAlbum.Alive, result);
    }

    /// <summary>Test SetAlivePicture with false value.</summary>
    [Fact]
    public void Test_SetAlivePicture_NoAlive()
    {
        var result = DefinePictures.SetAlivePicture(false);
        Assert.Equal(PicturesAlbum.NoAlive, result);
    }

    #endregion

    #region SetDevilFruitPicture Tests

    /// <summary>Test SetDevilFruitPicture with true value.</summary>
    [Fact]
    public void Test_SetDevilFruitPicture_DevilFruit()
    {
        var result = DefinePictures.SetDevilFruitPicture(true);
        Assert.Equal(PicturesAlbum.DevilFruit, result);
    }

    /// <summary>Test SetDevilFruitPicture with false value.</summary>
    [Fact]
    public void Test_SetDevilFruitPicture_NoDevilFruit()
    {
        var result = DefinePictures.SetDevilFruitPicture(false);
        Assert.Equal(PicturesAlbum.NoDevilFruit, result);
    }

    #endregion

    #region SetCrewPictures Tests

    /// <summary>Test SetCrewPictures with Citizen value.</summary>
    [Fact]
    public void Test_SetCrewPictures_Citizen()
    {
        var result = DefinePictures.SetCrewPictures("Citizen");
        Assert.Equal(PicturesAlbum.CrewCitizen, result);
    }

    /// <summary>Test SetCrewPictures with Navy's Crew value.</summary>
    [Fact]
    public void Test_SetCrewPictures_NavyCrew()
    {
        var result = DefinePictures.SetCrewPictures(Crew.Navy);
        Assert.Equal(PicturesAlbum.CrewNavy, result);
    }

    /// <summary>Test SetCrewPictures with Clan d'Ener value.</summary>
    [Fact]
    public void Test_SetCrewPictures_ClanDEner()
    {
        var result = DefinePictures.SetCrewPictures(Crew.EnerCrew);
        Assert.Equal(PicturesAlbum.CrewEner, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage aux Cent Bêtes value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageAuxCentBetes()
    {
        var result = DefinePictures.SetCrewPictures(Crew.KaidoCrew);
        Assert.Equal(PicturesAlbum.CrewKaido, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Barbe Noire value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeBarbeNoire()
    {
        var result = DefinePictures.SetCrewPictures(Crew.TeachCrew);
        Assert.Equal(PicturesAlbum.CrewTeach, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Big Mom value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeBigMom()
    {
        var result = DefinePictures.SetCrewPictures(Crew.BigMomCrew);
        Assert.Equal(PicturesAlbum.CrewBigmom, result);
    }

    /// <summary>Test SetCrewPictures with Cross Guild value.</summary>
    [Fact]
    public void Test_SetCrewPictures_CrossGuild()
    {
        var result = DefinePictures.SetCrewPictures(Crew.CrossGuild);
        Assert.Equal(PicturesAlbum.CrossGuild, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Roux value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuRoux()
    {
        var result = DefinePictures.SetCrewPictures(Crew.ShanksCrew);
        Assert.Equal(PicturesAlbum.CrewShanks, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Barbe Blanche value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeBarbeBlanche()
    {
        var result = DefinePictures.SetCrewPictures(Crew.NewgateCrew);
        Assert.Equal(PicturesAlbum.CrewNewgate, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Chapeau de Paille value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuChapeauDePaille()
    {
        var result = DefinePictures.SetCrewPictures(Crew.MugiwaraCrew);
        Assert.Equal(PicturesAlbum.CrewMugiwara, result);
    }

    /// <summary>Test SetCrewPictures with Allié de L'Équipage du Chapeau de Paille value.</summary>
    [Fact]
    public void Test_SetCrewPictures_AllieDeLEquipageDuChapeauDePaille()
    {
        var result = DefinePictures.SetCrewPictures(Crew.MugiwaraAllies);
        Assert.Equal(PicturesAlbum.CrewMugiwara, result);
    }

    /// <summary>Test SetCrewPictures with Faux Équipage du Chapeau de Paille value.</summary>
    [Fact]
    public void Test_SetCrewPictures_FauxEquipageDuChapeauDePaille()
    {
        var result = DefinePictures.SetCrewPictures(Crew.FalseMugiwaraCrew);
        Assert.Equal(PicturesAlbum.CrewMugiwara, result);
    }

    /// <summary>Test SetCrewPictures with Revolutionary's Crew value.</summary>
    [Fact]
    public void Test_SetCrewPictures_RevolutionarysCrew()
    {
        var result = DefinePictures.SetCrewPictures("Revolutionary's Crew");
        Assert.Equal(PicturesAlbum.CrewRevolutionaryArmy, result);
    }

    /// <summary>Test SetCrewPictures with Gouvernement Mondial value.</summary>
    [Fact]
    public void Test_SetCrewPictures_GouvernementMondial()
    {
        var result = DefinePictures.SetCrewPictures(Crew.GouvernementMondial);
        Assert.Equal(PicturesAlbum.CrewWorldGov, result);
    }

    /// <summary>Test SetCrewPictures with Cipher Pol value.</summary>
    [Fact]
    public void Test_SetCrewPictures_CipherPol()
    {
        var result = DefinePictures.SetCrewPictures(Crew.CipherPol);
        Assert.Equal(PicturesAlbum.CrewWorldGov, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage d'Arlong value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDArlong()
    {
        var result = DefinePictures.SetCrewPictures(Crew.ArlongCrew);
        Assert.Equal(PicturesAlbum.CrewArlong, result);
    }

    /// <summary>Test SetCrewPictures with Baroque Works value.</summary>
    [Fact]
    public void Test_SetCrewPictures_BaroqueWorks()
    {
        var result = DefinePictures.SetCrewPictures(Crew.BaroqueWorks);
        Assert.Equal(PicturesAlbum.CrewBW, result);
    }

    /// <summary>Test SetCrewPictures with L'Armada Pirate de Don Krieg value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LArmadaPirateDeDonKrieg()
    {
        var result = DefinePictures.SetCrewPictures(Crew.DonKriegCrew);
        Assert.Equal(PicturesAlbum.CrewKrieg, result);
    }

    /// <summary>Test SetCrewPictures with Thriller Bark value.</summary>
    [Fact]
    public void Test_SetCrewPictures_ThrillerBark()
    {
        var result = DefinePictures.SetCrewPictures(Crew.ThrillerBark);
        Assert.Equal(PicturesAlbum.CrewMoria, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Heart value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuHeart()
    {
        var result = DefinePictures.SetCrewPictures(Crew.LawCrew);
        Assert.Equal(PicturesAlbum.CrewLaw, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Kid value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeKid()
    {
        var result = DefinePictures.SetCrewPictures(Crew.KidCrew);
        Assert.Equal(PicturesAlbum.CrewKidd, result);
    }

    /// <summary>Test SetCrewPictures with Kujas value.</summary>
    [Fact]
    public void Test_SetCrewPictures_Kujas()
    {
        var result = DefinePictures.SetCrewPictures(Crew.Kujas);
        Assert.Equal(PicturesAlbum.CrewKuja, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Caribou value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeCaribou()
    {
        var result = DefinePictures.SetCrewPictures(Crew.CaribouCrew);
        Assert.Equal(PicturesAlbum.CrewCaribou, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage des Pirates du Soleil value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDesPiratesDuSoleil()
    {
        var result = DefinePictures.SetCrewPictures(Crew.SunPiratesCrew);
        Assert.Equal(PicturesAlbum.CrewSunpirates, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage des Pirates Roger value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDesPiratesRoger()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage des Pirates Roger");
        Assert.Equal(PicturesAlbum.CrewRoger, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Don Quichotte Doflamingo value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeDonQuichotteDoflamingo()
    {
        var result = DefinePictures.SetCrewPictures(Crew.DoflamingoCrew);
        Assert.Equal(PicturesAlbum.CrewDoffy, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Rumbar value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuRumbar()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage du Rumbar");
        Assert.Equal(PicturesAlbum.CrewRumbar, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage des Nouveaux Hommes-Poissons value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDesNouveauxHommesPoissons()
    {
        var result = DefinePictures.SetCrewPictures(Crew.NewFishmenCrew);
        Assert.Equal(PicturesAlbum.CrewNewfish, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage des Géants value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDesGeants()
    {
        var result = DefinePictures.SetCrewPictures(Crew.GiantsCrew);
        Assert.Equal(PicturesAlbum.CrewGiants, result);
    }

    /// <summary>Test SetCrewPictures with Celestial Dragons value.</summary>
    [Fact]
    public void Test_SetCrewPictures_CelestialDragons()
    {
        var result = DefinePictures.SetCrewPictures(Crew.CelestialDragons);
        Assert.Equal(PicturesAlbum.CrewCelestial, result);
    }

    /// <summary>Test SetCrewPictures with Impel Down value.</summary>
    [Fact]
    public void Test_SetCrewPictures_ImpelDown()
    {
        var result = DefinePictures.SetCrewPictures(Crew.ImpelDown);
        Assert.Equal(PicturesAlbum.CrewID, result);
    }

    /// <summary>Test SetCrewPictures with Ligue des Primates value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LigueDesPrimates()
    {
        var result = DefinePictures.SetCrewPictures(Crew.PrimatesCrew);
        Assert.Equal(PicturesAlbum.CrewPrimates, result);
    }

    /// <summary>Test SetCrewPictures with Edward Weeble value.</summary>
    [Fact]
    public void Test_SetCrewPictures_EdwardWeeble()
    {
        var result = DefinePictures.SetCrewPictures(Crew.WeebleCrew);
        Assert.Equal(PicturesAlbum.CrewWeeble, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Chat Noir value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuChatNoir()
    {
        var result = DefinePictures.SetCrewPictures(Crew.BlackCatCrew);
        Assert.Equal(PicturesAlbum.CrewChatnoir, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Foxy value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeFoxy()
    {
        var result = DefinePictures.SetCrewPictures(Crew.FoxyCrew);
        Assert.Equal(PicturesAlbum.CrewFoxy, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Fire Tank value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuFireTank()
    {
        var result = DefinePictures.SetCrewPictures(Crew.BegeCrew);
        Assert.Equal(PicturesAlbum.CrewFiretank, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Bonney value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeBonney()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage de Bonney");
        Assert.Equal(PicturesAlbum.CrewBonney, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage des Moines Dépravés value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDesMoinesDepraves()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage des Moines Dépravés");
        Assert.Equal(PicturesAlbum.CrewUrouge, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de X. Barrels value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeXBarrels()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage de X. Barrels");
        Assert.Equal(PicturesAlbum.CrewXbarrels, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du On-Air value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuOnAir()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage du On-Air");
        Assert.Equal(PicturesAlbum.CrewApoo, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Hawkins value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeHawkins()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage de Hawkins");
        Assert.Equal(PicturesAlbum.CrewHawkins, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Lion d'Or value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuLionDOr()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage du Lion d'Or");
        Assert.Equal(PicturesAlbum.CrewShiki, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage du Rolling value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDuRolling()
    {
        var result = DefinePictures.SetCrewPictures(Crew.RollingCrew);
        Assert.Equal(PicturesAlbum.CrewDefault, result);
    }

    /// <summary>Test SetCrewPictures with Gang du Pays des Fleurs (Famille Chinjao) value.</summary>
    [Fact]
    public void Test_SetCrewPictures_GangDuPaysDesFleursFamilleChinjao()
    {
        var result = DefinePictures.SetCrewPictures("Gang du Pays des Fleurs (Famille Chinjao)");
        Assert.Equal(PicturesAlbum.CrewDefault, result);
    }

    /// <summary>Test SetCrewPictures with Bandit value.</summary>
    [Fact]
    public void Test_SetCrewPictures_Bandit()
    {
        var result = DefinePictures.SetCrewPictures("Bandit");
        Assert.Equal(PicturesAlbum.CrewDefault, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Bluejam value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeBluejam()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage de Bluejam");
        Assert.Equal(PicturesAlbum.CrewDefault, result);
    }

    /// <summary>Test SetCrewPictures with Bandits des montagnes value.</summary>
    [Fact]
    public void Test_SetCrewPictures_BanditsDesMontagnes()
    {
        var result = DefinePictures.SetCrewPictures(Crew.MountainBandit);
        Assert.Equal(PicturesAlbum.CrewDefault, result);
    }

    /// <summary>Test SetCrewPictures with L'Équipage de Wapol value.</summary>
    [Fact]
    public void Test_SetCrewPictures_LEquipageDeWapol()
    {
        var result = DefinePictures.SetCrewPictures("L'Équipage de Wapol");
        Assert.Equal(PicturesAlbum.CrewDefault, result);
    }

    /// <summary>Test SetCrewPictures with unknown value.</summary>
    [Fact]
    public void Test_SetCrewPictures_Unknown()
    {
        var result = DefinePictures.SetCrewPictures("Unknown");
        Assert.Equal(PicturesAlbum.CrewDefault, result);
    }

    #endregion

}
