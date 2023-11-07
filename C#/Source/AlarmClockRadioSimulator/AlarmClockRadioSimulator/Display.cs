using System.Drawing;
using System.Drawing.Drawing2D;

namespace AlarmClockRadioSimulator
{
    class Display
    {
        private CanvasHandler canvas;

        private SolidBrush background = new SolidBrush(Color.FromArgb(0, 64, 0));
        private SolidBrush inactiveDigit = new SolidBrush(Color.FromArgb(0, 78, 0));
        private SolidBrush activeDigit = new SolidBrush(Color.FromArgb(0, 255, 0));
        private Point[][] sevenSegmentDisplayPoints = new Point[7][];
        private Point[][] smallSevenSegmentDisplayPoints = new Point[7][];
        private Point[][] fourteenSegmentDisplayPoints = new Point[14][];

        public Display(CanvasHandler canvas)
        {
            this.canvas = canvas;

            sevenSegmentDisplayPoints[0] = new Point[6]
            {new Point(4, 8), new Point(20, 0), new Point(68, 0), new Point(84, 8), new Point(68, 16), new Point(20, 16) };
            sevenSegmentDisplayPoints[1] = new Point[4]
            {new Point(0, 10), new Point(12, 18), new Point(12, 66), new Point(0, 74)};
            sevenSegmentDisplayPoints[2] = new Point[4]
            {new Point(86, 10), new Point(74, 18), new Point(74, 66), new Point(86, 74)};
            sevenSegmentDisplayPoints[3] = new Point[6]
            {new Point(4, 76), new Point(20, 68), new Point(68, 68), new Point(84, 76), new Point(68, 84), new Point(20, 84) };
            sevenSegmentDisplayPoints[4] = new Point[4]
            {new Point(0, 78), new Point(12, 86), new Point(12, 134), new Point(0, 142)};
            sevenSegmentDisplayPoints[5] = new Point[4]
            {new Point(86, 78), new Point(74, 86), new Point(74, 134), new Point(86, 142)};
            sevenSegmentDisplayPoints[6] = new Point[6]
            {new Point(4, 144), new Point(20, 136), new Point(68, 136), new Point(84, 144), new Point(68, 152), new Point(20, 152) };

            smallSevenSegmentDisplayPoints[0] = new Point[4]
            {new Point(0, 0), new Point(36, 0), new Point(32, 4), new Point(4, 4)};
            smallSevenSegmentDisplayPoints[1] = new Point[4]
            {new Point(0, 2), new Point(4, 6), new Point(4, 32), new Point(0, 36)};
            smallSevenSegmentDisplayPoints[2] = new Point[4]
            {new Point(36, 2), new Point(32, 6), new Point(32, 32), new Point(36, 36)};
            smallSevenSegmentDisplayPoints[3] = new Point[6]
            {new Point(0, 38), new Point(4, 36), new Point(32, 36), new Point(36, 38), new Point(32, 40), new Point(4, 40)};
            smallSevenSegmentDisplayPoints[4] = new Point[4]
            {new Point(0, 40), new Point(4, 44), new Point(4, 70), new Point(0, 74)};
            smallSevenSegmentDisplayPoints[5] = new Point[4]
            {new Point(36, 40), new Point(32, 44), new Point(32, 70), new Point(36, 74)};
            smallSevenSegmentDisplayPoints[6] = new Point[4]
            {new Point(0, 76), new Point(36, 76), new Point(32, 72), new Point(4, 72)};

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

        public void drawBackground()
        {
            canvas.Canvas.FillRectangle(background, 0, 0, 840, 256);
        }

        public void update(string bigNumbers, string smallNumbers, string letters, bool bigColon, bool bigDot, bool smallColon, bool smallDot,
            bool al1, bool al2, bool ac, bool fmr, bool amr, bool usb, bool pm)
        {
            drawDot(304, 94, bigColon);
            drawDot(304, 180, bigColon);
            drawDot(466, 200, bigDot);
            drawDot(714, 86, smallColon, true);
            drawDot(714, 110, smallColon, true);
            drawDot(714, 130, smallDot, true);

            drawDot(12, 12, al1);
            drawDot(144, 12, al2);
            drawDot(276, 12, ac);
            drawDot(408, 12, fmr);
            drawDot(540, 12, amr);
            drawDot(672, 12, usb);
            drawDot(804, 12, pm);

            bigNumbers = bigNumbers.ToUpper().PadLeft(4, ' ');
            drawBigNumber(bigNumbers[0], 56, 64);
            drawBigNumber(bigNumbers[1], 182, 64);
            drawBigNumber(bigNumbers[2], 370, 64);
            drawBigNumber(bigNumbers[3], 496, 64);

            smallNumbers = smallNumbers.ToUpper().PadRight(2, ' ');
            drawSmallNumber(smallNumbers[0], 620, 160);
            drawSmallNumber(smallNumbers[1], 670, 160);

            letters = letters.ToUpper().PadRight(4, ' ');
            drawLetter(letters[0], 620, 64);
            drawLetter(letters[1], 670, 64);
            drawLetter(letters[2], 734, 64);
            drawLetter(letters[3], 784, 64);
        }

        public void setBrightness(int brightness)
        {
            activeDigit = new SolidBrush(Color.FromArgb(0, 95 + (brightness * 16), 0));
        }

        private void drawDot(int x, int y, bool on)
        {
            drawDot(x, y, on, false);
        }

        private void drawDot(int x, int y, bool on, bool small)
        {
            Brush dotColor;
            if (on)
            {
                dotColor = activeDigit;
            }
            else
            {
                dotColor = inactiveDigit;
            }
            if (small)
            {
                canvas.Canvas.FillEllipse(dotColor, new Rectangle(x, y, 12, 12));
            }
            else
            {
                canvas.Canvas.FillEllipse(dotColor, new Rectangle(x, y, 24, 24));
            }
            
        }

        private void drawBigNumber(char character, int x, int y)
        {
            bool[] segments = charTo7Segment(character);
            for (byte i = 0; i < 7; i++)
            {
                byte[] pointTypes = new byte[sevenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < pointTypes.Length; j++)
                {
                    pointTypes[j] = 1;
                }
                Brush digitColor;
                if (segments[i])
                {
                    digitColor = activeDigit;
                }
                else
                {
                    digitColor = inactiveDigit;
                }
                Point[] points = new Point[sevenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < sevenSegmentDisplayPoints[i].Length; j++)
                {
                    points[j] = new Point(sevenSegmentDisplayPoints[i][j].X, sevenSegmentDisplayPoints[i][j].Y);
                    points[j].Offset(x, y);
                }
                canvas.Canvas.FillPath(digitColor, new GraphicsPath(points, pointTypes));
            }
        }

        private void drawSmallNumber(char character, int x, int y)
        {
            bool[] segments = charTo7Segment(character);
            for (byte i = 0; i < 7; i++)
            {
                byte[] pointTypes = new byte[smallSevenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < pointTypes.Length; j++)
                {
                    pointTypes[j] = 1;
                }
                Brush digitColor;
                if (segments[i])
                {
                    digitColor = activeDigit;
                }
                else
                {
                    digitColor = inactiveDigit;
                }
                Point[] points = new Point[smallSevenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < smallSevenSegmentDisplayPoints[i].Length; j++)
                {
                    points[j] = new Point(smallSevenSegmentDisplayPoints[i][j].X, smallSevenSegmentDisplayPoints[i][j].Y);
                    points[j].Offset(x, y);
                }
                canvas.Canvas.FillPath(digitColor, new GraphicsPath(points, pointTypes));
            }
        }

        private void drawLetter(char character, int x, int y)
        {
            bool[] segments = charTo14Segment(character);
            for (byte i = 0; i < 14; i++)
            {
                byte[] pointTypes = new byte[fourteenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < pointTypes.Length; j++)
                {
                    pointTypes[j] = 1;
                }
                Brush digitColor;
                if (segments[i])
                {
                    digitColor = activeDigit;
                }
                else
                {
                    digitColor = inactiveDigit;
                }
                Point[] points = new Point[fourteenSegmentDisplayPoints[i].Length];
                for (byte j = 0; j < fourteenSegmentDisplayPoints[i].Length; j++)
                {
                    points[j] = new Point(fourteenSegmentDisplayPoints[i][j].X, fourteenSegmentDisplayPoints[i][j].Y);
                    points[j].Offset(x, y);
                }
                canvas.Canvas.FillPath(digitColor, new GraphicsPath(points, pointTypes));
            }
        }

        private bool[] charTo7Segment(char character)
        {
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
                case '<':
                    return new bool[7] { false, false, false, false, true, false, false };
                case '>':
                    return new bool[7] { false, false, false, false, false, true, false };
                case '[':
                    return new bool[7] { false, true, false, false, false, false, false };
                case ']':
                    return new bool[7] { false, false, true, false, false, false, false };
                case '^':
                    return new bool[7] { true, false, false, false, false, false, false };
                default:
                    return new bool[7] { false, false, false, false, false, false, false };
            }
        }

        private bool[] charTo14Segment(char character)
        {
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
                    bool[] bools = charTo7Segment(character);
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
                case '%':
                    return new bool[14] { false, true, false, false, true, false, false, false, false, true, false, false, true, false };
                default:
                    return new bool[14] { false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            }
        }
    }
}
