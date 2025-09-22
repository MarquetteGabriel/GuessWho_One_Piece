// <copyright file="TabBar.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model;
using Microsoft.AspNetCore.Components;

namespace GuessWhoOnePiece.Components.Layout;

public partial class TabBar : ComponentBase
{
    internal void ChangeActiveState(IndexMenuTabBar index)
    {
        IndexMenuService.IndexMenu = index;
        StateHasChanged();
    }
}
