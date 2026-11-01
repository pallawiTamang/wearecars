namespace WeAreCarsRentalSystem.Forms
{
    partial class BookingSummaryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Label lblLblCustomerName;
        private System.Windows.Forms.Label lblValCustomerName;
        private System.Windows.Forms.Label lblLblAddress;
        private System.Windows.Forms.Label lblValAddress;
        private System.Windows.Forms.Label lblLblAge;
        private System.Windows.Forms.Label lblValAge;
        private System.Windows.Forms.Label lblLblLicence;
        private System.Windows.Forms.Label lblValLicence;
        private System.Windows.Forms.GroupBox grpRental;
        private System.Windows.Forms.Label lblLblDays;
        private System.Windows.Forms.Label lblValDays;
        private System.Windows.Forms.Label lblLblCarType;
        private System.Windows.Forms.Label lblValCarType;
        private System.Windows.Forms.Label lblLblFuelType;
        private System.Windows.Forms.Label lblValFuelType;
        private System.Windows.Forms.GroupBox grpExtras;
        private System.Windows.Forms.Label lblLblMileage;
        private System.Windows.Forms.Label lblValMileage;
        private System.Windows.Forms.Label lblLblBreakdownCover;
        private System.Windows.Forms.Label lblValBreakdownCover;
        private System.Windows.Forms.GroupBox grpCost;
        private System.Windows.Forms.Label lblLblCostBase;
        private System.Windows.Forms.Label lblValCostBase;
        private System.Windows.Forms.Label lblLblCostCar;
        private System.Windows.Forms.Label lblValCostCar;
        private System.Windows.Forms.Label lblLblCostFuel;
        private System.Windows.Forms.Label lblValCostFuel;
        private System.Windows.Forms.Label lblLblCostMileage;
        private System.Windows.Forms.Label lblValCostMileage;
        private System.Windows.Forms.Label lblLblCostBreakdown;
        private System.Windows.Forms.Label lblValCostBreakdown;
        private System.Windows.Forms.Panel pnlTotalHighlight;
        private System.Windows.Forms.Label lblLblTotalPrice;
        private System.Windows.Forms.Label lblValTotalPrice;
        private System.Windows.Forms.Button btnConfirmBooking;
        private System.Windows.Forms.Button btnBackEdit;
        private System.Windows.Forms.Button btnCancel;

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
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBackEdit = new System.Windows.Forms.Button();
            this.btnConfirmBooking = new System.Windows.Forms.Button();
            this.grpCost = new System.Windows.Forms.GroupBox();
            this.pnlTotalHighlight = new System.Windows.Forms.Panel();
            this.lblValTotalPrice = new System.Windows.Forms.Label();
            this.lblLblTotalPrice = new System.Windows.Forms.Label();
            this.lblValCostBreakdown = new System.Windows.Forms.Label();
            this.lblLblCostBreakdown = new System.Windows.Forms.Label();
            this.lblValCostMileage = new System.Windows.Forms.Label();
            this.lblLblCostMileage = new System.Windows.Forms.Label();
            this.lblValCostFuel = new System.Windows.Forms.Label();
            this.lblLblCostFuel = new System.Windows.Forms.Label();
            this.lblValCostCar = new System.Windows.Forms.Label();
            this.lblLblCostCar = new System.Windows.Forms.Label();
            this.lblValCostBase = new System.Windows.Forms.Label();
            this.lblLblCostBase = new System.Windows.Forms.Label();
            this.grpExtras = new System.Windows.Forms.GroupBox();
            this.lblValBreakdownCover = new System.Windows.Forms.Label();
            this.lblLblBreakdownCover = new System.Windows.Forms.Label();
            this.lblValMileage = new System.Windows.Forms.Label();
            this.lblLblMileage = new System.Windows.Forms.Label();
            this.grpRental = new System.Windows.Forms.GroupBox();
            this.lblValFuelType = new System.Windows.Forms.Label();
            this.lblLblFuelType = new System.Windows.Forms.Label();
            this.lblValCarType = new System.Windows.Forms.Label();
            this.lblLblCarType = new System.Windows.Forms.Label();
            this.lblValDays = new System.Windows.Forms.Label();
            this.lblLblDays = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblValLicence = new System.Windows.Forms.Label();
            this.lblLblLicence = new System.Windows.Forms.Label();
            this.lblValAge = new System.Windows.Forms.Label();
            this.lblLblAge = new System.Windows.Forms.Label();
            this.lblValAddress = new System.Windows.Forms.Label();
            this.lblLblAddress = new System.Windows.Forms.Label();
            this.lblValCustomerName = new System.Windows.Forms.Label();
            this.lblLblCustomerName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.grpCost.SuspendLayout();
            this.pnlTotalHighlight.SuspendLayout();
            this.grpExtras.SuspendLayout();
            this.grpRental.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblSummaryTitle);
            this.pnlHeader.Controls.Add(this.lblSystemTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(860, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(530, 25);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(300, 24);
            this.lblSummaryTitle.TabIndex = 2;
            this.lblSummaryTitle.Text = "BOOKING VERIFICATION SUMMARY";
            this.lblSummaryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblSystemTitle.Location = new System.Drawing.Point(165, 25);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(264, 25);
            this.lblSystemTitle.TabIndex = 1;
            this.lblSystemTitle.Text = "WeAreCars Rental Management";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(15, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 58);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.btnCancel);
            this.pnlContent.Controls.Add(this.btnBackEdit);
            this.pnlContent.Controls.Add(this.btnConfirmBooking);
            this.pnlContent.Controls.Add(this.grpCost);
            this.pnlContent.Controls.Add(this.grpExtras);
            this.pnlContent.Controls.Add(this.grpRental);
            this.pnlContent.Controls.Add(this.grpCustomer);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 80);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(25);
            this.pnlContent.Size = new System.Drawing.Size(860, 600);
            this.pnlContent.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnCancel.Location = new System.Drawing.Point(675, 530);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(155, 42);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnBackEdit
            // 
            this.btnBackEdit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnBackEdit.Location = new System.Drawing.Point(490, 530);
            this.btnBackEdit.Name = "btnBackEdit";
            this.btnBackEdit.Size = new System.Drawing.Size(170, 42);
            this.btnBackEdit.TabIndex = 5;
            this.btnBackEdit.Text = "<< Back / Edit Details";
            this.btnBackEdit.UseVisualStyleBackColor = true;
            this.btnBackEdit.Click += new System.EventHandler(this.btnBackEdit_Click);
            // 
            // btnConfirmBooking
            // 
            this.btnConfirmBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnConfirmBooking.Location = new System.Drawing.Point(490, 470);
            this.btnConfirmBooking.Name = "btnConfirmBooking";
            this.btnConfirmBooking.Size = new System.Drawing.Size(340, 50);
            this.btnConfirmBooking.TabIndex = 4;
            this.btnConfirmBooking.Text = "CONFIRM & STORE BOOKING";
            this.btnConfirmBooking.UseVisualStyleBackColor = true;
            this.btnConfirmBooking.Click += new System.EventHandler(this.btnConfirmBooking_Click);
            // 
            // grpCost
            // 
            this.grpCost.BackColor = System.Drawing.Color.White;
            this.grpCost.Controls.Add(this.pnlTotalHighlight);
            this.grpCost.Controls.Add(this.lblValCostBreakdown);
            this.grpCost.Controls.Add(this.lblLblCostBreakdown);
            this.grpCost.Controls.Add(this.lblValCostMileage);
            this.grpCost.Controls.Add(this.lblLblCostMileage);
            this.grpCost.Controls.Add(this.lblValCostFuel);
            this.grpCost.Controls.Add(this.lblLblCostFuel);
            this.grpCost.Controls.Add(this.lblValCostCar);
            this.grpCost.Controls.Add(this.lblLblCostCar);
            this.grpCost.Controls.Add(this.lblValCostBase);
            this.grpCost.Controls.Add(this.lblLblCostBase);
            this.grpCost.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.grpCost.Location = new System.Drawing.Point(490, 20);
            this.grpCost.Name = "grpCost";
            this.grpCost.Padding = new System.Windows.Forms.Padding(15);
            this.grpCost.Size = new System.Drawing.Size(340, 435);
            this.grpCost.TabIndex = 3;
            this.grpCost.TabStop = false;
            this.grpCost.Text = "Financial Cost Breakdown";
            // 
            // pnlTotalHighlight
            // 
            this.pnlTotalHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.pnlTotalHighlight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTotalHighlight.Controls.Add(this.lblValTotalPrice);
            this.pnlTotalHighlight.Controls.Add(this.lblLblTotalPrice);
            this.pnlTotalHighlight.Location = new System.Drawing.Point(15, 330);
            this.pnlTotalHighlight.Name = "pnlTotalHighlight";
            this.pnlTotalHighlight.Padding = new System.Windows.Forms.Padding(10);
            this.pnlTotalHighlight.Size = new System.Drawing.Size(310, 80);
            this.pnlTotalHighlight.TabIndex = 10;
            // 
            // lblValTotalPrice
            // 
            this.lblValTotalPrice.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblValTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblValTotalPrice.Location = new System.Drawing.Point(120, 20);
            this.lblValTotalPrice.Name = "lblValTotalPrice";
            this.lblValTotalPrice.Size = new System.Drawing.Size(180, 40);
            this.lblValTotalPrice.TabIndex = 1;
            this.lblValTotalPrice.Text = "£0.00";
            this.lblValTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLblTotalPrice
            // 
            this.lblLblTotalPrice.AutoSize = true;
            this.lblLblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblLblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblLblTotalPrice.Location = new System.Drawing.Point(10, 28);
            this.lblLblTotalPrice.Name = "lblLblTotalPrice";
            this.lblLblTotalPrice.Size = new System.Drawing.Size(107, 20);
            this.lblLblTotalPrice.TabIndex = 0;
            this.lblLblTotalPrice.Text = "TOTAL PRICE:";
            // 
            // lblValCostBreakdown
            // 
            this.lblValCostBreakdown.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValCostBreakdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValCostBreakdown.Location = new System.Drawing.Point(170, 260);
            this.lblValCostBreakdown.Name = "lblValCostBreakdown";
            this.lblValCostBreakdown.Size = new System.Drawing.Size(155, 20);
            this.lblValCostBreakdown.TabIndex = 9;
            this.lblValCostBreakdown.Text = "£0.00";
            this.lblValCostBreakdown.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLblCostBreakdown
            // 
            this.lblLblCostBreakdown.AutoSize = true;
            this.lblLblCostBreakdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblCostBreakdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblCostBreakdown.Location = new System.Drawing.Point(15, 260);
            this.lblLblCostBreakdown.Name = "lblLblCostBreakdown";
            this.lblLblCostBreakdown.Size = new System.Drawing.Size(100, 15);
            this.lblLblCostBreakdown.TabIndex = 8;
            this.lblLblCostBreakdown.Text = "Breakdown Cover:";
            // 
            // lblValCostMileage
            // 
            this.lblValCostMileage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValCostMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValCostMileage.Location = new System.Drawing.Point(170, 210);
            this.lblValCostMileage.Name = "lblValCostMileage";
            this.lblValCostMileage.Size = new System.Drawing.Size(155, 20);
            this.lblValCostMileage.TabIndex = 7;
            this.lblValCostMileage.Text = "£0.00";
            this.lblValCostMileage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLblCostMileage
            // 
            this.lblLblCostMileage.AutoSize = true;
            this.lblLblCostMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblCostMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblCostMileage.Location = new System.Drawing.Point(15, 210);
            this.lblLblCostMileage.Name = "lblLblCostMileage";
            this.lblLblCostMileage.Size = new System.Drawing.Size(107, 15);
            this.lblLblCostMileage.TabIndex = 6;
            this.lblLblCostMileage.Text = "Unlimited Mileage:";
            // 
            // lblValCostFuel
            // 
            this.lblValCostFuel.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValCostFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValCostFuel.Location = new System.Drawing.Point(170, 155);
            this.lblValCostFuel.Name = "lblValCostFuel";
            this.lblValCostFuel.Size = new System.Drawing.Size(155, 20);
            this.lblValCostFuel.TabIndex = 5;
            this.lblValCostFuel.Text = "£0.00";
            this.lblValCostFuel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLblCostFuel
            // 
            this.lblLblCostFuel.AutoSize = true;
            this.lblLblCostFuel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblCostFuel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblCostFuel.Location = new System.Drawing.Point(15, 155);
            this.lblLblCostFuel.Name = "lblLblCostFuel";
            this.lblLblCostFuel.Size = new System.Drawing.Size(91, 15);
            this.lblLblCostFuel.TabIndex = 4;
            this.lblLblCostFuel.Text = "Fuel Surcharge:";
            // 
            // lblValCostCar
            // 
            this.lblValCostCar.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValCostCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValCostCar.Location = new System.Drawing.Point(170, 105);
            this.lblValCostCar.Name = "lblValCostCar";
            this.lblValCostCar.Size = new System.Drawing.Size(155, 20);
            this.lblValCostCar.TabIndex = 3;
            this.lblValCostCar.Text = "£0.00";
            this.lblValCostCar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLblCostCar
            // 
            this.lblLblCostCar.AutoSize = true;
            this.lblLblCostCar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblCostCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblCostCar.Location = new System.Drawing.Point(15, 105);
            this.lblLblCostCar.Name = "lblLblCostCar";
            this.lblLblCostCar.Size = new System.Drawing.Size(86, 15);
            this.lblLblCostCar.TabIndex = 2;
            this.lblLblCostCar.Text = "Car Surcharge:";
            // 
            // lblValCostBase
            // 
            this.lblValCostBase.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValCostBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValCostBase.Location = new System.Drawing.Point(130, 50);
            this.lblValCostBase.Name = "lblValCostBase";
            this.lblValCostBase.Size = new System.Drawing.Size(195, 20);
            this.lblValCostBase.TabIndex = 1;
            this.lblValCostBase.Text = "£0.00";
            this.lblValCostBase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLblCostBase
            // 
            this.lblLblCostBase.AutoSize = true;
            this.lblLblCostBase.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblCostBase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblCostBase.Location = new System.Drawing.Point(15, 50);
            this.lblLblCostBase.Name = "lblLblCostBase";
            this.lblLblCostBase.Size = new System.Drawing.Size(73, 15);
            this.lblLblCostBase.TabIndex = 0;
            this.lblLblCostBase.Text = "Base Rental:";
            // 
            // grpExtras
            // 
            this.grpExtras.BackColor = System.Drawing.Color.White;
            this.grpExtras.Controls.Add(this.lblValBreakdownCover);
            this.grpExtras.Controls.Add(this.lblLblBreakdownCover);
            this.grpExtras.Controls.Add(this.lblValMileage);
            this.grpExtras.Controls.Add(this.lblLblMileage);
            this.grpExtras.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpExtras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.grpExtras.Location = new System.Drawing.Point(25, 435);
            this.grpExtras.Name = "grpExtras";
            this.grpExtras.Padding = new System.Windows.Forms.Padding(15);
            this.grpExtras.Size = new System.Drawing.Size(445, 135);
            this.grpExtras.TabIndex = 2;
            this.grpExtras.TabStop = false;
            this.grpExtras.Text = "Optional Extras";
            // 
            // lblValBreakdownCover
            // 
            this.lblValBreakdownCover.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValBreakdownCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValBreakdownCover.Location = new System.Drawing.Point(160, 80);
            this.lblValBreakdownCover.Name = "lblValBreakdownCover";
            this.lblValBreakdownCover.Size = new System.Drawing.Size(270, 20);
            this.lblValBreakdownCover.TabIndex = 3;
            this.lblValBreakdownCover.Text = "None";
            // 
            // lblLblBreakdownCover
            // 
            this.lblLblBreakdownCover.AutoSize = true;
            this.lblLblBreakdownCover.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblBreakdownCover.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblBreakdownCover.Location = new System.Drawing.Point(15, 80);
            this.lblLblBreakdownCover.Name = "lblLblBreakdownCover";
            this.lblLblBreakdownCover.Size = new System.Drawing.Size(100, 15);
            this.lblLblBreakdownCover.TabIndex = 2;
            this.lblLblBreakdownCover.Text = "Breakdown Cover:";
            // 
            // lblValMileage
            // 
            this.lblValMileage.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValMileage.Location = new System.Drawing.Point(160, 40);
            this.lblValMileage.Name = "lblValMileage";
            this.lblValMileage.Size = new System.Drawing.Size(270, 20);
            this.lblValMileage.TabIndex = 1;
            this.lblValMileage.Text = "None";
            // 
            // lblLblMileage
            // 
            this.lblLblMileage.AutoSize = true;
            this.lblLblMileage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblMileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblMileage.Location = new System.Drawing.Point(15, 40);
            this.lblLblMileage.Name = "lblLblMileage";
            this.lblLblMileage.Size = new System.Drawing.Size(107, 15);
            this.lblLblMileage.TabIndex = 0;
            this.lblLblMileage.Text = "Unlimited Mileage:";
            // 
            // grpRental
            // 
            this.grpRental.BackColor = System.Drawing.Color.White;
            this.grpRental.Controls.Add(this.lblValFuelType);
            this.grpRental.Controls.Add(this.lblLblFuelType);
            this.grpRental.Controls.Add(this.lblValCarType);
            this.grpRental.Controls.Add(this.lblLblCarType);
            this.grpRental.Controls.Add(this.lblValDays);
            this.grpRental.Controls.Add(this.lblLblDays);
            this.grpRental.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpRental.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.grpRental.Location = new System.Drawing.Point(25, 255);
            this.grpRental.Name = "grpRental";
            this.grpRental.Padding = new System.Windows.Forms.Padding(15);
            this.grpRental.Size = new System.Drawing.Size(445, 165);
            this.grpRental.TabIndex = 1;
            this.grpRental.TabStop = false;
            this.grpRental.Text = "Rental Details";
            // 
            // lblValFuelType
            // 
            this.lblValFuelType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValFuelType.Location = new System.Drawing.Point(160, 115);
            this.lblValFuelType.Name = "lblValFuelType";
            this.lblValFuelType.Size = new System.Drawing.Size(270, 20);
            this.lblValFuelType.TabIndex = 5;
            this.lblValFuelType.Text = "Fuel";
            // 
            // lblLblFuelType
            // 
            this.lblLblFuelType.AutoSize = true;
            this.lblLblFuelType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblFuelType.Location = new System.Drawing.Point(15, 115);
            this.lblLblFuelType.Name = "lblLblFuelType";
            this.lblLblFuelType.Size = new System.Drawing.Size(61, 15);
            this.lblLblFuelType.TabIndex = 4;
            this.lblLblFuelType.Text = "Fuel Type:";
            // 
            // lblValCarType
            // 
            this.lblValCarType.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValCarType.Location = new System.Drawing.Point(160, 75);
            this.lblValCarType.Name = "lblValCarType";
            this.lblValCarType.Size = new System.Drawing.Size(270, 20);
            this.lblValCarType.TabIndex = 3;
            this.lblValCarType.Text = "Car";
            // 
            // lblLblCarType
            // 
            this.lblLblCarType.AutoSize = true;
            this.lblLblCarType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblCarType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblCarType.Location = new System.Drawing.Point(15, 75);
            this.lblLblCarType.Name = "lblLblCarType";
            this.lblLblCarType.Size = new System.Drawing.Size(56, 15);
            this.lblLblCarType.TabIndex = 2;
            this.lblLblCarType.Text = "Car Type:";
            // 
            // lblValDays
            // 
            this.lblValDays.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValDays.Location = new System.Drawing.Point(160, 35);
            this.lblValDays.Name = "lblValDays";
            this.lblValDays.Size = new System.Drawing.Size(270, 20);
            this.lblValDays.TabIndex = 1;
            this.lblValDays.Text = "Days";
            // 
            // lblLblDays
            // 
            this.lblLblDays.AutoSize = true;
            this.lblLblDays.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblDays.Location = new System.Drawing.Point(15, 35);
            this.lblLblDays.Name = "lblLblDays";
            this.lblLblDays.Size = new System.Drawing.Size(96, 15);
            this.lblLblDays.TabIndex = 0;
            this.lblLblDays.Text = "Number of Days:";
            // 
            // grpCustomer
            // 
            this.grpCustomer.BackColor = System.Drawing.Color.White;
            this.grpCustomer.Controls.Add(this.lblValLicence);
            this.grpCustomer.Controls.Add(this.lblLblLicence);
            this.grpCustomer.Controls.Add(this.lblValAge);
            this.grpCustomer.Controls.Add(this.lblLblAge);
            this.grpCustomer.Controls.Add(this.lblValAddress);
            this.grpCustomer.Controls.Add(this.lblLblAddress);
            this.grpCustomer.Controls.Add(this.lblValCustomerName);
            this.grpCustomer.Controls.Add(this.lblLblCustomerName);
            this.grpCustomer.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.grpCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.grpCustomer.Location = new System.Drawing.Point(25, 20);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Padding = new System.Windows.Forms.Padding(15);
            this.grpCustomer.Size = new System.Drawing.Size(445, 220);
            this.grpCustomer.TabIndex = 0;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Details";
            // 
            // lblValLicence
            // 
            this.lblValLicence.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValLicence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(101)))), ((int)(((byte)(52)))));
            this.lblValLicence.Location = new System.Drawing.Point(160, 170);
            this.lblValLicence.Name = "lblValLicence";
            this.lblValLicence.Size = new System.Drawing.Size(270, 20);
            this.lblValLicence.TabIndex = 7;
            this.lblValLicence.Text = "Verified";
            // 
            // lblLblLicence
            // 
            this.lblLblLicence.AutoSize = true;
            this.lblLblLicence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblLicence.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblLicence.Location = new System.Drawing.Point(15, 170);
            this.lblLblLicence.Name = "lblLblLicence";
            this.lblLblLicence.Size = new System.Drawing.Size(89, 15);
            this.lblLblLicence.TabIndex = 6;
            this.lblLblLicence.Text = "Driving Licence:";
            // 
            // lblValAge
            // 
            this.lblValAge.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValAge.Location = new System.Drawing.Point(160, 130);
            this.lblValAge.Name = "lblValAge";
            this.lblValAge.Size = new System.Drawing.Size(270, 20);
            this.lblValAge.TabIndex = 5;
            this.lblValAge.Text = "Age";
            // 
            // lblLblAge
            // 
            this.lblLblAge.AutoSize = true;
            this.lblLblAge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblAge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblAge.Location = new System.Drawing.Point(15, 130);
            this.lblLblAge.Name = "lblLblAge";
            this.lblLblAge.Size = new System.Drawing.Size(31, 15);
            this.lblLblAge.TabIndex = 4;
            this.lblLblAge.Text = "Age:";
            // 
            // lblValAddress
            // 
            this.lblValAddress.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValAddress.Location = new System.Drawing.Point(160, 75);
            this.lblValAddress.Name = "lblValAddress";
            this.lblValAddress.Size = new System.Drawing.Size(270, 45);
            this.lblValAddress.TabIndex = 3;
            this.lblValAddress.Text = "Address";
            // 
            // lblLblAddress
            // 
            this.lblLblAddress.AutoSize = true;
            this.lblLblAddress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblAddress.Location = new System.Drawing.Point(15, 75);
            this.lblLblAddress.Name = "lblLblAddress";
            this.lblLblAddress.Size = new System.Drawing.Size(52, 15);
            this.lblLblAddress.TabIndex = 2;
            this.lblLblAddress.Text = "Address:";
            // 
            // lblValCustomerName
            // 
            this.lblValCustomerName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblValCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblValCustomerName.Location = new System.Drawing.Point(160, 35);
            this.lblValCustomerName.Name = "lblValCustomerName";
            this.lblValCustomerName.Size = new System.Drawing.Size(270, 20);
            this.lblValCustomerName.TabIndex = 1;
            this.lblValCustomerName.Text = "Name";
            // 
            // lblLblCustomerName
            // 
            this.lblLblCustomerName.AutoSize = true;
            this.lblLblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblLblCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblLblCustomerName.Location = new System.Drawing.Point(15, 35);
            this.lblLblCustomerName.Name = "lblLblCustomerName";
            this.lblLblCustomerName.Size = new System.Drawing.Size(97, 15);
            this.lblLblCustomerName.TabIndex = 0;
            this.lblLblCustomerName.Text = "Customer Name:";
            // 
            // BookingSummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(860, 680);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BookingSummaryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WeAreCars - Booking Summary";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.grpCost.ResumeLayout(false);
            this.grpCost.PerformLayout();
            this.pnlTotalHighlight.ResumeLayout(false);
            this.pnlTotalHighlight.PerformLayout();
            this.grpExtras.ResumeLayout(false);
            this.grpExtras.PerformLayout();
            this.grpRental.ResumeLayout(false);
            this.grpRental.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
