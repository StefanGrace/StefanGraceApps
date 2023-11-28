using System;

namespace DateFormatter
{
    class AmbiguousDateException : Exception
    {
        private string[] interpretations;

        public AmbiguousDateException(int[][] dateInterpretations, string[] formats, Formatter formatter)
        {
            string[] interpretations = new string[dateInterpretations.Length];
            for (int i = 0; i < dateInterpretations.Length; i++)
            {
                string year = dateInterpretations[i][0].ToString().PadLeft(4, '0');
                string month = formatter.Months[dateInterpretations[i][1]];
                string day = dateInterpretations[i][2] + formatter.Ordinal(dateInterpretations[i][2]);

                switch (formats[i])
                {
                    case "ymd": interpretations[i] = year + " " + month + " " + day; break;
                    case "dmy": interpretations[i] = day + " " + month + " " + year; break;
                    case "mdy": interpretations[i] = month + " " + day + " " + year; break;
                }
            }
            this.interpretations = interpretations;
        }

        public string[] Interpretations
        {
            get
            {
                return interpretations;
            }
        }
    }
}
