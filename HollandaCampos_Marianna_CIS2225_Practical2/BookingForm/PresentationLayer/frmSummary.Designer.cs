
namespace BookingForm.PresentationLayer
{
    partial class frmSummary
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblVenueSize = new System.Windows.Forms.Label();
            this.lblBandType = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtTotalCost = new System.Windows.Forms.TextBox();
            this.txtVenueSize = new System.Windows.Forms.TextBox();
            this.txtBandType = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F);
            this.lblSummary.Location = new System.Drawing.Point(76, 28);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(166, 22);
            this.lblSummary.TabIndex = 0;
            this.lblSummary.Text = "Event Summary!!";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblVenueName.Location = new System.Drawing.Point(35, 68);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(93, 15);
            this.lblVenueName.TabIndex = 1;
            this.lblVenueName.Text = "Venue Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblFirstName.Location = new System.Drawing.Point(35, 127);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(82, 15);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblLastName.Location = new System.Drawing.Point(37, 191);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 15);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblVenueSize
            // 
            this.lblVenueSize.AutoSize = true;
            this.lblVenueSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblVenueSize.Location = new System.Drawing.Point(202, 191);
            this.lblVenueSize.Name = "lblVenueSize";
            this.lblVenueSize.Size = new System.Drawing.Size(83, 15);
            this.lblVenueSize.TabIndex = 4;
            this.lblVenueSize.Text = "Venue Size:";
            // 
            // lblBandType
            // 
            this.lblBandType.AutoSize = true;
            this.lblBandType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblBandType.Location = new System.Drawing.Point(207, 127);
            this.lblBandType.Name = "lblBandType";
            this.lblBandType.Size = new System.Drawing.Size(78, 15);
            this.lblBandType.TabIndex = 5;
            this.lblBandType.Text = "Band Type:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblEmail.Location = new System.Drawing.Point(221, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email:";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F);
            this.lblTotalCost.Location = new System.Drawing.Point(122, 241);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(77, 15);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // txtVenueName
            // 
            this.txtVenueName.Location = new System.Drawing.Point(28, 86);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.ReadOnly = true;
            this.txtVenueName.Size = new System.Drawing.Size(100, 20);
            this.txtVenueName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(28, 145);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(28, 209);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtTotalCost
            // 
            this.txtTotalCost.Location = new System.Drawing.Point(109, 259);
            this.txtTotalCost.Name = "txtTotalCost";
            this.txtTotalCost.ReadOnly = true;
            this.txtTotalCost.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCost.TabIndex = 11;
            // 
            // txtVenueSize
            // 
            this.txtVenueSize.Location = new System.Drawing.Point(194, 209);
            this.txtVenueSize.Name = "txtVenueSize";
            this.txtVenueSize.ReadOnly = true;
            this.txtVenueSize.Size = new System.Drawing.Size(100, 20);
            this.txtVenueSize.TabIndex = 12;
            // 
            // txtBandType
            // 
            this.txtBandType.Location = new System.Drawing.Point(194, 145);
            this.txtBandType.Name = "txtBandType";
            this.txtBandType.ReadOnly = true;
            this.txtBandType.Size = new System.Drawing.Size(100, 20);
            this.txtBandType.TabIndex = 13;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(194, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // frmSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 296);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtBandType);
            this.Controls.Add(this.txtVenueSize);
            this.Controls.Add(this.txtTotalCost);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtVenueName);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBandType);
            this.Controls.Add(this.lblVenueSize);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblVenueName);
            this.Controls.Add(this.lblSummary);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSummary";
            this.Text = "Summary Form";
            this.Load += new System.EventHandler(this.frmSummary_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblVenueSize;
        private System.Windows.Forms.Label lblBandType;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.TextBox txtVenueSize;
        private System.Windows.Forms.TextBox txtBandType;
        private System.Windows.Forms.TextBox txtEmail;
    }
}