// <copyright file="PictureManager.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.CsvManager;
using SkiaSharp;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;


namespace GuessWhoOnePiece.Model.DataEntries.Picture
{
    /// <summary>Represents the retrieval of pictures.</summary>
    public static partial class PictureManager
    {
        private static readonly HttpClient _httpClient = new();

        /// <summary>Dowload picture to the folder.</summary>
        /// <param name="imageUrl">Link of the picture.</param>
        /// <param name="fileName">Name of the character which is used in the fileName.</param>
        /// <returns>The fileName.</returns>
        internal static async Task<string> DownloadImageAsync(string imageUrl, string fileName, IFileServiceReader fileServiceReader)
        {
            fileName = fileName.Replace("/", "_", StringComparison.OrdinalIgnoreCase) + ".webp";
            string picturePath = fileServiceReader.GetPicturePath;
            try
            {
                if (!Directory.Exists(picturePath))
                    Directory.CreateDirectory(picturePath);

                var outputFilePath = Path.Combine(picturePath, fileName);
                if (File.Exists(outputFilePath))
                    return @"Images/" + fileName;

                var imageData = await _httpClient.GetByteArrayAsync(imageUrl);

                using MemoryStream memoryStream = new(imageData);
                using var skBitmap = SKBitmap.Decode(memoryStream);
                using var image = SKImage.FromBitmap(skBitmap);
                using var data = image.Encode(SKEncodedImageFormat.Webp, 75);

                await File.WriteAllBytesAsync(outputFilePath, data.ToArray());

                return @"Images/" + fileName;
            }
            catch (Exception)
            {
                return imageUrl;
            }
        }
    }
}
