// Form1.cs
// Stefan Grace
// Created: 2022-12-18
// Modified: 2022-12-20

using System;
using System.Drawing;
using System.Windows.Forms;

namespace NumberWords
{
    public partial class Form1 : Form
    {
        private Converter converter = new Converter();
        private int function = 0;

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Load grammer settings from file
            try
            {
                string[] lines = System.IO.File.ReadAllLines("GrammarSettings.txt");
                converter.SetVariables(int.Parse(lines[0]), bool.Parse(lines[1]), bool.Parse(lines[2]), bool.Parse(lines[3]), bool.Parse(lines[4]), bool.Parse(lines[5]));
            }
            catch
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SingleNumberRadioButton_Click(object sender, EventArgs e)
        {
            FunctionChange(0);
        }

        private void CountToNumberRadioButton_Click(object sender, EventArgs e)
        {
            FunctionChange(1);
        }

        private void RangeRadioButton_Click(object sender, EventArgs e)
        {
            FunctionChange(2);
        }

        private void RangeWithIntervalRadioButton_Click(object sender, EventArgs e)
        {
            FunctionChange(3);
        }

        // Change function
        private void FunctionChange(int function)
        {
            this.function = function;
            switch (function)
            {
                case 0: // Single number
                    NumberStartLabel.Text = "Number:";
                    EndLabel.Hide();
                    EndTextBox.Hide();
                    IntervalLabel.Hide();
                    IntervalTextBox.Hide();
                    IncludeZeroCheckBox.Hide();
                    OutputLabel.Show();
                    SingleOutputTextBox.Show();
                    GenerateButton.Hide();
                    OutputLabel1.Hide();
                    OutputRichTextBox.Hide();
                    Size = new Size(512, Size.Height);
                    GenerateSingleNumber();
                    break;

                case 1: // Count to number
                    NumberStartLabel.Text = "Number:";
                    EndLabel.Hide();
                    EndTextBox.Hide();
                    IntervalLabel.Hide();
                    IntervalTextBox.Hide();
                    IncludeZeroCheckBox.Show();
                    OutputLabel.Hide();
                    SingleOutputTextBox.Hide();
                    GenerateButton.Show();
                    OutputLabel1.Show();
                    OutputRichTextBox.Show();
                    Size = new Size(940, Size.Height);
                    break;

                case 2: // Range
                    NumberStartLabel.Text = "Start:";
                    EndLabel.Show();
                    EndTextBox.Show();
                    IntervalLabel.Hide();
                    IntervalTextBox.Hide();
                    IncludeZeroCheckBox.Hide();
                    OutputLabel.Hide();
                    SingleOutputTextBox.Hide();
                    GenerateButton.Show();
                    OutputLabel1.Show();
                    OutputRichTextBox.Show();
                    Size = new Size(940, Size.Height);
                    break;

                case 3: // Range with interval
                    NumberStartLabel.Text = "Start:";
                    EndLabel.Show();
                    EndTextBox.Show();
                    IntervalLabel.Show();
                    IntervalTextBox.Show();
                    IncludeZeroCheckBox.Hide();
                    OutputLabel.Hide();
                    SingleOutputTextBox.Hide();
                    GenerateButton.Show();
                    OutputLabel1.Show();
                    OutputRichTextBox.Show();
                    Size = new Size(940, Size.Height);
                    break;
            }
        }

        private void NumberStartTextBox_TextChanged(object sender, EventArgs e)
        {
            GenerateSingleNumber();   
        }

