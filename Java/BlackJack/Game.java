import java.util.Random;

class Game
{
	public int decideWinner(int playerScore, int aiScore)
    {
        if (playerScore > 21)
        {
            if (aiScore > 21)
            {
                return 0;
            }
                return -1;
        }
        if (aiScore > 21)
        {
            return 1;
        }
        if (playerScore > aiScore)
        {
            return 1;
        }
        if (aiScore > playerScore)
        {
            return -1;
        }
        return 0;
    }    
}