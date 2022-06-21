
namespace Client_gui
{
    partial class StatusForm
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
            this.averageTimeAnwerLabel = new System.Windows.Forms.Label();
            this.numberOfWrongAnswerLabel = new System.Windows.Forms.Label();
            this.numberOfRightAnswerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.numberOfGamesLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.SystemColors.Control;
            this.backButton.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.backButton.Location = new System.Drawing.Point(720, 29);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(85, 33);
            this.backButton.TabIndex = 8;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.averageTimeAnwerLabel);
            this.panel2.Controls.Add(this.numberOfWrongAnswerLabel);
            this.panel2.Controls.Add(this.numberOfRightAnswerLabel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.numberOfGamesLabel);
            this.panel2.Location = new System.Drawing.Point(116, 119);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 454);
            this.panel2.TabIndex = 7;
            // 
            // averageTimeAnwerLabel
            // 
            this.averageTimeAnwerLabel.BackColor = System.Drawing.Color.Transparent;
            this.averageTimeAnwerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.averageTimeAnwerLabel.ForeColor = System.Drawing.Color.Black;
            this.averageTimeAnwerLabel.Location = new System.Drawing.Point(99, 289);
            this.averageTimeAnwerLabel.Name = "averageTimeAnwerLabel";
            this.averageTimeAnwerLabel.Size = new System.Drawing.Size(420, 28);
            this.averageTimeAnwerLabel.TabIndex = 10;
            this.averageTimeAnwerLabel.Text = "1.";
            // 
            // numberOfWrongAnswerLabel
            // 
            this.numberOfWrongAnswerLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberOfWrongAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfWrongAnswerLabel.ForeColor = System.Drawing.Color.Black;
            this.numberOfWrongAnswerLabel.Location = new System.Drawing.Point(99, 235);
            this.numberOfWrongAnswerLabel.Name = "numberOfWrongAnswerLabel";
            this.numberOfWrongAnswerLabel.Size = new System.Drawing.Size(420, 28);
            this.numberOfWrongAnswerLabel.TabIndex = 9;
            this.numberOfWrongAnswerLabel.Text = "1.";
            // 
            // numberOfRightAnswerLabel
            // 
            this.numberOfRightAnswerLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberOfRightAnswerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfRightAnswerLabel.ForeColor = System.Drawing.Color.Black;
            this.numberOfRightAnswerLabel.Location = new System.Drawing.Point(99, 176);
            this.numberOfRightAnswerLabel.Name = "numberOfRightAnswerLabel";
            this.numberOfRightAnswerLabel.Size = new System.Drawing.Size(420, 28);
            this.numberOfRightAnswerLabel.TabIndex = 8;
            this.numberOfRightAnswerLabel.Text = "1.";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.StatusLabel);
            this.panel1.Location = new System.Drawing.Point(0, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 52);
            this.panel1.TabIndex = 7;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.Location = new System.Drawing.Point(239, -3);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(141, 55);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            // 
            // numberOfGamesLabel
            // 
            this.numberOfGamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.numberOfGamesLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.numberOfGamesLabel.ForeColor = System.Drawing.Color.Black;
            this.numberOfGamesLabel.Location = new System.Drawing.Point(99, 121);
            this.numberOfGamesLabel.Name = "numberOfGamesLabel";
            this.numberOfGamesLabel.Size = new System.Drawing.Size(420, 28);
            this.numberOfGamesLabel.TabIndex = 6;
            this.numberOfGamesLabel.Text = "1.";
            this.numberOfGamesLabel.Click += new System.EventHandler(this.numberOfGamesLabel_Click);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Name = "StatusForm";
            this.Text = "StatusForm";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label numberOfGamesLabel;
        private System.Windows.Forms.Label numberOfRightAnswerLabel;
        private System.Windows.Forms.Label averageTimeAnwerLabel;
        private System.Windows.Forms.Label numberOfWrongAnswerLabel;
    }
}