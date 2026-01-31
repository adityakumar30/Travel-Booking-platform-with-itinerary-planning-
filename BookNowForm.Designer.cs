namespace TravelBookingSystem2
{
    partial class BookNowForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox destinationComboBox;
        private System.Windows.Forms.DateTimePicker travelDatePicker;
        private System.Windows.Forms.NumericUpDown travelersUpDown;
        private System.Windows.Forms.CheckBox flightCheckBox;
        private System.Windows.Forms.CheckBox hotelCheckBox;
        private System.Windows.Forms.CheckBox taxiCheckBox;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label destinationLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label travelersLabel;
        private System.Windows.Forms.Label serviceLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.destinationComboBox = new System.Windows.Forms.ComboBox();
            this.travelDatePicker = new System.Windows.Forms.DateTimePicker();
            this.travelersUpDown = new System.Windows.Forms.NumericUpDown();
            this.flightCheckBox = new System.Windows.Forms.CheckBox();
            this.hotelCheckBox = new System.Windows.Forms.CheckBox();
            this.taxiCheckBox = new System.Windows.Forms.CheckBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.destinationLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.travelersLabel = new System.Windows.Forms.Label();
            this.serviceLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.travelersUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // destinationComboBox
            // 
            this.destinationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationComboBox.Items.AddRange(new object[] {
            "Paris",
            "Maldives",
            "Tokyo"});
            this.destinationComboBox.Location = new System.Drawing.Point(88, 133);
            this.destinationComboBox.Name = "destinationComboBox";
            this.destinationComboBox.Size = new System.Drawing.Size(220, 21);
            this.destinationComboBox.TabIndex = 2;
            // 
            // travelDatePicker
            // 
            this.travelDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.travelDatePicker.Location = new System.Drawing.Point(644, 134);
            this.travelDatePicker.Name = "travelDatePicker";
            this.travelDatePicker.Size = new System.Drawing.Size(220, 20);
            this.travelDatePicker.TabIndex = 4;
            // 
            // travelersUpDown
            // 
            this.travelersUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.travelersUpDown.Location = new System.Drawing.Point(712, 273);
            this.travelersUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.travelersUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.travelersUpDown.Name = "travelersUpDown";
            this.travelersUpDown.Size = new System.Drawing.Size(60, 20);
            this.travelersUpDown.TabIndex = 6;
            this.travelersUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // flightCheckBox
            // 
            this.flightCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flightCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.flightCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flightCheckBox.Location = new System.Drawing.Point(133, 263);
            this.flightCheckBox.Name = "flightCheckBox";
            this.flightCheckBox.Size = new System.Drawing.Size(100, 30);
            this.flightCheckBox.TabIndex = 8;
            this.flightCheckBox.Text = "Flight";
            this.flightCheckBox.UseVisualStyleBackColor = false;
            // 
            // hotelCheckBox
            // 
            this.hotelCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.hotelCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.hotelCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hotelCheckBox.Location = new System.Drawing.Point(133, 297);
            this.hotelCheckBox.Name = "hotelCheckBox";
            this.hotelCheckBox.Size = new System.Drawing.Size(100, 20);
            this.hotelCheckBox.TabIndex = 9;
            this.hotelCheckBox.Text = "Hotel";
            this.hotelCheckBox.UseVisualStyleBackColor = false;
            // 
            // taxiCheckBox
            // 
            this.taxiCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.taxiCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.taxiCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxiCheckBox.Location = new System.Drawing.Point(133, 323);
            this.taxiCheckBox.Name = "taxiCheckBox";
            this.taxiCheckBox.Size = new System.Drawing.Size(100, 20);
            this.taxiCheckBox.TabIndex = 10;
            this.taxiCheckBox.Text = "Taxi";
            this.taxiCheckBox.UseVisualStyleBackColor = false;
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.confirmButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirmButton.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.White;
            this.confirmButton.Location = new System.Drawing.Point(363, 387);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(160, 56);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Confirm Booking";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Navy;
            this.titleLabel.Location = new System.Drawing.Point(-210, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(300, 35);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Book Your Trip";
            // 
            // destinationLabel
            // 
            this.destinationLabel.BackColor = System.Drawing.Color.Transparent;
            this.destinationLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationLabel.Location = new System.Drawing.Point(117, 101);
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(162, 20);
            this.destinationLabel.TabIndex = 1;
            this.destinationLabel.Text = "Select Destination:";
            // 
            // dateLabel
            // 
            this.dateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(694, 101);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(112, 20);
            this.dateLabel.TabIndex = 3;
            this.dateLabel.Text = "Travel Date:";
            // 
            // travelersLabel
            // 
            this.travelersLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.travelersLabel.BackColor = System.Drawing.Color.Transparent;
            this.travelersLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.travelersLabel.Location = new System.Drawing.Point(674, 240);
            this.travelersLabel.Name = "travelersLabel";
            this.travelersLabel.Size = new System.Drawing.Size(144, 20);
            this.travelersLabel.TabIndex = 5;
            this.travelersLabel.Text = "No. of Travelers:";
            // 
            // serviceLabel
            // 
            this.serviceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.serviceLabel.BackColor = System.Drawing.Color.Transparent;
            this.serviceLabel.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviceLabel.Location = new System.Drawing.Point(100, 240);
            this.serviceLabel.Name = "serviceLabel";
            this.serviceLabel.Size = new System.Drawing.Size(162, 20);
            this.serviceLabel.TabIndex = 7;
            this.serviceLabel.Text = "Select Options:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 68);
            this.panel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(313, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Your Trip";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TravelBookingSystem2.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BookNowForm
            // 
            this.BackgroundImage = global::TravelBookingSystem2.Properties.Resources.pexels_quang_nguyen_vinh_222549_14022236;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 566);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.destinationLabel);
            this.Controls.Add(this.destinationComboBox);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.travelDatePicker);
            this.Controls.Add(this.travelersLabel);
            this.Controls.Add(this.travelersUpDown);
            this.Controls.Add(this.serviceLabel);
            this.Controls.Add(this.flightCheckBox);
            this.Controls.Add(this.hotelCheckBox);
            this.Controls.Add(this.taxiCheckBox);
            this.Controls.Add(this.confirmButton);
            this.Name = "BookNowForm";
            this.Text = "Book Now";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookNowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.travelersUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}