// <copyright file="MainLayout.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using Microsoft.Maui.Storage;

namespace GuessWhoOnePiece.Components.Layout
{
    public partial class MainLayout
    {
        private TabBar tabBarRef;

        public TabBar TabBarRef
        {
            get => tabBarRef;
            set => tabBarRef = value;
        }

        protected override void OnInitialized()
        {
            if(Preferences.Get("Updated", false))
                LoadingService.Loading = false;
            else
                LoadingService.Loading = true;

            IndexMenuService.IndexMenu = Model.IndexMenuTabBar.Game;
        }
    }
}
