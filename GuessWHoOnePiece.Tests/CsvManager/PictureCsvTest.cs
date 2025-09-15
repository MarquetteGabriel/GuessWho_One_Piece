// <copyright file="PictureCsvTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.CsvManager;
using GuessWhoOnePiece.Model.DataEntries.Picture;
using HtmlAgilityPack;
using Moq;
using System.IO;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.Tests.CsvManager
{
    public class PictureCsvTest
    {
        private const string LocalPath = "C:\\Users\\Gabriel Marquette\\AppData\\Local\\Packages\\com.companyname.guesswhoonepiece_9zz4h110yvjzm\\LocalState\\";

        [Fact]
        public async Task Test_DownloadImage_Null()
        {
            var mockFileService = new Mock<IFileServiceReader>();
            mockFileService.Setup(pp => pp.GetPicturePath)
                           .Returns(LocalPath + "Images");
            var result = await PictureManager.DownloadImageAsync("Yosaku", "", mockFileService.Object);

            Assert.NotNull(result);
            Assert.Equal("Yosaku", result);
        }

        [Fact]
        public async Task Test_DownloadImage()
        {
            var mockFileService = new Mock<IFileServiceReader>();
            mockFileService.Setup(pp => pp.GetPicturePath)
                           .Returns(LocalPath + "Images");

            if (File.Exists(LocalPath + "Images/Yosaku.jpeg"))
                File.Delete(LocalPath + "Images/Yosaku.jpeg");

            var result = await PictureManager.DownloadImageAsync("https://static.wikia.nocookie.net/onepiece/images/1/1e/Yosaku_Manga_Post_Ellipse_Infobox.png/revision/latest?cb=20150809210655&path-prefix=fr", "Yosaku", mockFileService.Object);
            Assert.NotNull(result);
            Assert.Equal("Images/Yosaku.jpeg", result);

            result = await PictureManager.DownloadImageAsync("", "Yosaku", mockFileService.Object);
            Assert.NotNull(result);
            Assert.Equal("Images/Yosaku.jpeg", result);            
        }

        [Fact]
        public void Test_PictureData()
        {
            HtmlNodeCollection htmlNodes = new HtmlNodeCollection(new HtmlNode(HtmlNodeType.Text, new HtmlDocument(), 0));
            var result = PictureManager.GetPictureLink(htmlNodes);

            Assert.NotNull(result);
            Assert.Equal(string.Empty, result);
        }
    }
}
