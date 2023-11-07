namespace NumberToSevenSegment
{
    class Converter
    {

        public string digitToSevenSegment(int digit)
        {
            bool[] digitBinary = digitToBinary(digit);
            bool[] segmentBinary = binaryToSevenSegment(digitBinary);
            string outputDisplay = display(segmentBinary);
            return outputDisplay;
        }

        public bool[] digitToBinary(int digit)
        {
            bool[] bits = new bool[4];
            bits[0] = (digit - (digit % 8)) > 0;
            bits[1] = ((digit - (digit % 4)) % 8) > 0;
            bits[2] = ((digit - (digit % 2)) % 4) > 0;
            bits[3] = (digit % 2) > 0;
            return bits;
        }


        public bool[] binaryToSevenSegment(bool[] digitBinary)
        {
            bool a = digitBinary[0];
            bool b = digitBinary[1];
            bool c = digitBinary[2];
            bool d = digitBinary[3];
            bool[] sevenSegmentBinary = new bool[7];
            sevenSegmentBinary[0] = (!b && !c && !d) || (!a && b && c) || (a && !b && !c);
            sevenSegmentBinary[1] = (!b && !c && d) || (!a && c && d) || (!c & !d) || (!a && !b);
            sevenSegmentBinary[2] = (!a && b) || (!a && !b && d) || (!c);
            sevenSegmentBinary[3] = (!a && b && !c && d) || (!a && !b && c) || (!b && c && !d) || (a && !b && !c) || (!b && !c && !d);
            sevenSegmentBinary[4] = (!b && !c && !d) || (!a && c & !d);
            sevenSegmentBinary[5] = (!b && b && c && !d) || (a && !b && !c) || (!c && !d) || (!a && b && !c);
            sevenSegmentBinary[6] = (!a && !b && c) || (!a && c && !d) || (!a && b && !c) || (a && !b && !c);
            return sevenSegmentBinary;
        }


        public string display(bool[] segmentBinary)
        {
            string[] onSegments = { "---", "|", "|", "---", "|", "|", "---" };
            string[] offSegments = { "   ", " ", " ", "   ", " ", " ", "   " };
            string[] outputSegments = new string[7];

            for (int i = 0; i < segmentBinary.Length; i++)
            {
                if (segmentBinary[i])
                {
                    outputSegments[i] = onSegments[i];
                }
                else
                {
                    outputSegments[i] = offSegments[i];
                }
            }

            string outputDisplay = " " + outputSegments[0] + " \n" +
                outputSegments[5] + "   " + outputSegments[1] + "\n" +
                " " + outputSegments[6] + " \n" +
                outputSegments[4] + "   " + outputSegments[2] + "\n" +
                " " + outputSegments[3] + " \n";

            return outputDisplay;
        }
    }
}
