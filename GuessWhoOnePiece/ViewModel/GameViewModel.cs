// <copyright file="GameViewModel.cs">
// Copyright (c) 2025 All Rights Reserved. 
// </copyright>
// <author>Gabriel Marquette</author>

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using GuessWhoOnePiece.Model;
using GuessWhoOnePiece.Model.Characters;
using GuessWhoOnePiece.Model.CsvManager;
using GuessWhoOnePiece.Model.Game;

namespace GuessWhoOnePiece.ViewModel
{
    /// <summary>View model for the game.</summary>
    public class GameViewModel : INotifyPropertyChanged
    {
        /// <summary>List of answers.</summary>
        internal readonly ObservableCollection<Character> AnswersList = new();

        /// <summary>Event for property changed.</summary>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>List of character names.</summary>
        internal List<string> CharacterNameList;

        /// <summary>Instance of SelectAnswer.</summary>
        private SelectAnswer? selectAnswer;

        /// <summary>Constructor.</summary>
        public GameViewModel(IFileServiceReader fileServiceReader)
        {
            CharacterNameList = new();
            _ = NewGame(fileServiceReader);
        }

        /// <summary>Set a new game.</summary>
        private async Task NewGame(IFileServiceReader fileServiceReader)
        {
            var characters = await ReceiveDataCsv.ReceiveAllCharacters(fileServiceReader);
            var _characterToFind = Guesser.SetCharacterToFind(characters);
            CharacterNameList.AddRange(characters.Select(character => character.Name));
            selectAnswer ??= new SelectAnswer(_characterToFind);
            AnswersList.Clear();
        }

        /// <summary>Check if the answer is correct or not.</summary>
        /// <param name="character">Character enter by the user.</param>
        public bool GetJudgmentDay(Character character)
        {
            character = selectAnswer!.SelectAnswerCharacter(character);
            AddAnswer(character);
            return character.AnswerStateList!.Name == AnswerState.Correct;
        }

        /// <summary>Add the character to the list.</summary>
        /// <param name="character">Character enter by the user.</param>
        public void AddAnswer(Character character)
        {
            AnswersList.Add(character);
            OnPropertyChanged();
        }

        /// <summary>Notify the change of the property.</summary>
        /// <param name="propertyName">Property changed.</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

