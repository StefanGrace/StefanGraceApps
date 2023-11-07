public class InputCollector
{
	public boolean collectYesOrNo(String input) throws InputNotYesOrNoException
	{
        char choice;
		try 
        {
            choice = input.toLowerCase().charAt(0);
        }
        catch (StringIndexOutOfBoundsException e)
        {
            throw new InputNotYesOrNoException();
        }
		switch (choice) 
		{
			case 'y':
				return true;
			case 'n':
				return false;
            default:
                throw new InputNotYesOrNoException(input);
		}
	}
}