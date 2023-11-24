import java.text.DecimalFormat;

class SumArgs 
{
    public static void main(String[] args)
    {
        try 
        {
            double sum = 0;
            for (int i = 0; i < args.length; i++)
            {
                sum += Double.parseDouble(args[i].replace(",",""));
            }
            DecimalFormat formatter = new DecimalFormat("#,###.#");
            System.out.println(formatter.format(sum));
        } 
        catch (Exception e) 
        {
            System.out.println("All arguments must be numbers, separated with spaces.");
        }
    }
}