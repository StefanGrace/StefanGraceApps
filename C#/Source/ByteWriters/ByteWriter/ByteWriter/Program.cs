using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write all possible bytes values (0-255) to "Bytes.txt"

            byte[] bytes = new byte[256];

            for (int i = 0; i < bytes.Length; i++)
            {
                bytes[i] = (byte)i;
            }

            File.WriteAllBytes("Bytes.txt", bytes);



            // Write all byte values that correspond to a printable ASCI character to "ASCII.txt"

            byte[] ascii = new byte[95];

            for (int i = 0; i < ascii.Length; i++)
            {
                ascii[i] = (byte)(i + 32);
            }

            File.WriteAllBytes("ASCII.txt", ascii);



            // Write all byte values that correspond to a printable character to "Printable_Bytes.txt"

            byte[] printableBytes = new byte[223];

            for (int i = 32; i < 127; i++)
            {
                printableBytes[i - 32] = (byte)i;
            }

            for (int i = 128; i < 256; i++)
            {
                printableBytes[i - 33] = (byte)i;
            }

            File.WriteAllBytes("Printable_Bytes.txt", printableBytes);



            // Write all byte values that correspond to a printable character in ISO 8859 to "Printable_ISO-8859_Bytes.txt"

            byte[] printableBytesISO = new byte[191];

            for (int i = 32; i < 127; i++)
            {
                printableBytesISO[i - 32] = (byte)i;
            }

            for (int i = 160; i < 256; i++)
            {
                printableBytesISO[i - 65] = (byte)i;
            }

            File.WriteAllBytes("Printable_ISO-8859_Bytes.txt", printableBytesISO);
        }
    }
}
