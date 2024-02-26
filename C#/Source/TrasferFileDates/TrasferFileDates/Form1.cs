using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrasferFileDates
{
    public partial class Form1 : Form
    {
        FileDateTrasfer fileDateTrasfer = new FileDateTrasfer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button_trasfer_Click(object sender, EventArgs e)
        {
            string fromDir = textBox_fromDir.Text.TrimEnd('\\').Replace("\"", "");
            if (fromDir == "")
            {
                MessageBox.Show("Please enter the path of the folder to trasfer file dates from.");
                return;
            }

            if (!System.IO.Directory.Exists(fromDir))
            {
                MessageBox.Show("\"" + fromDir + "\" does not exist.", "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string toDir = textBox_toDir.Text.TrimEnd('\\').Replace("\"", "");
            if (toDir == "")
            {
                MessageBox.Show("Please enter the path of the folder to trasfer file dates to");
                return;
            }

            if (!System.IO.Directory.Exists(toDir))
            {
                MessageBox.Show("\"" + toDir + "\" does not exist.", "Directory not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fromExt = textBox_fromExt.Text;
            string toExt = textBox_toExt.Text;
        

            fileDateTrasfer.TrasferFileDates(fromDir, toDir, fromExt, toExt, checkBox_modified.Checked, checkBox_created.Checked, checkBox_accessed.Checked);
        }
    }
}
