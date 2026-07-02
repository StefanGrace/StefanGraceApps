using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirListingExtStat
{
    class ExtStatData
    {
        private string[] headings;
        private string[,] data;
        private bool[] rightAlign;
        private string[] footer;

        public ExtStatData(string[] headings, string[,] data, bool[] rightAlign, string[] footer = null)
        {
            this.headings = headings;
            this.data = data;
            this.rightAlign = rightAlign;
            this.footer = footer;
        }

        public string[] Headings { get => headings; }
        public string[,] Data { get => data; }
        public bool[] RightAlign { get => rightAlign; }
        public string[] Footer { get => footer; }
    }
}
