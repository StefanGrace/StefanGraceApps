using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FourteenSegmentDisplay
{
    class Display
    {
        private const int numDigits = 10;

        private CanvasHandler canvas;

        private SolidBrush background = new SolidBrush(Color.FromArgb(0, 64, 0));
        private SolidBrush inactiveDigit = new SolidBrush(Color.FromArgb(0, 78, 0));
        private SolidBrush activeDigit = new SolidBrush(Color.FromArgb(0, 255, 0));

        private Point[][] fourteenSegmentDisplayPoints = new Point[14][];

        private string align = "left";

        private string lastText = "";

        public Display(CanvasHandler canvas)
        {
            this.canvas = canvas;

            fourteenSegmentDisplayPoints[0] = new Point[4]
            {new Point(0, 0), new Point(36, 0), new Point(32, 4), new Point(4, 4)};
            fourteenSegmentDisplayPoints[1] = new Point[4]
            {new Point(0, 2), new Point(4, 6), new Point(4, 32), new Point(0, 36)};
            fourteenSegmentDisplayPoints[2] = new Point[4]
            {new Point(6, 10), new Point(9, 6), new Point(13, 28), new Point(10, 32)};
            fourteenSegmentDisplayPoints[3] = new Point[4]
            {new Point(16, 6), new Point(20, 6), new Point(20, 34), new Point(16, 34)};
            fourteenSegmentDisplayPoints[4] = new Point[4]
            {new Point(30, 10), new Point(27, 6), new Point(23, 28), new Point(26, 32)};
            fourteenSegmentDisplayPoints[5] = new Point[4]
            {new Point(36, 2), new Point(32, 6), new Point(32, 32), new Point(36, 36)};
            fourteenSegmentDisplayPoints[6] = new Point[5]
            {new Point(0, 38), new Point(4, 36), new Point(17, 36), new Point(17, 40), new Point(4, 40)};
            fourteenSegmentDisplayPoints[7] = new Point[5]
            {new Point(19, 36), new Point(32, 36), new Point(36, 38), new Point(32, 40), new Point(19, 40)};
            fourteenSegmentDisplayPoints[8] = new Point[4]
            {new Point(0, 40), new Point(4, 44), new Point(4, 70), new Point(0, 74)};
            fourteenSegmentDisplayPoints[9] = new Point[4]
            {new Point(6, 66), new Point(9, 70), new Point(13, 48), new Point(10, 44)};
            fourteenSegmentDisplayPoints[10] = new Point[4]
            {new Point(16, 42), new Point(20, 42), new Point(20, 70), new Point(16, 70)};
            fourteenSegmentDisplayPoints[11] = new Point[4]
            {new Point(30, 66), new Point(27, 70), new Point(23, 48), new Point(26, 44)};
            fourteenSegmentDisplayPoints[12] = new Point[4]
            {new Point(36, 40), new Point(32, 44), new Point(32, 70), new Point(36, 74)};
            fourteenSegmentDisplayPoints[13] = new Point[4]
            {new Point(0, 76), new Point(36, 76), new Point(32, 72), new Point(4, 72)};
        }

        public void Update(string text)
        {
            lastText = text;

            text = text.ToUpper();

            if (text.Length > numDigits)
            {
                text = text.Substring(0, numDigits);
            }

            switch (align)
            {
                case "left":
                    text = text.PadRight(numDigits, ' ');
                    break;

                case "center-left":
                case "center-right":
                    int blankDigits = numDigits - text.Length;
                    int leftSpaces = align == "center-left" ? (int)Math.Floor((double)blankDigits / 2) : (int)Math.Ceiling((double)blankDigits / 2);
                    int rightSpaces = align == "center-left" ? (int)Math.Ceiling((double)blankDigits / 2) : (int)Math.Floor((double)blankDigits / 2);
                    text = new string(' ', leftSpaces) + text + new string(' ', rightSpaces);
                    break;

                case "right":
                    text = text.PadLeft(numDigits, ' ');
                    break;
            }

            for (int i = 0; i < numDigits; i++)
            {
                DrawLetter(text[i], 12 + (i * 50), 12);
            }
        }

        public void SetColor(SolidBrush background, SolidBrush inactiveDigit, SolidBrush activeDigit)
        {
            this.background = background;
            this.inactiveDigit = inactiveDigit;
            this.activeDigit = activeDigit;
            canvas.Canvas.FillRectangle(background, 0, 0, 512, 100);
            Update(lastText);
        }

        public String Align
        {
            set
            {
                align = value;
                Update(lastText);
            }
        }

        private void DrawLetter(char character, int x, int y)
        {
            bool[] segments = CharTo14Segment(character);
            for (byte i = 0; i < 14; i++)
            {
                byte[] pointTypes = new byte[fourteenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < pointTypes.Length; j++)
                {
                    pointTypes[j] = 1;
                }

                Brush digitColor = segments[i] ? activeDigit : inactiveDigit;

                Point[] points = new Point[fourteenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < fourteenSegmentDisplayPoints[i].Length; j++)
                {
                    points[j] = new Point(fourteenSegmentDisplayPoints[i][j].X, fourteenSegmentDisplayPoints[i][j].Y);
                    points[j].Offset(x, y);
                }
                canvas.Canvas.FillPath(digitColor, new GraphicsPath(points, pointTypes));
            }
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

                case '0':
                    return new bool[14] { true, true, false, false, true, true, false, false, true, true, false, false, true, true };
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
