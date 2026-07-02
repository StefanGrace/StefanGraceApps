using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NumberWordLengthChainLengthGenerator
{
    class ChainLengthGenerator
    {
        private Converter converter = new Converter();

        public void GenerateChainLengths(long startNumber, long endNumber)
        {
            //File.WriteAllText("NumberWordChainLengths.csv", "");

            for (long i = startNumber; i <= endNumber; i++)
            {
                File.AppendAllText("NumberWordChainLengths.csv", i.ToString() + ", " + GetChainLength(i).ToString() + "\r\n");
            }
        }

        private int GetChainLength(long inputNumber)
        {
            string numberWord = converter.NumberToWord(inputNumber);

            int chainLength = 1;

            while (numberWord != "four")
            {
                numberWord = converter.NumberToWord(numberWord.Length);
                chainLength++;
            }

            return chainLength;
        }
    }
}
