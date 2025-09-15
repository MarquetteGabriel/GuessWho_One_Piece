// <copyright file="PictureStream.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System.IO;
using System.Reflection;

namespace GuessWhoOnePiece.Model.Converts
{
    public static class PictureStream
    {
        public static Stream? GetImageStream(string pictureName)
        {
            Assembly assembly = typeof(PictureStream).Assembly;
            var resourceName = $"{assembly.GetName().Name}.Resources.Images.{pictureName}";
            return assembly.GetManifestResourceStream(resourceName);
        }

        public static string GetAssemblyName(string pictureName)
        {
            Assembly assembly = typeof(PictureStream).Assembly;
            return $"{assembly.GetName().Name}.Resources.Images.{pictureName}";

        }
    }
}
