public class InputNotYesOrNoException extends Exception 
{
    private String text;
    
    public InputNotYesOrNoException(String text)
    {
        this.text = text;
    }
    
    public InputNotYesOrNoException()
    {
        text = "";
    }
    
    public String getText()
    {
        return text;
    }
}