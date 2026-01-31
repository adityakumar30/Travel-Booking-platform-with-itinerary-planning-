using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace TravelBookingSystem2
{
    public partial class LoginForm : Form
    {
        string userFile = "users.csv";

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (!File.Exists(userFile))
            {
                MessageBox.Show("No user data found. Please sign up first.");
                return;
            }

            string[] users = File.ReadAllLines(userFile);
            foreach (string user in users)
            {
                string[] parts = user.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    MessageBox.Show("Login successful!");
                    this.Hide();
                    new DashboardForm(username).ShowDialog();
                    this.Close();
                    return;
                }
            }

            MessageBox.Show("Invalid username or password.");
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            if (!File.Exists(userFile)) File.Create(userFile).Close();

            string[] users = File.ReadAllLines(userFile);
            foreach (string user in users)
            {
                if (user.StartsWith(username + ","))
                {
                    MessageBox.Show("Username already exists.");
                    return;
                }
            }

            File.AppendAllText(userFile, username + "," + password + Environment.NewLine);
            MessageBox.Show("Signup successful! You can now login.");
        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}