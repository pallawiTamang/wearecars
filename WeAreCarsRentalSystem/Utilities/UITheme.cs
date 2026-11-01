using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace WeAreCarsRentalSystem.Utilities
{
    /// <summary>
    /// Provides consistent visual styling, fonts, color palettes, and graphic assets
    /// adhering to professional UI design standards and the WeAreCars corporate identity.
    /// </summary>
    public static class UITheme
    {
        // Color Palette
        public static readonly Color PrimaryBlue = Color.FromArgb(16, 52, 96);       // Deep corporate navy
        public static readonly Color AccentBlue = Color.FromArgb(37, 99, 235);        // Vibrant primary accent
        public static readonly Color BackgroundLight = Color.FromArgb(248, 250, 252); // Crisp light slate background
        public static readonly Color CardWhite = Color.FromArgb(255, 255, 255);       // Pure white card panel
        public static readonly Color BorderLight = Color.FromArgb(226, 232, 240);     // Subtle divider border
        public static readonly Color TextDark = Color.FromArgb(15, 23, 42);          // Deep charcoal text
        public static readonly Color TextMuted = Color.FromArgb(100, 116, 139);      // Secondary grey text
        public static readonly Color SuccessGreen = Color.FromArgb(22, 101, 52);      // Positive feedback green
        public static readonly Color ErrorRed = Color.FromArgb(185, 28, 28);          // Validation error red
        public static readonly Color WarningAmber = Color.FromArgb(180, 83, 9);       // Warning amber

        // Standard Typography
        public static readonly Font TitleFont = new Font("Segoe UI", 16F, FontStyle.Bold);
        public static readonly Font SubtitleFont = new Font("Segoe UI", 11F, FontStyle.Bold);
        public static readonly Font BodyFont = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        public static readonly Font BodyBold = new Font("Segoe UI", 9.5F, FontStyle.Bold);
        public static readonly Font SmallFont = new Font("Segoe UI", 8.5F, FontStyle.Regular);

        /// <summary>
        /// Attempts to load the official WeAreCars logo image from the application Resources directory.
        /// If not found on disk, gracefully renders a fallback high-resolution branded logo bitmap.
        /// </summary>
        public static Image GetLogoImage()
        {
            try
            {
                // Check local base directory Resources
                string baseDir = AppDomain.CurrentDomain.BaseDirectory;
                string primaryPath = Path.Combine(baseDir, "Resources", "WeAreCars.png");

                if (File.Exists(primaryPath))
                {
                    return Image.FromFile(primaryPath);
                }

                // Check project root Resources folder
                string projectDir = Path.GetFullPath(Path.Combine(baseDir, "..", "..", "..", "Resources", "WeAreCars.png"));
                if (File.Exists(projectDir))
                {
                    return Image.FromFile(projectDir);
                }
            }
            catch
            {
                // Fallback to rendered logo
            }

            return CreateFallbackLogo();
        }

        /// <summary>
        /// Generates a clean fallback corporate logo bitmap in case the file asset is relocated.
        /// </summary>
        private static Image CreateFallbackLogo()
        {
            var bmp = new Bitmap(220, 60);
            using (var g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                using var brush = new SolidBrush(PrimaryBlue);
                using var fontMain = new Font("Segoe UI", 16F, FontStyle.Bold);
                using var fontSub = new Font("Segoe UI", 8F, FontStyle.Regular);
                g.DrawString("WeAreCars", fontMain, brush, new PointF(5, 5));
                g.DrawString("CAR RENTAL SYSTEM", fontSub, new SolidBrush(AccentBlue), new PointF(6, 35));
            }
            return bmp;
        }

        /// <summary>
        /// Applies consistent primary styling to standard action buttons.
        /// </summary>
        public static void StylePrimaryButton(Button button)
        {
            button.BackColor = PrimaryBlue;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = BodyBold;
            button.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Applies consistent secondary styling to cancel/back buttons.
        /// </summary>
        public static void StyleSecondaryButton(Button button)
        {
            button.BackColor = CardWhite;
            button.ForeColor = TextDark;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = BorderLight;
            button.FlatAppearance.BorderSize = 1;
            button.Font = BodyFont;
            button.Cursor = Cursors.Hand;
        }
    }
}
