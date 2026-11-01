using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WeAreCarsRentalSystem.Models;
using WeAreCarsRentalSystem.Services;
using WeAreCarsRentalSystem.Utilities;

namespace WeAreCarsRentalSystem.Forms
{
    /// <summary>
    /// Displays and filters the live operational fleet of rented vehicles and confirmed bookings.
    /// Utilises a styled DataGridView directly bound to real booking data.
    /// </summary>
    public partial class RentedCarsForm : Form
    {
        private readonly DashboardForm _dashboard;

        public RentedCarsForm(DashboardForm dashboard)
        {
            _dashboard = dashboard ?? throw new ArgumentNullException(nameof(dashboard));
            InitializeComponent();
            ApplyCustomStyling();
            SetupTooltips();
            PopulateFilterDropdown();
            ConfigureDataGridView();
            LoadRentedCars();
        }

        private void ApplyCustomStyling()
        {
            picLogo.Image = UITheme.GetLogoImage();
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;

            lblSystemTitle.Font = UITheme.TitleFont;
            lblSystemTitle.ForeColor = UITheme.PrimaryBlue;

            lblFormHeader.Font = UITheme.SubtitleFont;
            lblFormHeader.ForeColor = UITheme.PrimaryBlue;

            UITheme.StylePrimaryButton(btnNewBooking);
            UITheme.StyleSecondaryButton(btnRefresh);
            UITheme.StyleSecondaryButton(btnBackToDashboard);
        }

        private void SetupTooltips()
        {
            var tip = new ToolTip();
            tip.SetToolTip(txtSearch, "Search active rentals by customer name, address, or booking reference.");
            tip.SetToolTip(cmbFilterCarType, "Filter displayed rentals by vehicle category.");
            tip.SetToolTip(btnRefresh, "Reload bookings from the local store.");
            tip.SetToolTip(btnNewBooking, "Open reservation form to create a new vehicle rental.");
            tip.SetToolTip(btnBackToDashboard, "Return to the main staff dashboard.");
            tip.SetToolTip(dgvRentedCars, "Double-click any booking row to inspect detailed customer and rental breakdown.");
        }

        private void PopulateFilterDropdown()
        {
            cmbFilterCarType.Items.Clear();
            cmbFilterCarType.Items.Add("All Vehicle Categories");
            cmbFilterCarType.Items.Add("City Car");
            cmbFilterCarType.Items.Add("Family Car");
            cmbFilterCarType.Items.Add("Sports Car");
            cmbFilterCarType.Items.Add("SUV");
            cmbFilterCarType.SelectedIndex = 0;
        }

