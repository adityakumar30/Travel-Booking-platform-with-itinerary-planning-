using System;
using System.Drawing;
using System.Windows.Forms;

namespace TravelBookingSystem2
{
    public partial class MyBookingsForm : Form
    {
        public MyBookingsForm()
        {
            InitializeComponent();
        }

        private void MyBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void LoadBookings()
        {
            flowLayoutPanel1.Controls.Clear();

            if (!string.IsNullOrWhiteSpace(BookNowForm.LastBookingDetails))
            {
                AddBooking(BookNowForm.LastBookingDetails);
            }
            else
            {
                // Optional: show message if no booking exists
                Label noBooking = new Label
                {
                    Text = "No bookings found.",
                    Font = new Font("Segoe UI", 11, FontStyle.Italic),
                    AutoSize = true,
                    ForeColor = Color.Gray,
                    Margin = new Padding(20)
                };
                flowLayoutPanel1.Controls.Add(noBooking);
            }
        }

        private void AddBooking(string bookingText)
        {
            Panel card = new Panel
            {
                Width = 550,
                Height = 120,
                BackColor = Color.AliceBlue,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            Label infoLabel = new Label
            {
                Text = bookingText,
                Font = new Font("Segoe UI", 10),
                Location = new Point(10, 10),
                AutoSize = true
            };

            Button cancelButton = new Button
            {
                Text = "Cancel Booking",
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(400, 70),
                Size = new Size(120, 30)
            };

            cancelButton.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Booking cancelled.");
                    cancelButton.Enabled = false;
                    cancelButton.Text = "Cancelled";
                    card.BackColor = Color.LightGray;
                }
            };

            card.Controls.Add(infoLabel);
            card.Controls.Add(cancelButton);
            flowLayoutPanel1.Controls.Add(card);
        }
    }
}