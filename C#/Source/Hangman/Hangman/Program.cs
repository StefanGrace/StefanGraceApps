using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game("Test");

            while (game.GameState == 0)
            {
                Console.WriteLine(Seperate(game.GuessedWord));            
                Console.WriteLine("Incorrect letters: " + Seperate(game.IncorrectLetters));
                Console.WriteLine("Incorrect words: " + Seperate(game.IncorrectWords));

                Console.Write("Guess a letter or word: ");
                game.MakeGuess(Console.ReadLine());
            }

            if (game.GameState == 1)
            {
                Console.WriteLine("You Win");
            }
            else if (game.GameState == -1)
            {
                Console.WriteLine("You Loose");
            }

            Console.ReadLine();
        }

        static string Seperate(char[] letters)
        {
            string output = "";
            foreach (char letter in letters)
            {
                output += letter + " ";
            }
            return output;
        }

        static string Seperate(string[] words)
        {
            string output = "";
            foreach (string word in words)
            {
                output += word + " ";
            }
            return output;
        }
    }
}
