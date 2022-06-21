
namespace Client_gui
{
    partial class JoinRoomForm
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
            this.noRoomsLabel = new System.Windows.Forms.Label();
            this.joinButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.roomsList = new System.Windows.Forms.ListBox();
            this.RoomListLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(722, 20);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 33);
            this.backButton.TabIndex = 10;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.noRoomsLabel);
            this.panel2.Controls.Add(this.joinButton);
            this.panel2.Controls.Add(this.refreshButton);
            this.panel2.Controls.Add(this.roomsList);
            this.panel2.Controls.Add(this.RoomListLabel);
            this.panel2.Location = new System.Drawing.Point(121, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 495);
            this.panel2.TabIndex = 9;
            // 
            // noRoomsLabel
            // 
            this.noRoomsLabel.BackColor = System.Drawing.Color.Transparent;
            this.noRoomsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.noRoomsLabel.ForeColor = System.Drawing.Color.Crimson;
            this.noRoomsLabel.Location = new System.Drawing.Point(72, 303);
            this.noRoomsLabel.Name = "noRoomsLabel";
            this.noRoomsLabel.Size = new System.Drawing.Size(458, 35);
            this.noRoomsLabel.TabIndex = 13;
            this.noRoomsLabel.Text = "no available rooms";
            this.noRoomsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // joinButton
            // 
            this.joinButton.BackColor = System.Drawing.SystemColors.Control;
            this.joinButton.Enabled = false;
            this.joinButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.joinButton.Location = new System.Drawing.Point(184, 418);
            this.joinButton.Name = "joinButton";
            this.joinButton.Size = new System.Drawing.Size(222, 51);
            this.joinButton.TabIndex = 12;
            this.joinButton.Text = "Join";
            this.joinButton.UseVisualStyleBackColor = false;
            this.joinButton.Click += new System.EventHandler(this.joinButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.SystemColors.Control;
            this.refreshButton.Font = new System.Drawing.Font("Showcard Gothic", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.refreshButton.Location = new System.Drawing.Point(214, 350);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(158, 51);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // roomsList
            // 
            this.roomsList.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.roomsList.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.roomsList.FormattingEnabled = true;
            this.roomsList.ItemHeight = 30;
            this.roomsList.Location = new System.Drawing.Point(46, 86);
            this.roomsList.Name = "roomsList";
            this.roomsList.Size = new System.Drawing.Size(513, 214);
            this.roomsList.TabIndex = 11;
            this.roomsList.Click += new System.EventHandler(this.roomList_Click);
            this.roomsList.SelectedIndexChanged += new System.EventHandler(this.roomsList_SelectedIndexChanged);
            // 
            // RoomListLabel
            // 
            this.RoomListLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomListLabel.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomListLabel.Location = new System.Drawing.Point(184, 28);
            this.RoomListLabel.Name = "RoomListLabel";
            this.RoomListLabel.Size = new System.Drawing.Size(252, 55);
            this.RoomListLabel.TabIndex = 5;
            this.RoomListLabel.Text = "Room List:";
            // 
            // JoinRoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Name = "JoinRoomForm";
            this.Text = "JoinRoomForm";
            this.Load += new System.EventHandler(this.JoinRoomForm_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button joinButton;
        private System.Windows.Forms.Button refreshButton;
        protected internal System.Windows.Forms.ListBox roomsList;
        private System.Windows.Forms.Label RoomListLabel;
        private System.Windows.Forms.Label noRoomsLabel;
    }
}