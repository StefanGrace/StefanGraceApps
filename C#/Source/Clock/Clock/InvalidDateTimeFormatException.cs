using System;

namespace Clock
{
    class InvalidDateTimeFormatException : Exception
    {
        private DateTimeFormat format;

        public InvalidDateTimeFormatException(DateTimeFormat format)
        {
            this.format = format;
        }

        public DateTimeFormat Format { get => format; }
    }
}
