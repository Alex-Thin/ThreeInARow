namespace WindowsFormsApp1
{
    partial class EndGame
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
            this.EndGameLabel = new System.Windows.Forms.Label();
            this.UserNameScoreLabel2 = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EndGameLabel
            // 
            this.EndGameLabel.AutoSize = true;
            this.EndGameLabel.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndGameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.EndGameLabel.Location = new System.Drawing.Point(214, 32);
            this.EndGameLabel.Name = "EndGameLabel";
            this.EndGameLabel.Size = new System.Drawing.Size(388, 75);
            this.EndGameLabel.TabIndex = 0;
            this.EndGameLabel.Text = "Игра закончена!";
            // 
            // UserNameScoreLabel2
            // 
            this.UserNameScoreLabel2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserNameScoreLabel2.ForeColor = System.Drawing.SystemColors.Window;
            this.UserNameScoreLabel2.Location = new System.Drawing.Point(29, 130);
            this.UserNameScoreLabel2.Name = "UserNameScoreLabel2";
            this.UserNameScoreLabel2.Size = new System.Drawing.Size(742, 48);
            this.UserNameScoreLabel2.TabIndex = 1;
            this.UserNameScoreLabel2.Text = "label1";
            this.UserNameScoreLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OkButton
            // 
            this.OkButton.AutoSize = true;
            this.OkButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.OkButton.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkButton.ForeColor = System.Drawing.SystemColors.Window;
            this.OkButton.Location = new System.Drawing.Point(310, 222);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(193, 72);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = false;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // EndGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 343);
            this.ControlBox = false;
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.UserNameScoreLabel2);
            this.Controls.Add(this.EndGameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "EndGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EndGame_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EndGameLabel;
        private System.Windows.Forms.Label UserNameScoreLabel2;
        private System.Windows.Forms.Button OkButton;
    }
}