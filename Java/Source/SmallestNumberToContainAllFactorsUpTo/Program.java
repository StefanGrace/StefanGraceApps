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
                System.out.print("Enter number: ");
                String userInput = scanner.nextLine();
                if (userInput == "")
                {
                    break;
                }
                System.out.println(String.format("%,d", nf.getNumber(Integer.parseInt(userInput))));
            }
            catch (ArithmeticException e)
            {
                System.out.println("Number too large to compute!");
            }
            catch(Exception e)
            {
                System.out.println("Input Error! Must be an integer.");
            } 
            
            System.out.println();
        } 
    }
}

