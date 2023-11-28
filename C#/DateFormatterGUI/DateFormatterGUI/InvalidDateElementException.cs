using System;

namespace DateFormatter
{
    class InvalidDateElementException : Exception
    {
        public override string Message
        {
            get
            {
                return "One of more of the date elements was outside of the valid range";
            }
        }
    }
}
