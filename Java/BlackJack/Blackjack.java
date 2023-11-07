import java.util.Scanner;

class Blackjack
{
	public static void main(String[] args)
	{
        boolean playAgain = true;
        while (playAgain) 
        {
            System.out.println("Welcome to Blackjack!");
            Scanner scanner = new Scanner(System.in);
            InputCollector ic = new InputCollector();
            Game g = new Game();
            Dice dice1 = new Dice();
            Dice dice2 = new Dice();
            int playerScore = dice1.roll() + dice2.roll();
            System.out.println("You roll 2 dice and get " + playerScore);
            boolean playerRollAgian = false;
            boolean playerMadeChoice = false;
            while (!playerMadeChoice)
            {
                try 
                {
                    System.out.print("Roll again? Y/N: ");
                    playerRollAgian = ic.collectYesOrNo(scanner.nextLine());
                    playerMadeChoice = true;
                }
                catch (InputNotYesOrNoException e)
                {
                    System.out.println("Invalid option: " + e.getText());
                }
            }
            if (playerRollAgian)
            {
                int secondRoll = dice1.roll() + dice2.roll();
                System.out.println("You roll 2 dice and get " + secondRoll);
                playerScore += secondRoll;
            }
            System.out.println("Total: " + playerScore);
            AI ai = new AI();
            ai.playFirstRoll();
            System.out.println();
            System.out.println("The AI rolls 2 dice and gets " + ai.getScore());
            int aiSecondRoll = ai.playSecondRoll();
            if (aiSecondRoll > -1) 
            {
                System.out.println("The AI rolls 2 dice again and gets " + aiSecondRoll);
            }
            else
            {
                System.out.println("The AI choses not to roll again");
            }
            System.out.println("Total: " + ai.getScore());
            System.out.println();
            int winner = g.decideWinner(playerScore, ai.getScore());
            switch (winner)
            {
                case -1: System.out.println("AI wins!"); break;
                case 0: System.out.println("Draw!"); break;
                case 1: System.out.println("You win!"); break;
            }
            System.out.println("Player total: " + playerScore);
            System.out.println("AI total: " + ai.getScore());
            playerMadeChoice = false;
            while (!playerMadeChoice)
            {
                try
                {
                    System.out.print("Play again? Y/N: ");
                    playAgain = ic.collectYesOrNo(scanner.nextLine());
                    playerMadeChoice = true;
                    System.out.println();
                }
                catch (InputNotYesOrNoException e)
                {
                    System.out.println("Invalid option: " + e.getText());
                }
            }
        }
	}
}