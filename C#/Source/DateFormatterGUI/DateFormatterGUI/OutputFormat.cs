namespace DateFormatter
{
    public class OutputFormat
    {
        private int dateOrder = 0;
        private int yearFormat = 0;
        private int monthFormat = 0;
        private int dayFormat = 0;
        private int separator = 0;
        private bool commaAfterDay = false;

        private const string file = "OutputFormat.txt";

        public void SetFormat(int dateOrder, int yearFormat, int monthFormat, int dayFormat, int separator, bool commaAfterDay)
        {
            this.dateOrder = dateOrder;
            this.yearFormat = yearFormat;
            this.monthFormat = monthFormat;
            this.dayFormat = dayFormat;
            this.separator = separator;
            this.commaAfterDay = commaAfterDay;
        }

        public void Load()
        {
            string[] lines = System.IO.File.ReadAllLines(file);
            int[] intLines = new int[lines.Length];
            int[] maxValues = { 3, 2, 4, 3, 6, 2 };
            for (int i = 0; i < lines.Length; i++)
            {
                intLines[i] = int.Parse(lines[i]);
                if (intLines[i] < 1 || intLines[i] > maxValues[i])
                {
                    throw new ChoiceOutOfRangeException(intLines[i]);
                }
            }
            dateOrder = intLines[0];
            yearFormat = intLines[1];
            monthFormat = intLines[2];
            dayFormat = intLines[3];
            separator = intLines[4];
            commaAfterDay = intLines[5] == 1;
        }

        public string Save()
        {
            try
            {
                int commaAfterDay;
                if (this.commaAfterDay)
                {
                    commaAfterDay = 1;
                }
                else
                {
                    commaAfterDay = 2;
                }

                System.IO.File.WriteAllLines(file, new string[] {
                dateOrder.ToString(),
                yearFormat.ToString(),
                monthFormat.ToString(),
                dayFormat.ToString(),
                separator.ToString(),
                commaAfterDay.ToString()
            });
                return "Output format saved to successfully to \"" + file + "\"";
            }
            catch
            {
                return "Unable to save output format to \"" + file + "\"";
            }
        }

        public string Delete()
        {
            try
            {
                if (System.IO.File.Exists(file))
                {
                    System.IO.File.Delete(file);
                    return file + " deleted successfully";
                }
                else
                {
                    return file + " does not exist";
                }
            }
            catch
            {
                return "Unable to delete \"" + file + "\"";
            }
        }


        // Properies

        public int DateOrder
        {
            get
            {
                return dateOrder;
            }
        }

        public int YearFormat
        {
            get
            {
                return yearFormat;
            }
        }

        public int MonthFormat
        {
            get
            {
                return monthFormat;
            }
        }

        public int DayFormat
        {
            get
            {
                return dayFormat;
            }
        }


        public string Separator
        {
            get
            {
                switch (separator)
                {
                    case 1: return "/";
                    case 2: return ".";
                    case 3: return "-";
                    case 4: return " ";
                    case 5: return "_";
                    case 6: return "";
                    default: return "";
                }
            }
        }

        public int SeparatorIndex
        {
            get
            {
                return separator;
            }
        }


        public bool CommaAfterDay
        {
            get
            {
                return commaAfterDay;
            }
        }

        public string FileName
        {
            get
            {
                return file;
            }
        }
    }
}
