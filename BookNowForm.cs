using System;
using System.Windows.Forms;

namespace TravelBookingSystem2
{
    public partial class BookNowForm : Form
    {
        public static string LastBookingDetails = ""; // Step 1: Static booking string

        public BookNowForm()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string destination = destinationComboBox.Text;
            DateTime travelDate = travelDatePicker.Value;
            int travelers = (int)travelersUpDown.Value;

            if (string.IsNullOrWhiteSpace(destination))
            {
                MessageBox.Show("Please select a destination.");
                return;
            }

            string services = "";
            if (flightCheckBox.Checked) services += "Flight ";
            if (hotelCheckBox.Checked) services += "Hotel ";
            if (taxiCheckBox.Checked) services += "Taxi ";
            if (string.IsNullOrWhiteSpace(services)) services = "None";

            // Store booking summary for MyBookingsForm to use
            LastBookingDetails =
                $"Type: {services.Trim()}\n" +
                $"Location: {destination}\n" +
                $"Date: {travelDate:dd MMM yyyy}\n" +
                $"Travelers: {travelers}\n" +
                $"Status: Confirmed";

            MessageBox.Show("✅ Booking Confirmed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void BookNowForm_Load(object sender, EventArgs e)
        {
        }

        private void travelDatePicker_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}