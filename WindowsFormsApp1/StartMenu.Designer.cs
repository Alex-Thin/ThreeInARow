namespace WindowsFormsApp1
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.NameLabel = new System.Windows.Forms.Label();
            this.StartNewGameButton = new System.Windows.Forms.Button();
            this.WatchResaultsButton = new System.Windows.Forms.Button();
            this.AboutGameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Segoe Print", 26.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.NameLabel.Location = new System.Drawing.Point(151, 47);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(523, 108);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Собери 3 в ряд";
            // 
            // StartNewGameButton
            // 
            this.StartNewGameButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.StartNewGameButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartNewGameButton.ForeColor = System.Drawing.SystemColors.Window;
            this.StartNewGameButton.Location = new System.Drawing.Point(197, 210);
            this.StartNewGameButton.Name = "StartNewGameButton";
            this.StartNewGameButton.Size = new System.Drawing.Size(430, 90);
            this.StartNewGameButton.TabIndex = 1;
            this.StartNewGameButton.Text = "Новая игра";
            this.StartNewGameButton.UseVisualStyleBackColor = false;
            this.StartNewGameButton.Click += new System.EventHandler(this.StartNewGameButton_Click);
            // 
            // WatchResaultsButton
            // 
            this.WatchResaultsButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.WatchResaultsButton.Font = new System.Drawing.Font("Times New Roman", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WatchResaultsButton.ForeColor = System.Drawing.SystemColors.Window;
            this.WatchResaultsButton.Location = new System.Drawing.Point(197, 323);
            this.WatchResaultsButton.Name = "WatchResaultsButton";
            this.WatchResaultsButton.Size = new System.Drawing.Size(430, 90);
            this.WatchResaultsButton.TabIndex = 2;
            this.WatchResaultsButton.Text = "Посмотреть результаты";
            this.WatchResaultsButton.UseVisualStyleBackColor = false;
            this.WatchResaultsButton.Click += new System.EventHandler(this.WatchResaultsButton_Click);
            // 
            // AboutGameButton
            // 
            this.AboutGameButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.AboutGameButton.Font = new System.Drawing.Font("Times New Roman", 15.85714F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutGameButton.ForeColor = System.Drawing.SystemColors.Window;
            this.AboutGameButton.Location = new System.Drawing.Point(197, 438);
            this.AboutGameButton.Name = "AboutGameButton";
            this.AboutGameButton.Size = new System.Drawing.Size(430, 90);
            this.AboutGameButton.TabIndex = 3;
            this.AboutGameButton.Text = "Об игре";
            this.AboutGameButton.UseVisualStyleBackColor = false;
            this.AboutGameButton.Click += new System.EventHandler(this.AboutGameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ExitButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.White;
            this.ExitButton.Location = new System.Drawing.Point(197, 558);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(430, 90);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Выход";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(825, 710);
            this.ControlBox = false;
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AboutGameButton);
            this.Controls.Add(this.WatchResaultsButton);
            this.Controls.Add(this.StartNewGameButton);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "StartMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button StartNewGameButton;
        private System.Windows.Forms.Button WatchResaultsButton;
        private System.Windows.Forms.Button AboutGameButton;
        private System.Windows.Forms.Button ExitButton;
    }
}