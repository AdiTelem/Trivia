using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace Client_gui
{
    public partial class Menu : Form
    {
        private bool _isLogged = false; 
        public static string username = ""; 
        public Menu(bool isLogged=false)
        {
            _isLogged = isLogged;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (_isLogged)
            {
                login(username);
            }
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            string unchecked_username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            LoginRequest loginRequest = new LoginRequest(unchecked_username, password);
            string loginJson = JsonSerializer.Serialize(loginRequest);
            int status = Deserialization.sendAndGetStatusOfMessage(loginJson, Program.LOGIN_CODE);
            if (status == Program.LOGIN_FAILED)
            {
                MessageBox.Show("Login Failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == Program.OK_STATUS) // if the username and password are valid
            {
                //log in
                username = unchecked_username;
                login(username);
            }
            else
            {
                MessageBox.Show("Error acuured...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            new SignUpForm().Show();
            this.Close();
        }

        private void joinRoomButton_Click(object sender, EventArgs e)
        {
            new JoinRoomForm().Show();
            this.Close();
        }

        private void createRoomButton_Click(object sender, EventArgs e)
        {
            new CreateRoomForm().Show();
            this.Close();
        }

        private void bestScoreButton_Click(object sender, EventArgs e)
        {
            new BestScores().Show();
            this.Close();
        }

        private void myStatusButton_Click(object sender, EventArgs e)
        {
            
            new StatusForm().Show();
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Deserialization.sendAndGetStatusOfMessage(null, Program.SIGNOUT_CODE);
            this.Close();
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void reload_Menu(object sender, EventArgs e)
        {
            //LoginRequest loginRequest = new LoginRequest(unchecked_username, password);
            int status = Deserialization.sendAndGetStatusOfMessage(null, Program.SIGNOUT_CODE);
            if (status == Program.ERROR_CODE)
            {
                MessageBox.Show("Signout Failed...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                new Menu().Show();
                this.Close();
            }
        }

        private void login(string username)
        {
            loginBlock.Visible = true;
            HelloUser.Text = "Hello " + username;
            HelloUser.TextAlign = ContentAlignment.MiddleCenter;
            Signup_Button.Visible = false;
            signoutButton.Visible = true;

            //enable all user buttons
            joinRoomButton.Enabled = true;
            createRoomButton.Enabled = true;
            nyStatusButton.Enabled = true;
            bestScoreButton.Enabled = true;
            quitButton.Enabled = true;
        }

        private void HelloUser_Click(object sender, EventArgs e)
        {

        }

        private void loginBlock_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
