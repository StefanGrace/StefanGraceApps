using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateFileStructureFromDirListings
{
    public partial class Form1 : Form
    {
        private string[] args;
        private DirListingsToFileStructure fsCreator = new DirListingsToFileStructure();
        private Encoding otherEncoding = null;
        int previousEncodingSelection;

        public Form1(string[] args)
        {
            this.args = args;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (args.Length > 0)
            {
                textBox_dirListingPath.Text = args[0];
            }
            comboBox_sizeUnit.SelectedIndex = 0;
            comboBox_invalidCharReplacement.SelectedIndex = 0;
            comboBox_inputSizeUnit.SelectedIndex = 0;
            comboBox_inputTextEncoding.SelectedIndex = 1;
            label_otherEncoding.Text = "";
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            if (button_Create.Text == "Create")
            {
                if (textBox_dirListingPath.Text == "")
                {
                    MessageBox.Show("Please enter a file path for the input dir listings TXT files.");
                    return;
                }

                if (!System.IO.File.Exists(textBox_dirListingPath.Text.Replace("\"", "")))
                {
                    MessageBox.Show("\"" + textBox_dirListingPath.Text.Replace("\"", "") + "\" does not exist.");
                    return;
                }

                if (textBox_fsPath.Text == "")
                {
                    MessageBox.Show("Please enter a folder path for file structure to be created");
                    return;
                }


                BuildFileStruce();
            }
            else if (button_Create.Text == "Cancel")
            {
                fsCreator.Terminate();
            }
        }

        private async void BuildFileStruce()
        {
            Encoding encoding;
            switch (comboBox_inputTextEncoding.SelectedItem.ToString())
            {
                case "ASCII":
                    encoding = Encoding.ASCII;
                    break;

                case "ANSI":
                    encoding = Encoding.Default;
                    break;

                case "Windows-1252":
                    encoding = Encoding.GetEncoding(1252);
                    break;

                case "UTF-8":
                    encoding = Encoding.UTF8;
                    break;

                case "UTF-16 LE":
                    encoding = Encoding.Unicode;
                    break;

                case "UTF-16 BE":
                    encoding = Encoding.BigEndianUnicode;
                    break;

                case "UTF-32 LE":
                    encoding = Encoding.UTF32;
                    break;

                case "UTF-32 BE":
                    encoding = Encoding.GetEncoding("utf-32BE");
                    break;

                case "Other...":
                    encoding = otherEncoding;
                    break;

                default:
                    throw new ArgumentException();
            }
            string[] dirListingLines = System.IO.File.ReadAllLines(textBox_dirListingPath.Text.Replace("\"", ""), encoding);
            progressBar.Maximum = dirListingLines.Length;
            IProgress<int> progress = new Progress<int>(count =>
            {
                progressBar.Value = count;
                label_progressPercent.Text = (((double)progressBar.Value / progressBar.Maximum) * 100).ToString("N0") + "%";
            });
            label_loading.Visible = true;
            progressBar.Visible = true;
            label_progressPercent.Visible = true;
            button_Create.Text = "Cancel";
            await Task.Run(() =>
            {
                fsCreator.CreateFileStructure(dirListingLines, textBox_fsPath.Text, checkBox_includeFiles.Checked, progress);
            });
            label_loading.Visible = false;
            progressBar.Visible = false;
            label_progressPercent.Visible = false;
            button_Create.Text = "Create";
        }

        private void checkBox_addFileSizeToName_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_fileSizeBeforeName.Enabled = checkBox_addFileSizeToName.Checked;
            radioButton_fileSizeAfterName.Enabled = checkBox_addFileSizeToName.Checked;
            label_sizeUnit.Enabled = checkBox_addFileSizeToName.Checked;
            comboBox_sizeUnit.Enabled = checkBox_addFileSizeToName.Checked;
            SetFileSizeInName();
        }

        private void radioButton_fileSizeBeforeName_CheckedChanged(object sender, EventArgs e)
        {
            SetFileSizeInName();
        }

        private void radioButton_fileSizeAfterName_CheckedChanged(object sender, EventArgs e)
        {
            SetFileSizeInName();
        }

        private void checkBox_includeFiles_CheckedChanged(object sender, EventArgs e)
        {
            groupBox_fileSize.Enabled = checkBox_includeFiles.Checked;
        }

        private void comboBox_invalidCharReplacement_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsCreator.InvalidCharReplacement = comboBox_invalidCharReplacement.SelectedItem.ToString()[0];
        }

        private void comboBox_sizeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            fsCreator.SizeUnit = comboBox_sizeUnit.SelectedItem.ToString();
        }

        private void SetFileSizeInName()
        {
            if (!checkBox_addFileSizeToName.Checked)
            {
                fsCreator.AddFileSizeToName = 0;
            }
            else if (radioButton_fileSizeBeforeName.Checked)
            {
                fsCreator.AddFileSizeToName = 1;
            }
            else
            {
                fsCreator.AddFileSizeToName = 2;
            }
        }

        private void button_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program takes the TXT file that Karen's Directory Printer outputs, and creates the original file structure, either with just the folders, or with the folder and empty versions of the files. It will also set the correct date modified and date created for the folders and files if they are present in the dir listing TXT. It can also add the file size to the start or end of the file names. ", "About");
        }

        private void comboBox_inputSizeUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            int[] sizeUnits = { 1000, 1024 };
            fsCreator.InputBytesInKB = sizeUnits[comboBox_inputSizeUnit.SelectedIndex];
        }

        private void comboBox_inputTextEncoding_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_inputTextEncoding.SelectedItem.ToString() == "Other...")
            {
                EncodingSelectionForm encodingSelection = new EncodingSelectionForm();
                encodingSelection.ShowDialog();

                otherEncoding = encodingSelection.SelectedEncoding;
                if (otherEncoding == null)
                {
                    comboBox_inputTextEncoding.SelectedIndex = previousEncodingSelection;
                }
                else
                {
                    label_otherEncoding.Text = otherEncoding.EncodingName;
                    button_changeEncoding.Visible = true;
                }
            }
            else
            {
                previousEncodingSelection = comboBox_inputTextEncoding.SelectedIndex;
                label_otherEncoding.Text = "";
                button_changeEncoding.Visible = false;
            }
        }

        private void button_changeEncoding_Click(object sender, EventArgs e)
        {
            EncodingSelectionForm encodingSelection = new EncodingSelectionForm();
            encodingSelection.ShowDialog();
            Encoding selectedEncoding = encodingSelection.SelectedEncoding;
            if (selectedEncoding != null)
            {
                otherEncoding = selectedEncoding;
                label_otherEncoding.Text = otherEncoding.EncodingName;
            }
        }
    }
}
