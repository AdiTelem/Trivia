
namespace Client_gui
{
    partial class CreateRoomForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomNameTextbox = new System.Windows.Forms.TextBox();
            this.numOfPlayersTextbox = new System.Windows.Forms.TextBox();
            this.numOfQuestionsTextBox = new System.Windows.Forms.TextBox();
            this.timeQuestionsTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomNameLabal = new System.Windows.Forms.Label();
            this.CreateButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(723, 23);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 33);
            this.backButton.TabIndex = 6;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.roomNameTextbox);
            this.panel2.Controls.Add(this.numOfPlayersTextbox);
            this.panel2.Controls.Add(this.numOfQuestionsTextBox);
            this.panel2.Controls.Add(this.timeQuestionsTextbox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.RoomNameLabal);
            this.panel2.Controls.Add(this.CreateButton);
            this.panel2.Location = new System.Drawing.Point(117, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 402);
            this.panel2.TabIndex = 5;
            // 
            // roomNameTextbox
            // 
            this.roomNameTextbox.Location = new System.Drawing.Point(261, 51);
            this.roomNameTextbox.MinimumSize = new System.Drawing.Size(30, 35);
            this.roomNameTextbox.Name = "roomNameTextbox";
            this.roomNameTextbox.Size = new System.Drawing.Size(310, 23);
            this.roomNameTextbox.TabIndex = 12;
            this.roomNameTextbox.Text = "room_name";
            // 
            // numOfPlayersTextbox
            // 
            this.numOfPlayersTextbox.Location = new System.Drawing.Point(261, 117);
            this.numOfPlayersTextbox.MinimumSize = new System.Drawing.Size(30, 35);
            this.numOfPlayersTextbox.Name = "numOfPlayersTextbox";
            this.numOfPlayersTextbox.Size = new System.Drawing.Size(310, 23);
            this.numOfPlayersTextbox.TabIndex = 11;
            this.numOfPlayersTextbox.Text = "4";
            // 
            // numOfQuestionsTextBox
            // 
            this.numOfQuestionsTextBox.Location = new System.Drawing.Point(261, 184);
            this.numOfQuestionsTextBox.MinimumSize = new System.Drawing.Size(30, 35);
            this.numOfQuestionsTextBox.Name = "numOfQuestionsTextBox";
            this.numOfQuestionsTextBox.Size = new System.Drawing.Size(310, 23);
            this.numOfQuestionsTextBox.TabIndex = 10;
            this.numOfQuestionsTextBox.Text = "6";
            this.numOfQuestionsTextBox.TextChanged += new System.EventHandler(this.numOfQuestions_TextChanged);
            // 
            // timeQuestionsTextbox
            // 
            this.timeQuestionsTextbox.Location = new System.Drawing.Point(261, 255);
            this.timeQuestionsTextbox.MinimumSize = new System.Drawing.Size(30, 35);
            this.timeQuestionsTextbox.Name = "timeQuestionsTextbox";
            this.timeQuestionsTextbox.Size = new System.Drawing.Size(310, 23);
            this.timeQuestionsTextbox.TabIndex = 9;
            this.timeQuestionsTextbox.Text = "15";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(15, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 48);
            this.label3.TabIndex = 8;
            this.label3.Text = "Time For Question";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 48);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number Of Questions";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 48);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number Of Players";
            // 
            // RoomNameLabal
            // 
            this.RoomNameLabal.BackColor = System.Drawing.Color.Transparent;
            this.RoomNameLabal.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.RoomNameLabal.Location = new System.Drawing.Point(15, 51);
            this.RoomNameLabal.Name = "RoomNameLabal";
            this.RoomNameLabal.Size = new System.Drawing.Size(141, 48);
            this.RoomNameLabal.TabIndex = 5;
            this.RoomNameLabal.Text = "Room Name";
            // 
            // CreateButton
            // 
            this.CreateButton.BackColor = System.Drawing.SystemColors.Control;
            this.CreateButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(222, 339);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(85, 38);
            this.CreateButton.TabIndex = 1;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = false;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // CreateRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Name = "CreateRoomForm";
            this.Text = "CreateRoomForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox roomNameTextbox;
        private System.Windows.Forms.TextBox numOfPlayersTextbox;
        private System.Windows.Forms.TextBox numOfQuestionsTextBox;
        private System.Windows.Forms.TextBox timeQuestionsTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoomNameLabal;
        private System.Windows.Forms.Button CreateButton;
    }
}