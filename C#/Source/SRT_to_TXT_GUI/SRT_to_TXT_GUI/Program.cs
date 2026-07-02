using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SRT_to_TXT_GUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            string inputFile;
            string outputFile;

            if (args.Length == 0)
            {
                inputFile = "";
                outputFile = "";
            }
            else if (args.Length == 1)
            {
                inputFile = args[0];

                if (args[0].ToLower().Contains(".srt"))
                {
                    outputFile = args[0].Replace("srt", "txt").Replace("SRT", "TXT");
                }
                else
                {
                    outputFile = args[0] + ".txt";
                }
            }
            else
            {
                inputFile = args[0];
                outputFile = args[1];
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(inputFile, outputFile));
        }
    }
}
