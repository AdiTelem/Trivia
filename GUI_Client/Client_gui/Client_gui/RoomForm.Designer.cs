
namespace Client_gui
{
    partial class RoomForm
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
            this.components = new System.ComponentModel.Container();
            this.question = new System.Windows.Forms.Label();
            this.QuestionNumber = new System.Windows.Forms.Label();
            this.RoomNameLabel = new System.Windows.Forms.Label();
            this.answer1 = new System.Windows.Forms.Button();
            this.answer2 = new System.Windows.Forms.Button();
            this.answer3 = new System.Windows.Forms.Button();
            this.answer4 = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // question
            // 
            this.question.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.question.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.question.ForeColor = System.Drawing.SystemColors.Control;
            this.question.Location = new System.Drawing.Point(59, 157);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(730, 39);
            this.question.TabIndex = 14;
            this.question.Text = "Question";
            // 
            // QuestionNumber
            // 
            this.QuestionNumber.BackColor = System.Drawing.Color.Transparent;
            this.QuestionNumber.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.QuestionNumber.ForeColor = System.Drawing.SystemColors.Control;
            this.QuestionNumber.Location = new System.Drawing.Point(259, 94);
            this.QuestionNumber.Name = "QuestionNumber";
            this.QuestionNumber.Size = new System.Drawing.Size(296, 39);
            this.QuestionNumber.TabIndex = 15;
            this.QuestionNumber.Text = "Question n";
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.RoomNameLabel.Font = new System.Drawing.Font("Elephant", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.RoomNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.RoomNameLabel.Location = new System.Drawing.Point(259, 22);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(296, 39);
            this.RoomNameLabel.TabIndex = 16;
            this.RoomNameLabel.Text = "room_name";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answer1
            // 
            this.answer1.BackColor = System.Drawing.SystemColors.Control;
            this.answer1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer1.Location = new System.Drawing.Point(75, 262);
            this.answer1.Name = "answer1";
            this.answer1.Size = new System.Drawing.Size(695, 50);
            this.answer1.TabIndex = 17;
            this.answer1.Text = "answer1";
            this.answer1.UseVisualStyleBackColor = false;
            this.answer1.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answer2
            // 
            this.answer2.BackColor = System.Drawing.SystemColors.Control;
            this.answer2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer2.Location = new System.Drawing.Point(75, 348);
            this.answer2.Name = "answer2";
            this.answer2.Size = new System.Drawing.Size(695, 50);
            this.answer2.TabIndex = 18;
            this.answer2.Text = "answer2";
            this.answer2.UseVisualStyleBackColor = false;
            this.answer2.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answer3
            // 
            this.answer3.BackColor = System.Drawing.SystemColors.Control;
            this.answer3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer3.Location = new System.Drawing.Point(75, 434);
            this.answer3.Name = "answer3";
            this.answer3.Size = new System.Drawing.Size(695, 50);
            this.answer3.TabIndex = 19;
            this.answer3.Text = "answer3";
            this.answer3.UseVisualStyleBackColor = false;
            this.answer3.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // answer4
            // 
            this.answer4.BackColor = System.Drawing.SystemColors.Control;
            this.answer4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.answer4.Location = new System.Drawing.Point(75, 523);
            this.answer4.Name = "answer4";
            this.answer4.Size = new System.Drawing.Size(695, 50);
            this.answer4.TabIndex = 20;
            this.answer4.Text = "answer4";
            this.answer4.UseVisualStyleBackColor = false;
            this.answer4.Click += new System.EventHandler(this.answerButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Red;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.backButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(751, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(68, 26);
            this.backButton.TabIndex = 21;
            this.backButton.Text = "Exit";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.timeLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.timeLabel.Location = new System.Drawing.Point(380, 604);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(51, 36);
            this.timeLabel.TabIndex = 22;
            this.timeLabel.Text = "60";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delayTimer
            // 
            this.delayTimer.Tick += new System.EventHandler(this.delayTimer_Tick);
            // 
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.answer4);
            this.Controls.Add(this.answer3);
            this.Controls.Add(this.answer2);
            this.Controls.Add(this.answer1);
            this.Controls.Add(this.RoomNameLabel);
            this.Controls.Add(this.QuestionNumber);
            this.Controls.Add(this.question);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label question;
        private System.Windows.Forms.Label QuestionNumber;
        private System.Windows.Forms.Label RoomNameLabel;
        private System.Windows.Forms.Button answer1;
        private System.Windows.Forms.Button answer2;
        private System.Windows.Forms.Button answer3;
        private System.Windows.Forms.Button answer4;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer delayTimer;
    }
}