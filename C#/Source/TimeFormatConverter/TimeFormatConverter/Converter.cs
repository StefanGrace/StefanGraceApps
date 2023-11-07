namespace TimeFormatConverter
{
    class Converter
    {
        public string convert(string input)
        {
            string inputFormat = "";
            bool pm = false;
            int amPmLength = 0;

            string _12hourEndChars = "map.";
            string _24hourEndChars = "h0123456789";

            foreach (char endChar in _12hourEndChars)
            {
                if (input[input.Length - 1] == endChar)
                {
                    inputFormat = "12-hour";
                }
            }

            foreach (char endChar in _24hourEndChars)
            {
                if (input[input.Length - 1] == endChar)
                {
                    inputFormat = "24-hour";
                }
            }

            switch (inputFormat)
            {
                case "12-hour":
                    switch (input[input.Length - 1])
                    {
                        case 'm':
                            switch (input[input.Length - 2])
                            {
                                case 'a':
                                    pm = false;
                                    amPmLength = 2;
                                    break;
                                case 'p':
                                    pm = true;
                                    amPmLength = 2;
                                    break;
                                default:
                                    throw new InvailInputException();
                            }
                            break;
                        case 'a':
                            pm = false;
                            amPmLength = 1;
                            break;
                        case 'p':
                            pm = true;
                            amPmLength = 1;
                            break;
                        case '.':
                            if (input[input.Length - 2] == 'm' && input[input.Length - 3] == '.')
                            {
                                switch (input[input.Length - 4])
                                {
                                    case 'a':
                                        pm = false;
                                        amPmLength = 4;
                                        break;
                                    case 'p':
                                        pm = true;
                                        amPmLength = 4;
                                        break;
                                    default:
                                        throw new InvailInputException();
                                }
                            }
                            else
                            {
                                throw new InvailInputException();
                            }
                            break;
                    }

                    string timeNumbers = input.Remove(input.Length - amPmLength, amPmLength);
                    timeNumbers = timeNumbers.Replace(":", "");
                    timeNumbers = timeNumbers.Replace(".", "");
                    timeNumbers = timeNumbers.Replace("-", "");
                    int.Parse(timeNumbers);
                    return _12hourTo24hour(timeNumbers, pm);

                case "24-hour":
                    string numbers = input.Replace("h", "");
                    numbers = numbers.Replace(":", "");
                    numbers = numbers.Replace(".", "");
                    numbers = numbers.Replace("-", "");
                    int.Parse(numbers);
                    return _24hourTo12hour(numbers);

                default:
                    throw new InvailInputException();
            }
        }

        private string _24hourTo12hour(string timeNumbers)
        {
            int[] timeInts = timeNumbersToIntArrary(timeNumbers);
            int _12hour = timeInts[0];
            bool pm = false;
            string amPmSymbol = "AM";
            if (timeInts[0] < 1)
            {
                _12hour = 12;
            }
            else if (timeInts[0] > 12)
            {
                _12hour = timeInts[0] - 12;
            }

            if (timeInts[0] >= 12 && timeInts[0] < 24)
            {
                pm = true;
            }

            if (pm)
            {
                amPmSymbol = "PM";
            }
            if (timeInts[2] == -1)
            {
                return _12hour + ":" + addLeadingZero(timeInts[1]) + " " + amPmSymbol;
            }
            else
            {
                return _12hour + ":" + addLeadingZero(timeInts[1]) + ":" + addLeadingZero(timeInts[2]) + " " + amPmSymbol;
            }
        }

        private string _12hourTo24hour(string timeNumbers, bool pm)
        {
            int[] timeInts = timeNumbersToIntArrary(timeNumbers);
            int _24hour = timeInts[0];
            if (timeInts[0] > 12)
            {
                throw new InvailInputException();
            }

            if (pm)
            {
                if (timeInts[0] < 12)
                {
                    _24hour = timeInts[0] + 12;
                }
            }
            else
            {
                if (timeInts[0] == 12)
                {
                    _24hour = 0;
                }
            }

            if (timeInts[2] == -1)
            {
                return addLeadingZero(_24hour) + ":" + addLeadingZero(timeInts[1]);
            }
            else
            {
                return addLeadingZero(_24hour) + ":" + addLeadingZero(timeInts[1]) + ":" + addLeadingZero(timeInts[2]);
            }
        }

        private int[] timeNumbersToIntArrary(string timeNumbers)
        {
            int[] timeInts = new int[3];

            switch (timeNumbers.Length)
            {
                case 1:
                case 2:
                    timeInts[0] = int.Parse(timeNumbers);
                    timeInts[1] = 0;
                    timeInts[2] = -1;
                    break;
                case 3:
                    timeInts[0] = int.Parse(timeNumbers[0].ToString());
                    timeInts[1] = int.Parse(timeNumbers.Remove(0, 1));
                    timeInts[2] = -1;
                    break;
                case 4:
                    timeInts[0] = int.Parse(timeNumbers.Remove(2, 2));
                    timeInts[1] = int.Parse(timeNumbers.Remove(0, 2));
                    timeInts[2] = -1;
                    break;
                case 5:
                    timeInts[0] = int.Parse(timeNumbers[0].ToString());
                    timeInts[1] = int.Parse(timeNumbers.Remove(0, 1).Remove(2, 2));
                    timeInts[2] = int.Parse(timeNumbers.Remove(0, 3));
                    break;
                case 6:
                    timeInts[0] = int.Parse(timeNumbers.Remove(2, 4));
                    timeInts[1] = int.Parse(timeNumbers.Remove(0, 2).Remove(2, 2));
                    timeInts[2] = int.Parse(timeNumbers.Remove(0, 4));
                    break;
                default:
                    throw new InvailInputException();
            }
            if (timeInts[0] > 24 || timeInts[1] > 59 || timeInts[2] > 60)
            {
                throw new InvailInputException();
            }
            return timeInts;
        }

        private string addLeadingZero(int input)
        {
            if (input < 10)
            {
                return "0" + input;
            }
            else
            {
                return "" + input;
            }
        }
    }
}
