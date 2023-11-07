using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_Tracker
{
    public partial class Form1 : Form
    {
        private Tracker tracker;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tracker = new Tracker();
        }

        private void assessmentWeightingTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void AssessmentMarkTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void submissionMarkTextBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void update()
        {
            float assessmentWeighting = stringToFloat(assessmentWeightingTextBox.Text);
            float assessmentMark = stringToFloat(assessmentMarkTextBox.Text);
            float submissionMark = stringToFloat(assessmentWeightingTextBox.Text);
            if (assessmentWeighting <= 0f || assessmentMark <= 0f || submissionMark < 0f)
            {
                InvalidInputLabel.Visible = false;
                nextButton.Enabled = true;
            }
            else
            {
                InvalidInputLabel.Visible = false;
                nextButton.Enabled = true;
                tracker.update(assessmentWeighting, assessmentMark, submissionMark);
            }
            paperPercentageLabel.Text = tracker.getPercentageString();
            paperGradeLabel.Text = tracker.getGrade();
            paperStatusLabel.Text = tracker.getStatus();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            paperPercentageLabel.Text = "";
            paperGradeLabel.Text = "";
            paperStatusLabel.Text = "";
            assessmentWeightingTextBox.Text = "";
            assessmentMarkTextBox.Text = "";
            submissionMarkTextBox.Text = "";
            tracker.next();
        }

        private float stringToFloat(string input)
        {
            try
            {
                return float.Parse(input);
            }
            catch
            {
                return -1f;
            }
        }
    }
}


class Tracker
{
    private Assessment[] assmessments = new Assessment[1000];
    private int bookmark = 0;

    public Tracker()
    {
        assmessments[0] = new Assessment();
    }

    public void update(float assessmentWeighting, float assessmentMark, float submissionMark)
    {
        assmessments[bookmark].setAssessmentWeighting(assessmentWeighting);
        assmessments[bookmark].setAssessmentMark(assessmentMark);
        assmessments[bookmark].setSubmissionMark(submissionMark);
        Console.WriteLine(getPercentageString());
    }

    private string formatDecimal(float value)
    {
        return value.ToString("0.00");
    }

    private string formatPercentage(float value)
    {
        return formatDecimal(value) + "%";
    }

    public string getPercentageString()
    {
        return formatPercentage(getPercentage());
    }

    public float getPercentage()
    {
        float total = 0;
        for (int i = 0; i < bookmark; i++)
        {
            total += assmessments[i].getPercentage();
        }
        return total / bookmark;
    }

    public string getGrade()
    {
        float percentage = getPercentage();
        if (percentage >= 90)
        {
            return "A+";
        }
        else if (percentage >= 85)
        {
            return "A";
        }
        else if (percentage >= 80)
        {
            return "A-";
        }
        else if (percentage >= 75)
        {
            return "B+";
        }
        else if (percentage >= 70)
        {
            return "B";
        }
        else if (percentage >= 65)
        {
            return "B-";
        }
        else if (percentage >= 60)
        {
            return "C+";
        }
        else if (percentage >= 55)
        {
            return "C";
        }
        else if (percentage >= 50)
        {
            return "C-";
        }
        else if (percentage >= 45)
        {
            return "D";
        }
        else
        {
            return "E";
        }
    }

    public string getStatus()
    {
        if (getPercentage() >= 50)
        {
            return "Pass";
        }
        else
        {
            return "No pass";
        }
    }

    public void next()
    {
        bookmark++;
        assmessments[bookmark] = new Assessment();
    }
}


class Assessment
{
    private float asssessmentWeighting = 100f;
    private float submissionMark = 100f;
    private float assessmentMark = 0f;

    public float getAssessmentWeighting()
    {
        return asssessmentWeighting;
    }

    public float getSubmissionMark()
    {
        return submissionMark;
    }

    public float getAssessmentMark()
    {
        return assessmentMark;
    }

    public void setAssessmentWeighting(float asssessmentWeighting)
    {
        this.asssessmentWeighting = asssessmentWeighting;
    }

    public void setSubmissionMark(float submissionMark)
    {
        this.submissionMark = submissionMark;
    }

    public void setAssessmentMark(float assessmentMark)
    {
        this.assessmentMark = assessmentMark;
    }

    public float getPercentage()
    {
        return asssessmentWeighting * (submissionMark / assessmentMark);
    }

}
