// <copyright file="Picture.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.Converts;
using Microsoft.AspNetCore.Components;
using Microsoft.Maui.Storage;
using System;
using System.IO;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.UI.Picture
{
    public partial class Picture : ComponentBase
    {
        [Parameter] public required string PicturePath { get; set; }

        private string? PathPicture;

        protected override async Task OnInitializedAsync()
        {
            if (string.IsNullOrEmpty(PicturePath))
                return;

            string base64string = string.Empty;

            try
            {
                if (PicturePath.Contains(".webp", StringComparison.Ordinal))
                {
                    var picturePath = PicturePath.Replace(" / ", " _ ", StringComparison.OrdinalIgnoreCase);
                    var filePath = Path.Combine(FileSystem.Current.AppDataDirectory, picturePath);
                    var fileBytes = await File.ReadAllBytesAsync(filePath);
                    base64string = Convert.ToBase64String(fileBytes);
                }
                else if (PicturePath.Contains(".svg", StringComparison.Ordinal))
                {
                    PathPicture = PictureStream.GetAssemblyName(PicturePath);
                    return;
                }
                else
                {
                    base64string = ConvertPictureToString(PicturePath);
                }
            }
            catch (Exception)
            {
                base64string = ConvertPictureToString("error.jpg");            
            }

            PathPicture = $"data:image/webp;base64, {base64string}";
        }

        private static string ConvertPictureToString(string picturePath)
        {
            var imageStream = PictureStream.GetImageStream(picturePath);
            using var memoryStream = new MemoryStream();
            imageStream!.CopyTo(memoryStream);
            return Convert.ToBase64String(memoryStream.ToArray());
        }
    }
}
