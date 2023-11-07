// Program.cs
// Stefan Grace
// Created: 2018-11-17
// Modified: 2018-11-17
// This program finds the smallest number to contain all factors upto a given number


using System;

namespace SmallestNumberToContainAllFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFinder nf = new NumberFinder();
            while (true)
            {
                try
                {
                    Console.WriteLine(nf.getNumber(int.Parse(Console.ReadLine())));
                }
                catch
                {
                    Console.WriteLine("Input Error!");
                } 
            } 
        }
    }

    class NumberFinder
    {
        public int getNumber(int input)
        {
            bool hasAllFactors = false;
            double i = 0;
            while (!hasAllFactors)
            {
                i++;
                hasAllFactors = true;
                for (double j = input; j > 0; j--)
                {
                    double test = (i / j) % 1d;
                    
                    if ((i / j) % 1 != 0)
                    {
                        hasAllFactors = false;
                    }
                }   
            }
            return Convert.ToInt32(i);
        }
    }
}
