// <copyright file="SplashScreen.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System.Threading.Tasks;
using GuessWhoOnePiece.Model.DataEntries;
using GuessWhoOnePiece.Services;
using Microsoft.Maui.Storage;
using GuessWhoOnePiece.Model.CsvManager;

namespace GuessWhoOnePiece.Components.Layout
{
    public partial class SplashScreen
    {
        private int ProgressValue;
        private const int MAX_PROGRESS = 100;

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (!firstRender)
                return;

            StartLoadingBar();
        }

        protected override Task OnInitializedAsync()
        {
            if(!Preferences.Get("Updated", false))
            {
                LoadingService.Loading = true;
            }
            else
            {
                LoadingService.Loading = false;
                Navigation.NavigateTo("/game");
            }

            return base.OnInitializedAsync();
        }
        
        private void StartLoadingBar()
        {
            if (!Preferences.Get("Updated", false))
            {
                ProgressValue = 0;
                var controlRoom = new ControlRoom();

                Task.Run(async () =>
                {
                    var threadsTask = controlRoom.GenerateThreads(FileServiceReader);
                    while (ProgressValue < MAX_PROGRESS)
                    {
                        ProgressValue = controlRoom.Percentage;
                        if (ProgressValue > MAX_PROGRESS)
                            ProgressValue = MAX_PROGRESS;

                        await InvokeAsync(() => StateHasChanged());

                        if (threadsTask.IsCompleted)
                        {
                            ProgressValue = MAX_PROGRESS;
                        }   
                    }
                    var characterList = threadsTask.Result;
                    ManageCsv.SaveCharactersToCsv(characterList, FileServiceReader);
                    Preferences.Set("Updated", true);
                    LoadingService.Loading = false;
                    controlRoom = null;
                    Navigation.NavigateTo("/game");
                });
            }
        }
    }
}
