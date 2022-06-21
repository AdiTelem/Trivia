using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using System.Threading;

namespace Client_gui
{
    public partial class WaitRoomForm : Form
    {
        public delegate void deleg();
        private string _id;
        private string _roomName;
        private string _maxPlayers;
        private string _numOfQuestions;
        private string _timePerQuestions;
        private bool _isCreator;
        private Thread _thread;
        private bool finished;

        public WaitRoomForm(string id, string roomName, string maxPlayers, string numOfQuestions, string timePerQuestion, bool isCreator = true)
        {
            _id = id;
            _roomName = roomName;
            _maxPlayers = maxPlayers;
            _numOfQuestions = numOfQuestions;
            _timePerQuestions = timePerQuestion;
            _isCreator = isCreator;
            _thread = new Thread(SetPlayers);
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            finished = false;
            RoomName.Text = _roomName;
            maxPlayesLabel.Text = "Max Players: " + _maxPlayers;
            NumOfQuestionsLabel.Text = "Number Of Questions: " + _numOfQuestions;
            TimePerQuestionLabel.Text = "Time Per Questions: " + _timePerQuestions;

            _thread.Start();

            if (!_isCreator)
            {
                LeaveButton.Visible = true;
                startRoomButton.Visible = false;
                backButton.Visible = false;
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Menu(true).Show();
            this.Close();
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            int status = Deserialization.sendAndGetStatusOfMessage(null, Program.LEAVE_ROOM_CODE);
            //
            //CancellationTokenSource.Cancel();
            finished = true;
            backButton_Click(sender, e);
            _thread.Join();
        }

        private void startRoomButton_Click(object sender, EventArgs e)
        {
            RoomForm.currentQuestionNumber = "1";
            RoomForm.score = 0;
            new RoomForm(_roomName, _numOfQuestions, _timePerQuestions).Show();
            this.Close();

        }

        private void NumOfQuestionsLabel_Click(object sender, EventArgs e)
        {
        }


        public void SetPlayers()
        {
            int i = 0;
            List<Player> getPlayers = null;
            while (!finished)
            {
                getPlayers = null;
                GetPlayersInRoomRequest getPlayersInRoomRequest = new GetPlayersInRoomRequest(_id);
                string joinRoomJson = JsonSerializer.Serialize(getPlayersInRoomRequest);
                getPlayers = Deserialization.sendAndGetPlayersOfMessage(joinRoomJson, Program.GET_PLAYERS_IN_ROOM_CODE);

                MethodInvoker inv = delegate
                {
                    participantsList.Items.Clear();

                    if (getPlayers != null)
                    {
                        for (i = 0; i < getPlayers.Count; i++)
                        {
                            participantsList.Items.Add(getPlayers[i].player);
                        }
                    }
                };

                this.Invoke(inv);
                

                if (!finished)
                    Thread.Sleep(3000);
            }
        }
    }
}


    