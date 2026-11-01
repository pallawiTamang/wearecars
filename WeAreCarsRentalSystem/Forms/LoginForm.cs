using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCarsRentalSystem.Services;
using WeAreCarsRentalSystem.Utilities;

namespace WeAreCarsRentalSystem.Forms
{
    /// <summary>
    /// Staff Authentication Gateway for the WeAreCars Rental System.
    /// Strictly verifies the CET131 Assignment 2 fixed staff credentials:
    /// Username: sta001
    /// Password: givemethekeys123
    /// </summary>
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            ApplyCustomStyling();
            SetupTooltips();
        }

        private void ApplyCustomStyling()
        {
            picLogo.Image = UITheme.GetLogoImage();
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            lblTitle.Font = UITheme.TitleFont;
            lblTitle.ForeColor = UITheme.PrimaryBlue;

            lblSubtitle.Font = UITheme.SubtitleFont;
            lblSubtitle.ForeColor = UITheme.TextMuted;

            UITheme.StylePrimaryButton(btnLogin);
            UITheme.StyleSecondaryButton(btnExit);

            lblValidationFeedback.ForeColor = UITheme.ErrorRed;
            lblValidationFeedback.Text = string.Empty;

            // Mask password characters by default
            txtPassword.UseSystemPasswordChar = true;
        }

        private void SetupTooltips()
        {
            var tip = new ToolTip();
            tip.SetToolTip(txtUsername, "Enter your staff user ID (e.g., sta001).");
            tip.SetToolTip(txtPassword, "Enter your confidential staff password.");
            tip.SetToolTip(chkShowPassword, "Toggle password text visibility.");
            tip.SetToolTip(btnLogin, "Authenticate and access the staff dashboard.");
            tip.SetToolTip(btnExit, "Exit the WeAreCars application.");
        }

        /// <summary>
        /// Handles the staff login attempt with robust validation and exact error reporting.
        /// </summary>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            // Clear previous inline feedback
            lblValidationFeedback.Text = string.Empty;

            // Perform authentication using AuthService
            bool isAuthenticated = AuthService.Authenticate(username, password, out string errorMessage);

            if (!isAuthenticated)
            {
                // Display feedback both on the form's status label and via an explicit message box
                lblValidationFeedback.Text = errorMessage;
                MessageBox.Show(
                    errorMessage,
                    "Authentication Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                // Guide user focus appropriately
                if (string.IsNullOrWhiteSpace(username))
                {
                    txtUsername.Focus();
                }
                else
                {
                    txtPassword.SelectAll();
                    txtPassword.Focus();
                }
                return;
            }

            // Successful authentication: Open Dashboard and transfer control
            var dashboard = new DashboardForm();
            dashboard.FormClosed += (s, args) => this.Close();
            this.Hide();
            dashboard.Show();
        }

        /// <summary>
        /// Toggles password text visibility.
        /// </summary>
        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !chkShowPassword.Checked;
        }

        /// <summary>
        /// Exits the application cleanly upon staff confirmation.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the WeAreCars Rental System?",
                "Confirm Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
