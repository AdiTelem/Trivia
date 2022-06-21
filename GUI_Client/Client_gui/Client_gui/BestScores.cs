using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client_gui
{
    public partial class BestScores : Form
    {
        public BestScores()
        {
            InitializeComponent();
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            new Menu(true).Show();
            this.Close();
        }

        private void BestScores_Load(object sender, EventArgs e)
        {

            UserStatisticsResponse getHighScore = Deserialization.sendAndGetStatsOfMessage(null, Program.GET_HIGH_SCORES_CODE);
            firstPlace.Text = getHighScore.UserStatistics[0].stat;
            secondPlace.Text = getHighScore.UserStatistics[1].stat;
            thirdPlace.Text = getHighScore.UserStatistics[2].stat;
        }

        private void firstPlace_Click(object sender, EventArgs e)
        {

        }
    }
}
