import java.util.Random;

class AI
{
    private int score = 0;
    private Dice dice1 = new Dice();
	private Dice dice2 = new Dice();
    
    public int playFirstRoll()
    { 
        score = dice1.roll() + dice2.roll();
        return score;
    }
    
    public int playSecondRoll()
    {
        Random r = new Random();
        if (r.nextBoolean())
        {
            int secondRoll = dice1.roll() + dice2.roll();
            score += secondRoll;
            return secondRoll;
        }
        else
        {
            return -1;
        }
    }
    
    public int getScore()
    {
        return score;
    }
    
}