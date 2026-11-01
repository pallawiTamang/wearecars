namespace WeAreCarsRentalSystem.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblSystemTitle;
        private System.Windows.Forms.Label lblStaffWelcome;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblSectionTitle;
        private System.Windows.Forms.Label lblSectionSubtitle;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.Button btnRentedCars;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlStatsCard;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblTotalRentalsCount;
        private System.Windows.Forms.Label lblStatsDesc;
        private System.Windows.Forms.Timer tmrClock;

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
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblStaffWelcome = new System.Windows.Forms.Label();
            this.lblSystemTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlStatsCard = new System.Windows.Forms.Panel();
            this.lblStatsDesc = new System.Windows.Forms.Label();
            this.lblTotalRentalsCount = new System.Windows.Forms.Label();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnRentedCars = new System.Windows.Forms.Button();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.lblSectionSubtitle = new System.Windows.Forms.Label();
            this.lblSectionTitle = new System.Windows.Forms.Label();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlContent.SuspendLayout();
            this.pnlStatsCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Controls.Add(this.lblStaffWelcome);
            this.pnlHeader.Controls.Add(this.lblSystemTitle);
            this.pnlHeader.Controls.Add(this.picLogo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(20, 10, 20, 10);
            this.pnlHeader.Size = new System.Drawing.Size(920, 90);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblDateTime
            // 
            this.lblDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblDateTime.Location = new System.Drawing.Point(620, 48);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(275, 23);
            this.lblDateTime.TabIndex = 3;
            this.lblDateTime.Text = "DateTime";
            this.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStaffWelcome
            // 
            this.lblStaffWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStaffWelcome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblStaffWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStaffWelcome.Location = new System.Drawing.Point(620, 20);
            this.lblStaffWelcome.Name = "lblStaffWelcome";
            this.lblStaffWelcome.Size = new System.Drawing.Size(275, 23);
            this.lblStaffWelcome.TabIndex = 2;
            this.lblStaffWelcome.Text = "Welcome, Staff Member";
            this.lblStaffWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSystemTitle
            // 
            this.lblSystemTitle.AutoSize = true;
            this.lblSystemTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblSystemTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(52)))), ((int)(((byte)(96)))));
            this.lblSystemTitle.Location = new System.Drawing.Point(180, 28);
            this.lblSystemTitle.Name = "lblSystemTitle";
            this.lblSystemTitle.Size = new System.Drawing.Size(306, 28);
            this.lblSystemTitle.TabIndex = 1;
            this.lblSystemTitle.Text = "Car Rental Management Portal";
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(20, 10);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(150, 68);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.pnlContent.Controls.Add(this.pnlStatsCard);
            this.pnlContent.Controls.Add(this.btnLogout);
            this.pnlContent.Controls.Add(this.btnRentedCars);
            this.pnlContent.Controls.Add(this.btnNewBooking);
            this.pnlContent.Controls.Add(this.lblSectionSubtitle);
            this.pnlContent.Controls.Add(this.lblSectionTitle);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 90);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(40);
            this.pnlContent.Size = new System.Drawing.Size(920, 480);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlStatsCard
            // 
            this.pnlStatsCard.BackColor = System.Drawing.Color.White;
            this.pnlStatsCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlStatsCard.Controls.Add(this.lblStatsDesc);
            this.pnlStatsCard.Controls.Add(this.lblTotalRentalsCount);
            this.pnlStatsCard.Controls.Add(this.lblStatsTitle);
            this.pnlStatsCard.Location = new System.Drawing.Point(40, 310);
            this.pnlStatsCard.Name = "pnlStatsCard";
            this.pnlStatsCard.Padding = new System.Windows.Forms.Padding(20);
            this.pnlStatsCard.Size = new System.Drawing.Size(840, 110);
            this.pnlStatsCard.TabIndex = 5;
            // 
            // lblStatsDesc
            // 
            this.lblStatsDesc.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblStatsDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStatsDesc.Location = new System.Drawing.Point(20, 68);
            this.lblStatsDesc.Name = "lblStatsDesc";
            this.lblStatsDesc.Size = new System.Drawing.Size(600, 23);
            this.lblStatsDesc.TabIndex = 2;
            this.lblStatsDesc.Text = "Currently recorded customer vehicle rentals across Sunderland branch operations.";
            // 
            // lblTotalRentalsCount
            // 
            this.lblTotalRentalsCount.AutoSize = true;
            this.lblTotalRentalsCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalRentalsCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.lblTotalRentalsCount.Location = new System.Drawing.Point(740, 32);
            this.lblTotalRentalsCount.Name = "lblTotalRentalsCount";
            this.lblTotalRentalsCount.Size = new System.Drawing.Size(32, 37);
            this.lblTotalRentalsCount.TabIndex = 1;
            this.lblTotalRentalsCount.Text = "0";
            this.lblTotalRentalsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStatsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblStatsTitle.Location = new System.Drawing.Point(20, 25);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(164, 20);
            this.lblStatsTitle.TabIndex = 0;
            this.lblStatsTitle.Text = "Fleet Rental Overview";
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogout.Location = new System.Drawing.Point(620, 130);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(260, 140);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "LOGOUT\r\n\r\nEnd authenticated staff session";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnRentedCars
            // 
            this.btnRentedCars.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnRentedCars.Location = new System.Drawing.Point(330, 130);
            this.btnRentedCars.Name = "btnRentedCars";
            this.btnRentedCars.Size = new System.Drawing.Size(260, 140);
            this.btnRentedCars.TabIndex = 3;
            this.btnRentedCars.Text = "RENTED CARS\r\n\r\nView active bookings && fleet records";
            this.btnRentedCars.UseVisualStyleBackColor = true;
            this.btnRentedCars.Click += new System.EventHandler(this.btnRentedCars_Click);
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnNewBooking.Location = new System.Drawing.Point(40, 130);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(260, 140);
            this.btnNewBooking.TabIndex = 2;
            this.btnNewBooking.Text = "NEW BOOKING\r\n\r\nCreate a new customer vehicle rental";
            this.btnNewBooking.UseVisualStyleBackColor = true;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // lblSectionSubtitle
            // 
            this.lblSectionSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSectionSubtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblSectionSubtitle.Location = new System.Drawing.Point(40, 68);
            this.lblSectionSubtitle.Name = "lblSectionSubtitle";
            this.lblSectionSubtitle.Size = new System.Drawing.Size(650, 30);
            this.lblSectionSubtitle.TabIndex = 1;
            this.lblSectionSubtitle.Text = "Select an operational action below to manage rentals or review system records.";
            // 
            // lblSectionTitle
            // 
            this.lblSectionTitle.AutoSize = true;
            this.lblSectionTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblSectionTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.lblSectionTitle.Location = new System.Drawing.Point(40, 35);
            this.lblSectionTitle.Name = "lblSectionTitle";
            this.lblSectionTitle.Size = new System.Drawing.Size(176, 30);
            this.lblSectionTitle.TabIndex = 0;
            this.lblSectionTitle.Text = "Main Dashboard";
            // 
            // tmrClock
            // 
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(920, 570);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeAreCars - Staff Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlStatsCard.ResumeLayout(false);
            this.pnlStatsCard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
