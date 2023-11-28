using System;

namespace DateFormatter
{
    class Program
    {
        private static Formatter formatter = new Formatter();

        private static int dateOrder;
        private static int yearFormat;
        private static int monthFormat;
        private static int dayFormat;
        private static int separator;
        private static int commaAfterDay = 2;

        static void Main(string[] args)
        {
            // Try to load previous-saved format
            try
            {
                string[] lines = System.IO.File.ReadAllLines("OutputFormat.txt");
                int[] intLines = new int[lines.Length];
                int[] maxValues = { 3, 2, 4, 3, 6, 2};
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
                commaAfterDay = intLines[5];
            }
            // If that fails, prompt the user to define a new format
            catch
            {
                Console.WriteLine("Define output format:");
                Console.WriteLine();
                DefineOutputFormat();
                if (dateOrder == 0)
                {
                    return;
                }
            }
            UpdateFormatterFormat();
            DisplayOptions();
        }

        static void DisplayOptions()
        {
            Console.WriteLine("What would you like to do?\n" +
                "1) Convert date format\n" +
                "2) Specify each element\n" +
                "3) Format current date\n" +
                "4) Re-define output date format\n" +
                "5) Change one aspect of output format\n" +
                "6) View current output format settings\n" +
                "7) Save current output format to load next time program is opened\n" +
                "8) Delete saved output format\n" +
                "0) Exit");

            switch (CollectChoice(8))
            {
                case 1:
                    InterpretDate();
                    break;

                case 2:
                    int[] dateElements = CollectDateByElement();
                    Console.WriteLine();
                    if (dateElements != null)
                    {
                        try
                        {
                            PrintDate(dateElements[0], dateElements[1], dateElements[2]);
                        }
                        catch (InvalidDateElementException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    break;

                case 3:
                    DateTime currentDate = DateTime.Now;
                    PrintDate(currentDate.Year, currentDate.Month, currentDate.Day);
                    break;

                case 4:
                    DefineOutputFormat();
                    UpdateFormatterFormat();
                    break;

                case 5:
                    ChangeOneAspectOfOutputFormat();
                    UpdateFormatterFormat();
                    break;

                case 6:
                    ViewOutputFormat();
                    break;

                case 7:
                    try
                    {
                        SaveOutputFormat();
                        Console.WriteLine("Output format saved to successfully to \"OutputFormat.txt\"");
                    }
                    catch
                    {
                        Console.WriteLine("Unable to save output format to \"OutputFormat.txt\"");
                    }
                    Console.WriteLine();
                    break;

                case 8:
                    try
                    {
                        if (System.IO.File.Exists("OutputFormat.txt"))
                        {
                            Console.WriteLine("Are you sure you want to delete \"OutputFormat.txt\"?\n" +
                                "1) Yes\n" +
                                "2) No");
                            if (CollectChoice(2, false) == 1)
                            {
                                System.IO.File.Delete("OutputFormat.txt");
                                Console.WriteLine("\"OutputFormat.txt\" deleted successfully");
                            }
                        }
                        else
                        {
                            Console.WriteLine("\"OutputFormat.txt\" does not exist");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Unable to delete \"OutputFormat.txt\"");
                    }
                    Console.WriteLine();
                    break;

                case 0:
                    return;
            }

            DisplayOptions();
        }

        static void DefineOutputFormat()
        {
            int[] choices = new int[6];

            for (int i = 1; i <= 5; i++)
            {
                choices[i] = CollectOutputFormat(i);
                if (choices[i] == 0)
                {
                    return;
                }
            }

            dateOrder = choices[1];
            yearFormat = choices[2];
            monthFormat = choices[3];
            dayFormat = choices[4];
            separator = choices[5];

            if (ShowCommaOption())
            {
                int commaChoice = CollectOutputFormat(6);
                if (commaChoice == 0)
                {
                    return;
                }
                else
                {
                    commaAfterDay = commaChoice;
                }
            }

            switch (CollectOutputFormat(7))
            {
                case 1:
                    try
                    {
                        SaveOutputFormat();
                    }
                    catch
                    {
                        Console.WriteLine("Unable to save output format");
                        Console.WriteLine();
                    }
                    break;
                case 0:
                    dateOrder = 0;
                    return;
            }

        }

        static int CollectOutputFormat(int aspect)
        {
            switch (aspect)
            {
                case 1:
                    Console.WriteLine("Date order:\n" +
                        "1) Year-Month-Day\n" +
                        "2) Day-Month-Year\n" +
                        "3) Month-Day-Year\n" +
                        "0) Exit");
                    return CollectChoice(3);

                case 2:
                    Console.WriteLine("Year format:\n" +
                        "1) 2-digit e.g. \"23\"\n" +
                        "2) 4-digit e.g. \"2023\"\n" +
                        "0) Exit");
                    return CollectChoice(2);

                case 3:
                    Console.WriteLine("Month format:\n" +
                        "1) Numerical without leading-zero e.g. \"8\"\n" +
                        "2) Numerical with leading-zero e.g. \"08\"\n" +
                        "3) Worded 3-letter e.g. \"Aug\"\n" +
                        "4) Worded full e.g. \"August\"\n" +
                        "0) Exit");
                    return CollectChoice(4);

                case 4:
                    Console.WriteLine("Day format:\n" +
                        "1) Without leading-zero e.g. \"5\"\n" +
                        "2) With leading-zero e.g. \"05\"\n" +
                        "3) Ordinanl e.g. \"5th\"\n" +
                        "0) Exit");
                    return CollectChoice(3);

                case 5:
                    Console.WriteLine("Separator:\n" +
                        "1) Slash (/)\n" +
                        "2) Dot (.)\n" +
                        "3) Hyphen (-)\n" +
                        "4) Space ( )\n" +
                        "5) Underscore (_)\n" +
                        "6) None ()\n" +
                        "0) Exit");
                    return CollectChoice(6);

                case 6:
                    Console.WriteLine("Would you like to include a comma after the day?\n" +
                        "1) Yes\n" +
                        "2) No");
                    return CollectChoice(2, false);

                case 7:
                    Console.WriteLine("Would you like to save current output format to load next time program is opened?\n" +
                        "1) Yes\n" +
                        "2) No");
                    return CollectChoice(2, false);

                default:
                    return 0;
            }
        }

        

        static int CollectChoice(int choices, bool zero = true)
        {
            while (true)
            {
                int start;
                if (zero)
                {
                    start = 0;
                }
                else
                {
                    start = 1;
                }
                Console.WriteLine();
                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();
                for (int i = start; i <= choices; i++)
                {
                    if (i.ToString() == choice)
                    {
                        Console.WriteLine();
                        return int.Parse(choice);
                    }
                }
                Console.WriteLine("Invalid choice: " + choice);
            }
        }


        static void ChangeOneAspectOfOutputFormat()
        {
            string commaOptionText = "";
            if (ShowCommaOption())
            {
                commaOptionText = "6) Show comma after day\n";
            }

            Console.WriteLine("What aspect of the output format would you like to change?\n" +
               "1) Date order\n" +
               "2) Year format\n" +
               "3) Month format\n" +
               "4) Day format\n" +
               "5) Separator\n" +
               commaOptionText +
               "0) Exit");

            int choice;
            if (ShowCommaOption())
            {
                choice = CollectChoice(6);
            }
            else
            {
                choice = CollectChoice(5);
            }
            
            if (choice > 0)
            {
                int collectedChoice = CollectOutputFormat(choice);
                switch (choice)
                {
                    case 1: dateOrder = collectedChoice; break;
                    case 2: yearFormat = collectedChoice; break;
                    case 3: monthFormat = collectedChoice; break;
                    case 4: dayFormat = collectedChoice; break;
                    case 5: separator = collectedChoice; break;
                }
                switch (CollectOutputFormat(7))
                {
                    case 1:
                        try
                        {
                            SaveOutputFormat();
                        }
                        catch
                        {
                            Console.WriteLine("Unable to save output format");
                            Console.WriteLine();
                        }
                        break;
                }
            }
        }


        static void SaveOutputFormat()
        {
            System.IO.File.WriteAllLines("OutputFormat.txt", new string[] {
                dateOrder.ToString(),
                yearFormat.ToString(),
                monthFormat.ToString(),
                dayFormat.ToString(),
                separator.ToString(),
                commaAfterDay.ToString()
            });
        }

        static int[] CollectDateByElement()
        {
            int year = -1;
            int month = -1;
            int day = -1;

            while (year < 1 || year > 9999)
            {
                Console.Write("Enter year ((000)1 to 9999): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    return null;
                }
                try
                {
                    year = int.Parse(input);
                }
                catch {}
                if (year < 1 || year > 9999)
                {
                    Console.WriteLine("Invalid input: " + input);
                }
            }

            while (month < 1 || month > 12)
            {
                Console.Write("Enter month ((0)1 to 12, or (Jan)uary to (Dec)ember): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    return null;
                }
                try
                {
                    month = int.Parse(input);
                }
                catch
                {
                    string[] months = { "", "jan", "feb", "mar", "apr", "may", "jun", "jul", "aug", "sep", "oct", "nov", "dec" };
                    for (int i = 1; i <= 12; i++)
                    {
                        if (input.ToLower().StartsWith(months[i]))
                        {
                            month = i;
                        }
                    }
                }
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid input: " + input);
                }
            }

            int daysInMonth = DateTime.DaysInMonth(year, month);

            while (day < 1 || day > daysInMonth)
            {
                Console.Write("Enter day ((0)1 to " + daysInMonth + "): ");
                string input = Console.ReadLine();
                if (input == "")
                {
                    return null;
                }
                try
                {
                    day = int.Parse(input);
                }
                catch {}
                if (day < 1 || day > daysInMonth)
                {
                    Console.WriteLine("Invalid input: " + input);
                }
            }

            return new int[] {year, month, day};
        }

        static void PrintDate(int year, int month, int day)
        {
            Console.WriteLine(formatter.FormatDate(year, month, day));
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        static void UpdateFormatterFormat()
        {
            string dateSeparator = "";
            switch (separator)
            {
                case 1: dateSeparator = "/"; break;
                case 2: dateSeparator = "."; break;
                case 3: dateSeparator = "-"; break;
                case 4: dateSeparator = " "; break;
                case 5: dateSeparator = "_"; break;
                case 6: dateSeparator = ""; break;
            }
            formatter.SetFormat(dateOrder, yearFormat, monthFormat, dayFormat, dateSeparator, commaAfterDay == 1);
        }

        static bool ShowCommaOption()
        {
            return dateOrder == 3 && (monthFormat == 3 || monthFormat == 4) && (separator == 4 || separator == 6);
           
        }

        static void ViewOutputFormat()
        {
            string dateOrderText = "";
            string yearFormatText = "";
            string monthFormatText = "";
            string dayFormatText = "";
            string separatorText = "";
            string commaAfterDayText = "";

            switch (dateOrder)
            {
                case 1: dateOrderText = "Year-Month-Day"; break;
                case 2: dateOrderText = "Day-Month-Year"; break;
                case 3: dateOrderText = "Month-Day-Year"; break;
            }
            switch (yearFormat)
            {
                case 1: yearFormatText = "2-digit"; break;
                case 2: yearFormatText = "4-digit"; break;
            }
            switch (monthFormat)
            {
                case 1: monthFormatText = "Numerical without leading-zero"; break;
                case 2: monthFormatText = "Numerical with leading-zero"; break;
                case 3: monthFormatText = "Worded 3-letter"; break;
                case 4: monthFormatText = "Worded full"; break;
            }
            switch (dayFormat)
            {
                case 1: dayFormatText = "Without leading-zero"; break;
                case 2: dayFormatText = "With leading-zero"; break;
                case 3: dayFormatText = "Ordinal"; break;
            }
            switch (separator)
            {
                case 1: separatorText = "Slash (/)"; break;
                case 2: separatorText = "Dot (.)"; break;
                case 3: separatorText = "Hyphen (-)"; break;
                case 4: separatorText = "Space ( )"; break;
                case 5: separatorText = "Underscore (_)"; break;
                case 6: separatorText = "None ()"; break;
            }
            if (ShowCommaOption())
            {
                commaAfterDayText = "\nComma after day: ";
                switch (commaAfterDay)
                {
                    case 1: commaAfterDayText += "Yes"; break;
                    case 2: commaAfterDayText += "No"; break;
                }
            }

            Console.WriteLine("Current output format settings:\n" +
                "Date order: " + dateOrderText + "\n" +
                "Year format: " + yearFormatText + "\n" +
                "Month format: " + monthFormatText + "\n" + 
                "Day fomat: " + dayFormatText + "\n" +
                "Seperator: " + separatorText + 
                commaAfterDayText);
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }

        static void InterpretDate()
        {
            Console.Write("Enter date: ");
            string input = Console.ReadLine();
            Console.WriteLine();
            if (input == "")
            {
                return;
            }
            try
            {
                int[] dateElements = formatter.InterpretDate(input);
                PrintDate(dateElements[0], dateElements[1], dateElements[2]);
            }
            catch (InvalidDateException e)
            {
                Console.WriteLine("Cannot interpret \"" + e.Date + "\" as a valid date");
                Console.WriteLine();
                InterpretDate();
            }
            catch (AmbiguousDateException e)
            {
                Console.WriteLine("By \"" + input + "\", do you mean: ");
                for (int i = 0; i < e.Interpretations.Length; i++)
                {
                    Console.WriteLine((i + 1) + ") " + e.Interpretations[i]);
                }
                try
                {
                    int[] dateElements = formatter.InterpretDate(e.Interpretations[CollectChoice(e.Interpretations.Length, false) - 1]);
                    PrintDate(dateElements[0], dateElements[1], dateElements[2]);
                }
                catch (InvalidDateException ex)
                {
                    Console.WriteLine("Cannot interpret \"" + ex.Date + "\" as a valid date");
                    Console.WriteLine();
                }
            }
            catch (InvalidDateElementException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine();
                InterpretDate();
            }
        }
    }
}
