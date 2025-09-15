// <copyright file="Settings.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Components.Layout;
using GuessWhoOnePiece.Model;
using GuessWhoOnePiece.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Storage;
using System;

namespace GuessWhoOnePiece.Components.Pages
{
    public partial class Settings
    {
        private string UpdateDate = Preferences.Get("UpdateDate", DateTime.Now.ToShortDateString());
        private int Wins = Preferences.Get("Wins", 0);

        [CascadingParameter(Name = "MainLayout")] private MainLayout? MainLayout { get; set; }

        private void OnUpdateDatas()
        {
            Preferences.Set("Updated", false);
            Preferences.Set("UpdateDate", DateTime.Now.ToShortDateString());
            LoadingService.Loading = true;
            MainLayout!.TabBarRef.ChangeActiveState(IndexMenuTabBar.Game);
            Navigation.NavigateTo("/loading");
        }
    }
}
