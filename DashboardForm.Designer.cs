namespace TravelBookingSystem2
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.viewDestButton = new System.Windows.Forms.Button();
            this.bookNowButton = new System.Windows.Forms.Button();
            this.myBookingsButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Controls.Add(this.logoPictureBox);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(989, 76);
            this.headerPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Travel Booking Dashboard";
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::TravelBookingSystem2.Properties.Resources.Logo;
            this.logoPictureBox.InitialImage = global::TravelBookingSystem2.Properties.Resources.Logo;
            this.logoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.Size = new System.Drawing.Size(74, 70);
            this.logoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoPictureBox.TabIndex = 2;
            this.logoPictureBox.TabStop = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.welcomeLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.welcomeLabel.Location = new System.Drawing.Point(401, 128);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(141, 21);
            this.welcomeLabel.TabIndex = 1;
            this.welcomeLabel.Text = "Welcome, [User]!";
            // 
            // viewDestButton
            // 
            this.viewDestButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.viewDestButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.viewDestButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewDestButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.viewDestButton.Location = new System.Drawing.Point(368, 183);
            this.viewDestButton.Name = "viewDestButton";
            this.viewDestButton.Size = new System.Drawing.Size(223, 53);
            this.viewDestButton.TabIndex = 2;
            this.viewDestButton.Text = "View Destinations";
            this.viewDestButton.UseVisualStyleBackColor = false;
            this.viewDestButton.Click += new System.EventHandler(this.viewDestButton_Click);
            // 
            // bookNowButton
            // 
            this.bookNowButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bookNowButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.bookNowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookNowButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bookNowButton.Location = new System.Drawing.Point(368, 269);
            this.bookNowButton.Name = "bookNowButton";
            this.bookNowButton.Size = new System.Drawing.Size(223, 54);
            this.bookNowButton.TabIndex = 3;
            this.bookNowButton.Text = "Book Now";
            this.bookNowButton.UseVisualStyleBackColor = false;
            this.bookNowButton.Click += new System.EventHandler(this.bookNowButton_Click);
            // 
            // myBookingsButton
            // 
            this.myBookingsButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.myBookingsButton.BackColor = System.Drawing.Color.Goldenrod;
            this.myBookingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBookingsButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.myBookingsButton.Location = new System.Drawing.Point(368, 347);
            this.myBookingsButton.Name = "myBookingsButton";
            this.myBookingsButton.Size = new System.Drawing.Size(223, 53);
            this.myBookingsButton.TabIndex = 4;
            this.myBookingsButton.Text = "My Bookings";
            this.myBookingsButton.UseVisualStyleBackColor = false;
            this.myBookingsButton.Click += new System.EventHandler(this.myBookingsButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logoutButton.BackColor = System.Drawing.Color.IndianRed;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.logoutButton.Location = new System.Drawing.Point(368, 443);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(223, 54);
            this.logoutButton.TabIndex = 5;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // DashboardForm
            // 
            this.BackgroundImage = global::TravelBookingSystem2.Properties.Resources.beautiful_tropical_beach_sea;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 559);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.myBookingsButton);
            this.Controls.Add(this.bookNowButton);
            this.Controls.Add(this.viewDestButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.headerPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DashboardForm";
            this.Text = "Dashboard - Travel Booking System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button viewDestButton;
        private System.Windows.Forms.Button bookNowButton;
        private System.Windows.Forms.Button myBookingsButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.PictureBox logoPictureBox;
    }
}