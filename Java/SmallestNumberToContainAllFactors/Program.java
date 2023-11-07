import java.util.Scanner;

class Program
{
    public static void main(String[] args)
    {
        NumberFinder nf = new NumberFinder();
        while (true)
        {
            try
            {
                Scanner scanner = new Scanner(System.in);
                System.out.println(nf.getNumber(Integer.parseInt(scanner.nextLine())));
            }
            catch(Exception e)
            {
                System.out.println("Input Error!");
            } 
        } 
    }
}

