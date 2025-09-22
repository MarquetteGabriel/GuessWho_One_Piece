// <copyright file="Routes.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using Microsoft.AspNetCore.Components;

namespace GuessWhoOnePiece.Components
{
    public partial class Routes
    {
        protected override void OnInitialized()
        {
            NavManager.NavigateTo("/loading");
        }
    }
}
