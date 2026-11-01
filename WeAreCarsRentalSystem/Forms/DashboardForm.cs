using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCarsRentalSystem.Services;
using WeAreCarsRentalSystem.Utilities;

namespace WeAreCarsRentalSystem.Forms
{
    /// <summary>
    /// Central operational dashboard for WeAreCars staff.
    /// Provides access to creating new vehicle bookings, inspecting current rentals,
    /// viewing operational statistics, and logging out securely.
    /// </summary>
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            ApplyCustomStyling();
            SetupTooltips();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            UpdateStaffDisplay();
            RefreshRentalStats();

            // Start live clock ticker
            tmrClock.Interval = 1000;
            tmrClock.Start();
            UpdateClock();
        }

        private void ApplyCustomStyling()
        {
            picLogo.Image = UITheme.GetLogoImage();
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            lblSystemTitle.Font = UITheme.TitleFont;
            lblSystemTitle.ForeColor = UITheme.PrimaryBlue;

            lblStaffWelcome.Font = UITheme.SubtitleFont;
            lblStaffWelcome.ForeColor = UITheme.TextDark;

            lblSectionTitle.Font = UITheme.SubtitleFont;
            lblSectionTitle.ForeColor = UITheme.AccentBlue;

            UITheme.StylePrimaryButton(btnNewBooking);
            UITheme.StylePrimaryButton(btnRentedCars);
            UITheme.StyleSecondaryButton(btnLogout);
        }

        private void SetupTooltips()
        {
            var tip = new ToolTip();
            tip.SetToolTip(btnNewBooking, "Open the vehicle reservation form to create a new customer rental.");
            tip.SetToolTip(btnRentedCars, "View and filter currently active vehicle rentals in the system.");
            tip.SetToolTip(btnLogout, "Securely end the current staff session and return to login.");
        }

        private void UpdateStaffDisplay()
        {
            string staffName = AuthService.CurrentStaff?.DisplayName ?? "Staff Member";
            lblStaffWelcome.Text = $"Welcome, {staffName}";
        }

        public void RefreshRentalStats()
        {
            var allBookings = BookingService.GetAllBookings();
            lblTotalRentalsCount.Text = allBookings.Count.ToString();
        }

        private void UpdateClock()
        {
            lblDateTime.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy  HH:mm:ss");
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }

        /// <summary>
        /// Navigates to the New Booking screen.
        /// </summary>
        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            var bookingForm = new BookingForm(this);
            this.Hide();
            bookingForm.Show();
        }

        /// <summary>
        /// Navigates to the Rented Cars screen.
        /// </summary>
        private void btnRentedCars_Click(object sender, EventArgs e)
        {
            var rentedCarsForm = new RentedCarsForm(this);
            this.Hide();
            rentedCarsForm.Show();
        }

        /// <summary>
        /// Logs out the staff member with confirmation and returns cleanly to LoginForm.
        /// </summary>
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out of the current staff session?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                AuthService.Logout();
                var loginForm = new LoginForm();
                loginForm.FormClosed += (s, args) => Application.Exit();
                this.Hide();
                loginForm.Show();
            }
        }

        private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // If user closed dashboard directly with the X button, ensure clean exit
            if (e.CloseReason == CloseReason.UserClosing && this.Visible)
            {
                Application.Exit();
            }
        }
    }
}
