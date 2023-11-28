using System;

namespace DateFormatter
{
    class Formatter
    {
        private int dateOrder; // 1 = YMD, 2 = DMY, 3 = MDY
        private int yearFormat; // 1 = 2-digit, 2 = 4-digit
        private int monthFormat; // 1 = non-zero-padded number, 2 = zero-padded number, 3 = 3-letter word, 4 = full word
        private int dayFormat; // 1 = non-zero-padded number, 2 = zero-padded number, 3 = ordinal
        private string separator ;
        private bool commaAfterDay;

        private string[] months = { "", "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public void SetFormat(int dateOrder, int yearFormat, int monthFormat, int dayFormat, string separator, bool commaAfterDay)
        {
            this.dateOrder = dateOrder;
            this.yearFormat = yearFormat;
            this.monthFormat = monthFormat;
            this.dayFormat = dayFormat;
            this.separator  = separator;
            this.commaAfterDay = commaAfterDay;
        }

        public string FormatDate(int year, int month, int day)
        {
            // If any of the date elements are outside of the valid range, throw an exception
            if (year < 1 || year > 9999 || month < 1 || month > 12 || day < 1 || day > DateTime.DaysInMonth(year, month))
            {
                throw new InvalidDateElementException();
            }

            // Generate year text
            string yearText = year.ToString().PadLeft(4, '0');
            if (yearFormat == 1)
            {
                yearText = yearText.Substring(2);
            }

            // Generate month text
            string monthText = "";
            
            switch (monthFormat)
            {
                case 1:
                    monthText = month.ToString();
                    break;
                case 2:
                    monthText = month.ToString().PadLeft(2, '0');
                    break;
                case 3:
                    monthText = months[month].Substring(0, 3);
                    break;
                case 4:
                    monthText = months[month];
                    break;
            }

            // Generate day text
            string dayText = day.ToString();
            if (dayFormat == 2)
            {
                dayText = dayText.PadLeft(2, '0');
            }
            else if (dayFormat == 3)
            {
                dayText += Ordinal(day);
            }

            // Add comma after the day if the date order is MDY, the month is worded, and seperator is ethier nothing or space
            if (commaAfterDay)
            {
                if (dateOrder == 3)
                {
                    if (monthFormat >= 3 && (separator  == "" || separator  == " "))
                    {
                        dayText += ",";
                    }
                }
            }

            // Assemble the elements to form the date
            string formattedDate = "";
            switch (dateOrder)
            {
                case 1:
                    formattedDate = yearText + separator  + monthText + separator  + dayText;
                    break;
                case 2:
                    formattedDate = dayText + separator  + monthText + separator  + yearText;
                    break;
                case 3:
                    formattedDate = monthText + separator  + dayText + separator  + yearText;
                    break;
                default:
                    formattedDate = "Output date format has not been set";
                    break;
            }

            // Return formatted date
            return formattedDate;
        }

        public string FormatDate(string date)
        {
            int[] dateElements = InterpretDate(date);
            return FormatDate(dateElements[0], dateElements[1], dateElements[2]);
        }

        public int[] InterpretDate(string date)
        {
            string originalDate = date;

            // Replace slashes, dots, spaces, and underscores with hyphens
            date = date.Replace('/', '-').Replace('.', '-').Replace(' ', '-').Replace('_', '-');

            // Replace full month names with 3-letter ones
            date = date.ToLower();
            for (int i = 1; i < months.Length; i++)
            {
                date = date.Replace(months[i].ToLower(), months[i].Substring(0, 3).ToLower());
            }

            // Remove ordinals and commas
            date = date.Replace("st", "").Replace("nd", "").Replace("rd", "").Replace("th", "").Replace(",", "");

            // Seperate each element
            int element1Length = 0;
            for (int i = 0; i < date.Length; i++)
            {
                if (date[i] == '-')
                {
                    element1Length = i;
                    i = date.Length;
                }
            }
            int element2Length = 0;
            for (int i = element1Length + 1; i < date.Length; i++)
            {
                if (date[i] == '-')
                {
                    element2Length = (i - element1Length) - 1;
                    i = date.Length;
                }
            }
            int element3Length = (date.Length - 2) - (element1Length + element2Length);

            if (element1Length == 0 || element2Length == 0 || element3Length == 0)
            {
                throw new InvalidDateException(originalDate);
            }

            string element1 = date.Substring(0, element1Length);
            string element2 = date.Substring(element1Length + 1, element2Length);
            string element3 = date.Substring(element1Length + element2Length + 2, element3Length);

            // Try to interpet the date in YMD, DMY, and MDY
            int[] ymd = new int[] { -1, -1,- 1 };
            int[] dmy = new int[] { -1, -1, -1 };
            int[] mdy = new int[] { -1, -1, -1 };
            int validInterpretations = 0;
            bool ambiguousYear = false;
            try
            {
                bool yearAmbiguous = false;
                int yearInt = InterpretYear(element1, ref yearAmbiguous);
                int monthInt = InterpretMonth(element2);
                int dayInt = InterpretDay(element3, yearInt, monthInt);
                ymd = new int[] { yearInt, monthInt, dayInt };
                if (yearAmbiguous)
                {
                    validInterpretations += 2;
                    ambiguousYear = true;
                }
                validInterpretations++;
                
            }
            catch (InvalidDateElementException) { }
            try
            {
                bool yearAmbiguous = false;
                int yearInt = InterpretYear(element3, ref yearAmbiguous);
                int monthInt = InterpretMonth(element2);
                int dayInt = InterpretDay(element1, yearInt, monthInt);
                int[] dmy_ = new int[] { yearInt, monthInt, dayInt };
                // If the DMY interpretation is the same as the YMD interpretation, don't include it as another valid interpretation
                if (dmy_[0] != ymd[0] || dmy_[1] != ymd[1] || dmy_[2] != ymd[2])
                {
                    dmy = dmy_;
                    if (yearAmbiguous)
                    {
                        validInterpretations += 2;
                        ambiguousYear = true;
                    }
                    validInterpretations++;
                }
            }
            catch (InvalidDateElementException) { }
            try
            {
                bool yearAmbiguous = false;
                int yearInt = InterpretYear(element3, ref yearAmbiguous);
                int monthInt = InterpretMonth(element1);
                int dayInt = InterpretDay(element2, yearInt, monthInt);
                int[] mdy_ = new int[] { yearInt, monthInt, dayInt };
                // If the MDY interpretation is the same as the YMD or DMY interpretation, don't include it as another valid interpretation
                if ((mdy_[0] != dmy[0] || mdy_[1] != dmy[1] || mdy_[2] != dmy[2]) && (mdy_[0] != ymd[0] || mdy_[1] != ymd[1] || mdy_[2] != ymd[2]))
                {
                    mdy = mdy_;
                    if (yearAmbiguous)
                    {
                        validInterpretations += 2;
                        ambiguousYear = true;
                    }
                    validInterpretations++;
                }
            }
            catch (InvalidDateElementException) { }

            /* If none of the interpretations are valid, throw an InvalidDateException,
            If one of the interpretations is valid, return it
            If multiple interpretations are valid, throw an AmbiguousDateException */
            switch (validInterpretations)
            {
                case 0:
                    throw new InvalidDateException(originalDate);

                case 1:
                    int[] dateElements;
                    if (ymd[0] != -1)
                    {
                        dateElements = ymd;
                    }
                    else if (dmy[0] != -1)
                    {
                        dateElements = dmy;
                    }
                    else
                    {
                        dateElements = mdy;
                    }
                    return dateElements;

                default:
                    int[][] dateInterpretations = new int[validInterpretations][];
                    string[] interpretedFormats = new string[validInterpretations];
                    int i = 0;
                    // If YMD is a valid interpretation
                    if (ymd[0] != -1) 
                    {
                        if (ambiguousYear)
                        {
                            for (int j = 1900; j <= 2100; j += 100)
                            {
                                dateInterpretations[i] = new int[] { ymd[0] + j, ymd[1], ymd[2] };
                                interpretedFormats[i] = "ymd";
                                i++;
                            }
                        }
                        else
                        {
                            dateInterpretations[i] = ymd;
                            interpretedFormats[i] = "ymd";
                            i++;
                        }
                    }
                    // If DMY is a valid interpretation
                    if (dmy[0] != -1)
                    {
                        if (ambiguousYear)
                        {
                            for (int j = 1900; j <= 2100; j += 100)
                            {
                                dateInterpretations[i] = new int[] { dmy[0] + j, dmy[1], dmy[2] };
                                interpretedFormats[i] = "dmy";
                                i++;
                            }
                        }
                        else
                        {
                            dateInterpretations[i] = dmy;
                            interpretedFormats[i] = "dmy";
                            i++;
                        }
                    }
                    // If MDY is a valid interpretation
                    if (mdy[0] != -1)
                    {
                        if (ambiguousYear)
                        {
                            for (int j = 1900; j <= 2100; j += 100)
                            {
                                dateInterpretations[i] = new int[] { mdy[0] + j, mdy[1], mdy[2] };
                                interpretedFormats[i] = "mdy";
                                i++;
                            }
                        }
                        else
                        {
                            dateInterpretations[i] = mdy;
                            interpretedFormats[i] = "mdy";
                        }
                    }

                    throw new AmbiguousDateException(dateInterpretations, interpretedFormats, new Formatter());
            }
        }

        private int InterpretYear(string year, ref bool yearAmbiguous)
        {
            int yearNumber = -1;

            switch (year.Length)
            {
                case 1:
                case 2:
                    try
                    {
                        yearAmbiguous = true;
                        return int.Parse(year);
                    }
                    catch
                    {
                        throw new InvalidDateElementException();
                    }

                case 3:
                case 4:
                    try
                    {
                        yearNumber = int.Parse(year);
                    }
                    catch { }
                    if (yearNumber < 1 || yearNumber > 9999)
                    {
                        throw new InvalidDateElementException();
                    }
                    else
                    {
                        return yearNumber;
                    }

                default:
                    throw new InvalidDateElementException();
            } 
        }

        private int InterpretMonth(string month)
        {
            int monthNumber = 0;

            try
            {
                monthNumber = int.Parse(month);
            }
            catch
            {
                for (int i = 1; i < months.Length; i++)
                {
                    if (month == months[i].Substring(0, 3).ToLower())
                    {
                        monthNumber = i;
                    }
                }
            }
            if (monthNumber > 12 || monthNumber < 1)
            {
                throw new InvalidDateElementException();
            }
            else
            {
                return monthNumber;
            }
        }

        private int InterpretDay(string day, int year, int month)
        {
            if (year == 0)
            {
                year = 2000;
            }
            if (day.Length > 2)
            {
                throw new InvalidDateElementException();
            }
            int dayNumber = 0;
            try
            {
                dayNumber = int.Parse(day);
            }
            catch { }
            if (dayNumber > DateTime.DaysInMonth(year, month) || dayNumber < 1)
            {
                throw new InvalidDateElementException();
            }
            else
            {
                return dayNumber; 
            }
        }

        public string[] Months
        {
            get
            {
                return months;
            }
        }

        public string Ordinal(int number)
        {
            string ordinal = "th";
            if (number - (number % 10) != 10)
            {
                switch (number % 10)
                {
                    case 1: ordinal = "st"; break;
                    case 2: ordinal = "nd"; break;
                    case 3: ordinal = "rd"; break;
                }
            }
            return ordinal;
        }
    }
}
