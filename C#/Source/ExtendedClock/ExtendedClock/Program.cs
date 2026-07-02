using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtendedClock
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            int format = 24;

            if (args.Length > 0)
            {
                try
                {
                    format = int.Parse(args[0]);
                    if (format != 6 && format != 12 && (format < 24 || format > 48))
                    {
                        format = 24;
                    }
                }
                catch { }
            }

            bool seconds = false;
            bool timeInTitle = false;

            if (args.Length > 1)
            {
                if (args[1].ToLower().Contains("s"))
                {
                    seconds = true;
                }
                if (args[1].ToLower().Contains("t"))
                {
                    timeInTitle = true;
                }
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(format, seconds, timeInTitle));
        }
    }
}
