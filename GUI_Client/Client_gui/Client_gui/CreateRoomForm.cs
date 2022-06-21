using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.Json;

namespace Client_gui
{
    public partial class CreateRoomForm : Form
    {
        public CreateRoomForm()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Menu(true).Show();
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            string roomName = roomNameTextbox.Text;
            string numOfPlayers = numOfPlayersTextbox.Text;
            string numOfQuestions = numOfQuestionsTextBox.Text;
            string timeForQuestion = timeQuestionsTextbox.Text;

            if (roomName != "" && numOfPlayers != "" && numOfQuestions != "" && timeForQuestion != "")
            {
                CreateRoomRequest createRoomRequest = new CreateRoomRequest(roomName, numOfPlayers, numOfQuestions, timeForQuestion);
                string createRoomJson = JsonSerializer.Serialize(createRoomRequest);
                int status = Deserialization.sendAndGetStatusOfMessage(createRoomJson, Program.CREATE_ROOM_CODE);
                if (status != 0)
                {
                    new WaitRoomForm(status.ToString(), roomName, numOfPlayers, numOfQuestions, timeForQuestion).Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error acuured...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Fill out the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void numOfQuestions_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
