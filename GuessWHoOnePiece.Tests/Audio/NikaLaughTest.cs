// <copyright file="NikaLaughTest.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Audio;

namespace GuessWhoOnePiece.Tests.Audio
{
    public class NikaLaughTest
    {

        [Fact]
        public void Test_PlayLaugh()
        {

            var nikaLaugh = new NikaLaugh();

            nikaLaugh.PlayLaugh();

            Assert.True(true);
        }
    }
}
