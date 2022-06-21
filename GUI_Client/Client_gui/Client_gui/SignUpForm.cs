using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Client_gui
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string email = emailTextBox.Text;

            SignupRequest signUpRequest = new SignupRequest(username, password, email);
            string jsonString = JsonSerializer.Serialize(signUpRequest);
            int status = Deserialization.sendAndGetStatusOfMessage(jsonString, Program.SIGNUP_CODE);
            if (username == "" || password == "" || email == "")
            {
                MessageBox.Show("Fill out the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (status == Program.OK_STATUS) // if user does not exist
            {
                //sign up (send the data to the server)
                MessageBox.Show("Sign up succeed", "Succeed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                backButton_Click(sender, e);
            }
            else
            {
                MessageBox.Show("User does already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Close();
        }

        private void ShowPasswordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !ShowPasswordCheckbox.Checked;
        }
    }
}
