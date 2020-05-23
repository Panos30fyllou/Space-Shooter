using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Space_Shooter
{
    public partial class Game : Form
    {
        private int score = 0;
        private int secs = 59;
        public Game()
        {
            InitializeComponent();
        }    
        private void Game_Closing(object sender, FormClosingEventArgs e)
        {
            //Saves the progress of the user to the text file, and then closes the application
            File.Delete(LoginScreen.path);
            foreach (LoginScreen.user u in LoginScreen.users)
                File.AppendAllText(LoginScreen.path, u.Username + "$" + u.Level + "$" + u.Highscore + "$" + u.Lastlogin + "$" + u.XP + Environment.NewLine);
            Application.Exit();
        }

        private void Game_Load(object sender, System.EventArgs e) {
            TimeLabel.Location =  new Point(Width - TimeLabel.Width - 20, 20);
            ScoreLabel.Location = new Point(TimeLabel.Location.X, TimeLabel.Location.Y + TimeLabel.Height + 10);
            TimeLabel.Text += " 01 : 00";
            ScoreLabel.Text += score;
            if (Lobby.dif == 1)         timer1.Interval = 1400; //Interval for difficulty "Easy"
            else if (Lobby.dif == 2)    timer1.Interval = 950;  //Interval for difficulty "Hard"
            else if (Lobby.dif == 3)    timer1.Interval = 500;  //Interval for difficulty "Insane"
            //Timers start, therefore the game starts
            timer1.Enabled = timer2.Enabled = true;
        }

        private void Spaceship_MouseClick(object sender, MouseEventArgs e)
        {
            //In every click, the variable score and the label
            score++;
            ScoreLabel.Text = "Score: " + score.ToString();//This is to update the label of the score every time the user hits the spaceship
        }

        Random r = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            //ShowS thE spaceship in random places into the game screen in every timer's tick
            Spaceship.Location = new Point(r.Next(0,Width - Spaceship.Width), r.Next(100, Height - Spaceship.Height));
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //Updates the label with the time left for the user to play
            if (secs >= 10)
                TimeLabel.Text = "Time: 00 : " + secs.ToString();
            else if(secs > 0)
                TimeLabel.Text = "Time: 00 : 0" + secs.ToString();
            else if (secs == 0) {
                //As the seconds left are zero, the timers stop, and therefore the game ends
                TimeLabel.Text = "Time: 00 : 00";
                timer1.Stop();
                timer2.Stop();
                LoginScreen.users[LoginScreen.userIndex].XP += score;               //User's XP is updated in the List
                if (score > LoginScreen.users[LoginScreen.userIndex].Highscore) {   //If there is a new highscore, the User's Highscore is updated in the List, and a message is appeared for the new hoghscore achievement
                    LoginScreen.users[LoginScreen.userIndex].Highscore = score;
                    MessageBox.Show("You scored " + score + " points. Congratulations, new highscore!");
                }
                else
                    MessageBox.Show("You scored " + score + " points");//If there is not a new highscore, a message is appeared for the scored achieved
                
                //Deletes the text file and creates a new one based on the updated List
                File.Delete(LoginScreen.path);
                foreach (LoginScreen.user u in LoginScreen.users)                
                    File.AppendAllText(LoginScreen.path, u.Username + "$" + u.Level + "$" + u.Highscore + "$" + u.Lastlogin + "$" + u.XP + Environment.NewLine);               
                //Then goes back to the Lobby
                Hide();
                Lobby form2 = new Lobby();
                form2.Show();
            }
            secs--;
        }
        //Stops the game, goes back to Lobby
        private void QuitButton_Click(object sender, EventArgs e)
        {
            timer2.Stop();
            Hide();
            Lobby form2 = new Lobby();
            form2.Show();
        }

        //UI allignments for every time the Game Screen is resized
        private void Game_Resize(object sender, EventArgs e)
        {
            TimeLabel.Location = new Point(Width - TimeLabel.Width - 20, 20);
            ScoreLabel.Location = new Point(TimeLabel.Location.X, TimeLabel.Location.Y + TimeLabel.Height + 10);
        }
    }
}