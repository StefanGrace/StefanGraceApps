using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public class UnitTextBox : IUnitTextBox
    {
        private TextBox textBox;
        private string unit;
        private string prefix;

        public UnitTextBox(TextBox textBox, string unit, string prefix = "")
        {
            this.textBox = textBox;
            this.unit = unit;
            this.prefix = prefix;
        }

        public TextBox TextBox { get => textBox; }
        public string Unit { get => unit; }
        public string Prefix { get => prefix; }
        public string PrefixAndUnit { get => prefix + unit; }
    }
}
