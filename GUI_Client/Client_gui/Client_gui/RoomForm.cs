using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client_gui
{
    public partial class RoomForm : Form
    {
        
        private string _numberOfQuestions;
        private string _roomName;
        private string _timePerQuestion;

        private int rightAnswer = 1;
        private bool isAnswered = false;
        private Button[] answers;
        private float delayAfterAnswer = 0;
        private const float delayTime = 0.62f;

        public static string currentQuestionNumber;
        public static int score;

        public RoomForm(string roomName, string numOfQuestions, string timePerQuestion)
        {
            _roomName = roomName;
            _numberOfQuestions = numOfQuestions;
            _timePerQuestion = timePerQuestion;
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            //set all questions and asnwers

            //assigning buttons to answers
            answers = new Button[4];
            answers[0] = answer1;
            answers[1] = answer2;
            answers[2] = answer3;
            answers[3] = answer4;

            timeLabel.Text = _timePerQuestion;
            timer.Enabled = true;
            delayTimer.Enabled = false;

            QuestionNumber.Text = "Question " + currentQuestionNumber + '/' + _numberOfQuestions;
            RoomNameLabel.Text = _roomName;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Menu(true).Show();
            this.Close();
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            isAnswered = true;
             if (sender == answers[rightAnswer-1]) //is right
            {
                score++;
                answers[rightAnswer - 1].BackColor = Color.Green;
            }
             else
            {
                foreach (Button button in answers)
                {
                    if (sender == button)
                    {
                        button.BackColor = Color.Red;
                    }
                } 
            }
            delayAfterAnswer = delayTime;
            timer.Stop();
            delayTimer.Enabled = true;
 
            foreach (Button button in answers)
            {
                button.Enabled = false;
            }
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            int newTime = Convert.ToInt32(timeLabel.Text) - 1;
 
            if (newTime <= 0)
            {
                timer.Stop();
                foreach (Button button in answers)
                {
                    button.BackColor = Color.Red;
                    button.Enabled = false;
                    delayAfterAnswer = delayTime;
                    delayTimer.Enabled = true;
                }
            }
            else if (newTime <= 10)
            {
                timeLabel.ForeColor = Color.Red;
            }
            timeLabel.Text = (newTime).ToString();
        }

        private void delayTimer_Tick(object sender, System.EventArgs e)
        {
            //setting delay so the player can see if he was right
            delayAfterAnswer -= 0.1f;
            if (delayAfterAnswer <= 0 && true) //if delay over and everyone also answered
            {
                if (currentQuestionNumber != _numberOfQuestions)
                {
                    currentQuestionNumber = (Convert.ToInt32(currentQuestionNumber)+1).ToString();
                    new RoomForm(_roomName, _numberOfQuestions, _timePerQuestion).Show();
                }
                else
                {
                    timer.Stop();
                    delayTimer.Stop();
                    MessageBox.Show("Username:" + Menu.username + " --- Score: " + score, "Scores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new Menu(true).Show();
                }
                this.Close();
            }
        }

    }
}
