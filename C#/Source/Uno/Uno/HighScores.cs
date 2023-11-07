using System;
using System.Windows.Forms;

// Stefan Grace
// Uno
// HighScores.cs

namespace Uno
{
    public partial class HighScores : Form
    {
        int[] highScores;
        string[] highScoreNames;
        DateTime[] highScoreDates;
        bool resetHighScores = false;
        
        public HighScores()
        {
            InitializeComponent();
        }

        public bool getResetHighScores()
        {

            return resetHighScores;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HighScores_Load(object sender, EventArgs e)
        {
            refreshAll();
        }

        public void setHighScores(int[] scores, string[] names, DateTime[] dateAndTime)
        {
            highScores = scores;
            highScoreNames = names;
            highScoreDates = dateAndTime;
        }

        private void dateFormatButton_Click(object sender, EventArgs e)
        {
            DateFormatForm dateFormatForm = new DateFormatForm();
            dateFormatForm.ShowDialog();
            refreshDates();
        }

        private void refershScores()
        {
            scoreLabel.Text = "Score \n \n \n";
            for (int i = 0; i < highScores.Length; i++)
            {
                scoreLabel.Text += highScores[i];
                if (highScores.Length - 1 != i)
                {
                    scoreLabel.Text += "\n \n";
                }
            }
        }

        private void refreshNames()
        {
            userNameLabel.Text = "Name \n \n \n";
            for (int i = 0; i < highScoreNames.Length; i++)
            {
                userNameLabel.Text += highScoreNames[i];
                if (highScoreNames.Length - 1 != i)
                {
                    userNameLabel.Text += "\n \n";
                }
            }
        }

        private void refreshAll()
        {
            refershScores();
            refreshNames();
            refreshDates();
        }

        private void refreshDates()
        {
            dateTimeLabel.Text = "Date/Time \n \n \n";
            for (int i = 0; i < highScoreDates.Length; i++)
            {
                if (highScoreDates[i] != new DateTime(0))
                {
                    DateFormatForm dateFormatForm = new DateFormatForm();
                    dateTimeLabel.Text += dateFormatForm.formatDate(highScoreDates[i]);

                }
                if (highScoreDates.Length - 1 != i)
                {
                    dateTimeLabel.Text += "\n \n";
                }
            }
        }

        private void resetScoresButton_Click(object sender, EventArgs e)
        {
            DialogResult userAwnser =  MessageBox.Show("Are you sure you want to reset high scores", "Reset High Scores?", MessageBoxButtons.YesNo);
            if (userAwnser == DialogResult.Yes)
            {
                for(int i = 0; i < highScores.Length; i++)
                {
                    highScores[i] = 0;
                    highScoreNames[i] = "";
                    highScoreDates[i] = new DateTime(0);
                }
                resetHighScores = true;
                refreshAll();
            } 
        }
    }
}
