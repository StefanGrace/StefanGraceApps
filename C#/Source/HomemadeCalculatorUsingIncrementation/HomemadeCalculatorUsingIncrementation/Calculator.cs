namespace HomemadeCalculatorUsingIncrementation
{
    class Calculator
    {
        /**
         * Homemade calculator using only subtraction. 
         * Can perform addition, subtraction, multiplication, division (rounds up), power, log (rounds up).
         * Multiplication, division, power and log only work on non-negative integers.
         */

        public int increment(int a)
        {
            a++;
            return a;
        }

        public int decrement(int a)
        {
            a--;
            return a;
        }

        public int add(int a, int b)
        {
            for (int i = 0; i < b; i = increment(i))
            {
                a = increment(a);
            }
            return a;
        }

        public int minus(int a, int b)
        {
            for (int i = b; i > 0; i = decrement(i))
            {
                a = decrement(a);
            }
            return a;
        }
        
        public int multiply(int a, int b)
        {
            int c = 0;
            for (int i = 0; i < b; i = increment(i))
            {
                c = add(c, a);
            }
            return c;
        }

        public int divide(int a, int b)
        {
            int i = 0;
            while (a > 0)
            {
                a = minus(a, b);
                i = increment(i);
            }
            return i;
        }

        public int power(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i = increment(i))
            {
                c = multiply(c, a);
            }
            return c;
        }

        public int log(int a, int b)
        {
            int i = 0;
            while (b > 1)
            {
                b = divide(b, a);
                i = increment(i);
            }
            return i;
        }

        public int tetration(int a, int b)
        {
            int c = 1;
            for (int i = 0; i < b; i = increment(i))
            {
                c = power(a, c);
            }
            return c;
        }

        public int superLog(int a, int b)
        {
            int i = 0;
            while (b > 1)
            {
                b = log(a, b);
                i =  increment(i);
            }
            return i;
        }
    }
}
