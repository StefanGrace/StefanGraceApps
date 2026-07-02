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

namespace CSV_to_TableTXT
{
    public partial class MainForm : Form
    {
        private string[] args;
        private TableBuilder tb = new TableBuilder();

        public MainForm(string[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alignmentComboBox.SelectedIndex = 0;
            autoAlignmentComboBox.SelectedIndex = 1;
            if (args.Length > 0)
            {
                inputCSVTextBox.Text = args[0];
            }
        }

        private void alignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItemText = alignmentComboBox.SelectedItem.ToString();

            alignmentTextBox.Visible = selectItemText == "Manual";

            bool autoAlignmentAvailable = selectItemText == "Auto" || selectItemText == "Manual";
            autoAlignmentLabel.Visible = autoAlignmentAvailable;
            autoAlignmentComboBox.Visible = autoAlignmentAvailable;

            switch (selectItemText)
            {
                case "Auto":
                    tb.ColAlign = ColummAlignment.Auto;
                    break;

                case "Left":
                    tb.ColAlign = ColummAlignment.Left;
                    break;

                case "Right":
                    tb.ColAlign = ColummAlignment.Right;
                    break;

                case "Manual":
                    tb.ColAlign = ColummAlignment.Manual;
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string[] table;
            try
            {
                table = BuildTable();
            }
            catch (MissingFieldException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (outputTXTTextBox.Text == "")
            {
                MessageBox.Show("Please enter the file path of the output TXT file.");
                return;
            }
            string outputTXTPath = outputTXTTextBox.Text.Replace("\"", "");

            try
            { 
                File.WriteAllLines(outputTXTPath, table);
            }
            catch
            {
                MessageBox.Show("Cannot write to \"" + outputTXTPath + "\"");
                return;
            }
        }

        private string[] BuildTable()
        {
            if (inputCSVTextBox.Text == "")
            {
                throw new MissingFieldException("Please enter the file path of the input CSV file.");
            }
            string inputCSVPath = inputCSVTextBox.Text.Replace("\"", "");

            string[] lines;
            try
            {
                 lines = File.ReadAllLines(inputCSVPath);
            }
            catch (FileNotFoundException)
            {
                throw new MissingFieldException("\"" + inputCSVPath + "\" does not exist.");
            }
            catch (DirectoryNotFoundException)
            {
                throw new MissingFieldException("\"" + inputCSVPath + "\" does not exist.");
            }
            catch
            {
                throw new MissingFieldException("Could not open \"" + inputCSVPath + "\".");
            }

            if (tb.ColAlign == ColummAlignment.Manual) {

                if (alignmentTextBox.Text == "")
                {

                    throw new MissingFieldException("Please enter column alignment text when using manual alignment.");
                }

                List<IndividualColummAlignment> alignment = new List<IndividualColummAlignment>();

                foreach (char character in alignmentTextBox.Text.ToUpper())
                {
                    
                    switch (character)
                    {
                        case 'A':
                            alignment.Add(IndividualColummAlignment.Auto);
                            break;
                        case 'L':
                            alignment.Add(IndividualColummAlignment.Left);
                            break;
                        case 'R':
                            alignment.Add(IndividualColummAlignment.Right);
                            break;
                    }
                }

                if (alignment.Count == 0)
                {
                    throw new MissingFieldException("Manual column alignment text is not formatted correcty.");
                }

                tb.ManualColAlign = alignment.ToArray();
            }

            

            
            string[,] data = CSVReader.ReadCSV(lines);
            string[] table = tb.BuildTable(data);
            return table;
        }

        private void previewButton_Click(object sender, EventArgs e)
        {
            string[] table;
            try
            {
                table = BuildTable();
            }
            catch (MissingFieldException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            PreviewForm preview = new PreviewForm(table);
            preview.ShowDialog();
        }

        private void bordersCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tb.TopBottomBorders = bordersCheckBox.Checked;
        }

        private void footerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            tb.LastRowIsFooter = footerCheckBox.Checked;
        }

        private void autoAlignmentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (autoAlignmentComboBox.SelectedItem.ToString())
            {
                case "First data row":
                    tb.AutoAlignment = AutoAlignment.FirstDataRow;
                    break;

                case "Majority (left if equal)":
                    tb.AutoAlignment = AutoAlignment.Majority_HalfIsLeft;
                    break;

                case "Majority (right if equal)":
                    tb.AutoAlignment = AutoAlignment.Majority_HalfIsRight;
                    break;

                case "All have to be numeric for right-alignment":
                    tb.AutoAlignment = AutoAlignment.AllHaveToBeNumber;
                    break;

                case "At least one has to be numeric for right-alignment":
                    tb.AutoAlignment = AutoAlignment.OneHasToBeNumber;
                    break;
            }
        }
    }
}
