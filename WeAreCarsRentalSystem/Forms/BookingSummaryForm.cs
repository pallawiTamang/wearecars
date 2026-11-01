using System;
using System.Drawing;
using System.Windows.Forms;
using WeAreCarsRentalSystem.Models;
using WeAreCarsRentalSystem.Services;
using WeAreCarsRentalSystem.Utilities;

namespace WeAreCarsRentalSystem.Forms
{
    /// <summary>
    /// Modal summary and verification dialog for vehicle rental bookings.
    /// Presents full customer identification, rental options, and itemised financial audit.
    /// Strictly ensures no booking is stored until staff explicitly clicks 'Confirm Booking'.
    /// </summary>
    public partial class BookingSummaryForm : Form
    {
        private readonly Customer _customer;
        private readonly PriceBreakdown _breakdown;

        public Booking? ConfirmedBooking { get; private set; }

        public BookingSummaryForm(Customer customer, PriceBreakdown breakdown)
        {
            _customer = customer ?? throw new ArgumentNullException(nameof(customer));
            _breakdown = breakdown ?? throw new ArgumentNullException(nameof(breakdown));

            InitializeComponent();
            ApplyCustomStyling();
            SetupTooltips();
            DisplaySummaryData();
        }

        private void ApplyCustomStyling()
        {
            picLogo.Image = UITheme.GetLogoImage();
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            lblSystemTitle.Font = UITheme.TitleFont;
            lblSystemTitle.ForeColor = UITheme.PrimaryBlue;

            lblSummaryTitle.Font = UITheme.SubtitleFont;
            lblSummaryTitle.ForeColor = UITheme.AccentBlue;

            UITheme.StylePrimaryButton(btnConfirmBooking);
            UITheme.StyleSecondaryButton(btnBackEdit);
            UITheme.StyleSecondaryButton(btnCancel);
        }

        private void SetupTooltips()
        {
            var tip = new ToolTip();
            tip.SetToolTip(btnConfirmBooking, "Store and commit this booking to active fleet rentals.");
            tip.SetToolTip(btnBackEdit, "Return to the booking configuration form to modify details.");
            tip.SetToolTip(btnCancel, "Discard this booking and return without saving.");
        }

        private void DisplaySummaryData()
        {
            // Customer Details
            lblValCustomerName.Text = _customer.FullName;
            lblValAddress.Text = _customer.Address;
            lblValAge.Text = $"{_customer.Age} years";
            lblValLicence.Text = _customer.HasValidDrivingLicence ? "Valid UK / EU Licence (Verified)" : "Invalid";

            // Rental Details
            lblValDays.Text = $"{_breakdown.RentalDays} day(s)";
            lblValCarType.Text = _breakdown.CarType switch
            {
                CarType.CityCar => "City Car (£0 extra)",
                CarType.FamilyCar => "Family Car (+£50)",
                CarType.SportsCar => "Sports Car (+£75)",
                CarType.SUV => "SUV (+£65)",
                _ => _breakdown.CarType.ToString()
            };
            lblValFuelType.Text = _breakdown.FuelType switch
            {
                FuelType.Petrol => "Petrol (£0 extra)",
                FuelType.Diesel => "Diesel (£0 extra)",
                FuelType.Hybrid => "Hybrid (+£30)",
                FuelType.FullElectric => "Full Electric (+£50)",
                _ => _breakdown.FuelType.ToString()
            };

            // Optional Extras
            lblValMileage.Text = _breakdown.HasUnlimitedMileage
                ? $"Included ({_breakdown.RentalDays} days × £10.00 = £{_breakdown.UnlimitedMileageCost:F2})"
                : "Not Selected (£0.00)";

            lblValBreakdownCover.Text = _breakdown.HasBreakdownCover
                ? $"Included ({_breakdown.RentalDays} days × £2.00 = £{_breakdown.BreakdownCoverCost:F2})"
                : "Not Selected (£0.00)";

            // Itemised Financial Cost Breakdown
            lblValCostBase.Text = $"£{_breakdown.BaseRentalCost:F2}  ({_breakdown.RentalDays} days @ £25/day)";
            lblValCostCar.Text = $"£{_breakdown.CarSurcharge:F2}";
            lblValCostFuel.Text = $"£{_breakdown.FuelSurcharge:F2}";
            lblValCostMileage.Text = $"£{_breakdown.UnlimitedMileageCost:F2}";
            lblValCostBreakdown.Text = $"£{_breakdown.BreakdownCoverCost:F2}";

            // Grand Total
            lblValTotalPrice.Text = $"£{_breakdown.TotalPrice:F2}";
        }

        /// <summary>
        /// Permanently commits and stores the booking in the system.
        /// </summary>
        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            // 1. Generate unique booking reference
            string reference = BookingService.GenerateBookingReference();

            // 2. Instantiate and assemble the booking entity
            ConfirmedBooking = Booking.CreateFromBreakdown(reference, _customer, _breakdown);

            // 3. Store the booking in persistent / session service
            BookingService.ConfirmBooking(ConfirmedBooking);

            // 4. Set DialogResult to OK so caller can handle success
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        /// <summary>
        /// Closes the summary dialog without storing, allowing staff to edit fields on BookingForm.
        /// </summary>
        private void btnBackEdit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Retry;
            this.Close();
        }

        /// <summary>
        /// Prompts confirmation before abandoning unconfirmed booking.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to cancel this booking? All entered information will be discarded.",
                "Cancel Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
