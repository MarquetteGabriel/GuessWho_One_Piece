// <copyright file="AppDelegate.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace GuessWhoOnePiece
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}
