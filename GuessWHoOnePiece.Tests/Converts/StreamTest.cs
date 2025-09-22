// <copyright file="StreamTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Converts;
using System.IO;

namespace GuessWhoOnePiece.Tests.Converts
{
    public class StreamTest
    {
        [Fact]
        public void Test_GetImageStream()
        {
            var pictureName = "error.jpg";
            var result = PictureStream.GetImageStream(pictureName);

            Assert.NotNull(result);
        }

        [Fact]
        public void Test_GetImageStreamNamespace()
        {
            var pictureName = "error.jpg";
            var result = PictureStream.GetAssemblyName(pictureName);

            Assert.Equal("GuessWhoOnePiece.Model.Resources.Images.error.jpg", result);
        }
    }
}
