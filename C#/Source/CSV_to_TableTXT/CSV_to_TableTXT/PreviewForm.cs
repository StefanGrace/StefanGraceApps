using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSV_to_TableTXT
{
    public partial class PreviewForm : Form
    {
        private string[] lines;

        public PreviewForm(string[] lines)
        {
            this.lines = lines;
            InitializeComponent();
        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            previewTextBox.Lines = lines;
            previewTextBox.SelectionStart = 0;
            previewTextBox.SelectionLength = 0;
        }
    }
}
