namespace LookAndSay
{
    class SequenceGenerator
    {
        public string[] GenerateSequence(string start, int iterations)
        {
            if (start.Length == 0)
            {
                throw new StartEmptyException();
            }
            if (iterations < 1)
            {
                throw new IterationsNotPositiveException();
            }

            string[] output = new string[iterations];
            output[0] = start;
            for (int i = 1; i < iterations; i++)
            {
                output[i] = GenerateElement(output[i - 1]);
            }
            return output;
        }

        private string GenerateElement(string input)
        {
            byte sameCharCount = 0;
            char lastChar = input[0];
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == lastChar)
                {
                    sameCharCount++;
                }
                else
                {
                    output += sameCharCount + lastChar.ToString();
                    sameCharCount = 1;
                    lastChar = input[i];
                }
            }
            output += sameCharCount + input[input.Length - 1].ToString();
            return output;
        }
    }
}
