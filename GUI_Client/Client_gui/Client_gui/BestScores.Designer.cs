
namespace Client_gui
{
    partial class BestScores
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
            this.thirdPlace = new System.Windows.Forms.Label();
            this.secondPlace = new System.Windows.Forms.Label();
            this.firstPlace = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.thirdPlace);
            this.panel2.Controls.Add(this.secondPlace);
            this.panel2.Controls.Add(this.firstPlace);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(119, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 454);
            this.panel2.TabIndex = 5;
            // 
            // thirdPlace
            // 
            this.thirdPlace.BackColor = System.Drawing.Color.Transparent;
            this.thirdPlace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.thirdPlace.ForeColor = System.Drawing.Color.Yellow;
            this.thirdPlace.Location = new System.Drawing.Point(147, 318);
            this.thirdPlace.Name = "thirdPlace";
            this.thirdPlace.Size = new System.Drawing.Size(312, 28);
            this.thirdPlace.TabIndex = 8;
            this.thirdPlace.Text = "3.";
            // 
            // secondPlace
            // 
            this.secondPlace.BackColor = System.Drawing.Color.Transparent;
            this.secondPlace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secondPlace.ForeColor = System.Drawing.Color.LawnGreen;
            this.secondPlace.Location = new System.Drawing.Point(147, 219);
            this.secondPlace.Name = "secondPlace";
            this.secondPlace.Size = new System.Drawing.Size(312, 28);
            this.secondPlace.TabIndex = 7;
            this.secondPlace.Text = "2.";
            // 
            // firstPlace
            // 
            this.firstPlace.BackColor = System.Drawing.Color.Transparent;
            this.firstPlace.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.firstPlace.ForeColor = System.Drawing.Color.Red;
            this.firstPlace.Location = new System.Drawing.Point(147, 120);
            this.firstPlace.Name = "firstPlace";
            this.firstPlace.Size = new System.Drawing.Size(361, 28);
            this.firstPlace.TabIndex = 6;
            this.firstPlace.Text = "1.";
            this.firstPlace.Click += new System.EventHandler(this.firstPlace_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(184, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(252, 55);
            this.label5.TabIndex = 5;
            this.label5.Text = "Best Scores:";
            // 
            // BestScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(831, 675);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.panel2);
            this.Name = "BestScores";
            this.Text = "BestScores";
            this.Load += new System.EventHandler(this.BestScores_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label thirdPlace;
        private System.Windows.Forms.Label secondPlace;
        private System.Windows.Forms.Label firstPlace;
        private System.Windows.Forms.Label label5;
    }
}