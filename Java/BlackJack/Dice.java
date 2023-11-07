import java.util.Random;

class Dice
{
	public int roll()
	{
		Random r = new Random();
		return r.nextInt(6) + 1;
	}
}