        // Single Number
        private void GenerateSingleNumber()
        {
            if (function == 0)
            {
                if (NumberStartTextBox.Text.Length > 0)
                {
                    try
                    {
                        SingleOutputTextBox.Text = converter.NumberToWord(decimal.Parse(NumberStartTextBox.Text));
                        SingleOutputTextBox.ForeColor = Color.Black;
                    }
                    catch (NumberOutOfRangeException error)
                    {
                        
                        SingleOutputTextBox.Text = error.ErrorMessage;
                    }
                    catch
                    {
                        
                        SingleOutputTextBox.Text = "Must be a number.";
                    }
                }
                else
                {
                    SingleOutputTextBox.Text = "";
                }
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            switch (function)
            {
                case 1: // Count to number
                    try
                    {
                        long inputNumber = long.Parse(NumberStartTextBox.Text.Replace(",", ""));
                        if (inputNumber > Math.Pow(10, 15) || inputNumber < -(Math.Pow(10, 15)))
                        {
                            throw new NumberOutOfRangeException();
                        }
                        if (inputNumber > 10_000 || inputNumber < -10_000)
                        {
                            DialogResult userAwnser = MessageBox.Show("Counting higher than 10,000 can take a very long time and make the application look frozen. Do you really want to continue?", "", MessageBoxButtons.YesNo);
                            if (userAwnser == DialogResult.Yes)
                            {
                                OutputRichTextBox.Text = converter.NumbersToWords(inputNumber, IncludeZeroCheckBox.Checked);
                            }
                        }
                        else
                        {
                            OutputRichTextBox.Text = converter.NumbersToWords(inputNumber, IncludeZeroCheckBox.Checked);
                        } 
                    }
                    catch (NumberOutOfRangeException error)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                    catch
                    {
                        MessageBox.Show("Must enter an interger to count to.");
                    }
                    break;

                case 2: // Range
                    try
                    {
                        long start = long.Parse(NumberStartTextBox.Text.Replace(",", ""));
                        long end = long.Parse(EndTextBox.Text.Replace(",", ""));
                        if (start > Math.Pow(10, 15) || end < -(Math.Pow(10, 15)) || end > Math.Pow(10, 15) || end < -(Math.Pow(10, 15)))
                        {
                            throw new NumberOutOfRangeException();
                        }
                        long range = Math.Abs(end - start);
                        if (range > 10_000)
                        {
                            DialogResult userAwnser = MessageBox.Show("This range contains " + range.ToString("###,###,###,###,###,###,###") + " numbers. Ranges with more that 10,000 numbers can take a very long time to generate and make the application look frozen. Do you really want to continue?", "", MessageBoxButtons.YesNo);
                            if (userAwnser == DialogResult.Yes)
                            {
                                OutputRichTextBox.Text = converter.NumbersToWords(start, end);
                            }
                        }
                        else
                        {
                            OutputRichTextBox.Text = converter.NumbersToWords(start, end);
                        }
                    }
                    catch (NumberOutOfRangeException error)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                    catch
                    {
                        MessageBox.Show("Must enter two intergers.");
                    }
                    break;

                case 3: // Range with interval
                    try
                    {
                        decimal start = decimal.Parse(NumberStartTextBox.Text.Replace(",", ""));
                        decimal end = decimal.Parse(EndTextBox.Text.Replace(",", ""));
                        decimal interval = decimal.Parse(IntervalTextBox.Text);
                        if ((double) start > Math.Pow(10, 15) || (double) end < -(Math.Pow(10, 15)) || (double) end > Math.Pow(10, 15) || (double) end < -(Math.Pow(10, 15)))
                        {
                            throw new NumberOutOfRangeException();
                        }
                        decimal range = Math.Floor(Math.Abs((end - start) / interval));
                        if (range > 10_000)
                        {
                            DialogResult userAwnser = MessageBox.Show("This range contains " + range.ToString("###,###,###,###,###,###,###") + " numbers. Ranges with more that 10,000 numbers can take a very long time to generate and make the application look frozen. Do you really want to continue?", "", MessageBoxButtons.YesNo);
                            if (userAwnser == DialogResult.Yes)
                            {
                                OutputRichTextBox.Text = converter.NumbersToWords(start, end, interval);
                            }
                        }
                        else
                        {
                            OutputRichTextBox.Text = converter.NumbersToWords(start, end, interval);
                        }  
                    }
                    catch (NumberOutOfRangeException error)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                    catch (NonPositiveIntervalException)
                    {
                        MessageBox.Show("Interval must be positive.");
                    }
                    catch
                    {
                        MessageBox.Show("Must enter three numbers.");
                    }
                    break;
            }
        }

        private void SaveOutputButton_Click(object sender, EventArgs e)
        {
            DateTime dateAndTime = DateTime.Now;
            string fileName = "Output_" +
                dateAndTime.Year.ToString().PadLeft(4, '0') + "-" +
                dateAndTime.Month.ToString().PadLeft(2, '0') + "-" +
                dateAndTime.Day.ToString().PadLeft(2, '0') + "_" +
                dateAndTime.Hour.ToString().PadLeft(2, '0') + "-" +
                dateAndTime.Minute.ToString().PadLeft(2, '0') + "-" +
                dateAndTime.Second.ToString().PadLeft(2, '0') + "_" +
                dateAndTime.Millisecond.ToString().PadLeft(3, '0') + ".txt";

            string[] lines = new string[1];
            if (function == 0)
            {
                lines[0] = SingleOutputTextBox.Text;
            }
            else
            {
                lines[0] = OutputRichTextBox.Text.Replace("\n","\r\n");
            }
            if (lines[0].Length == 0)
            {
                MessageBox.Show("There's no output to save!");
            }
            else
            {
                try
                {
                    System.IO.File.WriteAllLines(fileName, lines);
                    MessageBox.Show("Output saved to \"" + fileName + "\".");
                }
                catch
                {
                    MessageBox.Show("Unable to save output.");
                }
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SingleOutputTextBox.Size = new Size(Size.Width - 193, SingleOutputTextBox.Size.Height);
        }

        private void GrammerBbutton_Click(object sender, EventArgs e)
        {
            GrammarForm gf = new GrammarForm(converter.LetterCasing, converter.IncludeAnd, converter.Commas, converter.ZeroBeforePoint, converter.NegativeMinus, converter.ShortHand);
            gf.ShowDialog();
            converter.SetVariables(gf.LetterCasing, gf.IncludeAnd, gf.Commas, gf.ZeroBeforePoint, gf.NegativeMinus, gf.ShortHand);
            GenerateSingleNumber();

            // Save grammer settings to file
            string[] lines = { gf.LetterCasing.ToString(), gf.IncludeAnd.ToString(), gf.Commas.ToString(), gf.ZeroBeforePoint.ToString(), gf.NegativeMinus.ToString(), gf.ShortHand.ToString() };
            try
            {
                System.IO.File.WriteAllLines("GrammarSettings.txt", lines);
            }
            catch
            {

            }
        }

        
    }
}
