// <copyright file="Home.razor.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using GuessWhoOnePiece.Model.CsvManager;
using System.Threading.Tasks;

namespace GuessWhoOnePiece.Components.Pages
{
    public partial class Home
    {
        private string _value = string.Empty;

        private void OnClickChargement()
        {
            CurrentCharacterService.CurrentCharacter = new Model.Characters.Character("Monkey D. Luffy", true, "3 Md", 1, "Pirate", true, 22, "Mugiwaras", "Images/Monkey D. Luffy.jpeg", 0);
            Navigation.NavigateTo("/victory");
        }

        public async Task OnShowCharacter()
        {
            var characters = await ReceiveDataCsv.ReceiveAllCharacters(FileServiceReader);
            foreach (var character in characters)
                {
                _value += character.Name + " ";
            }
        }
    }
}
