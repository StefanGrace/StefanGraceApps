using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateListGenerator
{
    class DateFilter
    {
        private bool[] weekdays = { true, true, true, true, true, true, true };
        private bool[] months = { true, true, true, true, true, true, true, true, true, true, true, true };
        private int minDay = 1;
        private int maxDay = 31;

        public bool[] Weekdays { get => weekdays; set => weekdays = value; }
        public bool[] Months { get => months; set => months = value; }
        public int MinDay { get => minDay; set => minDay = value; }
        public int MaxDay { get => maxDay; set => maxDay = value; }
    }
}
