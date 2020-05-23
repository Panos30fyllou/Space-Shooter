namespace Space_Shooter
{
    partial class Lobby
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.OnlineTimeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.DifficultyGroupBox = new System.Windows.Forms.GroupBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.LastLoginLabel = new System.Windows.Forms.Label();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.HighscoreLabel = new System.Windows.Forms.Label();
            this.UserInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.xpProgressBar = new System.Windows.Forms.ProgressBar();
            this.LevelLabel = new System.Windows.Forms.Label();
            this.LeaderBoardLabel = new System.Windows.Forms.Label();
            this.LBNamesLabel = new System.Windows.Forms.Label();
            this.LBScoresLabel = new System.Windows.Forms.Label();
            this.DifficultyGroupBox.SuspendLayout();
            this.UserInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(250, 10);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(700, 65);
            this.WelcomeLabel.TabIndex = 0;
            this.WelcomeLabel.Text = "Welcome";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // OnlineTimeLabel
            // 
            this.OnlineTimeLabel.AutoSize = true;
            this.OnlineTimeLabel.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.OnlineTimeLabel.Location = new System.Drawing.Point(6, 25);
            this.OnlineTimeLabel.Name = "OnlineTimeLabel";
            this.OnlineTimeLabel.Size = new System.Drawing.Size(172, 37);
            this.OnlineTimeLabel.TabIndex = 1;
            this.OnlineTimeLabel.Text = "Online Time:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton1.Location = new System.Drawing.Point(6, 25);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(150, 35);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Easy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.RadioButtonEasy_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton2.Location = new System.Drawing.Point(6, 82);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(150, 35);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Hard";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.RadioButtonHard_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.radioButton3.Location = new System.Drawing.Point(6, 141);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(150, 35);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Insane";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.RadioButtonInsane_Click);
            // 
            // DifficultyGroupBox
            // 
            this.DifficultyGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.DifficultyGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DifficultyGroupBox.Controls.Add(this.radioButton1);
            this.DifficultyGroupBox.Controls.Add(this.radioButton3);
            this.DifficultyGroupBox.Controls.Add(this.radioButton2);
            this.DifficultyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.DifficultyGroupBox.ForeColor = System.Drawing.Color.White;
            this.DifficultyGroupBox.Location = new System.Drawing.Point(865, 65);
            this.DifficultyGroupBox.Name = "DifficultyGroupBox";
            this.DifficultyGroupBox.Size = new System.Drawing.Size(300, 187);
            this.DifficultyGroupBox.TabIndex = 5;
            this.DifficultyGroupBox.TabStop = false;
            this.DifficultyGroupBox.Text = "Difficulty";
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.StartButton.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.StartButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.StartButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.StartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(450, 260);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(300, 50);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Visible = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // LastLoginLabel
            // 
            this.LastLoginLabel.AutoSize = true;
            this.LastLoginLabel.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LastLoginLabel.Location = new System.Drawing.Point(6, 62);
            this.LastLoginLabel.Name = "LastLoginLabel";
            this.LastLoginLabel.Size = new System.Drawing.Size(148, 37);
            this.LastLoginLabel.TabIndex = 6;
            this.LastLoginLabel.Text = "Last Login:";
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.LogoutButton.Font = new System.Drawing.Font("Malgun Gothic", 20F);
            this.LogoutButton.ForeColor = System.Drawing.Color.White;
            this.LogoutButton.Location = new System.Drawing.Point(12, 17);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(10);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(200, 50);
            this.LogoutButton.TabIndex = 7;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // HighscoreLabel
            // 
            this.HighscoreLabel.AutoSize = true;
            this.HighscoreLabel.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.HighscoreLabel.Location = new System.Drawing.Point(7, 102);
            this.HighscoreLabel.Name = "HighscoreLabel";
            this.HighscoreLabel.Size = new System.Drawing.Size(147, 37);
            this.HighscoreLabel.TabIndex = 8;
            this.HighscoreLabel.Text = "Highscore:";
            // 
            // UserInfoGroupBox
            // 
            this.UserInfoGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.UserInfoGroupBox.Controls.Add(this.xpProgressBar);
            this.UserInfoGroupBox.Controls.Add(this.LevelLabel);
            this.UserInfoGroupBox.Controls.Add(this.OnlineTimeLabel);
            this.UserInfoGroupBox.Controls.Add(this.HighscoreLabel);
            this.UserInfoGroupBox.Controls.Add(this.LastLoginLabel);
            this.UserInfoGroupBox.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.UserInfoGroupBox.ForeColor = System.Drawing.Color.White;
            this.UserInfoGroupBox.Location = new System.Drawing.Point(12, 67);
            this.UserInfoGroupBox.Name = "UserInfoGroupBox";
            this.UserInfoGroupBox.Size = new System.Drawing.Size(450, 185);
            this.UserInfoGroupBox.TabIndex = 9;
            this.UserInfoGroupBox.TabStop = false;
            this.UserInfoGroupBox.Text = "User Info";
            // 
            // xpProgressBar
            // 
            this.xpProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.xpProgressBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xpProgressBar.Location = new System.Drawing.Point(145, 146);
            this.xpProgressBar.Name = "xpProgressBar";
            this.xpProgressBar.Size = new System.Drawing.Size(299, 30);
            this.xpProgressBar.Step = 1;
            this.xpProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.xpProgressBar.TabIndex = 10;
            this.xpProgressBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.xpProgressBar_MouseClick);
            // 
            // LevelLabel
            // 
            this.LevelLabel.AutoSize = true;
            this.LevelLabel.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.LevelLabel.Location = new System.Drawing.Point(7, 139);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(93, 37);
            this.LevelLabel.TabIndex = 9;
            this.LevelLabel.Text = "Level: ";
            // 
            // LeaderBoardLabel
            // 
            this.LeaderBoardLabel.BackColor = System.Drawing.Color.Transparent;
            this.LeaderBoardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.LeaderBoardLabel.ForeColor = System.Drawing.Color.White;
            this.LeaderBoardLabel.Location = new System.Drawing.Point(450, 320);
            this.LeaderBoardLabel.Name = "LeaderBoardLabel";
            this.LeaderBoardLabel.Size = new System.Drawing.Size(300, 30);
            this.LeaderBoardLabel.TabIndex = 11;
            this.LeaderBoardLabel.Text = "LeaderBoard";
            this.LeaderBoardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBNamesLabel
            // 
            this.LBNamesLabel.BackColor = System.Drawing.Color.Transparent;
            this.LBNamesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LBNamesLabel.ForeColor = System.Drawing.Color.White;
            this.LBNamesLabel.Location = new System.Drawing.Point(450, 360);
            this.LBNamesLabel.Name = "LBNamesLabel";
            this.LBNamesLabel.Size = new System.Drawing.Size(235, 200);
            this.LBNamesLabel.TabIndex = 12;
            // 
            // LBScoresLabel
            // 
            this.LBScoresLabel.BackColor = System.Drawing.Color.Transparent;
            this.LBScoresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LBScoresLabel.ForeColor = System.Drawing.Color.White;
            this.LBScoresLabel.Location = new System.Drawing.Point(690, 360);
            this.LBScoresLabel.Name = "LBScoresLabel";
            this.LBScoresLabel.Size = new System.Drawing.Size(75, 200);
            this.LBScoresLabel.TabIndex = 13;
            this.LBScoresLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::Space_Shooter.Properties.Resources.SpacePixelArt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.LBScoresLabel);
            this.Controls.Add(this.LBNamesLabel);
            this.Controls.Add(this.LeaderBoardLabel);
            this.Controls.Add(this.UserInfoGroupBox);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.DifficultyGroupBox);
            this.Controls.Add(this.WelcomeLabel);
            this.DoubleBuffered = true;
            this.Name = "Lobby";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter - Lobby";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Lobby_Closing);
            this.Load += new System.EventHandler(this.Lobby_Load);
            this.Resize += new System.EventHandler(this.Lobby_Resize);
            this.DifficultyGroupBox.ResumeLayout(false);
            this.UserInfoGroupBox.ResumeLayout(false);
            this.UserInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label OnlineTimeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox DifficultyGroupBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label LastLoginLabel;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Label HighscoreLabel;
        private System.Windows.Forms.GroupBox UserInfoGroupBox;
        private System.Windows.Forms.Label LevelLabel;
        private System.Windows.Forms.ProgressBar xpProgressBar;
        private System.Windows.Forms.Label LeaderBoardLabel;
        private System.Windows.Forms.Label LBNamesLabel;
        private System.Windows.Forms.Label LBScoresLabel;
    }
}