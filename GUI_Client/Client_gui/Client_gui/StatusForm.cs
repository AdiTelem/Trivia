using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Client_gui
{
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
        }
        
        private void StatusForm_Load(object sender, EventArgs e)
        {
            UserStatisticsResponse getStats = Deserialization.sendAndGetStatsOfMessage(null, Program.GET_PERSONAL_STATS_CODE);

            numberOfGamesLabel.Text = getStats.UserStatistics[0].stat;
            numberOfRightAnswerLabel.Text = getStats.UserStatistics[1].stat;
            numberOfWrongAnswerLabel.Text = getStats.UserStatistics[2].stat;
            averageTimeAnwerLabel.Text = getStats.UserStatistics[3].stat;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Menu(true).Show();
            this.Close();
        }

        private void numberOfGamesLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
