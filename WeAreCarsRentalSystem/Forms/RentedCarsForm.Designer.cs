namespace WeAreCarsRentalSystem.Forms
{
    partial class RentedCarsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblFormHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterCar;
        private System.Windows.Forms.ComboBox cmbFilterCarType;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Panel pnlGridCard;
        private System.Windows.Forms.DataGridView dgvRentedCars;
        private System.Windows.Forms.Button btnNewBooking;
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
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.pnlGridCard = new System.Windows.Forms.Panel();
            this.dgvRentedCars = new System.Windows.Forms.DataGridView();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cmbFilterCarType = new System.Windows.Forms.ComboBox();
            this.lblFilterCar = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlGridCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedCars)).BeginInit();
            this.pnlFilters.SuspendLayout();
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
            this.pnlHeader.Size = new System.Drawing.Size(1040, 85);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblFormHeader
            // 
            this.lblFormHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFormHeader.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblFormHeader.Location = new System.Drawing.Point(710, 28);
            this.lblFormHeader.Name = "lblFormHeader";
            this.lblFormHeader.Size = new System.Drawing.Size(300, 24);
            this.lblFormHeader.TabIndex = 2;
            this.lblFormHeader.Text = "ACTIVE FLEET & RENTED CARS";
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
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.btnBackToDashboard);
            this.pnlContent.Controls.Add(this.btnNewBooking);
            this.pnlContent.Controls.Add(this.pnlGridCard);
            this.pnlContent.Controls.Add(this.pnlFilters);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 85);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(25);
            this.pnlContent.Size = new System.Drawing.Size(1040, 565);
            this.pnlContent.TabIndex = 1;
            // 
            // btnBackToDashboard
            // 
            this.btnBackToDashboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackToDashboard.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnBackToDashboard.Location = new System.Drawing.Point(835, 510);
            this.btnBackToDashboard.Name = "btnBackToDashboard";
            this.btnBackToDashboard.Size = new System.Drawing.Size(180, 40);
            this.btnBackToDashboard.TabIndex = 4;
            this.btnBackToDashboard.Text = "Back to Dashboard";
            this.btnBackToDashboard.UseVisualStyleBackColor = true;
            this.btnBackToDashboard.Click += new System.EventHandler(this.btnBackToDashboard_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewBooking.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNewBooking.Location = new System.Drawing.Point(25, 510);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(220, 40);
            this.btnNewBooking.TabIndex = 3;
            this.btnNewBooking.Text = "+ Create New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // pnlGridCard
            // 
            this.pnlGridCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridCard.BackColor = System.Drawing.Color.White;
            this.pnlGridCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGridCard.Controls.Add(this.dgvRentedCars);
            this.pnlGridCard.Location = new System.Drawing.Point(25, 95);
            this.pnlGridCard.Name = "pnlGridCard";
            this.pnlGridCard.Padding = new System.Windows.Forms.Padding(10);
            this.pnlGridCard.Size = new System.Drawing.Size(990, 400);
            this.pnlGridCard.TabIndex = 1;
            // 
            // dgvRentedCars
            // 
            this.dgvRentedCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentedCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRentedCars.Location = new System.Drawing.Point(10, 10);
            this.dgvRentedCars.Name = "dgvRentedCars";
            this.dgvRentedCars.RowTemplate.Height = 25;
            this.dgvRentedCars.Size = new System.Drawing.Size(968, 378);
            this.dgvRentedCars.TabIndex = 0;
            this.dgvRentedCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentedCars_CellDoubleClick);
            // 
            // pnlFilters
            // 
            this.pnlFilters.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFilters.BackColor = System.Drawing.Color.White;
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.lblRecordCount);
            this.pnlFilters.Controls.Add(this.btnRefresh);
            this.pnlFilters.Controls.Add(this.cmbFilterCarType);
            this.pnlFilters.Controls.Add(this.lblFilterCar);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.Location = new System.Drawing.Point(25, 20);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.pnlFilters.Size = new System.Drawing.Size(990, 60);
            this.pnlFilters.TabIndex = 0;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblRecordCount.Location = new System.Drawing.Point(740, 18);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(230, 23);
            this.lblRecordCount.TabIndex = 5;
            this.lblRecordCount.Text = "Showing 0 record(s)";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.Location = new System.Drawing.Point(580, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 28);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cmbFilterCarType
            // 
            this.cmbFilterCarType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCarType.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFilterCarType.FormattingEnabled = true;
            this.cmbFilterCarType.Location = new System.Drawing.Point(395, 18);
            this.cmbFilterCarType.Name = "cmbFilterCarType";
            this.cmbFilterCarType.Size = new System.Drawing.Size(170, 23);
            this.cmbFilterCarType.TabIndex = 3;
            this.cmbFilterCarType.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCarType_SelectedIndexChanged);
            // 
            // lblFilterCar
            // 
            this.lblFilterCar.AutoSize = true;
            this.lblFilterCar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblFilterCar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblFilterCar.Location = new System.Drawing.Point(330, 21);
            this.lblFilterCar.Name = "lblFilterCar";
            this.lblFilterCar.Size = new System.Drawing.Size(58, 15);
            this.lblFilterCar.TabIndex = 2;
            this.lblFilterCar.Text = "Category:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.Location = new System.Drawing.Point(75, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search by name, address or reference...";
            this.txtSearch.Size = new System.Drawing.Size(235, 23);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSearch.Location = new System.Drawing.Point(15, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 15);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search:";
            // 
            // RentedCarsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1040, 650);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RentedCarsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeAreCars - Fleet Rented Cars";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RentedCarsForm_FormClosing);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlGridCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentedCars)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
