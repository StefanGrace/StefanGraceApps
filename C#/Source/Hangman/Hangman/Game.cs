using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Game
    {
        private string correctWord;
        private List<char> gueesedLetters = new List<char>();
        private List<string> incorrectWords = new List<string>();
        private int gameState = 0; // -1 = lost, 0 = ongoing, 1 = won

        private const int maxIncorrectGuesses = 6;

        public Game(string correctWord)
        {
            this.correctWord = correctWord.ToUpper();
        }

        public char[] IncorrectLetters
        {
            get
            {
                List<char> incorrectLetters = new List<char>();

                foreach (char letter in gueesedLetters)
                {
                    if (!correctWord.Contains(letter))
                    {
                        incorrectLetters.Add(letter);
                    }
                }

                return incorrectLetters.ToArray();
            }
        }

        public string[] IncorrectWords
        {
            get
            {
                return incorrectWords.ToArray();
            }
        }

        public int IncorrectGuesses
        {
            get
            {
                return IncorrectLetters.Length + IncorrectWords.Length;
            }
        }

        public int GameState
        {
            get
            {
                return gameState;
            }
        }


        public char[] GuessedWord
        {
            get
            {
                if (gameState == 1)
                {
                    return correctWord.ToCharArray();
                }

                List<char> guessedWord = new List<char>();

                foreach (char letter in correctWord)
                {
                    if (gueesedLetters.Contains(letter))
                    {
                        guessedWord.Add(letter);
                    }
                    else
                    {
                        guessedWord.Add('_');
                    }
                }

                return guessedWord.ToArray();
            }
        }


        public void MakeGuess(string guess)
        {
            if (guess.Length == 0)
            {
                throw new Exception();
            }
            if (guess.Length == 1)
            {
                if (!char.IsLetter(guess[0]))
                {
                    throw new Exception();
                }
                gueesedLetters.Add(guess.ToUpper()[0]);
                if (!GuessedWord.Contains('_'))
                {
                    gameState = 1;
                }
                else if (IncorrectGuesses > maxIncorrectGuesses)
                {
                    gameState = -1;
                }
            }
            else
            {
                if (guess.ToUpper() == correctWord)
                {
                    gameState = 1;
                }
                else
                {
                    incorrectWords.Add(guess.ToUpper());
                }
            }
        }
    }
}
