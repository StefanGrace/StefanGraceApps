using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRT_to_TXT
{
    class Converter
    {
        public static string[] CreateTXT(string[] srt)
        {

            // Create a string array with the same length as the input
            string[] outputLines = new string[srt.Length];
            // Fill each element of the string array with an empty string
            for (int i = 0; i < outputLines.Length; i++)
            {
                outputLines[i] = "";
            }

            int currentIndex = -1;

            for (int i = 0; i < srt.Length; i++)
            {
                bool textLine = true;
                try
                {
                    textLine = !srt[i + 1].Contains(" --> ") && !srt[i + 2].Contains(" --> ");
                }
                catch { }

                if (srt[i].Contains(" --> "))
                {
                    currentIndex++;
                } 
                else if (textLine)
                {
                    outputLines[currentIndex] += srt[i];
                }
            }

            // Remove all empty string from the output array
            List<string> outputLinesList = outputLines.ToList();
            while (outputLinesList.Contains(""))
            {
                outputLinesList.Remove("");
            }
            outputLines = outputLinesList.ToArray();

            return outputLines;
        }
    }
}
