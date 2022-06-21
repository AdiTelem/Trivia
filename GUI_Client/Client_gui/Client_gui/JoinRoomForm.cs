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
    public partial class JoinRoomForm : Form
    {
        private List<RoomData> rooms;

        public JoinRoomForm()
        {
            InitializeComponent();

            rooms = new List<RoomData>();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Menu(true).Show();
            this.Close();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            GetRoomsResponse getRoomsResponse = Deserialization.sendAndGetRoomsOfMessage(null, Program.GET_ROOMS_CODE);

            roomsList.Items.Clear();
            getRoomsResponse.rooms.ForEach(roomi => rooms.Add(roomi.room));
            getRoomsResponse.rooms.ForEach(roomi => roomsList.Items.Add(roomi.room.name));

        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            //go into the waiting room
            int i = 0;
            RoomData roomData = null;
            string roomName = roomsList.SelectedItem.ToString();
            for (i = 0; i < rooms.Count; i++)
            {
                if(rooms[i].name == roomName)
                {
                    roomData = rooms[i];
                }
            }

            JoinRoomRequest joinRoomRequest = new JoinRoomRequest(roomData.id.ToString());
            string joinRoomJson = JsonSerializer.Serialize(joinRoomRequest);
            int status = Deserialization.sendAndGetStatusOfMessage(joinRoomJson, Program.JOIN_ROOM_CODE);
            if (status == Program.OK_STATUS)
            {
                new WaitRoomForm(roomData.id.ToString(), roomName, roomData.maxPlayers.ToString(), roomData.numOfQuestionsinGame.ToString(), roomData.timePerQuestion.ToString(), false).Show(); //now its just random varibles needs to get room data from server
                this.Close();
            }
            else
            {
                MessageBox.Show("Error acuured...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void roomList_Click(object sender, EventArgs e)
        {
            if (roomsList.SelectedItem != null)
            {
                joinButton.Enabled = true;
            }
        }

        private void JoinRoomForm_Load(object sender, EventArgs e)
        {
            refreshButton_Click(sender, e);
            if (roomsList.Items.Count == 0)
            {
                noRoomsLabel.Visible = true;
            }
            else
            {
                noRoomsLabel.Visible = false;
            }
        }

        private void roomsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
