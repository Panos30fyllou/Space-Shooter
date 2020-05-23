using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Space_Shooter
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        public class user
        {
            public user(string username, int level, int highscore, DateTime lastlogin, int  xp)
            {
                Username = username;
                Level = level;
                Highscore = highscore;
                Lastlogin = lastlogin;
                XP = xp;
            }

            public string Username { get; set; }
            public int Level { get; set; }
            public int Highscore { get; set; }
            public DateTime Lastlogin { get; set; }
            public int XP { get; set; }

        }

        public static string path = @"Users.txt";
        private static string username = "";
        public static DateTime loginTime;
        public static int highscore = 0;
        public static int userIndex;
        public static List<user> users = new List<user>();

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            UsernameTextBox.Select();
            //If the file exists, and there are users in the file
            if (File.Exists(path) && new FileInfo(path).Length > 0) {
                //Every line is split using the $. Each part is stored to userInfo and corresponds to a user;s username, level, etc.
                foreach (var line in File.ReadLines(path)) {
                    char[] seperator = { '$' };
                    string[] userInfo = line.Split(seperator, 5);
                    bool exists = false;
                    //The following loads the users from the text file to the List.
                    //It searches the whole List. If the user is not found there, it adds the user found in the specific line of file to the List. Then goes to the next line etc.
                    foreach (user u in users)
                        if (userInfo[0] == u.Username) exists = true;
                    if (!exists)
                        users.Add(new user(userInfo[0], int.Parse(userInfo[1]), int.Parse(userInfo[2]), DateTime.Parse(userInfo[3]), int.Parse(userInfo[4])));
                }
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool validuname = false;
            username = UsernameTextBox.Text;

            if (!(username.Length >= 0 && username.Trim().Length == 0))//If the username is not null or consisted of space characters, the username is valid. Else, an invalid username message is shown
                validuname = true;
            else
                MessageBox.Show("Enter a valid username");
            if (validuname) {                                       //If the username is valid
                bool foundInList = false;
                foreach (user u in users) {                         //Searches the List
                    if (username == u.Username){                    //If there is a match
                        foundInList = true;
                        userIndex = users.IndexOf(u);               //Stores its index. It will be used to save the user's progress to the List                      
                        loginTime = users[userIndex].Lastlogin;     //Stores his last login (loaded by the text file)
                        users[userIndex].Lastlogin = DateTime.Now;  //So we can then update the last login the List
                        MessageBox.Show("Successful Login");
                        break;
                    }
                }
                if (!foundInList) {                 //If there is not a match, meaning this user doesn't exist, it creates a new user to the List and to the text file
                    loginTime = DateTime.Now;
                    users.Add(new user(username, 1, 0, loginTime, 0));
                    userIndex = users.Count - 1;    //He is the last user added, and we count from 0, so we subtract 1 from the List count
                    File.AppendAllText(path, username + "$" + 1 + "$" + 0 + "$" + loginTime + "$" + 0 + Environment.NewLine);
                    MessageBox.Show("New player, huh? Signed as " + username);
                }                              
                users[userIndex].Lastlogin = DateTime.Now;
                //Then goes to the Lobby Screen
                Hide();
                Lobby form2 = new Lobby();
                form2.Show();
            }
        }

        //When the Login Screen is to be closed, it first saves the progress to the text file
        private void LoginScreen_Closing(object sender, FormClosingEventArgs e)
        {
            File.Delete(path);
            foreach (user u in users)             
                File.AppendAllText(path, u.Username + "$" + u.Level + "$" + u.Highscore + "$" + u.Lastlogin + "$" + u.XP + Environment.NewLine);              
            Application.Exit();           
        }

        //If the user presses Enter while typing, it automatically logs in with the username already typed
        private void UsernameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)    LoginButton.PerformClick();
        }
    }
}