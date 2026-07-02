using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TextCharAnalysis
{
    class TextAnalyser
    {
        public static Tuple<string, int>[] AnalyseText(string text)
        {
            int asciiChars = 0;
            int twoByteUTF8Chars = 0;
            int threeByteUTF8Chars = 0;
            int nonBmpChars = 0;

            int asciiNewLines = 0;
            int asciiTabs = 0;
            int asciiOtherCtrs = 0;
            int asciiSpaces = 0;
            int asciiUppercase = 0;
            int asciiLowercase = 0;
            int asciiNumbers = 0;
            int asciiSymbols = 0;
            int nonAsciiChars = 0;
            int totalLength = 0;

            foreach (char character in text)
            {
                if (character < 128)
                {
                    asciiChars++;
                }
                else if (character < 2048)
                {
                    twoByteUTF8Chars++;
                }
                else if (char.IsHighSurrogate(character))
                {
                    nonBmpChars++;
                }
                else
                {
                    threeByteUTF8Chars++;
                }

                if (character == '\n' || character == '\r')
                {
                    asciiNewLines++;
                }
                else if (character == '\t')
                {
                    asciiTabs++;
                }
                else if (character < 32 || character == 127)
                {
                    asciiOtherCtrs++;
                }
                else if (character == ' ')
                {
                    asciiSpaces++;
                }
                else if (character >= 'A' && character <= 'Z')
                {
                    asciiUppercase++;
                }
                else if (character >= 'a' && character <= 'z')
                {
                    asciiLowercase++;
                }
                else if (character >= '0' && character <= '9')
                {
                    asciiNumbers++;
                }
                else if (character < 127)
                {
                    asciiSymbols++;
                }
                else
                {
                    nonAsciiChars++;
                }

                if (!char.IsLowSurrogate(character))
                {
                    totalLength++;
                }

            }

            return new Tuple<string, int>[]
            {
                new Tuple<string, int>("ASCII", asciiChars),
                new Tuple<string, int>("2-byte UTF-8", twoByteUTF8Chars),
                new Tuple<string, int>("3-byte UTF-8", threeByteUTF8Chars),
                new Tuple<string, int>("Non-BMP", nonBmpChars),
                new Tuple<string, int>("", -1),
                new Tuple<string, int>("ASCII new line", asciiNewLines),
                new Tuple<string, int>("ASCII tab", asciiTabs),
                new Tuple<string, int>("ASCII other ctrl", asciiOtherCtrs),
                new Tuple<string, int>("ASCII space", asciiSpaces),
                new Tuple<string, int>("ASCII numbers", asciiNumbers),
                new Tuple<string, int>("ASCII uppercase", asciiUppercase),
                new Tuple<string, int>("ASCII lowercase", asciiLowercase),
                new Tuple<string, int>("ASCII symbol", asciiSymbols),
                new Tuple<string, int>("Non-ASCII", nonAsciiChars),
                new Tuple<string, int>("Total", totalLength),
            };
        }
    }
}
