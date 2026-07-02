using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private const int displayWidth = 30;
        private Calc calc;

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void CalculatorForm_Load(object sender, EventArgs e)
        {
            calc = new Calc(displayWidth - "yroot ".Length);
        }

        private void UpdateDisplay()
        {
            string[] displayLines = new string[3];
            displayLines[0] = calc.InputLine1;
            displayLines[1] = GetOperationNotation(calc.CurrentOperation).PadRight(displayWidth - (calc.InputLine2.Length + 1)) + calc.InputLine2;
            if (calc.IsOutput)
            {
                string calcOutputString = calc.Output.ToString();
                displayLines[2] = "=".PadRight(displayWidth - (calcOutputString.Length + 1)) + calcOutputString.ToString();
            }
            else
            {
                displayLines[2] = "";
            }

            displayTextBox.Lines = displayLines;
        }

        private void InputDigit(char digit)
        {
            calc.InputDigit(digit);
            UpdateDisplay();
        }

        private void InputConstant(Constant constant)
        {
            calc.InputConstant(constant);
            UpdateDisplay();
        }

        private void Operate(Operation operation)
        {
            calc.Operate(operation);
            UpdateDisplay();
        }

        private void Backspace()
        {
            calc.Backspace();
            UpdateDisplay();
        }

        private void Clear()
        {
            calc.Clear();
            UpdateDisplay();
        }

        private void Calculate()
        {
            calc.Calculate();
            UpdateDisplay();
        }

        private void NegateSign()
        {
            calc.NegateSign();
            UpdateDisplay();
        }

        private string GetOperationNotation(Operation operation)
        {
            switch (operation)
            {
                case Operation.None:
                    return "";

                case Operation.Add:
                    return "+";
                    
                case Operation.Subtract:
                    return "-";
                    
                case Operation.Times:
                    return "*";
                    
                case Operation.Divide:
                    return "/";

                case Operation.Power:
                    return "^";

                case Operation.Yroot:
                    return "yroot";

                case Operation.Logn:
                    return "logn";

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            calc.Calculate();
            UpdateDisplay();
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            Operate(Operation.Divide);
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            NegateSign();
        }

        private void lognButton_Click(object sender, EventArgs e)
        {
            Operate(Operation.Logn);
        }

        private void timesButton_Click(object sender, EventArgs e)
        {
            Operate(Operation.Times);
        }

        private void num3Button_Click(object sender, EventArgs e)
        {
            InputDigit('3');
        }

        private void decimalPointButton_Click(object sender, EventArgs e)
        {
            InputDigit('.');
        }

        private void num2Button_Click(object sender, EventArgs e)
        {
            InputDigit('2');
        }

        private void num0Button_Click(object sender, EventArgs e)
        {
            InputDigit('0');
        }

        private void num1Button_Click(object sender, EventArgs e)
        {
            InputDigit('1');
        }

        private void backspaceButton_Click(object sender, EventArgs e)
        {
            Backspace();
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            InputConstant(Constant.E);
        }

        private void yrootButton_Click(object sender, EventArgs e)
        {
            Operate(Operation.Yroot);
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            Operate(Operation.Subtract);
        }

        private void num6Button_Click(object sender, EventArgs e)
        {
            InputDigit('6');
        }

        private void num5Button_Click(object sender, EventArgs e)
        {
            InputDigit('5');
        }

        private void num4Button_Click(object sender, EventArgs e)
        {
            InputDigit('4');
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            InputConstant(Constant.Pi);
        }

        private void exponentButton_Click(object sender, EventArgs e)
        {
            Operate(Operation.Power);
        }

        private void plusBbutton_Click(object sender, EventArgs e)
        {
            Operate(Operation.Add);
        }

        private void num9Button_Click(object sender, EventArgs e)
        {
            InputDigit('9');
        }

        private void num8Button_Click(object sender, EventArgs e)
        {
            InputDigit('8');
        }

        private void num7Button_Click(object sender, EventArgs e)
        {
            InputDigit('7');
        }

        private void CalculatorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Shift)
            {
                switch (e.KeyCode)
                {
                    case Keys.D6:
                        Operate(Operation.Power);
                        break;

                    case Keys.D8:
                        Operate(Operation.Times);
                        break;

                    case Keys.Oemplus:
                        Calculate();
                        break;
                }
            }
            else
            {
                switch (e.KeyCode)
                {
                    case Keys.D0:
                    case Keys.NumPad0:
                        InputDigit('0');
                        break;

                    case Keys.D1:
                    case Keys.NumPad1:
                        InputDigit('1');
                        break;

                    case Keys.D2:
                    case Keys.NumPad2:
                        InputDigit('2');
                        break;

                    case Keys.D3:
                    case Keys.NumPad3:
                        InputDigit('3');
                        break;

                    case Keys.D4:
                    case Keys.NumPad4:
                        InputDigit('4');
                        break;

                    case Keys.D5:
                    case Keys.NumPad5:
                        InputDigit('5');
                        break;

                    case Keys.D6:
                    case Keys.NumPad6:
                        InputDigit('6');
                        break;

                    case Keys.D7:
                    case Keys.NumPad7:
                        InputDigit('7');
                        break;

                    case Keys.D8:
                    case Keys.NumPad8:
                        InputDigit('8');
                        break;

                    case Keys.D9:
                    case Keys.NumPad9:
                        InputDigit('9');
                        break;

                    case Keys.Decimal:
                    case Keys.OemPeriod:
                        InputDigit('.');
                        break;

                    case Keys.Oemplus:
                        Operate(Operation.Add);
                        break;
                }

                switch (e.KeyCode)
                {

                    case Keys.Enter:
                        Calculate();
                        break;

                    case Keys.Back:
                    case Keys.Delete:
                        Backspace();
                        break;

                    case Keys.Clear:
                    case Keys.Escape:
                        Clear();
                        break;

                    case Keys.Add:
                        Operate(Operation.Add);
                        break;

                    case Keys.Subtract:
                    case Keys.OemMinus:
                        Operate(Operation.Subtract);
                        break;

                    case Keys.Multiply:
                        Operate(Operation.Times);
                        break;

                    case Keys.Divide:
                    case Keys.OemQuestion:
                        Operate(Operation.Divide);
                        break;

                    case Keys.R:
                        Operate(Operation.Yroot);
                        break;

                    case Keys.L:
                        Operate(Operation.Logn);
                        break;

                    case Keys.N:
                        NegateSign();
                        break;

                    case Keys.P:
                        InputConstant(Constant.Pi);
                        break;

                    case Keys.E:
                        InputConstant(Constant.E);
                        break;

                }

            }

        }

        private void keyboardShortcutsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KeyboardShortcutsForm kbShortcuts = new KeyboardShortcutsForm();
            kbShortcuts.Show();
        }
    }
}
