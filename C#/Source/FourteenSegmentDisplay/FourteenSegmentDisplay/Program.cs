using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FourteenSegmentDisplay
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            string input = "";
            for (int i = 0; i < args.Length; i++)
            {
                input += args[i] + " ";
            }
            input = input.TrimEnd(' ');

            if (input.Length > 10)
            {
                input = input.Substring(0, 10);
            }
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(input));
        }
    }
}
