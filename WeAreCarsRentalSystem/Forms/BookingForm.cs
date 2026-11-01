using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCarsRentalSystem.Models;
using WeAreCarsRentalSystem.Services;
using WeAreCarsRentalSystem.Utilities;

namespace WeAreCarsRentalSystem.Forms
{
    /// <summary>
    /// Vehicle Rental Booking configuration form for WeAreCars staff.
    /// Captures mandatory customer details, verifies driving licence validity,
    /// configures rental parameters, and calculates live price previews.
    /// </summary>
    public partial class BookingForm : Form
    {
        private readonly DashboardForm _dashboard;
        private PriceBreakdown? _currentPriceBreakdown;

        public BookingForm(DashboardForm dashboard)
        {
            _dashboard = dashboard ?? throw new ArgumentNullException(nameof(dashboard));
            InitializeComponent();
            ApplyCustomStyling();
            SetupTooltips();
            PopulateDropdowns();
            UpdateLivePricePreview();
        }

        private void ApplyCustomStyling()
        {
            picLogo.Image = UITheme.GetLogoImage();
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            lblSystemTitle.Font = UITheme.TitleFont;
            lblSystemTitle.ForeColor = UITheme.PrimaryBlue;

            lblFormHeader.Font = UITheme.SubtitleFont;
            lblFormHeader.ForeColor = UITheme.PrimaryBlue;

            UITheme.StylePrimaryButton(btnReviewBooking);
            UITheme.StyleSecondaryButton(btnClearForm);
            UITheme.StyleSecondaryButton(btnBackToDashboard);

            pnlPreviewCard.BackColor = UITheme.BackgroundLight;
        }

        private void SetupTooltips()
        {
            var tip = new ToolTip();
            tip.SetToolTip(txtFirstName, "Enter the customer's legal first name.");
            tip.SetToolTip(txtSurname, "Enter the customer's legal family surname.");
            tip.SetToolTip(txtAddress, "Enter the customer's current permanent residential address.");
            tip.SetToolTip(txtAge, "Enter the customer's age in completed years (must be at least 17 to legally drive).");
            tip.SetToolTip(rdoLicenceYes, "Customer has presented an active and valid driving licence.");
            tip.SetToolTip(rdoLicenceNo, "Customer has no valid driving licence (rental blocked).");
            tip.SetToolTip(nudRentalDays, "Enter a rental period between 1 and 28 days (£25/day base charge).");
            tip.SetToolTip(cmbCarType, "Select the vehicle category required by the customer.");
            tip.SetToolTip(cmbFuelType, "Select the required propulsion/fuel type.");
            tip.SetToolTip(chkUnlimitedMileage, "Adds £10 per rental day for unrestricted mileage.");
            tip.SetToolTip(chkBreakdownCover, "Adds £2 per rental day for full roadside breakdown coverage.");
            tip.SetToolTip(btnReviewBooking, "Proceed to review full booking summary and confirm reservation.");
            tip.SetToolTip(btnClearForm, "Reset all input fields to default values.");
            tip.SetToolTip(btnBackToDashboard, "Return to the main staff dashboard.");
        }

        private void PopulateDropdowns()
        {
            // Populate Car Types
            cmbCarType.Items.Clear();
            cmbCarType.Items.Add("Select Vehicle Type...");
            cmbCarType.Items.Add("City Car (No extra charge)");
            cmbCarType.Items.Add("Family Car (+£50)");
            cmbCarType.Items.Add("Sports Car (+£75)");
            cmbCarType.Items.Add("SUV (+£65)");
            cmbCarType.SelectedIndex = 0;

            // Populate Fuel Types
            cmbFuelType.Items.Clear();
            cmbFuelType.Items.Add("Select Fuel Type...");
            cmbFuelType.Items.Add("Petrol (No extra charge)");
            cmbFuelType.Items.Add("Diesel (No extra charge)");
            cmbFuelType.Items.Add("Hybrid (+£30)");
            cmbFuelType.Items.Add("Full Electric (+£50)");
            cmbFuelType.SelectedIndex = 0;

            // Default licence selection to Yes for convenience, but staff can toggle
            rdoLicenceYes.Checked = true;
            nudRentalDays.Value = 1;
        }

