namespace Client_gui
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.SignIn_Button = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.Signup_Button = new System.Windows.Forms.Button();
            this.joinRoomButton = new System.Windows.Forms.Button();
            this.createRoomButton = new System.Windows.Forms.Button();
            this.nyStatusButton = new System.Windows.Forms.Button();
            this.bestScoreButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.loginBlock = new System.Windows.Forms.Panel();
            this.HelloUser = new System.Windows.Forms.Label();
            this.signoutButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.loginBlock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Controls.Add(this.SignIn_Button);
            this.panel1.Controls.Add(this.passwordTextBox);
            this.panel1.Location = new System.Drawing.Point(120, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(580, 100);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 28);
            this.label4.TabIndex = 9;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(27, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 28);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(133, 26);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(340, 23);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // SignIn_Button
            // 
            this.SignIn_Button.BackColor = System.Drawing.SystemColors.Control;
            this.SignIn_Button.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.SignIn_Button.Location = new System.Drawing.Point(490, 9);
            this.SignIn_Button.Name = "SignIn_Button";
            this.SignIn_Button.Size = new System.Drawing.Size(85, 78);
            this.SignIn_Button.TabIndex = 1;
            this.SignIn_Button.Text = "SIGN IN";
            this.SignIn_Button.UseVisualStyleBackColor = false;
            this.SignIn_Button.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(133, 55);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(340, 23);
            this.passwordTextBox.TabIndex = 0;
            this.passwordTextBox.UseSystemPasswordChar = true;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // Signup_Button
            // 
            this.Signup_Button.BackColor = System.Drawing.SystemColors.Control;
            this.Signup_Button.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Signup_Button.Location = new System.Drawing.Point(314, 223);
            this.Signup_Button.Name = "Signup_Button";
            this.Signup_Button.Size = new System.Drawing.Size(219, 50);
            this.Signup_Button.TabIndex = 1;
            this.Signup_Button.Text = "Sign Up";
            this.Signup_Button.UseVisualStyleBackColor = false;
            this.Signup_Button.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // joinRoomButton
            // 
            this.joinRoomButton.BackColor = System.Drawing.SystemColors.Control;
            this.joinRoomButton.Enabled = false;
            this.joinRoomButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.joinRoomButton.Location = new System.Drawing.Point(314, 297);
            this.joinRoomButton.Name = "joinRoomButton";
            this.joinRoomButton.Size = new System.Drawing.Size(219, 50);
            this.joinRoomButton.TabIndex = 1;
            this.joinRoomButton.Text = "Join Room";
            this.joinRoomButton.UseVisualStyleBackColor = false;
            this.joinRoomButton.Click += new System.EventHandler(this.joinRoomButton_Click);
            // 
            // createRoomButton
            // 
            this.createRoomButton.BackColor = System.Drawing.SystemColors.Control;
            this.createRoomButton.Enabled = false;
            this.createRoomButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.createRoomButton.Location = new System.Drawing.Point(314, 378);
            this.createRoomButton.Name = "createRoomButton";
            this.createRoomButton.Size = new System.Drawing.Size(219, 50);
            this.createRoomButton.TabIndex = 1;
            this.createRoomButton.Text = "Create Room";
            this.createRoomButton.UseVisualStyleBackColor = false;
            this.createRoomButton.Click += new System.EventHandler(this.createRoomButton_Click);
            // 
            // nyStatusButton
            // 
            this.nyStatusButton.BackColor = System.Drawing.SystemColors.Control;
            this.nyStatusButton.Enabled = false;
            this.nyStatusButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.nyStatusButton.Location = new System.Drawing.Point(314, 461);
            this.nyStatusButton.Name = "nyStatusButton";
            this.nyStatusButton.Size = new System.Drawing.Size(219, 50);
            this.nyStatusButton.TabIndex = 1;
            this.nyStatusButton.Text = "My Status";
            this.nyStatusButton.UseVisualStyleBackColor = false;
            this.nyStatusButton.Click += new System.EventHandler(this.myStatusButton_Click);
            // 
            // bestScoreButton
            // 
            this.bestScoreButton.BackColor = System.Drawing.SystemColors.Control;
            this.bestScoreButton.Enabled = false;
            this.bestScoreButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.bestScoreButton.Location = new System.Drawing.Point(314, 536);
            this.bestScoreButton.Name = "bestScoreButton";
            this.bestScoreButton.Size = new System.Drawing.Size(219, 50);
            this.bestScoreButton.TabIndex = 1;
            this.bestScoreButton.Text = "Best Scores";
            this.bestScoreButton.UseVisualStyleBackColor = false;
            this.bestScoreButton.Click += new System.EventHandler(this.bestScoreButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.SystemColors.Control;
            this.quitButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.quitButton.Location = new System.Drawing.Point(372, 613);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(100, 50);
            this.quitButton.TabIndex = 1;
            this.quitButton.Text = "quit";
            this.quitButton.Enabled = false;
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // loginBlock
            // 
            this.loginBlock.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.loginBlock.Controls.Add(this.HelloUser);
            this.loginBlock.Location = new System.Drawing.Point(120, 83);
            this.loginBlock.Name = "loginBlock";
            this.loginBlock.Size = new System.Drawing.Size(580, 100);
            this.loginBlock.TabIndex = 3;
            this.loginBlock.Visible = false;
            this.loginBlock.Paint += new System.Windows.Forms.PaintEventHandler(this.loginBlock_Paint);
            // 
            // HelloUser
            // 
            this.HelloUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HelloUser.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HelloUser.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HelloUser.Location = new System.Drawing.Point(3, 35);
            this.HelloUser.Name = "HelloUser";
            this.HelloUser.Size = new System.Drawing.Size(572, 45);
            this.HelloUser.TabIndex = 0;
            this.HelloUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelloUser.Click += new System.EventHandler(this.HelloUser_Click);
            // 
            // signoutButton
            // 
            this.signoutButton.BackColor = System.Drawing.SystemColors.Control;
            this.signoutButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.signoutButton.Location = new System.Drawing.Point(314, 223);
            this.signoutButton.Name = "signoutButton";
            this.signoutButton.Size = new System.Drawing.Size(219, 50);
            this.signoutButton.TabIndex = 4;
            this.signoutButton.Text = "Sign Out";
            this.signoutButton.UseVisualStyleBackColor = false;
            this.signoutButton.Visible = false;
            this.signoutButton.Click += new System.EventHandler(this.reload_Menu);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.Controls.Add(this.signoutButton);
            this.Controls.Add(this.loginBlock);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.bestScoreButton);
            this.Controls.Add(this.nyStatusButton);
            this.Controls.Add(this.createRoomButton);
            this.Controls.Add(this.joinRoomButton);
            this.Controls.Add(this.Signup_Button);
            this.Controls.Add(this.panel1);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginBlock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SignIn_Button;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Button Signup_Button;
        private System.Windows.Forms.Button joinRoomButton;
        private System.Windows.Forms.Button createRoomButton;
        private System.Windows.Forms.Button nyStatusButton;
        private System.Windows.Forms.Button bestScoreButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Panel loginBlock;
        private System.Windows.Forms.Label HelloUser;
        private System.Windows.Forms.Button signoutButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

