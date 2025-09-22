// <copyright file="CarouselAnswer.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using Microsoft.AspNetCore.Components;

namespace GuessWhoOnePiece.UI.CarouselAnswer;

public partial class CarouselAnswer : ComponentBase
{
    [Parameter] public Character? Character { get; set; }
}
