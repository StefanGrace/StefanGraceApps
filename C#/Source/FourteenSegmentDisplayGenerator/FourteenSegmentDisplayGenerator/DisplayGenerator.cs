namespace FourteenSegmentDisplayGenerator
{
    class DisplayGenerator
    {
        public string GenerateDisplay(char character)
        {
            string[] segments = new string[14];
            segments[0] = "---";
            segments[1] = "|";
            segments[2] = "\\";
            segments[3] = "|";
            segments[4] = "/";
            segments[5] = "|";
            segments[6] = "-";
            segments[7] = "-";
            segments[8] = "|";
            segments[9] = "/";
            segments[10] = "|";
            segments[11] = "\\";
            segments[12] = "|";
            segments[13] = "---";

            bool[] displaySegments = CharTo14Segment(character);

            for (int i = 0; i < 14; i++)
            {
                if (!displaySegments[i])
                {
                    segments[i] = MakeSpaces(segments[i].Length);
                }
            }

            return " " + segments[0] + " \n" + 
                segments[1] + segments[2] + segments[3] + segments[4] + segments[5] + "\n" +
                " " + segments[6] + " " + segments[7] + " \n" +
                segments[8] + segments[9] + segments[10] + segments[11] + segments[12] + "\n" +
                " " + segments[13] + " ";
        }

        private string MakeSpaces(int length)
        {
            string spaces = "";
            for (int i = 0; i < length; i++)
            {
                spaces += " ";
            }
            return spaces;
        }

        private bool[] CharTo7Segment(char character)
        {
            character = character.ToString().ToUpper()[0];

            switch (character)
            {
                case '0':
                    return new bool[7] { true, true, true, false, true, true, true };
                case '1':
                    return new bool[7] { false, false, true, false, false, true, false };
                case '2':
                    return new bool[7] { true, false, true, true, true, false, true };
                case '3':
                    return new bool[7] { true, false, true, true, false, true, true };
                case '4':
                    return new bool[7] { false, true, true, true, false, true, false };
                case '5':
                    return new bool[7] { true, true, false, true, false, true, true };
                case '6':
                    return new bool[7] { true, true, false, true, true, true, true };
                case '7':
                    return new bool[7] { true, false, true, false, false, true, false };
                case '8':
                    return new bool[7] { true, true, true, true, true, true, true };
                case '9':
                    return new bool[7] { true, true, true, true, false, true, true };
                case 'A':
                    return new bool[7] { true, true, true, true, true, true, false };
                case 'C':
                    return new bool[7] { true, true, false, false, true, false, true };
                case 'D':
                    return new bool[7] { false, false, true, true, true, true, true };
                case 'E':
                    return new bool[7] { true, true, false, true, true, false, true };
                case 'F':
                    return new bool[7] { true, true, false, true, true, false, false };
                case 'H':
                    return new bool[7] { false, true, true, true, true, true, false };
                case 'I':
                    return new bool[7] { false, false, true, false, false, true, false };
                case 'J':
                    return new bool[7] { false, false, true, false, false, true, true };
                case 'L':
                    return new bool[7] { false, true, false, false, true, false, true };
                case 'N':
                    return new bool[7] { false, false, false, true, true, true, false };
                case 'O':
                    return new bool[7] { false, false, false, true, true, true, true };
                case 'P':
                    return new bool[7] { true, true, true, true, true, false, false };
                case 'S':
                    return new bool[7] { true, true, false, true, false, true, true };
                case 'U':
                    return new bool[7] { false, true, true, false, true, true, true };
                case '-':
                    return new bool[7] { false, false, false, true, false, false, false };
                case '_':
                    return new bool[7] { false, false, false, false, false, false, true };
                case '[':
                    return new bool[7] { true, true, false, false, true, false, true };
                case ']':
                    return new bool[7] { true, false, true, false, false, true, true };
                case '=':
                    return new bool[7] { false, false, false, true, false, false, true };
                default:
                    return new bool[7] { false, false, false, false, false, false, false };
            }
        }

        private bool[] CharTo14Segment(char character)
        {
            character = character.ToString().ToUpper()[0];

            switch (character)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case 'A':
                case 'C':
                case 'E':
                case 'F':
                case 'H':
                case 'J':
                case 'L':
                case 'P':
                case 'S':
                case 'U':
                case '-':
                case '_':
                case '[':
                case ']':
                case '=':
                    bool[] bools = CharTo7Segment(character);
                    return new bool[14] { bools[0], bools[1], false, false, false, bools[2], bools[3], bools[3], bools[4], false, false, false, bools[5], bools[6] };
                case 'B':
                    return new bool[14] { true, false, false, true, false, true, true, true, false, false, true, false, true, true };
                case 'D':
                    return new bool[14] { true, false, false, true, false, true, false, false, false, false, true, false, true, true };
                case 'G':
                    return new bool[14] { true, true, false, false, false, false, false, true, true, false, false, false, true, true };
                case 'I':
                    return new bool[14] { true, false, false, true, false, false, false, false, false, false, true, false, false, true };
                case 'K':
                    return new bool[14] { false, true, false, false, true, false, true, false, true, false, false, true, false, false };
                case 'M':
                    return new bool[14] { false, true, true, false, true, true, false, false, true, false, false, false, true, false };
                case 'N':
                    return new bool[14] { false, true, true, false, false, true, false, false, true, false, false, true, true, false };
                case 'O':
                    return new bool[14] { true, true, false, false, false, true, false, false, true, false, false, false, true, true };
                case 'Q':
                    return new bool[14] { true, true, false, false, false, true, false, false, true, false, false, true, true, true };
                case 'R':
                    return new bool[14] { true, true, false, false, false, true, true, true, true, false, false, true, false, false };
                case 'T':
                    return new bool[14] { true, false, false, true, false, false, false, false, false, false, true, false, false, false };
                case 'V':
                    return new bool[14] { false, true, false, false, true, false, false, false, true, true, false, false, false, false };
                case 'W':
                    return new bool[14] { false, true, false, false, false, true, false, false, true, true, false, true, true, false };
                case 'X':
                    return new bool[14] { false, false, true, false, true, false, false, false, false, true, false, true, false, false };
                case 'Y':
                    return new bool[14] { false, false, true, false, true, false, false, false, false, false, true, false, false, false };
                case 'Z':
                    return new bool[14] { true, false, false, false, true, false, false, false, false, true, false, false, false, true };
                case '"':
                    return new bool[14] { false, false, false, true, false, true, false, false, false, false, false, false, false, false };
                case '#':
                    return new bool[14] { false, false, false, true, false, true, true, true, false, false, true, false, true, true };
                case '$':
                    return new bool[14] { true, true, false, true, false, false, true, true, false, false, true, false, true, true };
                case '%':
                    return new bool[14] { false, true, false, false, true, false, false, false, false, true, false, false, true, false };
                case '&':
                    return new bool[14] { true, false, true, false, true, false, false, false, false, true, false, true, true, true };
                case '\'':
                    return new bool[14] { false, false, false, false, false, true, false, false, false, false, false, false, false, false };
                case '<':
                case '(':
                    return new bool[14] { false, false, false, false, true, false, false, false, false, false, false, true, false, false };
                case '>':
                case ')':
                    return new bool[14] { false, false, true, false, false, false, false, false, false, true, false, false, false, false };
                case '*':
                    return new bool[14] { false, false, true, true, true, false, true, true, false, true, true, true, false, false };
                case '+':
                    return new bool[14] { false, false, false, true, false, false, true, true, false, false, true, false, false, false };
                case ',':
                    return new bool[14] { false, false, false, false, false, false, false, false, false, false, true, false, false, false };
                case '/':
                    return new bool[14] { false, false, false, false, true, false, false, false, false, true, false, false, false, false };
                case '\\':
                    return new bool[14] { false, false, true, false, false, false, false, false, false, false, false, true, false, false };
                case '|':
                    return new bool[14] { false, false, false, true, false, false, false, false, false, false, true, false, false, false };
                case '`':
                    return new bool[14] { false, false, true, false, false, false, false, false, false, false, false, false, false, false };
                case '^':
                    return new bool[14] { false, false, false, false, false, false, false, false, false, true, false, true, false, false };
                case '?':
                    return new bool[14] { true, false, false, false, false, true, false, true, false, false, true, false, false, false };
                case '@':
                    return new bool[14] { true, true, false, false, false, true, false, true, true, false, false, false, false, true };
                case '{':
                    return new bool[14] { true, false, true, false, false, false, false, false, false, true, false, false, false, true };
                case '}':
                    return new bool[14] { true, false, false, false, true, false, false, false, false, false, false, true, false, true };
                case ' ':
                    return new bool[14] { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
                default:
                    return new bool[14] { true, true, true, true, true, true, true, true, true, true, true, true, true, true };
            }
        }
    }
}
