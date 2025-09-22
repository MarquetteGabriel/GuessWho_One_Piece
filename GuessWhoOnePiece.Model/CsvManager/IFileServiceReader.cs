// <copyright file="IFileServiceReader.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

namespace GuessWhoOnePiece.Model.CsvManager
{
    public interface IFileServiceReader
    {
        string GetCsvPath { get; }

        string GetPicturePath { get; }
    }
}
