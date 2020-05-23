using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Space_Shooter
{
    public partial class Lobby : Form
    {
        public static int dif = 0;
        Color backcolor = Color.FromArgb(7, 17, 36);    //Nice shade of blue, that matches the background art of the screen. Will be used as background color tou buttons etc.

        public Lobby()
        {
            InitializeComponent();
        }
        private void Lobby_Load(object sender, EventArgs e)
        {
            //UI Adjastments
            WelcomeLabel.Location = new Point((Width - WelcomeLabel.Width) / 2, 10);
            WelcomeLabel.Text += " " + LoginScreen.users[LoginScreen.userIndex].Username;
            DifficultyGroupBox.Location = new Point(Width - DifficultyGroupBox.Width - 20, 65);
            StartButton.Location = new Point((Width - StartButton.Width) / 2, 260);
            LeaderBoardLabel.Location = new Point((Width - LeaderBoardLabel.Width) / 2, StartButton.Location.Y + StartButton.Height + 10);
            LBNamesLabel.Location = new Point(LeaderBoardLabel.Location.X, LeaderBoardLabel.Location.Y + 30);
            LBScoresLabel.Location = new Point(LBNamesLabel.Location.X + LBNamesLabel.Width, LBNamesLabel.Location.Y);
            LBNamesLabel.Height = Height - LBNamesLabel.Location.Y;
            LBScoresLabel.Height = LBNamesLabel.Height;
            LogoutButton.BackColor = StartButton.BackColor = backcolor;

            LastLoginLabel.Text += " " + LoginScreen.loginTime;
            HighscoreLabel.Text += " " + LoginScreen.users[LoginScreen.userIndex].Highscore;
            LevelLabel.Text += " " + LoginScreen.users[LoginScreen.userIndex].Level;

            //Progress Bar update
            if (LoginScreen.users[LoginScreen.userIndex].Level > 1)
                xpProgressBar.Value = LoginScreen.users[LoginScreen.userIndex].XP % ((LoginScreen.users[LoginScreen.userIndex].Level - 1) * 100);
            else
                xpProgressBar.Value = LoginScreen.users[LoginScreen.userIndex].XP % (LoginScreen.users[LoginScreen.userIndex].Level * 100);
            if (LoginScreen.users[LoginScreen.userIndex].XP >= LoginScreen.users[LoginScreen.userIndex].Level * 100) {
                LoginScreen.users[LoginScreen.userIndex].Level++;
                MessageBox.Show("Level up! You are now level " + LoginScreen.users[LoginScreen.userIndex].Level);
            }        

            //LeaderBoard info
            List<LoginScreen.user> LeaderBoard = new List<LoginScreen.user>();
            foreach (LoginScreen.user u in LoginScreen.users)
                LeaderBoard.Add(u);
            List<LoginScreen.user> SortedLeaderBoard = LeaderBoard.OrderByDescending(o => o.Highscore).ToList();
            foreach (LoginScreen.user u in SortedLeaderBoard) {
                LBNamesLabel.Text += u.Username + Environment.NewLine;
                LBScoresLabel.Text += u.Highscore + Environment.NewLine;
            }

        }

        //Updates the Online Time Label every ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = DateTime.Now.Subtract(LoginScreen.users[LoginScreen.userIndex].Lastlogin);
            OnlineTimeLabel.Text = "Online Time: " + ts.ToString(@"hh\:mm\:ss");
        }

        //When the Start button is clicked, the Game screen opens
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (dif > 0) {
                Hide();
                Game form3 = new Game();
                form3.Show();
            }
        }

        private void RadioButtonEasy_Click(object sender, EventArgs e)
        {
            StartButton.Visible = true;
            dif = 1;
        }

        private void RadioButtonHard_Click(object sender, EventArgs e)
        {
            StartButton.Visible = true;
            dif = 2;
        }

        private void RadioButtonInsane_Click(object sender, EventArgs e)
        {
            StartButton.Visible = true;
            dif = 3;
        }

        private void Lobby_Closing(object sender, FormClosingEventArgs e)
        {
            //Saves the List to the Text File and Exits the application
            File.Delete(LoginScreen.path);
            foreach (LoginScreen.user u in LoginScreen.users)            
                File.AppendAllText(LoginScreen.path, u.Username + "$" + u.Level + "$" + u.Highscore + "$" + u.Lastlogin + "$" + u.XP + Environment.NewLine);            
            Application.Exit();
        }

        //At logout, returns to Login Screen
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginScreen form1 = new LoginScreen();
            form1.Show();   
        }

        //Info shown about the XP of the user everytime the Progress Bar is clicked
        private void xpProgressBar_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("XP: " + xpProgressBar.Value + " / 100. " + (100 - xpProgressBar.Value) + " points left for Level up");
        }

        //UI allignments for every time the Lobby Form is resized
        private void Lobby_Resize(object sender, EventArgs e)
        {
            WelcomeLabel.Location = new Point((Width - WelcomeLabel.Width) / 2, 10);
            DifficultyGroupBox.Location = new Point(Width - DifficultyGroupBox.Width - 20, 65);
            StartButton.Location = new Point((Width - StartButton.Width) / 2, 260);
            LeaderBoardLabel.Location = new Point((Width - LeaderBoardLabel.Width) / 2, StartButton.Location.Y + StartButton.Height + 10);
            LBNamesLabel.Location = new Point(LeaderBoardLabel.Location.X, LeaderBoardLabel.Location.Y + 30);
            LBScoresLabel.Location = new Point(LBNamesLabel.Location.X + LBNamesLabel.Width, LBNamesLabel.Location.Y);
            LBNamesLabel.Height = Height - LBNamesLabel.Location.Y;
            LBScoresLabel.Height = LBNamesLabel.Height;

        }
    }
}