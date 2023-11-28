using System;

namespace DateFormatter
{
    class InvalidDateException : Exception
    {
        private string date;

        public InvalidDateException(string date)
        {
            this.date = date;
        }

        public string Date
        {
            get
            {
                return date;
            }
        }
    }
}
