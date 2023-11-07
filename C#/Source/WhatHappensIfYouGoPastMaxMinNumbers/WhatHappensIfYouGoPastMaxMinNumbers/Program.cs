// What happens if you go past the highest and lowest numbers?

using System;

namespace WhatHappensIfYouGoPastMaxMinNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What happens if you go past the highest and lowest numbers?");
            Console.WriteLine();

            Console.Write("Highest signed 8-bit integer: ");
            sbyte maxS8i = sbyte.MaxValue;
            maxS8i++;
            Console.WriteLine(maxS8i);

            Console.Write("Highest unsigned 8-bit integer: ");
            byte maxU8i = byte.MaxValue;
            maxU8i++;
            Console.WriteLine(maxU8i);

            Console.Write("Highest signed 16-bit integer: ");
            short maxS16i = short.MaxValue;
            maxS16i++;
            Console.WriteLine(maxS16i);

            Console.Write("Highest unsigned 16-bit integer: ");
            ushort maxU16i = ushort.MaxValue;
            maxU16i++;
            Console.WriteLine(maxU16i);

            Console.Write("Highest signed 32-bit integer: ");
            int maxS32i = int.MaxValue;
            maxS32i++;
            Console.WriteLine(maxS32i);

            Console.Write("Highest unsigned 32-bit integer: ");
            uint maxU32i = uint.MaxValue;
            maxU32i++;
            Console.WriteLine(maxU32i);

            Console.Write("Highest signed 64-bit integer: ");
            long maxS64i = long.MaxValue;
            maxS64i++;
            Console.WriteLine(maxS64i);

            Console.Write("Highest unsigned 64-bit integer: ");
            ulong maxU64i = ulong.MaxValue;
            maxU64i++;
            Console.WriteLine(maxU64i);

            Console.Write("Highest 32-bit float: ");
            float max32f = float.MaxValue;
            max32f *= 1.1f;
            Console.WriteLine(max32f);

            Console.Write("Highest 64-bit float: ");
            double max64f = double.MaxValue;
            max64f *= 1.1;
            Console.WriteLine(max64f);

            Console.Write("Highest decimal: ");
            decimal maxDec = decimal.MaxValue;
            try
            {
                maxDec++;
                Console.WriteLine(maxDec);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            

            Console.Write("Lowest positive 32-bit float: ");
            float min32f = 1;
            while (true)
            {
                float div = min32f / 2;
                if (div > 0)
                {
                    min32f = div;
                }
                else
                {
                    break;
                }
            }
            min32f /= 2f;
            Console.WriteLine(min32f);

            Console.Write("Lowest positive 64-bit float: ");
            double min64f = 1;
            while (true)
            {
                double div = min64f / 2;
                if (div > 0)
                {
                    min64f = div;
                }
                else
                {
                    break;
                }
            }
            min64f /= 2;
            Console.WriteLine(min64f);

            Console.Write("Lowest positive decimal: ");
            decimal minDec = 1;
            while (true)
            {
                decimal div = minDec / 2;
                if (div > 0)
                {
                    minDec = div;
                }
                else
                {
                    break;
                }
            }
            minDec /= 2;
            Console.WriteLine(minDec);


            Console.Read();
        }
    }
}
