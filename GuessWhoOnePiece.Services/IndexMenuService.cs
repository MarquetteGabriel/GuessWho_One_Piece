// <copyright file="IndexMenuService.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model;
using System;

namespace GuessWhoOnePiece.Services
{
    public class IndexMenuService
    {
        public event EventHandler? OnChange;
        private IndexMenuTabBar _index;

        public IndexMenuTabBar IndexMenu
        {
            get => _index;
            set
            {
                if (_index != value)
                {
                    _index = value;
                    NotifyStateChanged();
                }
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke(this, EventArgs.Empty);

    }
}
