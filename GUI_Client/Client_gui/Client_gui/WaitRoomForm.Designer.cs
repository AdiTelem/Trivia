
namespace Client_gui
{
    partial class WaitRoomForm
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
            this.LeaveButton = new System.Windows.Forms.Button();
            this.startRoomButton = new System.Windows.Forms.Button();
            this.participantLabel = new System.Windows.Forms.Label();
            this.participantsList = new System.Windows.Forms.ListBox();
            this.TimePerQuestionLabel = new System.Windows.Forms.Label();
            this.NumOfQuestionsLabel = new System.Windows.Forms.Label();
            this.maxPlayesLabel = new System.Windows.Forms.Label();
            this.RoomName = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(714, 26);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 33);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "Close";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.LeaveButton);
            this.panel2.Controls.Add(this.startRoomButton);
            this.panel2.Controls.Add(this.participantLabel);
            this.panel2.Controls.Add(this.participantsList);
            this.panel2.Controls.Add(this.TimePerQuestionLabel);
            this.panel2.Controls.Add(this.NumOfQuestionsLabel);
            this.panel2.Controls.Add(this.maxPlayesLabel);
            this.panel2.Controls.Add(this.RoomName);
            this.panel2.Location = new System.Drawing.Point(110, 116);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 488);
            this.panel2.TabIndex = 7;
            // 
            // LeaveButton
            // 
            this.LeaveButton.BackColor = System.Drawing.SystemColors.Control;
            this.LeaveButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.LeaveButton.Location = new System.Drawing.Point(175, 399);
            this.LeaveButton.Name = "LeaveButton";
            this.LeaveButton.Size = new System.Drawing.Size(222, 51);
            this.LeaveButton.TabIndex = 14;
            this.LeaveButton.Text = "Leave Room";
            this.LeaveButton.UseVisualStyleBackColor = false;
            this.LeaveButton.Visible = false;
            this.LeaveButton.Click += new System.EventHandler(this.leaveButton_Click);
            // 
            // startRoomButton
            // 
            this.startRoomButton.BackColor = System.Drawing.SystemColors.Control;
            this.startRoomButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.startRoomButton.Location = new System.Drawing.Point(175, 412);
            this.startRoomButton.Name = "startRoomButton";
            this.startRoomButton.Size = new System.Drawing.Size(222, 51);
            this.startRoomButton.TabIndex = 9;
            this.startRoomButton.Text = "Start Room";
            this.startRoomButton.UseVisualStyleBackColor = false;
            this.startRoomButton.Click += new System.EventHandler(this.startRoomButton_Click);
            // 
            // participantLabel
            // 
            this.participantLabel.AutoSize = true;
            this.participantLabel.Font = new System.Drawing.Font("Elephant", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.participantLabel.Location = new System.Drawing.Point(198, 143);
            this.participantLabel.Name = "participantLabel";
            this.participantLabel.Size = new System.Drawing.Size(186, 31);
            this.participantLabel.TabIndex = 13;
            this.participantLabel.Text = "Participants:";
            // 
            // participantsList
            // 
            this.participantsList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.participantsList.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.participantsList.FormattingEnabled = true;
            this.participantsList.ItemHeight = 23;
            this.participantsList.Location = new System.Drawing.Point(144, 177);
            this.participantsList.Name = "participantsList";
            this.participantsList.Size = new System.Drawing.Size(302, 188);
            this.participantsList.TabIndex = 11;
            // 
            // TimePerQuestionLabel
            // 
            this.TimePerQuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimePerQuestionLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TimePerQuestionLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.TimePerQuestionLabel.Location = new System.Drawing.Point(387, 83);
            this.TimePerQuestionLabel.Name = "TimePerQuestionLabel";
            this.TimePerQuestionLabel.Size = new System.Drawing.Size(250, 28);
            this.TimePerQuestionLabel.TabIndex = 10;
            this.TimePerQuestionLabel.Text = "Time Per Questions: ";
            // 
            // NumOfQuestionsLabel
            // 
            this.NumOfQuestionsLabel.BackColor = System.Drawing.Color.Transparent;
            this.NumOfQuestionsLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NumOfQuestionsLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.NumOfQuestionsLabel.Location = new System.Drawing.Point(175, 83);
            this.NumOfQuestionsLabel.Name = "NumOfQuestionsLabel";
            this.NumOfQuestionsLabel.Size = new System.Drawing.Size(250, 28);
            this.NumOfQuestionsLabel.TabIndex = 9;
            this.NumOfQuestionsLabel.Text = "Number Of Questions: ";
            this.NumOfQuestionsLabel.Click += new System.EventHandler(this.NumOfQuestionsLabel_Click);
            // 
            // maxPlayesLabel
            // 
            this.maxPlayesLabel.BackColor = System.Drawing.Color.Transparent;
            this.maxPlayesLabel.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.maxPlayesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.maxPlayesLabel.Location = new System.Drawing.Point(36, 83);
            this.maxPlayesLabel.Name = "maxPlayesLabel";
            this.maxPlayesLabel.Size = new System.Drawing.Size(172, 28);
            this.maxPlayesLabel.TabIndex = 7;
            this.maxPlayesLabel.Text = "Max Players: ";
            // 
            // RoomName
            // 
            this.RoomName.BackColor = System.Drawing.Color.Transparent;
            this.RoomName.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomName.Location = new System.Drawing.Point(184, 28);
            this.RoomName.Name = "RoomName";
            this.RoomName.Size = new System.Drawing.Size(252, 55);
            this.RoomName.TabIndex = 5;
            this.RoomName.Text = "Room_Name";
            this.RoomName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WaitRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Name = "WaitRoomForm";
            this.Text = "WaitRoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label TimePerQuestionLabel;
        private System.Windows.Forms.Label NumOfQuestionsLabel;
        private System.Windows.Forms.Label maxPlayesLabel;
        private System.Windows.Forms.Label RoomName;
        private System.Windows.Forms.Label participantLabel;
        private System.Windows.Forms.Button startRoomButton;
        protected internal System.Windows.Forms.ListBox participantsList;
        private System.Windows.Forms.Button LeaveButton;
    }
}