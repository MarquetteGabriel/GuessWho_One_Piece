// <copyright file="FileServiceReader.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using Microsoft.Maui.Storage;
using System.IO;

namespace GuessWhoOnePiece.Model.CsvManager
{
    public class FileServiceReader : IFileServiceReader
    {
        public string GetCsvPath { get; } = Path.Combine(FileSystem.Current.AppDataDirectory, "Characters.csv");

        public string GetPicturePath { get; } = Path.Combine(FileSystem.Current.AppDataDirectory, "Images");
    }
}
