class NumberFinder
{
    public long getNumber(int input)
    {
        boolean hasAllFactors = false;
        long i = 0;
        while (!hasAllFactors)
        {
            i++;
            if (i == Long.MAX_VALUE)
            {
                throw new ArithmeticException();
            }
            hasAllFactors = true;
            for (int j = input; j > 0; j--)
            {
                if (i % j != 0)
                {
                    hasAllFactors = false;
                }
            }   
        }
        return i;
    }
}