using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCarsRentalSystem.Utilities;

namespace WeAreCarsRentalSystem.Forms
{
    /// <summary>
    /// Welcome Splash Screen for the WeAreCars Car Rental System.
    /// Provides corporate branding, application instructions, and a smooth animated transition to staff login.
    /// </summary>
    public partial class SplashForm : Form
    {
        private int _loadProgress = 0;

        public SplashForm()
        {
            InitializeComponent();
            ApplyCustomStyling();
        }

        private void ApplyCustomStyling()
        {
            // Configure corporate branding
            picLogo.Image = UITheme.GetLogoImage();
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            lblWelcomeTitle.Font = UITheme.TitleFont;
            lblWelcomeTitle.ForeColor = UITheme.PrimaryBlue;

            lblSubtitle.Font = UITheme.SubtitleFont;
            lblSubtitle.ForeColor = UITheme.AccentBlue;

            lblInstructions.Font = UITheme.BodyFont;
            lblInstructions.ForeColor = UITheme.TextDark;

            lblStatus.Font = UITheme.SmallFont;
            lblStatus.ForeColor = UITheme.TextMuted;

            UITheme.StylePrimaryButton(btnContinue);
        }

        private void SplashForm_Load(object sender, EventArgs e)
        {
            // Start the loading timer
            tmrSplash.Interval = 40; // ~2 seconds total for 50 ticks
            tmrSplash.Start();
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            _loadProgress += 2;

            if (_loadProgress < 30)
            {
                lblStatus.Text = "Initializing WeAreCars system modules...";
            }
            else if (_loadProgress < 60)
            {
                lblStatus.Text = "Loading vehicle tariffs and rental categories...";
            }
            else if (_loadProgress < 90)
            {
                lblStatus.Text = "Preparing staff authentication gateway...";
            }
            else
            {
                lblStatus.Text = "System ready. Launching login...";
            }

            if (_loadProgress <= 100)
            {
                prgLoading.Value = _loadProgress;
            }
            else
            {
                tmrSplash.Stop();
                ProceedToLogin();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Allow immediate transition if staff member does not wish to wait for progress bar
            tmrSplash.Stop();
            ProceedToLogin();
        }

        private void ProceedToLogin()
        {
            // Transition cleanly to the staff LoginForm
            var loginForm = new LoginForm();
            loginForm.FormClosed += (s, args) => this.Close();
            this.Hide();
            loginForm.Show();
        }
    }
}
