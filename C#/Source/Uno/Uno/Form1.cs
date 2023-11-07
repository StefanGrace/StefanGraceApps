using System;
using System.Drawing;
using System.Windows.Forms;
using Uno.Properties;

// Stefan Grace
// Uno
// Form1.cs

namespace Uno
{
    public partial class Form1 : Form
    {
        Game game;
        CanvasHandler canvasHandler;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Graphics canvas = pictureBox1.CreateGraphics();
            canvasHandler = new CanvasHandler();
            canvasHandler.setCanvas(canvas);
            game = new Game(canvasHandler);
            loadWindowSize();
            game.show();
        }

        private void loadWindowSize()
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines("WindowSize.txt");
                if (int.Parse(lines[5]) == Screen.PrimaryScreen.Bounds.Width && int.Parse(lines[6]) == Screen.PrimaryScreen.Bounds.Height)
                {
                    if (int.Parse(lines[0]) <= Screen.PrimaryScreen.Bounds.Width && int.Parse(lines[1]) <= Screen.PrimaryScreen.Bounds.Height && lines[2].ToLower() != "maximized")
                    {
                        Size = new Size(int.Parse(lines[0]), int.Parse(lines[1]));
                    }
                    if (int.Parse(lines[3]) <= Screen.PrimaryScreen.Bounds.Height && int.Parse(lines[4]) <= Screen.PrimaryScreen.Bounds.Width && lines[2].ToLower() != "maximized")
                    {
                        Top = int.Parse(lines[3]);
                        Left = int.Parse(lines[4]);
                    }
                    if (lines[2].ToLower() == "maximized")
                    {
                        WindowState = FormWindowState.Maximized;
                    }
                }
            }
            catch { }
        }


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!redButton.Visible) // Make it so the user can't cick on a card until they have selected a color
            {
                game.click(e);
            }
            showColorButtons(game.showColorButtons()); // show the color selection buttons if the player has put the a wild card or a +4
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            game.restart();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            game.pause();
            updatePauseButtonLabel();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            game.showHighScores();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            playerScoreLabel.Text = game.getPlayerScores();
            updatePauseButtonLabel();
            game.step();
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            game.changeCurrentColor("red");
            showColorButtons(game.showColorButtons());
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            game.changeCurrentColor("blue");
            showColorButtons(game.showColorButtons());
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            game.changeCurrentColor("yellow");
            showColorButtons(game.showColorButtons());
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            game.changeCurrentColor("green");
            showColorButtons(game.showColorButtons());
        }

        private void showColorButtons(bool show)
        {
            redButton.Visible = show;
            yellowButton.Visible = show;
            greenButton.Visible = show;
            blueButton.Visible = show;
            game.show();
        }
        private void updatePauseButtonLabel()
        {
            if (game.isPaused())
            {
                pauseButton.Text = "Resume";
            }
            else
            {
                pauseButton.Text = "Pause";
            }
        }

        private void resetScoresButton_Click(object sender, EventArgs e)
        {
            DialogResult userAwnser = MessageBox.Show("Are sure you want to reset the running scores?", "Reset Scores?", MessageBoxButtons.YesNo);
            if (userAwnser == DialogResult.Yes)
            {
                game.resetScores();
            }
        }

        private void resetHiScoresButton_Click(object sender, EventArgs e)
        {
            DialogResult userAwnser = MessageBox.Show("Are sure you want to reset the top high scores?", "Reset High Scores?", MessageBoxButtons.YesNo);
            if (userAwnser == DialogResult.Yes)
            {
                game.resetHiScores();
            }
        }

        private void pictureBox1_Resize(object sender, EventArgs e)
        {
            resizeCanvas();
        }

        private void resizeCanvas()
        {
            game.resizeCanvas(pictureBox1.Size.Width, pictureBox1.Size.Height);
            canvasHandler.setCanvas(pictureBox1.CreateGraphics());
            timer2.Enabled = true;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {

        }

        private void saveWindowSize()
        {
            try
            {
                string[] lines = new string[7];
                lines[0] = Size.Width.ToString();
                lines[1] = Size.Height.ToString();
                lines[2] = WindowState.ToString();
                lines[3] = Top.ToString();
                lines[4] = Left.ToString();
                lines[5] = Screen.PrimaryScreen.Bounds.Width.ToString();
                lines[6] = Screen.PrimaryScreen.Bounds.Height.ToString();
                System.IO.File.WriteAllLines("WindowSize.txt", lines);
            }
            catch { }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            game.show();
            timer2.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveWindowSize();
        }
    }



    class Game
    {
        private Players players;
        private DrawPile drawPile;
        private DepositPile depositPile;
        private bool paused = false;
        private bool shown = false;
        private CanvasHandler canvas;
        private bool started = false;
        private int canvasWidth = 800;
        private int canvasHeight = 480;

        public Game(CanvasHandler canvas)
        {
            drawPile = new DrawPile(canvas);
            Card[,] cards = new Card[2, 7];
            for (int i = 0; i < 2; i++) // sets up the starting cards for both players
            {
                for (int j = 0; j < 7; j++)
                {
                    cards[i, j] = drawCard();
                    if (i == 0)
                    {
                        cards[i, j].setY(36);
                    }
                    else
                    {
                        cards[i, j].setY(322);
                        cards[i, j].flip();
                    }
                }
            }
            players = new Players(canvas, cards);
            this.canvas = canvas;
            depositPile = new DepositPile();
            Card aCard = drawCard();
            if (aCard.getColor() == "wild") // so that if the deposit pile starts with a wild card it will be a color
            {
                aCard.setColor(generateRandomColor());
            }

            depositPile.depositCard(aCard);
        }

        public void restart()
        {
            Application.Restart();
        }

        public void pause()
        {
            paused = !paused;
        }

        public void show()
        {
            players.show();
            canvas.getCanvas().FillRectangle(Brushes.Green, 0, 0, canvasWidth, canvasHeight);
            drawPile.show();
            players.show();
            depositPile.show();
        }

        public void pickupCard()
        {
            players.pickupCard(drawCard());
        }

        public void changePlayerTurn()
        {
            players.changePlayerTurn();
            if (players.getPlayerTurn() == 0 && players.getSumOfCards(1) != 0) // if it is the AI's turn and the player has cards left the AI will have it's turn
            {
                playAI();
                while (depositPile.getTopCard().getValue() == 11) // gives the AI another turn if it puts down a skip card
                {
                    playAI();
                }
            }
            players.changePlayerTurn();

        }

        public void click(MouseEventArgs e)
        {
            if (paused)
            {
                return;
            }
            Card aCard = players.click(e, depositPile.getTopCard());
            if (aCard != null) // if the player has clicked on a one of their cards
            {
                depositPile.depositCard(aCard);
                show();
                if (aCard.getValue() != 11 && aCard.getColor() != "wild") // if the player has NOT put down a skip card
                {
                    changePlayerTurn();
                }
                if (aCard.getValue() == 10) // if the player has put down a plus 2 card
                {
                    for (int i = 0; i < 2; i++)
                    {
                        players.pickupCard(drawCard(), 0);
                    }
                }
            }
            if (drawPile.getSpace().Contains(e.Location)) // if the player has clicked on the draw pile
            {
                pickupCard();
                show();
                changePlayerTurn();
            }
        }

        public void changeCurrentColor(string color)
        {
            if (depositPile.getTopCard().getColor() == "wild")
            {
                depositPile.getTopCard().setColor(color);
                depositPile.show();
                if (depositPile.getTopCard().getValue() == 12) // if the player has put down a plus 4 card
                {
                    for (int i = 0; i < 4; i++)
                    {
                        players.pickupCard(drawCard(), 0);
                    }
                }
                changePlayerTurn();
            }
        }

        public bool showColorButtons()
        {
            return depositPile.getTopCard().getColor() == "wild";
        }

        public bool showFinishedTurn()
        {
            return true;
        }

        public string getPlayerTurn()
        {
            if (players.getPlayerTurn() == 0)
            {
                return "AI's turn";
            }
            else
            {
                return "Your turn";
            }
        }

        public void playAI()
        {
            for (int i = 0; i < players.getPlayerCards().Length; i++) // if the AI has playable card it will play it
            {
                if (players.getPlayerCards()[i] != null)
                {
                    if (players.getPlayerCards()[i].getColor() == depositPile.getTopCard().getColor() ||
                        players.getPlayerCards()[i].getValue() == depositPile.getTopCard().getValue() ||
                        players.getPlayerCards()[i].getColor() == "wild")
                    {
                        if (players.getPlayerCards()[i].getValue() == 10) // if the AI has put down a plus 2 card
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                players.pickupCard(drawCard(), 1);
                            }
                        }
                        if (players.getPlayerCards()[i].getValue() == 12) // if the AI has put down a plus 4 card
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                players.pickupCard(drawCard(), 1);
                            }
                        }
                        if (players.getPlayerCards()[i].getColor() == "wild") // if the AI has put down a wild card
                        {
                            players.getPlayerCards()[i].setColor(generateRandomColor());
                        }
                        depositPile.depositCard(players.playCard(i));
                        return;
                    }
                }
            }
            players.pickupCard(drawCard()); //  if the AI does not have a playable card it will draw a card
        }

        public string generateRandomColor() // used when the game starts with a wild card or when the AI puts down a wild card
        {
            Random rdm = new Random();
            int seed = rdm.Next(4);
            string newColor = "";
            switch (seed)
            {
                case 0:
                    newColor = "red";
                    break;
                case 1:
                    newColor = "yellow";
                    break;
                case 2:
                    newColor = "green";
                    break;
                case 3:
                    newColor = "blue";
                    break;
            }
            return newColor;
        }

        public string getPlayerScores() //  returns the player scores in a formatted string ready to display
        {
            return "Player Score: " + players.getPlayerScores()[1] + "\n" + "AI Score: " + players.getPlayerScores()[0] + "\n \n" +
                "Player Top High Score: " + players.getPlayerHiScores()[1] + "\n" + "AI Top High Score: " + players.getPlayerHiScores()[0] + "\n \n" +
                "Player Last Score: " + players.getPlayerLastScores()[1] + "\n" + "AI Last Score: " + players.getPlayerLastScores()[0];

        }

        public void step()
        {
            if (!started) // shows the cards table when the game has started
            {
                show();
                started = true;
            }
            if (players.isPlayerOutOfCards())
            {
                paused = true;
                players.flipCardsAI();
                if (!shown)
                {
                    show();
                    shown = true;
                }
            }
        }

        public bool isPaused()
        {
            return paused;
        }

        public void resetScores()
        {
            players.resetScores();
        }

        public void resetHiScores()
        {
            players.resetHiScores();
        }

        public void resizeCanvas(int width, int height)
        {
            double newWidth;
            double newHeight;
            int cardWidth;
            int cardHeight;
            if (width * 0.6 > height)
            {
                newWidth = height / 0.6;
                newHeight = height;
            }
            else
            {
                newWidth = width;
                newHeight = width * 0.6;
            }
            cardWidth = Convert.ToInt32(newWidth / 10);
            cardHeight = Convert.ToInt32(newHeight / 4.2857142857142857142857142857143);
            players.resizeCanvas(newWidth, newHeight, cardWidth, cardHeight);
            drawPile.resizeCanvas(newWidth, newHeight, cardWidth, cardHeight);
            depositPile.resizeCanvas(newWidth, newHeight, cardWidth, cardHeight);
            canvasWidth = Convert.ToInt32(width);
            canvasHeight = Convert.ToInt32(height);
        }

        public void showHighScores()
        {
            players.showHighScores();
        }

        public Card drawCard()
        {
            return drawPile.drawCard();
            if (drawPile.isOutOfCards())
            {
                drawPile.refill(depositPile.drawCards());
            }
        }
    }



    class CanvasHandler
    {
        private Graphics canvas;

        public void setCanvas(Graphics canvas)
        {
            this.canvas = canvas;
        }
        
        public Graphics getCanvas()
        {
            return canvas;
        }
    }



    class Players
    {
        private int playerTurn = 1;
        private Player[] players = new Player[2];
        private int[] playerScores = new int[] { 0, 0 };
        private int[] playerHiScores = new int[] { 0, 0 };
        private int[] playerLastScores = new int[] { 0, 0 };
        private bool scoresHaveBeenAdded = false;
        private int canvasWidth = 800;
        private int canvasHeight = 480;
        private int[] highScores = new int[10];
        private string[] highScoreNames = new string[10];
        private DateTime[] highScoreDates = new DateTime[10];

        public Players(CanvasHandler canvas, Card[,] cards)
        {
            for (int i = 0; i < 2; i++)
            {
                Card[] newCards = new Card[7];
                for (int j = 0; j < 7; j++)
                {
                    newCards[j] = cards[i, j];
                }
                players[i] = new Player(canvas, newCards, i == 0); // If 'i' is equal to 0 then the new player will be an AI, else it will be a human player
            }
            // Load the saved scores from the Scores.txt file
            try
            {
                string[] lines = System.IO.File.ReadAllLines("Scores.txt");
                playerScores[0] = int.Parse(lines[0]);
                playerScores[1] = int.Parse(lines[1]);
                playerHiScores[0] = int.Parse(lines[2]);
                playerHiScores[1] = int.Parse(lines[3]);
                playerLastScores[0] = int.Parse(lines[4]);
                playerLastScores[1] = int.Parse(lines[5]);
            }
            catch
            {
                for(int i = 0; i < highScores.Length; i++)
                {
                    highScores[i] = 0;
                    highScoreNames[i] = "";
                    highScoreDates[i] = new DateTime(0);
                }
            }
            // Load the saves high scores from the HighScores.txt files
            try
            {
                string[] lines = System.IO.File.ReadAllLines("HighScores.txt");
                for (int i = 0; i < highScores.Length; i++)
                {
                    highScores[i] = int.Parse(lines[i * 3]);
                    highScoreNames[i] = lines[(i * 3) + 1];
                    highScoreDates[i] = new DateTime(long.Parse(lines[(i * 3) + 2]));
                }
            }
            catch
            {
                // if HighScores.txt does not exist then it will starts the scores at 0
            }
        }

        public void show()
        {
            for (int i = 0; i < players.Length; i++)
            {
                players[i].show();
            }
        }

        public Card playCard(int cardNumber)
        {
            return players[playerTurn].playCard(cardNumber);
        }

        public void pickupCard(Card aCard, int playerTurn)
        {
            if (playerTurn == 0)
            {
                aCard.setY(Convert.ToInt32(canvasHeight / 13.333333333333333333333333333333));
            }
            else
            {
                aCard.setY(Convert.ToInt32(canvasHeight / 1.4906832298136645962732919254658));
                aCard.flip();
            }
            players[playerTurn].pickUpCard(aCard);
        }

        public void pickupCard(Card aCard)
        {
            pickupCard(aCard, playerTurn);
        }

        public void changePlayerTurn()
        {
            if (players[0].getNumberOfCards() == 0 || players[1].getNumberOfCards() == 0)
            {
                if (!scoresHaveBeenAdded)
                {
                    addScores();
                }
                scoresHaveBeenAdded = true;
            }
            if (playerTurn == 1)
            {
                playerTurn = 0;
            }
            else
            {
                playerTurn = 1;
            }
        }

        public Card click(MouseEventArgs e, Card topCard)
        {
            return players[playerTurn].click(e, topCard);
        }

        public int getPlayerTurn()
        {
            return playerTurn;
        }

        public Card[] getPlayerCards()
        {
            return players[playerTurn].getCards();
        }

        public Card[] getPlayerCards(int player)
        {
            return players[player].getCards();
        }

        public void addScores()
        {
            for (int i = 0; i < 2; i++)
            {
                if (players[i].getNumberOfCards() == 0)
                {
                    int otherPlayer;
                    if (i == 0)
                    {
                        otherPlayer = 1;
                    }
                    else
                    {
                        otherPlayer = 0;
                    }
                    playerScores[i] += players[otherPlayer].getSumOfCards(); // adds the value of the cards to the other player's score
                    playerLastScores[i] = players[otherPlayer].getSumOfCards();
                    playerLastScores[otherPlayer] = 0;
                    if (players[otherPlayer].getSumOfCards() > playerHiScores[i]) // sets the high scores
                    {
                        playerHiScores[i] = players[otherPlayer].getSumOfCards();
                    }
                    // Sets the high scores list
                    for (int j = 0; j < highScores.Length; j++)
                    {
                        if (highScores[j] < players[otherPlayer].getSumOfCards())
                        {
                            for (int k = highScores.Length - 1; k > j; k--)
                            {
                                highScores[k] = highScores[k - 1];
                                highScoreNames[k] = highScoreNames[k - 1];
                                highScoreDates[k] = highScoreDates[k - 1];
                            }
                            highScores[j] = players[otherPlayer].getSumOfCards();
                            if (i == 0)
                            {
                                highScoreNames[j] = "AI";
                            }
                            else
                            {
                                NameInputForm nameInputForm = new NameInputForm();
                                nameInputForm.ShowDialog();
                                highScoreNames[j] = nameInputForm.getUserName();
                            }
                            highScoreDates[j] = DateTime.Now;
                            j = highScores.Length;
                        }
                    }
                }
            }
            saveScoresToFile();
            saveHighScoresToFile();
            showHighScores();
        }
        public int[] getPlayerScores()
        {
            return playerScores;
        }

        public int[] getPlayerHiScores()
        {
            return playerHiScores;
        }

        public int[] getPlayerLastScores()
        {
            return playerLastScores;
        }

        public bool isPlayerOutOfCards()
        {
            return players[0].getNumberOfCards() == 0 || players[1].getNumberOfCards() == 0;
        }

        public void flipCardsAI()
        {
            players[0].flipCards();
        }

        public int getSumOfCards(int player)
        {
            return players[player].getSumOfCards();
        }

        public void resetScores()
        {
            for (int i = 0; i < playerScores.Length; i++)
            {
                playerScores[i] = 0;
            }
            saveScoresToFile();
        }

        public void resetHiScores()
        {
            for (int i = 0; i < playerHiScores.Length; i++)
            {
                playerHiScores[i] = 0;
            }
            saveScoresToFile();
        }

        public void saveScoresToFile()
        {
            // to save the scores to the Scores.txt file
            string[] lines = { playerScores[0].ToString(), playerScores[1].ToString(), playerHiScores[0].ToString(), playerHiScores[1].ToString(), playerLastScores[0].ToString(), playerLastScores[1].ToString() };
            System.IO.File.WriteAllLines("Scores.txt", lines);
        }

        public void saveHighScoresToFile()
        {
            string[] lines = new string[highScores.Length * 3];
            for (int j = 0; j < highScores.Length; j++)
            {
                lines[j * 3] = highScores[j].ToString();
                lines[(j * 3) + 1] = highScoreNames[j];
                lines[(j * 3) + 2] = highScoreDates[j].Ticks.ToString();
            }
            System.IO.File.WriteAllLines("HighScores.txt", lines);
        }

        public void showHighScores()
        {
            HighScores hs = new HighScores();
            hs.setHighScores(highScores, highScoreNames, highScoreDates);
            hs.ShowDialog();
            if (hs.getResetHighScores())
            {
                for (int i = 0; i < highScores.Length; i++)
                {
                    highScores[i] = 0;
                    highScoreNames[i] = "";
                    highScoreDates[i] = new DateTime(0);
                }
                saveHighScoresToFile();
            }
        }

        public void resizeCanvas(double width, double height, int cardWidth, int cardHeight)
        {
            for (int i = 0; i < players.Length; i++)
            {
                players[i].resizeCanvas(width, height, cardWidth, cardHeight);
            }
            canvasWidth = Convert.ToInt32(width);
            canvasHeight = Convert.ToInt32(height);

        }
    }



    class Player
    {
        private Card[] cards = new Card[104];
        private bool AI = false;
        int canvasWidth = 800;
        int canvasHeight = 480;

        public Player(CanvasHandler canvas, Card[] cards, bool AI)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                this.cards[i] = cards[i];
            }
            this.AI = AI;
        }

        public void show()
        {
            int numberOfCards = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    numberOfCards += 1;
                }
            }
            int cardsNumber = 0;
            int cardSpacing = canvasWidth / (numberOfCards + 1);
            int cardX = cardSpacing;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    cards[i].setX(cardX - (cards[i].getWidth() / 2));
                    cards[i].show();
                    cardsNumber += 1;
                    cardX += cardSpacing;
                }
            }
        }

        public Card playCard(int cardNumber)
        {
            Card temp = cards[cardNumber];
            cards[cardNumber] = null;
            return temp;

        }

        public void pickUpCard(Card aCard)
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] == null)
                {
                    cards[i] = aCard;
                    return;
                }
            }
        }

        public int getNumberOfCards()
        {
            int numberOfCards = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    numberOfCards += 1;
                }
            }
            return numberOfCards;
        }

        public int getSumOfCards()
        {
            int sumOfCards = 0;
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    if (cards[i].getValue() == 10 || cards[i].getValue() == 11) // plus 2 and skip cards are worth 20 points each
                    {
                        sumOfCards += 20;
                    }
                    else if (cards[i].getValue() == 12 || cards[i].getValue() == 13) // plus 4 and wild cards are worth 50 point each
                    {
                        sumOfCards += 50;
                    }
                    else // number cards are worth their face value
                    {
                        sumOfCards += cards[i].getValue();
                    }
                }
            }
            return sumOfCards;
        }

        public Card click(MouseEventArgs e, Card topCard)
        {
            for (int i = cards.Length - 1; i >= 0; i--)
            {
                if (cards[i] != null)
                {
                    if (cards[i].getSpace().Contains(e.Location))
                    {
                        if (cards[i].getColor() == topCard.getColor() || cards[i].getValue() == topCard.getValue() || cards[i].getColor() == "wild")
                        {
                            return playCard(i);
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
            return null;
        }

        public Card[] getCards()
        {
            return cards;
        }

        public void flipCards()
        {
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    cards[i].flip(true);
                }
            }
        }

        public void resizeCanvas(double width, double height, int cardWidth, int cardHeight)
        {
            canvasWidth = Convert.ToInt32(width);
            canvasHeight = Convert.ToInt32(height);
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    cards[i].resize(cardWidth, cardHeight);
                    if (AI)
                    {
                        cards[i].setY(Convert.ToInt32(height / 13.333333333333333333333333333333));
                    }
                    else
                    {
                        cards[i].setY(Convert.ToInt32(height / 1.4906832298136645962732919254658));
                    }
                }
            }
        }
    }



    class DrawPile
    {
        private int bookmark = 0;
        private Card[] cards = new Card[104];
        private bool outOfCards = false;
        private CanvasHandler canvas;
        private int cardWidth = 80;
        private int cardHeight = 112;
        private int x = 226;
        private int y = 184;

        public DrawPile(CanvasHandler canvas)
        {
            this.canvas = canvas;
            makeCards();
        }

        public void makeCards()
        {
            for (int k = 0; k< 2; k++)
            {
                for (int i = 0; i< 4; i++)
                {
                    string cardColor = "";
                    switch (i)
                    {
                        case 0:
                            cardColor = "red";
                            break;
                        case 1:
                            cardColor = "yellow";
                            break;
                        case 2:
                            cardColor = "green";
                            break;
                        case 3:
                            cardColor = "blue";
                            break;
                    }
                    for (int j = 0; j< 12; j++)
                    {
                        cards[(i * 12) + j + (k * 48)] = new Card(canvas, cardColor, j);
                    }
                }
            }
            for (int i = 0; i< 4; i++)
            {
                for (int j = 0; j< 2; j++)
                {
                    cards[96 + (i * 2) + j] = new Card(canvas, "wild", j + 12);
                }
            }
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    cards[i].resize(cardWidth, cardHeight);
                    cards[i].setX(x);
                    cards[i].setY(y);
                }
            }
            cards = shuffle(cards);
        }

        public Card[] shuffle(Card[] cards)
        {
            Random rdm = new Random();
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < cards.Length; j++)
                {
                    Card temp = cards[j];
                    int place = rdm.Next(0, cards.Length - 1);
                    cards[j] = cards[place];
                    cards[place] = temp;
                }
            }
            return cards;
        }

        public void show()
        {
            if (cards[bookmark] != null)
            {
                cards[bookmark].show();
            }
        }

        public Card drawCard()
        {
            Card temp = cards[bookmark];
            cards[bookmark] = null;
            bookmark++;
            if (bookmark >= cards.Length)
            {
                bookmark = 0;
                makeCards();
            }
            return temp;
        }

        public Rectangle getSpace()
        {
            return cards[bookmark].getSpace();
        }

        public void resizeCanvas(double width, double height, int cardWidth, int cardHeight)
        {
            int x = Convert.ToInt32(width / 3.5398230088495575221238938053097);
            int y = Convert.ToInt32(height / 2.6086956521739130434782608695652);
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    cards[i].resize(cardWidth, cardHeight);
                    cards[i].setX(x);
                    cards[i].setY(y);
                }
            }
            this.cardWidth = cardWidth;
            this.cardHeight = cardHeight;
            this.x = x;
            this.y = y;
        }

        public bool isOutOfCards()
        {
            return outOfCards;
        }

        public void refill(Card[] cards)
        {
            for (int i = this.cards.Length - cards.Length; i < this.cards.Length; i++)
            {
                this.cards[i] = cards[i];
            }
            bookmark = this.cards.Length - cards.Length;
        }
    }



    class DepositPile
    {
        private Card[] cards = new Card[104];
        private int bookmark = 0;
        private int x = 493;
        private int y = 184;

        public void depositCard(Card aCard)
        {
            aCard.flip(true);
            aCard.setX(x);
            aCard.setY(y);
            if (bookmark >= 104)
            {
                bookmark = 0;
                for (int i = 0; i < cards.Length; i++)
                {
                    cards[i] = null;
                }
            }
            cards[bookmark] = aCard;
            bookmark += 1;
        }

        public void show()
        {
            cards[bookmark - 1].show();
        }

        public Card getTopCard()
        {
            return cards[bookmark - 1];
        }

        public void changeCurrentColor(string color)
        {
            if (cards[bookmark - 1].getColor() == "wild")
            {
                cards[bookmark - 1].setColor(color);
            }
        }

        public void resizeCanvas(double width, double height, int cardWidth, int cardHeight)
        {
            int x = Convert.ToInt32(width / 1.6227180527383367139959432048682);
            int y = Convert.ToInt32(height / 2.6086956521739130434782608695652);
            for (int i = 0; i < cards.Length; i++)
            {
                if (cards[i] != null)
                {
                    cards[i].resize(cardWidth, cardHeight);
                    cards[i].setX(x);
                    cards[i].setY(y);
                }
            }
            this.x = x;
            this.y = y;
        }

        public Card[] drawCards()
        {
            Card[] cardsToDraw = new Card[bookmark - 1];
            for (int i = 0; i < bookmark - 1; i++)
            {
                cardsToDraw[i] = cards[i];
                cards[i] = null;
            }
            cards[0] = cards[bookmark - 1];
            cards[bookmark - 1] = null;
            return cardsToDraw;
        }
    }



    class Card
    {
        private string color;
        private int value;
        private int x;
        private int y;
        private int width;
        private int height;
        private bool flipped = false;
        private CanvasHandler canvas;

        public Card(CanvasHandler canvas, string color, int value, int x, int y)
        {
            this.canvas = canvas;
            this.color = color;
            this.value = value;
            this.x = x;
            this.y = y;
            width = 80;
            height = 112;
        }

        public Card(CanvasHandler canvas, string color, int value) : this(canvas, color, value, 226, 184) { }

        public void show()
        {
            if (flipped)
            {
                Bitmap cardImage = Resources.green5;
                switch (color)
                {
                    case "red":
                        switch (value)
                        {
                            case 0:
                                cardImage = Resources.red0;
                                break;
                            case 1:
                                cardImage = Resources.red1;
                                break;
                            case 2:
                                cardImage = Resources.red2;
                                break;
                            case 3:
                                cardImage = Resources.red3;
                                break;
                            case 4:
                                cardImage = Resources.red4;
                                break;
                            case 5:
                                cardImage = Resources.red5;
                                break;
                            case 6:
                                cardImage = Resources.red6;
                                break;
                            case 7:
                                cardImage = Resources.red7;
                                break;
                            case 8:
                                cardImage = Resources.red8;
                                break;
                            case 9:
                                cardImage = Resources.red9;
                                break;
                            case 10:
                                cardImage = Resources.redPlus2;
                                break;
                            case 11:
                                cardImage = Resources.redSkip;
                                break;
                            case 12:
                                cardImage = Resources.plus4Red;
                                break;
                            case 13:
                                cardImage = Resources.wildRed;
                                break;
                        }
                        break;
                    case "yellow":
                        switch (value)
                        {
                            case 0:
                                cardImage = Resources.yellow0;
                                break;
                            case 1:
                                cardImage = Resources.yellow1;
                                break;
                            case 2:
                                cardImage = Resources.yellow2;
                                break;
                            case 3:
                                cardImage = Resources.yellow3;
                                break;
                            case 4:
                                cardImage = Resources.yellow4;
                                break;
                            case 5:
                                cardImage = Resources.yellow5;
                                break;
                            case 6:
                                cardImage = Resources.yellow6;
                                break;
                            case 7:
                                cardImage = Resources.yellow7;
                                break;
                            case 8:
                                cardImage = Resources.yellow8;
                                break;
                            case 9:
                                cardImage = Resources.yellow9;
                                break;
                            case 10:
                                cardImage = Resources.yellowPlus2;
                                break;
                            case 11:
                                cardImage = Resources.yellowSkip;
                                break;
                            case 12:
                                cardImage = Resources.plus4Yellow;
                                break;
                            case 13:
                                cardImage = Resources.wildYellow;
                                break;
                        }
                        break;
                    case "green":
                        switch (value)
                        {
                            case 0:
                                cardImage = Resources.green0;
                                break;
                            case 1:
                                cardImage = Resources.green1;
                                break;
                            case 2:
                                cardImage = Resources.green2;
                                break;
                            case 3:
                                cardImage = Resources.green3;
                                break;
                            case 4:
                                cardImage = Resources.green4;
                                break;
                            case 5:
                                cardImage = Resources.green5;
                                break;
                            case 6:
                                cardImage = Resources.green6;
                                break;
                            case 7:
                                cardImage = Resources.green7;
                                break;
                            case 8:
                                cardImage = Resources.green8;
                                break;
                            case 9:
                                cardImage = Resources.green9;
                                break;
                            case 10:
                                cardImage = Resources.greenPlus2;
                                break;
                            case 11:
                                cardImage = Resources.greenSkip;
                                break;
                            case 12:
                                cardImage = Resources.plus4Green;
                                break;
                            case 13:
                                cardImage = Resources.wildGreen;
                                break;
                        }
                        break;
                    case "blue":
                        switch (value)
                        {
                            case 0:
                                cardImage = Resources.blue0;
                                break;
                            case 1:
                                cardImage = Resources.blue1;
                                break;
                            case 2:
                                cardImage = Resources.blue2;
                                break;
                            case 3:
                                cardImage = Resources.blue3;
                                break;
                            case 4:
                                cardImage = Resources.blue4;
                                break;
                            case 5:
                                cardImage = Resources.blue5;
                                break;
                            case 6:
                                cardImage = Resources.blue6;
                                break;
                            case 7:
                                cardImage = Resources.blue7;
                                break;
                            case 8:
                                cardImage = Resources.blue8;
                                break;
                            case 9:
                                cardImage = Resources.blue9;
                                break;
                            case 10:
                                cardImage = Resources.bluePlus2;
                                break;
                            case 11:
                                cardImage = Resources.blueSkip;
                                break;
                            case 12:
                                cardImage = Resources.plus4Blue;
                                break;
                            case 13:
                                cardImage = Resources.wildBlue;
                                break;
                        }
                        break;
                    case "wild":
                        switch (value)
                        {
                            case 12:
                                cardImage = Resources.plus4;
                                break;
                            case 13:
                                cardImage = Resources.wild;
                                break;
                        }
                        break;
                }
                canvas.getCanvas().DrawImage(cardImage, x, y, width, height);
            }
            else
            {
                canvas.getCanvas().DrawImage(Resources.back, x, y, width, height);
            }
        }

        public void flip()
        {
            flipped = !flipped;
        }

        public void flip(bool flipped)
        {
            this.flipped = flipped;
        }

        public string getColor()
        {
            return color;
        }

        public int getValue()
        {
            return value;
        }

        public Rectangle getSpace()
        {
            return new Rectangle(x, y, width, height);
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public int getWidth()
        {
            return width;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void resize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}