// <copyright file="LoadingService.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System;

namespace GuessWhoOnePiece.Services
{
    public class LoadingService
    {
        public event EventHandler? OnChange;
        private bool _loading;

        public bool Loading
        {
            get => _loading;
            set
            {
                if (_loading != value)
                {
                    _loading = value;
                    NotifyStateChanged();
                }
            }
        }

        private void NotifyStateChanged() => OnChange?.Invoke(this, EventArgs.Empty);
    }
}