        /// <summary>
        /// Recalculates and updates the live pricing preview card.
        /// </summary>
        private void UpdateLivePricePreview()
        {
            int days = (int)nudRentalDays.Value;
            if (days < 1) days = 1;
            if (days > 28) days = 28;

            CarType carType = GetSelectedCarType() ?? CarType.CityCar;
            FuelType fuelType = GetSelectedFuelType() ?? FuelType.Petrol;
            bool unlimitedMileage = chkUnlimitedMileage.Checked;
            bool breakdownCover = chkBreakdownCover.Checked;

            _currentPriceBreakdown = PricingService.Calculate(days, carType, fuelType, unlimitedMileage, breakdownCover);

            lblPreviewDays.Text = $"{days} day(s) × £25.00 = £{_currentPriceBreakdown.BaseRentalCost:F2}";
            lblPreviewCar.Text = $"{_currentPriceBreakdown.CarType} surcharge: £{_currentPriceBreakdown.CarSurcharge:F2}";
            lblPreviewFuel.Text = $"{_currentPriceBreakdown.FuelType} surcharge: £{_currentPriceBreakdown.FuelSurcharge:F2}";
            lblPreviewMileage.Text = unlimitedMileage ? $"Unlimited Mileage ({days} × £10.00): £{_currentPriceBreakdown.UnlimitedMileageCost:F2}" : "Unlimited Mileage: £0.00";
            lblPreviewBreakdown.Text = breakdownCover ? $"Breakdown Cover ({days} × £2.00): £{_currentPriceBreakdown.BreakdownCoverCost:F2}" : "Breakdown Cover: £0.00";
            lblPreviewTotal.Text = $"£{_currentPriceBreakdown.TotalPrice:F2}";
        }

        private CarType? GetSelectedCarType()
        {
            return cmbCarType.SelectedIndex switch
            {
                1 => CarType.CityCar,
                2 => CarType.FamilyCar,
                3 => CarType.SportsCar,
                4 => CarType.SUV,
                _ => null
            };
        }

        private FuelType? GetSelectedFuelType()
        {
            return cmbFuelType.SelectedIndex switch
            {
                1 => FuelType.Petrol,
                2 => FuelType.Diesel,
                3 => FuelType.Hybrid,
                4 => FuelType.FullElectric,
                _ => null
            };
        }

        // Live Preview Event Handlers
        private void nudRentalDays_ValueChanged(object sender, EventArgs e) => UpdateLivePricePreview();
        private void cmbCarType_SelectedIndexChanged(object sender, EventArgs e) => UpdateLivePricePreview();
        private void cmbFuelType_SelectedIndexChanged(object sender, EventArgs e) => UpdateLivePricePreview();
        private void chkUnlimitedMileage_CheckedChanged(object sender, EventArgs e) => UpdateLivePricePreview();
        private void chkBreakdownCover_CheckedChanged(object sender, EventArgs e) => UpdateLivePricePreview();

