using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UTF32Writer
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


            byte[] bytesBE = new byte[(codepoints.Length * 4) + 4];

            bytesBE[0] = 0;
            bytesBE[1] = 0;
            bytesBE[2] = 254;
            bytesBE[3] = 255;

            for (int i = 0; i < codepoints.Length; i++)
            {
                bytesBE[(i * 4) + 4] = 0;
                bytesBE[(i * 4) + 5] = (byte)(codepoints[i] / 65536);
                bytesBE[(i * 4) + 6] = (byte)(codepoints[i] / 256);
                bytesBE[(i * 4) + 7] = (byte)codepoints[i];
            }

            File.WriteAllBytes("UTF-32_BE.txt", bytesBE);


            byte[] bytesLE = new byte[(codepoints.Length * 4) + 4];

            bytesLE[0] = 255;
            bytesLE[1] = 254;
            bytesLE[2] = 0;
            bytesLE[3] = 0;

            for (int i = 0; i < codepoints.Length; i++)
            {
                bytesLE[(i * 4) + 4] = (byte)codepoints[i];
                bytesLE[(i * 4) + 5] = (byte)(codepoints[i] / 256);
                bytesLE[(i * 4) + 6] = (byte)(codepoints[i] / 65536);
                bytesLE[(i * 4) + 7] = 0;
            }

            File.WriteAllBytes("UTF-32_LE.txt", bytesLE);

        }
    }
}
