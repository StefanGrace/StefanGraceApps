class NumberFinder
{
    public double getNumber(int input)
    {
        boolean hasAllFactors = false;
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
        return i;
    }
}