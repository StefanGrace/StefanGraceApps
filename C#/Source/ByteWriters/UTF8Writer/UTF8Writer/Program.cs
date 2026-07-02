using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UTF8Writer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] codepoints = new int[17 * 65536];

            for (int i = 0; i < codepoints.Length; i++)
            {
                codepoints[i] = i;
            }

            List<byte> bytes = new List<byte>();

            foreach (int codepoint in codepoints)
            {
                byte[] codepointBytes = ConvertToUTF8(codepoint);

                foreach (byte codepointByte in codepointBytes)
                {
                    bytes.Add(codepointByte);
                }
            }

            File.WriteAllBytes("UTF-8.txt", bytes.ToArray());


            byte[] bom = ConvertToUTF8(65279);

            bytes.InsertRange(0, bom);
            File.WriteAllBytes("UTF-8_BOM.txt", bytes.ToArray());

        }

        static byte[] ConvertToUTF8(int codepoint)
        {
            if (codepoint < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (codepoint < 128) 
            {
                return new byte[] { (byte)codepoint };
            }
            else if (codepoint < 2048)
            {
                bool[] bitsLE = NumberToBitsLE(codepoint);

                bool[,] utf8Bits = new bool[,]
                {
                    {true, true, false, bitsLE[10], bitsLE[9], bitsLE[8], bitsLE[7], bitsLE[6] },
                    {true, false, bitsLE[5], bitsLE[4], bitsLE[3], bitsLE[2], bitsLE[1], bitsLE[0]},
                };

                return BitsBEToBytes(utf8Bits);
            }
            else if (codepoint < 65_536)
            {
                bool[] bitsLE = NumberToBitsLE(codepoint);

                bool[,] utf8Bits = new bool[,]
                {
                    {true, true, true, false, bitsLE[15], bitsLE[14], bitsLE[13], bitsLE[12] },
                    {true, false, bitsLE[11], bitsLE[10], bitsLE[9], bitsLE[8], bitsLE[7], bitsLE[6]},
                    {true, false, bitsLE[5], bitsLE[4], bitsLE[3], bitsLE[2], bitsLE[1], bitsLE[0]},
                };

                return BitsBEToBytes(utf8Bits);
            }
            else if (codepoint < 2_097_152)
            {
                bool[] bitsLE = NumberToBitsLE(codepoint);

                bool[,] utf8Bits = new bool[,]
                {
                    {true, true, true, true, false, bitsLE[20], bitsLE[19], bitsLE[18] },
                    {true, false, bitsLE[17], bitsLE[16], bitsLE[15], bitsLE[14], bitsLE[13], bitsLE[12]},
                    {true, false, bitsLE[11], bitsLE[10], bitsLE[9], bitsLE[8], bitsLE[7], bitsLE[6]},
                    {true, false, bitsLE[5], bitsLE[4], bitsLE[3], bitsLE[2], bitsLE[1], bitsLE[0]},
                };

                return BitsBEToBytes(utf8Bits);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        static bool[] NumberToBitsLE(int number)
        {
            bool[] bitsLE = new bool[21];

            for (int i = 0; i < 21; i++)
            {
                bitsLE[i] = (int)((number % Math.Pow(2, i + 1)) / Math.Pow(2, i)) == 1;
            }

            return bitsLE;
        }

        static byte[] BitsBEToBytes(bool[,] bitsBE)
        {
            byte[] bytes = new byte[bitsBE.GetLength(0)];

            for (int i = 0; i < bitsBE.GetLength(0); i++)
            {
                byte currentByte = 0;

                for (int j = 0; j < 8; j++)
                {
                    currentByte += (byte)((bitsBE[i, j] ? 1 : 0) * Math.Pow(2, 7 - j));
                }

                bytes[i] = currentByte;
            }

            return bytes;
        }
    }
}