        /// <summary>
        /// Validates all mandatory customer and vehicle requirements before progression.
        /// </summary>
        private bool ValidateBookingInputs(out string errorMessage, out Control? controlToFocus)
        {
            errorMessage = string.Empty;
            controlToFocus = null;

            // 1. Customer First Name validation
            string firstName = txtFirstName.Text.Trim();
            if (string.IsNullOrWhiteSpace(firstName))
            {
                errorMessage = "Please enter the customer's first name.";
                controlToFocus = txtFirstName;
                return false;
            }
            if (decimal.TryParse(firstName, out _))
            {
                errorMessage = "Customer first name cannot be a purely numeric value.";
                controlToFocus = txtFirstName;
                return false;
            }

            // 2. Customer Surname validation
            string surname = txtSurname.Text.Trim();
            if (string.IsNullOrWhiteSpace(surname))
            {
                errorMessage = "Please enter the customer's surname.";
                controlToFocus = txtSurname;
                return false;
            }
            if (decimal.TryParse(surname, out _))
            {
                errorMessage = "Customer surname cannot be a purely numeric value.";
                controlToFocus = txtSurname;
                return false;
            }

            // 3. Customer Address validation
            string address = txtAddress.Text.Trim();
            if (string.IsNullOrWhiteSpace(address))
            {
                errorMessage = "Please enter the customer's full address.";
                controlToFocus = txtAddress;
                return false;
            }

            // 4. Customer Age validation
            string ageText = txtAge.Text.Trim();
            if (string.IsNullOrWhiteSpace(ageText))
            {
                errorMessage = "Please enter the customer's age.";
                controlToFocus = txtAge;
                return false;
            }
            if (!int.TryParse(ageText, out int age) || age <= 0)
            {
                errorMessage = "Customer age must be a valid positive whole number.";
                controlToFocus = txtAge;
                return false;
            }
            if (age < 17)
            {
                errorMessage = "Customer must be at least 17 years old to hold a valid UK driving licence.";
                controlToFocus = txtAge;
                return false;
            }

            // 5. Driving Licence validation (Mandatory Requirement)
            if (!rdoLicenceYes.Checked)
            {
                errorMessage = "A valid driving licence is required to proceed with this booking.";
                controlToFocus = rdoLicenceNo;
                return false;
            }

            // 6. Rental Days validation (1 to 28 days)
            int days = (int)nudRentalDays.Value;
            if (days < 1 || days > 28)
            {
                errorMessage = "Rental duration must be between 1 and 28 days.";
                controlToFocus = nudRentalDays;
                return false;
            }

            // 7. Car Type Selection
            if (cmbCarType.SelectedIndex <= 0)
            {
                errorMessage = "Please select a vehicle category.";
                controlToFocus = cmbCarType;
                return false;
            }

            // 8. Fuel Type Selection
            if (cmbFuelType.SelectedIndex <= 0)
            {
                errorMessage = "Please select a fuel type.";
                controlToFocus = cmbFuelType;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Validates inputs and opens the Booking Summary screen.
        /// </summary>
        private void btnReviewBooking_Click(object sender, EventArgs e)
        {
            if (!ValidateBookingInputs(out string errorMessage, out Control? controlToFocus))
            {
                MessageBox.Show(
                    errorMessage,
                    "Booking Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                controlToFocus?.Focus();
                return;
            }

            // Build Customer instance
            var customer = new Customer(
                txtFirstName.Text.Trim(),
                txtSurname.Text.Trim(),
                txtAddress.Text.Trim(),
                int.Parse(txtAge.Text.Trim()),
                rdoLicenceYes.Checked);

            // Compute accurate price breakdown
            CarType carType = GetSelectedCarType()!.Value;
            FuelType fuelType = GetSelectedFuelType()!.Value;
            int days = (int)nudRentalDays.Value;
            bool unlimitedMileage = chkUnlimitedMileage.Checked;
            bool breakdownCover = chkBreakdownCover.Checked;

            PriceBreakdown breakdown = PricingService.Calculate(
                days,
                carType,
                fuelType,
                unlimitedMileage,
                breakdownCover);

            // Open BookingSummaryForm as modal dialog
            using var summaryForm = new BookingSummaryForm(customer, breakdown);
            DialogResult result = summaryForm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                // Booking was successfully confirmed and stored
                _dashboard.RefreshRentalStats();

                DialogResult nextAction = MessageBox.Show(
                    "Booking confirmed successfully!\n\nWould you like to view the Rented Cars list now?",
                    "Booking Complete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information);

                if (nextAction == DialogResult.Yes)
                {
                    this.Close();
                    var rentedCarsForm = new RentedCarsForm(_dashboard);
                    rentedCarsForm.Show();
                }
                else
                {
                    // Return to dashboard
                    this.Close();
                    _dashboard.Show();
                }
            }
            // If result is Cancel / Retry, staff member remains on BookingForm with values intact for editing
        }

        /// <summary>
        /// Clears all input controls back to defaults upon confirmation.
        /// </summary>
        private void btnClearForm_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to clear all entered customer details and rental options?",
                "Clear Booking Form",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                txtFirstName.Clear();
                txtSurname.Clear();
                txtAddress.Clear();
                txtAge.Clear();
                rdoLicenceYes.Checked = true;
                nudRentalDays.Value = 1;
                cmbCarType.SelectedIndex = 0;
                cmbFuelType.SelectedIndex = 0;
                chkUnlimitedMileage.Checked = false;
                chkBreakdownCover.Checked = false;
                UpdateLivePricePreview();
                txtFirstName.Focus();
            }
        }

        /// <summary>
        /// Returns to Dashboard without creating a booking.
        /// </summary>
        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to return to the dashboard? Any unconfirmed booking information will be discarded.",
                "Return to Dashboard",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                this.Close();
                _dashboard.Show();
            }
        }

        private void BookingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_dashboard.Visible && !Application.OpenForms.OfType<RentedCarsForm>().Any())
            {
                _dashboard.Show();
            }
        }
    }
}
