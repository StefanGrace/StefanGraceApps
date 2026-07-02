using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateListGenerator
{
    public partial class AdvancedDateFilterForm : Form
    {
        private CheckBox[] weekdayCheckboxes;
        private CheckBox[] monthCheckboxes;

        public AdvancedDateFilterForm()
        {
            InitializeComponent();
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AdvancedDateFilterForm_Load(object sender, EventArgs e)
        {
             weekdayCheckboxes = new CheckBox[] 
             {
                 checkBox_monday,
                 checkBox_tuesday,
                 checkBox_wednesday,
                 checkBox_thursday,
                 checkBox_friday,
                 checkBox_saturday,
                 checkBox_sunday,
             };

            monthCheckboxes = new CheckBox[]
            {
                checkBox_jan,
                checkBox_feb,
                checkBox_mar,
                checkBox_apr,
                checkBox_jun,
                checkBox_jul,
                checkBox_aug,
                checkBox_sep,
                checkBox_oct,
                checkBox_nov,
                checkBox_dec,
            };
        }

        private void button_weekdayAll_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in weekdayCheckboxes)
            {
                checkBox.Checked = true;
            }
        }

        private void button_weekdayNone_Click(object sender, EventArgs e)
        {
            foreach (CheckBox checkBox in weekdayCheckboxes)
            {
                checkBox.Checked = false;
            }
        }
    }
}
