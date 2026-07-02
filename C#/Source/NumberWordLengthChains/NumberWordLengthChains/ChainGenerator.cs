using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberWordLengthChains
{
    class ChainGenerator
    {
        private Converter converter = new Converter();
        private bool excudeNonLetters;

        public Converter Converter { get => converter; }
        public bool ExcudeNonLetters { set => excudeNonLetters = value; }

        public string[] GenerateChain(string inputNumber)
        {
            inputNumber = inputNumber.TrimEnd(' ');

            string numberWord;
            try
            {
                numberWord = converter.NumberToWord(decimal.Parse(inputNumber));
            }
            catch
            {
                numberWord = inputNumber;
            }

            List<string> chain = new List<string>();

            chain.Add(numberWord);

            while (numberWord.ToLower() != "four")
            {
                int wordLength;
                if (excudeNonLetters)
                {
                    wordLength = 0;
                    foreach (char c in numberWord)
                    {
                        if (char.IsLetter(c))
                        {
                            wordLength++;
                        }
                    }
                }
                else
                {
                    wordLength = numberWord.Length;
                }

                numberWord = converter.NumberToWord(wordLength);
                chain.Add(numberWord);
            }

            return chain.ToArray();
        }
    }
}
