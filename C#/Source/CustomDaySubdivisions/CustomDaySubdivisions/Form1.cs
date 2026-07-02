using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomDaySubdivisions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown_secondDecimals_ValueChanged(object sender, EventArgs e)
        {
            int decimalPlaces = (int)numericUpDown_secondDecimals.Value;
            numericUpDown_inputSecond.DecimalPlaces = decimalPlaces;
            int dotWidth = decimalPlaces == 0 ? 0 : 3;
            numericUpDown_inputSecond.Width = numericUpDown_inputSecondsInMinute.Width + dotWidth + (decimalPlaces * 6);
        }
    }
}
