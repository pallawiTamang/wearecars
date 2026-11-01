namespace WeAreCarsRentalSystem.Forms
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.RadioButton rdoLicenceYes;
        private System.Windows.Forms.RadioButton rdoLicenceNo;
        private System.Windows.Forms.GroupBox grpRental;
        private System.Windows.Forms.Label lblRentalDays;
        private System.Windows.Forms.NumericUpDown nudRentalDays;
        private System.Windows.Forms.Label lblCarType;
        private System.Windows.Forms.ComboBox cmbCarType;
        private System.Windows.Forms.Label lblFuelType;
        private System.Windows.Forms.ComboBox cmbFuelType;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.CheckBox chkUnlimitedMileage;
        private System.Windows.Forms.CheckBox chkBreakdownCover;
        private System.Windows.Forms.Panel pnlPreviewCard;
        private System.Windows.Forms.Label lblPreviewTitle;
        private System.Windows.Forms.Label lblPreviewDays;
        private System.Windows.Forms.Label lblPreviewCar;
        private System.Windows.Forms.Label lblPreviewFuel;
        private System.Windows.Forms.Label lblPreviewMileage;
        private System.Windows.Forms.Label lblPreviewBreakdown;
        private System.Windows.Forms.Label lblPreviewTotalHeader;
        private System.Windows.Forms.Label lblPreviewTotal;
        private System.Windows.Forms.Button btnReviewBooking;
        private System.Windows.Forms.Button btnClearForm;
        private System.Windows.Forms.Button btnBackToDashboard;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblFormHeader = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnBackToDashboard = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnReviewBooking = new System.Windows.Forms.Button();
            this.pnlPreviewCard = new System.Windows.Forms.Panel();
            this.lblPreviewTotal = new System.Windows.Forms.Label();
            this.lblPreviewTotalHeader = new System.Windows.Forms.Label();
            this.lblPreviewBreakdown = new System.Windows.Forms.Label();
            this.lblPreviewMileage = new System.Windows.Forms.Label();
            this.lblPreviewFuel = new System.Windows.Forms.Label();
            this.lblPreviewCar = new System.Windows.Forms.Label();
            this.lblPreviewDays = new System.Windows.Forms.Label();
            this.lblPreviewTitle = new System.Windows.Forms.Label();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.chkBreakdownCover = new System.Windows.Forms.CheckBox();
            this.chkUnlimitedMileage = new System.Windows.Forms.CheckBox();
            this.grpRental = new System.Windows.Forms.GroupBox();
            this.cmbFuelType = new System.Windows.Forms.ComboBox();
            this.lblFuelType = new System.Windows.Forms.Label();
            this.cmbCarType = new System.Windows.Forms.ComboBox();
            this.lblCarType = new System.Windows.Forms.Label();
            this.nudRentalDays = new System.Windows.Forms.NumericUpDown();
            this.lblRentalDays = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.rdoLicenceNo = new System.Windows.Forms.RadioButton();
            this.rdoLicenceYes = new System.Windows.Forms.RadioButton();
            this.lblLicence = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlPreviewCard.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.grpRental.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalDays)).BeginInit();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblFormHeader);
            this.pnlHeader.Controls.Add(this.lblSystemTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(960, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblFormHeader.Location = new System.Drawing.Point(630, 28);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(300, 24);
            this.lblFormHeader.TabIndex = 2;
            this.lblFormHeader.Text = "NEW VEHICLE BOOKING";
            this.lblFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblSystemTitle.Location = new System.Drawing.Point(170, 28);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(264, 25);
            this.lblSystemTitle.TabIndex = 1;
            this.lblSystemTitle.Text = "WeAreCars Rental Management";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(15, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(140, 62);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.btnBackToDashboard);
            this.pnlContent.Controls.Add(this.btnClearForm);
            this.pnlContent.Controls.Add(this.btnReviewBooking);
            this.pnlContent.Controls.Add(this.pnlPreviewCard);
            this.pnlContent.Controls.Add(this.grpExtras);
            this.pnlContent.Controls.Add(this.grpRental);
            this.pnlContent.Controls.Add(this.grpCustomer);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 85);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(25);
            this.pnlContent.Size = new System.Drawing.Size(960, 575);
            this.pnlContent.TabIndex = 1;
            // 
            // btnBackToDashboard
            // 
            this.btnBackToDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnBackToDashboard.Location = new System.Drawing.Point(745, 505);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(185, 40);
            this.btnBackToDashboard.TabIndex = 6;
            this.btnBackToDashboard.Text = "Back to Dashboard";
            this.btnBackToDashboard.UseVisualStyleBackColor = true;
            this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClearForm.Location = new System.Drawing.Point(545, 505);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(185, 40);
            this.btnClearForm.TabIndex = 5;
            this.btnClearForm.Text = "Clear Booking Form";
            this.btnClearForm.UseVisualStyleBackColor = true;
            this.btnClearForm.Click += new System.EventHandler(this.btnClearForm_Click);
            // 
            // btnReviewBooking
            // 
            this.btnReviewBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnReviewBooking.Location = new System.Drawing.Point(545, 445);
            this.btnReviewBooking.Name = "btnReviewBooking";
            this.btnReviewBooking.Size = new System.Drawing.Size(385, 48);
            this.btnReviewBooking.TabIndex = 4;
            this.btnReviewBooking.Text = "Review Booking Summary  >>";
            this.btnReviewBooking.UseVisualStyleBackColor = true;
            this.btnReviewBooking.Click += new System.EventHandler(this.btnReviewBooking_Click);
            // 
            // pnlPreviewCard
            // 
            this.pnlPreviewCard.BackColor = System.Drawing.Color.White;
            this.pnlPreviewCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPreviewCard.Controls.Add(this.lblPreviewTotal);
            this.pnlPreviewCard.Controls.Add(this.lblPreviewTotalHeader);
            this.pnlPreviewCard.Controls.Add(this.lblPreviewBreakdown);
            this.pnlPreviewCard.Controls.Add(this.lblPreviewMileage);
            this.pnlPreviewCard.Controls.Add(this.lblPreviewFuel);
            this.pnlPreviewCard.Controls.Add(this.lblPreviewCar);
            this.pnlPreviewCard.Controls.Add(this.lblPreviewDays);
            this.pnlPreviewCard.Controls.Add(this.lblPreviewTitle);
            this.pnlPreviewCard.Location = new System.Drawing.Point(545, 220);
            this.pnlPreviewCard.Name = "pnlPreviewCard";
            this.pnlPreviewCard.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPreviewCard.Size = new System.Drawing.Size(385, 205);
            this.pnlPreviewCard.TabIndex = 3;
            // 
            // lblPreviewTotal
            // 
            this.lblPreviewTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreviewTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPreviewTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblPreviewTotal.Location = new System.Drawing.Point(210, 160);
            this.lblPreviewTotal.Name = "lblPreviewTotal";
            this.lblPreviewTotal.Size = new System.Drawing.Size(155, 30);
            this.lblPreviewTotal.TabIndex = 7;
            this.lblPreviewTotal.Text = "£25.00";
            this.lblPreviewTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPreviewTotalHeader
            // 
            this.lblPreviewTotalHeader.AutoSize = true;
            this.lblPreviewTotalHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPreviewTotalHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblPreviewTotalHeader.Location = new System.Drawing.Point(15, 165);
            this.lblPreviewTotalHeader.Name = "lblPreviewTotalHeader";
            this.lblPreviewTotalHeader.Size = new System.Drawing.Size(117, 21);
            this.lblPreviewTotalHeader.TabIndex = 6;
            this.lblPreviewTotalHeader.Text = "ESTIMATED TOTAL:";
            // 
            // lblPreviewBreakdown
            // 
            this.lblPreviewBreakdown.AutoSize = true;
            this.lblPreviewBreakdown.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPreviewBreakdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPreviewBreakdown.Location = new System.Drawing.Point(15, 132);
            this.lblPreviewBreakdown.Name = "lblPreviewBreakdown";
            this.lblPreviewBreakdown.Size = new System.Drawing.Size(130, 15);
            this.lblPreviewBreakdown.TabIndex = 5;
            this.lblPreviewBreakdown.Text = "Breakdown Cover: £0.00";
            // 
            // lblPreviewMileage
            // 
            this.lblPreviewMileage.AutoSize = true;
            this.lblPreviewMileage.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPreviewMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPreviewMileage.Location = new System.Drawing.Point(15, 110);
            this.lblPreviewMileage.Name = "lblPreviewMileage";
            this.lblPreviewMileage.Size = new System.Drawing.Size(137, 15);
            this.lblPreviewMileage.TabIndex = 4;
            this.lblPreviewMileage.Text = "Unlimited Mileage: £0.00";
            // 
            // lblPreviewFuel
            // 
            this.lblPreviewFuel.AutoSize = true;
            this.lblPreviewFuel.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPreviewFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPreviewFuel.Location = new System.Drawing.Point(15, 88);
            this.lblPreviewFuel.Name = "lblPreviewFuel";
            this.lblPreviewFuel.Size = new System.Drawing.Size(133, 15);
            this.lblPreviewFuel.TabIndex = 3;
            this.lblPreviewFuel.Text = "Petrol surcharge: £0.00";
            // 
            // lblPreviewCar
            // 
            this.lblPreviewCar.AutoSize = true;
            this.lblPreviewCar.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPreviewCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPreviewCar.Location = new System.Drawing.Point(15, 66);
            this.lblPreviewCar.Name = "lblPreviewCar";
            this.lblPreviewCar.Size = new System.Drawing.Size(142, 15);
            this.lblPreviewCar.TabIndex = 2;
            this.lblPreviewCar.Text = "City Car surcharge: £0.00";
            // 
            // lblPreviewDays
            // 
            this.lblPreviewDays.AutoSize = true;
            this.lblPreviewDays.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPreviewDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblPreviewDays.Location = new System.Drawing.Point(15, 44);
            this.lblPreviewDays.Name = "lblPreviewDays";
            this.lblPreviewDays.Size = new System.Drawing.Size(164, 15);
            this.lblPreviewDays.TabIndex = 1;
            this.lblPreviewDays.Text = "1 day(s) × £25.00 = £25.00";
            // 
            // lblPreviewTitle
            // 
            this.lblPreviewTitle.AutoSize = true;
            this.lblPreviewTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPreviewTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblPreviewTitle.Location = new System.Drawing.Point(15, 15);
            this.lblPreviewTitle.Name = "lblPreviewTitle";
            this.lblPreviewTitle.Size = new System.Drawing.Size(130, 19);
            this.lblPreviewTitle.TabIndex = 0;
            this.lblPreviewTitle.Text = "Live Price Preview";
            // 
            // grpExtras
            // 
            this.grpExtras.BackColor = System.Drawing.Color.White;
            this.grpExtras.Controls.Add(this.chkBreakdownCover);
            this.grpExtras.Controls.Add(this.chkUnlimitedMileage);
            this.grpExtras.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.grpExtras.Location = new System.Drawing.Point(545, 25);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Padding = new System.Windows.Forms.Padding(15);
            this.grpExtras.Size = new System.Drawing.Size(385, 180);
            this.grpExtras.TabIndex = 2;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Optional Extras";
            // 
            // chkBreakdownCover
            // 
            this.chkBreakdownCover.AutoSize = true;
            this.chkBreakdownCover.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkBreakdownCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkBreakdownCover.Location = new System.Drawing.Point(20, 95);
            this.chkBreakdownCover.Name = "chkBreakdownCover";
            this.chkBreakdownCover.Size = new System.Drawing.Size(232, 21);
            this.chkBreakdownCover.TabIndex = 1;
            this.chkBreakdownCover.Text = "Breakdown Cover (+£2.00 per day)";
            this.chkBreakdownCover.UseVisualStyleBackColor = true;
            this.chkBreakdownCover.CheckedChanged += new System.EventHandler(this.chkBreakdownCover_CheckedChanged);
            // 
            // chkUnlimitedMileage
            // 
            this.chkUnlimitedMileage.AutoSize = true;
            this.chkUnlimitedMileage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.chkUnlimitedMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.chkUnlimitedMileage.Location = new System.Drawing.Point(20, 45);
            this.chkUnlimitedMileage.Name = "chkUnlimitedMileage";
            this.chkUnlimitedMileage.Size = new System.Drawing.Size(243, 21);
            this.chkUnlimitedMileage.TabIndex = 0;
            this.chkUnlimitedMileage.Text = "Unlimited Mileage (+£10.00 per day)";
            this.chkUnlimitedMileage.UseVisualStyleBackColor = true;
            this.chkUnlimitedMileage.CheckedChanged += new System.EventHandler(this.chkUnlimitedMileage_CheckedChanged);
            // 
            // grpRental
            // 
            this.grpRental.BackColor = System.Drawing.Color.White;
            this.grpRental.Controls.Add(this.cmbFuelType);
            this.grpRental.Controls.Add(this.lblFuelType);
            this.grpRental.Controls.Add(this.cmbCarType);
            this.grpRental.Controls.Add(this.lblCarType);
            this.grpRental.Controls.Add(this.nudRentalDays);
            this.grpRental.Controls.Add(this.lblRentalDays);
            this.grpRental.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.grpRental.Location = new System.Drawing.Point(25, 345);
            this.grpRental.Name = "grpRental";
            this.grpRental.Padding = new System.Windows.Forms.Padding(15);
            this.grpRental.Size = new System.Drawing.Size(490, 200);
            this.grpRental.TabIndex = 1;
            this.grpRental.TabStop = false;
            this.grpRental.Text = "Rental & Vehicle Parameters";
            // 
            // cmbFuelType
            // 
            this.cmbFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFuelType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbFuelType.FormattingEnabled = true;
            this.cmbFuelType.Location = new System.Drawing.Point(180, 140);
            this.cmbFuelType.Name = "cmbFuelType";
            this.cmbFuelType.Size = new System.Drawing.Size(280, 25);
            this.cmbFuelType.TabIndex = 5;
            this.cmbFuelType.SelectedIndexChanged += new System.EventHandler(this.cmbFuelType_SelectedIndexChanged);
            // 
            // lblFuelType
            // 
            this.lblFuelType.AutoSize = true;
            this.lblFuelType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFuelType.Location = new System.Drawing.Point(20, 145);
            this.lblFuelType.Name = "lblFuelType";
            this.lblFuelType.Size = new System.Drawing.Size(73, 15);
            this.lblFuelType.TabIndex = 4;
            this.lblFuelType.Text = "Fuel Type: *";
            // 
            // cmbCarType
            // 
            this.cmbCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCarType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmbCarType.FormattingEnabled = true;
            this.cmbCarType.Location = new System.Drawing.Point(180, 90);
            this.cmbCarType.Name = "cmbCarType";
            this.cmbCarType.Size = new System.Drawing.Size(280, 25);
            this.cmbCarType.TabIndex = 3;
            this.cmbCarType.SelectedIndexChanged += new System.EventHandler(this.cmbCarType_SelectedIndexChanged);
            // 
            // lblCarType
            // 
            this.lblCarType.AutoSize = true;
            this.lblCarType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblCarType.Location = new System.Drawing.Point(20, 95);
            this.lblCarType.Name = "lblCarType";
            this.lblCarType.Size = new System.Drawing.Size(91, 15);
            this.lblCarType.TabIndex = 2;
            this.lblCarType.Text = "Vehicle Type: *";
            // 
            // nudRentalDays
            // 
            this.nudRentalDays.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.nudRentalDays.Location = new System.Drawing.Point(180, 40);
            this.nudRentalDays.Maximum = new decimal(new int[] { 28, 0, 0, 0 });
            this.nudRentalDays.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudRentalDays.Name = "nudRentalDays";
            this.nudRentalDays.Size = new System.Drawing.Size(90, 24);
            this.nudRentalDays.TabIndex = 1;
            this.nudRentalDays.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudRentalDays.ValueChanged += new System.EventHandler(this.nudRentalDays_ValueChanged);
            // 
            // lblRentalDays
            // 
            this.lblRentalDays.AutoSize = true;
            this.lblRentalDays.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblRentalDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblRentalDays.Location = new System.Drawing.Point(20, 45);
            this.lblRentalDays.Name = "lblRentalDays";
            this.lblRentalDays.Size = new System.Drawing.Size(138, 15);
            this.lblRentalDays.TabIndex = 0;
            this.lblRentalDays.Text = "Rental Days: * (1 – 28)";
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.White;
            this.grpCustomer.Controls.Add(this.rdoLicenceNo);
            this.grpCustomer.Controls.Add(this.rdoLicenceYes);
            this.grpCustomer.Controls.Add(this.lblLicence);
            this.grpCustomer.Controls.Add(this.txtAge);
            this.grpCustomer.Controls.Add(this.lblAge);
            this.grpCustomer.Controls.Add(this.txtAddress);
            this.grpCustomer.Controls.Add(this.lblAddress);
            this.grpCustomer.Controls.Add(this.txtSurname);
            this.grpCustomer.Controls.Add(this.lblSurname);
            this.grpCustomer.Controls.Add(this.txtFirstName);
            this.grpCustomer.Controls.Add(this.lblFirstName);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.grpCustomer.Location = new System.Drawing.Point(25, 25);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(15);
            this.grpCustomer.Size = new System.Drawing.Size(490, 305);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Identification (Mandatory)";
            // 
            // rdoLicenceNo
            // 
            this.rdoLicenceNo.AutoSize = true;
            this.rdoLicenceNo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rdoLicenceNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.rdoLicenceNo.Location = new System.Drawing.Point(260, 255);
            this.rdoLicenceNo.Name = "rdoLicenceNo";
            this.rdoLicenceNo.Size = new System.Drawing.Size(44, 21);
            this.rdoLicenceNo.TabIndex = 10;
            this.rdoLicenceNo.Text = "No";
            this.rdoLicenceNo.UseVisualStyleBackColor = true;
            // 
            // rdoLicenceYes
            // 
            this.rdoLicenceYes.AutoSize = true;
            this.rdoLicenceYes.Checked = true;
            this.rdoLicenceYes.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rdoLicenceYes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.rdoLicenceYes.Location = new System.Drawing.Point(180, 255);
            this.rdoLicenceYes.Name = "rdoLicenceYes";
            this.rdoLicenceYes.Size = new System.Drawing.Size(45, 21);
            this.rdoLicenceYes.TabIndex = 9;
            this.rdoLicenceYes.TabStop = true;
            this.rdoLicenceYes.Text = "Yes";
            this.rdoLicenceYes.UseVisualStyleBackColor = true;
            // 
            // lblLicence
            // 
            this.lblLicence.AutoSize = true;
            this.lblLicence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLicence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLicence.Location = new System.Drawing.Point(20, 258);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(138, 15);
            this.lblLicence.TabIndex = 8;
            this.lblLicence.Text = "Valid Driving Licence: *";
            // 
            // txtAge
            // 
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAge.Location = new System.Drawing.Point(180, 205);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(90, 24);
            this.txtAge.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblAge.Location = new System.Drawing.Point(20, 210);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(99, 15);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Customer Age: *";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtAddress.Location = new System.Drawing.Point(180, 135);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(280, 50);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblAddress.Location = new System.Drawing.Point(20, 140);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(121, 15);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Customer Address: *";
            // 
            // txtSurname
            // 
            this.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSurname.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtSurname.Location = new System.Drawing.Point(180, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(280, 24);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSurname.Location = new System.Drawing.Point(20, 90);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(126, 15);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Customer Surname: *";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txtFirstName.Location = new System.Drawing.Point(180, 35);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(280, 24);
            this.txtFirstName.TabIndex = 1;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFirstName.Location = new System.Drawing.Point(20, 40);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(137, 15);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "Customer First Name: *";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(960, 660);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeAreCars - New Rental Booking";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookingForm_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlPreviewCard.ResumeLayout(false);
            this.pnlPreviewCard.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            this.grpRental.ResumeLayout(false);
            this.grpRental.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRentalDays)).EndInit();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
