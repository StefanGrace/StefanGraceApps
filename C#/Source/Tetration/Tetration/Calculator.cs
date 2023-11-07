using System;

namespace Tetration
{
    class Calculator
    {
        public double tetrationLeft(double a, double b)
        {
            double c = a;
            for (double i = 1; i < b; i++)
            {
                c = Math.Pow(c, a);
            }
            return c;
        }

        public double tetrationRight(double a, double b)
        {
            double c = 1;
            for (double i = 0; i < b; i++)
            {
                c = Math.Pow(a, c);
            }
            return c;
        }

        public double pentationLeft(double a, double b)
        {
            double c = a;
            for (double i = 1; i < b; i++)
            {
                c = tetrationLeft(c, a);
            }
            return c;
        }

        public double pentationRight(double a, double b)
        {
            double c = 1;
            for (double i = 0; i < b; i++)
            {
                c = tetrationRight(a, c);
            }
            return c;
        }

        public double hexationLeft(double a, double b)
        {
            double c = a;
            for (double i = 1; i < b; i++)
            {
                c = pentationLeft(c, a);
            }
            return c;
        }

        public double hexationRight(double a, double b)
        {
            double c = 1;
            for (double i = 0; i < b; i++)
            {
                c = pentationRight(a, c);
            }
            return c;
        }

        public double tetrationLog(double a, double b)
        {
            double i = 0;
            while (b > 1)
            {
                b = Math.Log(b, a);
                i++;
            }
            return i;
        }

        public double pentationLog(double a, double b)
        {
            double i = 0;
            while (b > 1)
            {
                b = tetrationLog(a, b);
                i++;
            }
            return i;
        }

        public double hexationLog(double a, double b)
        {
            double i = 0;
            while (b > 1)
            {
                b = pentationLog(a, b);
                i++;
            }
            return i;
        }
    }
    
}
