using System;

namespace NumberWords
{
    class NumberOutOfRangeException : Exception
    {
        private string errorMessage = "Number must be less than 10^15 and more than -(10^15).";

        public string ErrorMessage
        {
            get
            {
                return errorMessage;
            }
        }

    }
}
