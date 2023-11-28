using System;

namespace DateFormatter
{
    class ChoiceOutOfRangeException : Exception
    {
        private int choice;

        public ChoiceOutOfRangeException(int choice)
        {
            this.choice = choice;
        }

        public int Choice
        {
            get
            {
                return choice;
            }
        }
    }
}
