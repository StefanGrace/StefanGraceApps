using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UnicodeWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] codepoints = new ushort[ushort.MaxValue + 1];

            for (int i = 0; i < codepoints.Length; i++)
            {
                codepoints[i] = (ushort)i;
            }


            byte[] bytesBE = new byte[(codepoints.Length * 2) + 2];

            bytesBE[0] = 254;
            bytesBE[1] = 255;

            for (int i = 0; i < codepoints.Length; i++)
            {
                bytesBE[(i * 2) + 2] = (byte)(codepoints[i] / 256);
                bytesBE[(i * 2) + 3] = (byte)codepoints[i];
            }

            File.WriteAllBytes("UCS-2_BE.txt", bytesBE);


            byte[] bytesLE = new byte[(codepoints.Length * 2) + 2];

            bytesLE[0] = 255;
            bytesLE[1] = 254;

            for (int i = 0; i < codepoints.Length; i++)
            {
                bytesLE[(i * 2) + 2] = (byte)codepoints[i];
                bytesLE[(i * 2) + 3] = (byte)(codepoints[i] / 256);
            }

            File.WriteAllBytes("UCS-2_LE.txt", bytesLE);
        }
    }
}
