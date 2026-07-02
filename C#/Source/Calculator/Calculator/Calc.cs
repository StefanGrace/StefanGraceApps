using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Calculator
{
    enum Operation
    {
        None, Add, Subtract, Times, Divide, Power, Yroot, Logn
    }

    enum Constant
    {
        Pi, E
    }

    class Calc
    {
        private int maxDigits;
        private Operation currentOperation = Operation.None;
        private string[] inputs = new string[] { "", "" };
        bool isOutput = false;
        double output = 0;

        public Calc(int maxDigits)
        {
            this.maxDigits = maxDigits;
        }

        public void InputDigit(char digit)
        {
            if (isOutput)
            {
                Clear();
            }

            string allowedDigits = "0123456789.";

            if (!allowedDigits.Contains(digit))
            {
                throw new ArgumentException();
            }

            int currentInput = CurrentInput;

            if (inputs[currentInput].Length < maxDigits - 2)
            {
                // Makes it so that the input can't have multiple dots
                if (digit == '.') 
                {
                    if (inputs[currentInput].Contains('.'))
                    {
                        return;
                    }
                }

                inputs[currentInput] += digit;
            }

            
            

        }

        public void InputConstant(Constant constant)
        {
            if (isOutput)
            {
                Clear();
            }

            double constantValue;

            switch (constant)
            {
                case Constant.Pi:
                    constantValue = Math.PI;
                    break;

                case Constant.E:
                    constantValue = Math.E;
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            inputs[CurrentInput] = constantValue.ToString();
        }

        public void Operate(Operation operation)
        {
            if (isOutput)
            {
                inputs[0] = output.ToString();
                inputs[1] = "";
                isOutput = false;
                output = 0;
            }

            if (inputs[0].Length == 0)
            {
                inputs[0] = "0";
            }

            if (inputs[1].Length == 0)
            {
                currentOperation = operation;
            }
        }

        public void NegateSign()
        {
            if (isOutput)
            {
                Clear();
            }

            int currentInput = CurrentInput;

            if (inputs[currentInput].StartsWith("-"))
            {
                inputs[currentInput] = inputs[currentInput].Replace("-", "");
            }
            else
            {
                inputs[currentInput] = "-" + inputs[currentInput];
            }
        }

        public double Calculate()
        {
            isOutput = true;

            if (inputs[0].Length == 0)
            {
                output = 0;
                return 0;
            }

            double input1 = double.Parse(inputs[0]);
            if (inputs[1].Length == 0)
            {
                output = input1;
                currentOperation = Operation.None;
                return output;
            }

            double input2 = double.Parse(inputs[1]);

            switch (currentOperation)
            {
                case Operation.Add:
                    output = input1 + input2;
                    break;

                case Operation.Subtract:
                    output = input1 - input2;
                    break;

                case Operation.Times:
                    output = input1 * input2;
                    break;

                case Operation.Divide:
                    output = input1 / input2;
                    break;

                case Operation.Power:
                    output = Math.Pow(input1, input2);
                    break;

                case Operation.Yroot:
                    output = Math.Pow(input1, 1 / input2);
                    break;

                case Operation.Logn:
                    output = Math.Log(input1, input2);
                    break;
            }

            

            return output;
        }

        public void Clear()
        {
            inputs[0] = "";
            inputs[1] = "";
            currentOperation = Operation.None;
            isOutput = false;
            output = 0;
        }

        public void Backspace()
        {
            if (isOutput)
            {
                Clear();
            }

            int currentInput = CurrentInput;

            if (inputs[currentInput].Length > 0)
            {
                inputs[currentInput] = inputs[currentInput].Substring(0, inputs[currentInput].Length - 1);
            }
        }

        public string InputLine1
        {
            get
            {
                return inputs[0];
            }
        }

        public string InputLine2
        {
            get
            {
                return inputs[1];
            }
        }

        public Operation CurrentOperation
        {
            get
            {
                return currentOperation;
            }
        }

        public bool IsOutput
        {
            get
            {
                return isOutput;
            }
        }

        public double Output
        {
            get
            {
                return output;
            }
        }

        public int CurrentInput
        {
            get
            {
                return currentOperation == Operation.None ? 0 : 1;
            }
        }

    }
}
