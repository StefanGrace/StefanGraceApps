using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CreateFileStructureFromDirListings
{
    public partial class EncodingSelectionForm : Form
    {
        Encoding encoding = null;

        public EncodingSelectionForm()
        {
            InitializeComponent();
        }

        private void EncodingSelectionForm_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = Encoding.GetEncodings();
            dataGridView.Columns[2].Width = 250;
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                int codepage = int.Parse(textBox_encoding.Text);
                encoding = Encoding.GetEncoding(codepage);
                Close();
            }
            catch
            {
                try
                {
                    encoding = Encoding.GetEncoding(textBox_encoding.Text);
                    Close();
                }
                catch
                {
                    MessageBox.Show("Invalid codepage or name.");
                }
            }
        }

        public Encoding SelectedEncoding
        {
            get
            {
                return encoding;
            }
        }
    }
}
