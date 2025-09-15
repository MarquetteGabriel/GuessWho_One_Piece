// <copyright file="CurrentCharacterService.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Characters;
using System;

namespace GuessWhoOnePiece.Services
{
    public class CurrentCharacterService
    {
        public event EventHandler? OnChange;
        private Character? _currentCharacter;

        public Character? CurrentCharacter
        {
            get => _currentCharacter;
            set
            {
                if (_currentCharacter != value)
                {
                    _currentCharacter = value;
                    NotifyStateChanged();
                }
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke(this, EventArgs.Empty);

    }
}
