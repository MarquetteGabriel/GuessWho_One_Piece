// <copyright file="AnswerCard.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model;
using Microsoft.AspNetCore.Components;

namespace GuessWhoOnePiece.UI.AnswerCard;

public partial class AnswerCard : ComponentBase
{
    [Parameter] public string? AnswerText { get; set; }
    [Parameter] public string? AnswerImage { get; set; }
    [Parameter] public AnswerState? AnswerState { get; set; }
    
    private string DefineColor()
    {
        if (!string.IsNullOrEmpty(AnswerImage) && string.IsNullOrEmpty(AnswerText))
            return "answer-no-answer";

        return AnswerState switch
        {
            Model.AnswerState.Correct => "answer-correct",
            Model.AnswerState.Wrong => "answer-wrong",
            Model.AnswerState.NotAnswered => "answer-not-answered",
            _ => "answer-no-answer"
        };
    }
}
