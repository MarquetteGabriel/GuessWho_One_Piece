﻿// <copyright file="CharacterInfo.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.CsvManager;
using Microsoft.AspNetCore.Components;

namespace GuessWhoOnePiece.Components.Pages;

public partial class CharacterInfo : ComponentBase
{
    [Parameter] public string CharacterName { get; set; }
    private Character Character {get; set; }

    protected override async Task OnParametersSetAsync()
    {
         Character = await ReceiveDataCsv.ReceiveCharacter(CharacterName);
         CharacterName = Character.Name;
    }
}
