using System;
using System.Drawing;
using System.Windows.Forms;

namespace TravelBookingSystem2
{
    public partial class ViewDestinationsForm : Form
    {
        public ViewDestinationsForm()
        {
            InitializeComponent();
            LoadDestinations();
        }

        private void LoadDestinations()
        {
            // Clear any existing destination cards
            flowLayoutPanel1.Controls.Clear();

            // Add destination cards with properly qualified resource references
            AddDestination(
                "Paris",
                "City of lights and love.",
                "$999",
                TravelBookingSystem2.Properties.Resources.Paris
            );

            AddDestination(
                "Maldives",
                "Tropical paradise for peace and beauty.",
                "$1499",
                TravelBookingSystem2.Properties.Resources.Maldives
            );

            AddDestination(
                "Tokyo",
                "Tech-savvy, tradition-rich city.",
                "$1299",
                TravelBookingSystem2.Properties.Resources.Tokyo
            );
        }

        private void AddDestination(string title, string description, string price, Image img)
        {
            // Card container
            Panel card = new Panel
            {
                Width = 280,
                Height = 200,
                BackColor = Color.White,
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Destination image
            PictureBox pic = new PictureBox
            {
                Image = img,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Width = 260,
                Height = 100,
                Location = new Point(10, 10)
            };

            // Title label
            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(10, 115),
                AutoSize = true
            };

            // Description label
            Label descLabel = new Label
            {
                Text = description,
                Location = new Point(10, 140),
                Size = new Size(260, 20)
            };

            // Price label
            Label priceLabel = new Label
            {
                Text = price,
                Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                Location = new Point(10, 165),
                AutoSize = true
            };

            // Add controls to card
            card.Controls.Add(pic);
            card.Controls.Add(titleLabel);
            card.Controls.Add(descLabel);
            card.Controls.Add(priceLabel);

            // Add card to flowLayoutPanel
            flowLayoutPanel1.Controls.Add(card);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}