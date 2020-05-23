namespace Space_Shooter
{
    partial class Game
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
            this.Spaceship = new System.Windows.Forms.PictureBox();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.QuitButton = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.TimeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship)).BeginInit();
            this.SuspendLayout();
            // 
            // Spaceship
            // 
            this.Spaceship.BackColor = System.Drawing.Color.Transparent;
            this.Spaceship.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Spaceship.Image = global::Space_Shooter.Properties.Resources.Spaceship3;
            this.Spaceship.Location = new System.Drawing.Point(386, 163);
            this.Spaceship.Name = "Spaceship";
            this.Spaceship.Size = new System.Drawing.Size(120, 120);
            this.Spaceship.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Spaceship.TabIndex = 0;
            this.Spaceship.TabStop = false;
            this.Spaceship.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Spaceship_MouseClick);
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.ScoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.ScoreLabel.Location = new System.Drawing.Point(972, 53);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(200, 30);
            this.ScoreLabel.TabIndex = 1;
            this.ScoreLabel.Text = "Score: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(17)))), ((int)(((byte)(36)))));
            this.QuitButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.QuitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.QuitButton.ForeColor = System.Drawing.Color.White;
            this.QuitButton.Location = new System.Drawing.Point(12, 12);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(100, 30);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.Text = "Quit";
            this.QuitButton.UseVisualStyleBackColor = false;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(972, 12);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 30);
            this.TimeLabel.TabIndex = 3;
            this.TimeLabel.Text = "Time:";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Space_Shooter.Properties.Resources.SpacePixelArt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.Spaceship);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DoubleBuffered = true;
            this.MinimizeBox = false;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Space Shooter - Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Game_Closing);
            this.Load += new System.EventHandler(this.Game_Load);
            this.Resize += new System.EventHandler(this.Game_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Spaceship)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Spaceship;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label TimeLabel;
    }
}