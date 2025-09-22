// <copyright file="Victory.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Components.Layout;
using GuessWhoOnePiece.Model;
using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Services;
using Microsoft.AspNetCore.Components;

namespace GuessWhoOnePiece.Components.Pages
{
    public partial class Victory : ComponentBase
    {
        private Character? Character { get; set; }
        [CascadingParameter(Name = "MainLayout")] private MainLayout? MainLayout { get; set; }

        protected override void OnInitialized()
        {
            Character = CurrentCharacterService.CurrentCharacter;
            StateHasChanged();
        }

        private void OnPlayAgain()
        {
            MainLayout!.TabBarRef.ChangeActiveState(IndexMenuTabBar.Game);
            Navigation.NavigateTo("/game");
        }
    }
}
