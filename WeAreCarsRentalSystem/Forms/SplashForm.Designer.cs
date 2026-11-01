namespace WeAreCarsRentalSystem.Forms
{
    partial class SplashForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblWelcomeTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ProgressBar prgLoading;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Timer tmrSplash;
        private System.Windows.Forms.Panel pnlCard;

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
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblWelcomeTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.prgLoading = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnContinue = new System.Windows.Forms.Button();
            this.tmrSplash = new System.Windows.Forms.Timer(this.components);
            this.pnlCard = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnlCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCard
            // 
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCard.Controls.Add(this.picLogo);
            this.pnlCard.Controls.Add(this.lblWelcomeTitle);
            this.pnlCard.Controls.Add(this.lblSubtitle);
            this.pnlCard.Controls.Add(this.lblInstructions);
            this.pnlCard.Controls.Add(this.prgLoading);
            this.pnlCard.Controls.Add(this.lblStatus);
            this.pnlCard.Controls.Add(this.btnContinue);
            this.pnlCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCard.Location = new System.Drawing.Point(0, 0);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Padding = new System.Windows.Forms.Padding(30);
            this.pnlCard.Size = new System.Drawing.Size(560, 400);
            this.pnlCard.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(170, 25);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(220, 90);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // lblWelcomeTitle
            // 
            this.lblWelcomeTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblWelcomeTitle.Location = new System.Drawing.Point(30, 125);
            this.lblWelcomeTitle.Name = "lblWelcomeTitle";
            this.lblWelcomeTitle.Size = new System.Drawing.Size(500, 32);
            this.lblWelcomeTitle.TabIndex = 1;
            this.lblWelcomeTitle.Text = "Welcome to WeAreCars";
            this.lblWelcomeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblSubtitle.Location = new System.Drawing.Point(30, 160);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(500, 24);
            this.lblSubtitle.TabIndex = 2;
            this.lblSubtitle.Text = "Car Rental Management System";
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstructions
            // 
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.lblInstructions.Location = new System.Drawing.Point(40, 195);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(480, 50);
            this.lblInstructions.TabIndex = 3;
            this.lblInstructions.Text = "Use this application to securely manage customer vehicle rental bookings, check active fleet rentals, and calculate transparent rental pricing.";
            this.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgLoading
            // 
            this.prgLoading.Location = new System.Drawing.Point(50, 265);
            this.prgLoading.Name = "prgLoading";
            this.prgLoading.Size = new System.Drawing.Size(460, 12);
            this.prgLoading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgLoading.TabIndex = 4;
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lblStatus.Location = new System.Drawing.Point(50, 285);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(320, 20);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Starting system...";
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnContinue.Location = new System.Drawing.Point(215, 325);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(130, 36);
            this.btnContinue.TabIndex = 6;
            this.btnContinue.Text = "Continue >>";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // tmrSplash
            // 
            this.tmrSplash.Tick += new System.EventHandler(this.tmrSplash_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(560, 400);
            this.Controls.Add(this.pnlCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeAreCars - Welcome";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
    }
}
