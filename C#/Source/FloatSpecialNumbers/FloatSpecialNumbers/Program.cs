using System;

namespace FloatSpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            float one = 1;
            float zero = 0;
            float minusOne = -1;
            float ten = 10;

            float infinity = one / zero;
            float minusInfinity = minusOne / zero;


            Console.Write("1 / 0 = ");
            Console.WriteLine(one / zero);

            Console.Write("-1 / 0 = ");
            Console.WriteLine(minusOne / zero);

            Console.Write("0 / 0 = ");
            Console.WriteLine(zero / zero);

            Console.Write("sqrt(-1) = ");
            Console.WriteLine(Math.Sqrt(minusOne));

            Console.Write("infinity + 1 = ");
            Console.WriteLine(infinity + one);

            Console.Write("infinity - 1 = ");
            Console.WriteLine(infinity - one);

            Console.Write("-infinity + 1 = ");
            Console.WriteLine(minusInfinity + one);           

            Console.Write("-infinity - 1 = ");
            Console.WriteLine(minusInfinity - one);

            Console.Write("1 - infinity = ");
            Console.WriteLine(one - infinity);           

            Console.Write("1 / infinity = ");
            Console.WriteLine(one / infinity);           

            Console.Write("1 / -infinity = ");
            Console.WriteLine(one / minusInfinity);        

            Console.Write("infinity + -infinity = ");
            Console.WriteLine(infinity + minusInfinity);
           
            Console.Write("infinity / 0 = ");
            Console.WriteLine(infinity / zero);

            Console.Write("infinity * 0 = ");
            Console.WriteLine(infinity * zero);

            Console.Write("infinity / 10 = ");
            Console.WriteLine(infinity / ten);

            Console.Write("sqrt(infinity) = ");
            Console.WriteLine(Math.Sqrt(infinity));

            Console.Write("infinity / infinity = ");
            Console.WriteLine(infinity / infinity);

            Console.Write("infinity - infinity = ");
            Console.WriteLine(infinity - infinity);

            Console.Write("infinity * infinity = ");
            Console.WriteLine(infinity * infinity);

            Console.Write("infinity + infinity = ");
            Console.WriteLine(infinity + infinity);

            Console.Write("log10(0) = ");
            Console.WriteLine(Math.Log10(zero));

            Console.Write("log10(infinity) = ");
            Console.WriteLine(Math.Log10(infinity));

            Console.Write("log10(-1) = ");
            Console.WriteLine(Math.Log10(minusOne));

            Console.Write("log10(-infinity) = ");
            Console.WriteLine(Math.Log10(minusInfinity));

            Console.Write("1 ^ -infinity = ");
            Console.WriteLine(Math.Pow(one, minusInfinity));

            Console.Write("10 ^ -infinity = ");
            Console.WriteLine(Math.Pow(ten, minusInfinity));

            Console.Write("1 ^ infinity = ");
            Console.WriteLine(Math.Pow(one, infinity));

            Console.Write("10 ^ infinity = ");
            Console.WriteLine(Math.Pow(ten, infinity));

            Console.ReadLine();
        }
    }
}
