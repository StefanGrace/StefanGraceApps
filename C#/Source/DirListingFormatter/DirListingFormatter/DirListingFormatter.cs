using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingFormatter
{
    class DirListingFormatter
    {
        public string[] FormatDirListings(string[] inputFileLines)
        {
            int outputFileLength = 1;
            foreach (string line in inputFileLines)
            {
                if (line.StartsWith("FILE"))
                {
                    outputFileLength++;
                }
            }

            string[] outputFilelines = new string[outputFileLength];

            outputFilelines[0] = "Folder path\tFilename without extention\tExtention\tDate modified\tSize in bytes";

            int index = 1;
            string currentFolder = "";
            foreach (string line in inputFileLines)
            {
                
                if (line.StartsWith("FOLDER"))
                {
                    currentFolder = SeperateTabs(line)[1];
                }
                else if (line.StartsWith("FILE"))
                {
                    string[] linesValues = SeperateTabs(line);
                    string[] filenameAndExtention = SeperateExtenion(linesValues[1]);

                    outputFilelines[index] = currentFolder + "\t" + filenameAndExtention[0] + "\t" 
                        + filenameAndExtention[1] + "\t" + linesValues[2] + "\t" + linesValues[3];

                    index++;
                }
            }
            return outputFilelines;
        }

        private string[] SeperateTabs(string stringWithTabs)
        {
            int outputLength = 1;
            foreach(char character in stringWithTabs)
            {
                if (character == '\t')
                {
                    outputLength++;
                }
            }

            string[] output = new string[outputLength];

            int index = 0;
            foreach (char character in stringWithTabs)
            {
                if (character == '\t')
                {
                    index++;
                }
                else
                {
                    output[index] += character;
                }                
            }

            return output;
        }

        private string[] SeperateExtenion(string filenameWithExtention)
        {
            string filename;
            string extenion;

            int indexOfDot = filenameWithExtention.LastIndexOf('.');

            if (indexOfDot > -1)
            {
                filename = filenameWithExtention.Substring(0, indexOfDot);
                extenion = filenameWithExtention.Substring(indexOfDot + 1).ToUpper();
            }
            else
            {
                filename = filenameWithExtention;
                extenion = "";
            }

            return new string[] { filename, extenion };
        }
    }
}