        private void ConfigureDataGridView()
        {
            dgvRentedCars.AutoGenerateColumns = false;
            dgvRentedCars.AllowUserToAddRows = false;
            dgvRentedCars.AllowUserToDeleteRows = false;
            dgvRentedCars.ReadOnly = true;
            dgvRentedCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRentedCars.MultiSelect = false;
            dgvRentedCars.BackgroundColor = Color.White;
            dgvRentedCars.BorderStyle = BorderStyle.None;
            dgvRentedCars.RowHeadersVisible = false;
            dgvRentedCars.DefaultCellStyle.Font = UITheme.BodyFont;
            dgvRentedCars.ColumnHeadersDefaultCellStyle.Font = UITheme.BodyBold;
            dgvRentedCars.ColumnHeadersDefaultCellStyle.BackColor = UITheme.PrimaryBlue;
            dgvRentedCars.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvRentedCars.EnableHeadersVisualStyles = false;
            dgvRentedCars.RowTemplate.Height = 32;

            dgvRentedCars.Columns.Clear();

            // 1. Booking Reference
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.BookingReference),
                HeaderText = "Reference",
                Width = 120
            });

            // 2. Customer Name
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.CustomerFullName),
                HeaderText = "Customer Name",
                Width = 150
            });

            // 3. Car Type
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.CarTypeDisplay),
                HeaderText = "Car Type",
                Width = 140
            });

            // 4. Fuel Type
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.FuelTypeDisplay),
                HeaderText = "Fuel Type",
                Width = 130
            });

            // 5. Rental Days
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.RentalDays),
                HeaderText = "Days",
                Width = 60
            });

            // 6. Optional Extras
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.ExtrasDisplay),
                HeaderText = "Optional Extras",
                Width = 180
            });

            // 7. Total Price
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.TotalPriceFormatted),
                HeaderText = "Total Price",
                Width = 100
            });

            // 8. Booking Date
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.BookingDateFormatted),
                HeaderText = "Booking Date",
                Width = 130
            });

            // 9. Status
            dgvRentedCars.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = nameof(Booking.Status),
                HeaderText = "Status",
                Width = 90
            });
        }

        /// <summary>
        /// Loads and filters bookings according to search query and category filters.
        /// </summary>
        public void LoadRentedCars()
        {
            string query = txtSearch.Text.Trim();
            CarType? carTypeFilter = cmbFilterCarType.SelectedIndex switch
            {
                1 => CarType.CityCar,
                2 => CarType.FamilyCar,
                3 => CarType.SportsCar,
                4 => CarType.SUV,
                _ => null
            };

            List<Booking> results = BookingService.SearchBookings(query, carTypeFilter);

            dgvRentedCars.DataSource = null;
            dgvRentedCars.DataSource = results;

            lblRecordCount.Text = $"Showing {results.Count} active rental record(s)";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadRentedCars();
        private void cmbFilterCarType_SelectedIndexChanged(object sender, EventArgs e) => LoadRentedCars();
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbFilterCarType.SelectedIndex = 0;
            LoadRentedCars();
        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            this.Close();
            var bookingForm = new BookingForm(_dashboard);
            bookingForm.Show();
        }

        private void btnBackToDashboard_Click(object sender, EventArgs e)
        {
            this.Close();
            _dashboard.Show();
            _dashboard.RefreshRentalStats();
        }

        private void dgvRentedCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvRentedCars.Rows[e.RowIndex].DataBoundItem is Booking booking)
            {
                // Show detailed information dialog for the inspected booking
                string details = $"BOOKING REFERENCE: {booking.BookingReference}\n" +
                                 $"----------------------------------------\n" +
                                 $"Customer: {booking.CustomerFullName}\n" +
                                 $"Address: {booking.CustomerAddress}\n" +
                                 $"Age: {booking.CustomerAge}  |  Licence: {booking.DrivingLicenceStatus}\n\n" +
                                 $"Rental Duration: {booking.RentalDays} day(s)\n" +
                                 $"Vehicle: {booking.CarTypeDisplay}\n" +
                                 $"Fuel Type: {booking.FuelTypeDisplay}\n" +
                                 $"Optional Extras: {booking.ExtrasDisplay}\n\n" +
                                 $"Base Rental (£25/day): £{booking.BaseRentalCost:F2}\n" +
                                 $"Car Surcharge: £{booking.CarSurcharge:F2}\n" +
                                 $"Fuel Surcharge: £{booking.FuelSurcharge:F2}\n" +
                                 $"Unlimited Mileage: £{booking.UnlimitedMileageCost:F2}\n" +
                                 $"Breakdown Cover: £{booking.BreakdownCoverCost:F2}\n" +
                                 $"----------------------------------------\n" +
                                 $"TOTAL PAID: {booking.TotalPriceFormatted}\n" +
                                 $"Booking Date: {booking.BookingDateFormatted}\n" +
                                 $"Status: {booking.Status}";

                MessageBox.Show(details, $"Booking Details - {booking.BookingReference}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RentedCarsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_dashboard.Visible && !Application.OpenForms.OfType<BookingForm>().Any())
            {
                _dashboard.Show();
                _dashboard.RefreshRentalStats();
            }
        }
    }
}
