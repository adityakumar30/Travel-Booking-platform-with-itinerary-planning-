using System;
using System.Windows.Forms;

namespace TravelBookingSystem2
{
    public partial class DashboardForm : Form
    {
        private string username;

        public DashboardForm(string user)
        {
            InitializeComponent();
            username = user;
            welcomeLabel.Text = $"Welcome, {username}!";
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
        }

        private void bookNowButton_Click(object sender, EventArgs e)
        {
            BookNowForm bookForm = new BookNowForm();
            bookForm.ShowDialog();
        }

        private void viewDestButton_Click(object sender, EventArgs e)
        {
            // ✅ Open the ViewDestinationsForm
            ViewDestinationsForm viewForm = new ViewDestinationsForm();
            viewForm.ShowDialog(); // or use Show() if you don't want it modal
        }

        private void myBookingsButton_Click(object sender, EventArgs e)
        {
            MyBookingsForm myBookings = new
                MyBookingsForm();
            myBookings.Show();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.Close(); // or go back to LoginForm
        }
    }
}