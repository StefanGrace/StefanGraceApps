using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateMonthTimestampsFromSrtDates
{

    class TimestampCreator
    {
        private readonly string[] monthNames = { "", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public string[] CreateMonthTimestamps(string[] SrtDates)
        {
            List<string> outputLines = new List<string>();
            string currentMonth = "";
            for (int i = 0; i < SrtDates.Length; i++)
            {
                if (SrtDates[i].Contains(" --> "))
                {
                    if (SrtDates[i + 1].Substring(5, 2) != currentMonth)
                    {
                        currentMonth = SrtDates[i + 1].Substring(5, 2);
                        outputLines.Add(SrtDates[i].Substring(3, 5) + " - " + monthNames[int.Parse(currentMonth)]);
                    }
                }
            }

            return outputLines.ToArray();
        }

    }
}
