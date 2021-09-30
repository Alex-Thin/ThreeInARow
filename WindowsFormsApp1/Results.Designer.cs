namespace WindowsFormsApp1
{
    partial class Results
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
            this.ResultsLabel1 = new System.Windows.Forms.Label();
            this.ExitButton3 = new System.Windows.Forms.Button();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ResultsLabel1
            // 
            this.ResultsLabel1.AutoSize = true;
            this.ResultsLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ResultsLabel1.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultsLabel1.ForeColor = System.Drawing.SystemColors.Window;
            this.ResultsLabel1.Location = new System.Drawing.Point(286, 37);
            this.ResultsLabel1.Name = "ResultsLabel1";
            this.ResultsLabel1.Size = new System.Drawing.Size(213, 75);
            this.ResultsLabel1.TabIndex = 0;
            this.ResultsLabel1.Text = "Рекорды";
            // 
            // ExitButton3
            // 
            this.ExitButton3.BackColor = System.Drawing.Color.MidnightBlue;
            this.ExitButton3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton3.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitButton3.Location = new System.Drawing.Point(233, 924);
            this.ExitButton3.Name = "ExitButton3";
            this.ExitButton3.Size = new System.Drawing.Size(332, 86);
            this.ExitButton3.TabIndex = 2;
            this.ExitButton3.Text = "Назад";
            this.ExitButton3.UseVisualStyleBackColor = false;
            this.ExitButton3.Click += new System.EventHandler(this.ExitButton3_Click);
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.BackColor = System.Drawing.Color.MidnightBlue;
            this.ResultTextBox.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ResultTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ResultTextBox.Location = new System.Drawing.Point(74, 159);
            this.ResultTextBox.Multiline = true;
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ResultTextBox.Size = new System.Drawing.Size(644, 732);
            this.ResultTextBox.TabIndex = 3;
            this.ResultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources._1475193;
            this.ClientSize = new System.Drawing.Size(796, 1108);
            this.ControlBox = false;
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.ExitButton3);
            this.Controls.Add(this.ResultsLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Results";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Результаты";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ResultsLabel1;
        private System.Windows.Forms.Button ExitButton3;
        private System.Windows.Forms.TextBox ResultTextBox;
    }
}