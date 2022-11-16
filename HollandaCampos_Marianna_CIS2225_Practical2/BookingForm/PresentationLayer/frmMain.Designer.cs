
namespace BookingForm
{
    partial class frmMain
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
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msPriceBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.msProcessBooking = new System.Windows.Forms.ToolStripMenuItem();
            this.gBoxBandType = new System.Windows.Forms.GroupBox();
            this.rdoClassical = new System.Windows.Forms.RadioButton();
            this.rdoPop = new System.Windows.Forms.RadioButton();
            this.rdoRock = new System.Windows.Forms.RadioButton();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEventSize = new System.Windows.Forms.Label();
            this.cmbEventSize = new System.Windows.Forms.ComboBox();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.richTxtTitle = new System.Windows.Forms.RichTextBox();
            this.msMain.SuspendLayout();
            this.gBoxBandType.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msEdit});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(361, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "File";
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(180, 22);
            this.msExit.Text = "Exit";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // msEdit
            // 
            this.msEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msPriceBooking,
            this.msProcessBooking});
            this.msEdit.Name = "msEdit";
            this.msEdit.Size = new System.Drawing.Size(39, 20);
            this.msEdit.Text = "Edit";
            // 
            // msPriceBooking
            // 
            this.msPriceBooking.Name = "msPriceBooking";
            this.msPriceBooking.Size = new System.Drawing.Size(161, 22);
            this.msPriceBooking.Text = "Price Booking";
            this.msPriceBooking.Click += new System.EventHandler(this.msPriceBooking_Click);
            // 
            // msProcessBooking
            // 
            this.msProcessBooking.Name = "msProcessBooking";
            this.msProcessBooking.Size = new System.Drawing.Size(161, 22);
            this.msProcessBooking.Text = "Process Booking";
            this.msProcessBooking.Click += new System.EventHandler(this.msProcessBooking_Click);
            // 
            // gBoxBandType
            // 
            this.gBoxBandType.Controls.Add(this.rdoClassical);
            this.gBoxBandType.Controls.Add(this.rdoPop);
            this.gBoxBandType.Controls.Add(this.rdoRock);
            this.gBoxBandType.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBoxBandType.Location = new System.Drawing.Point(167, 209);
            this.gBoxBandType.Name = "gBoxBandType";
            this.gBoxBandType.Size = new System.Drawing.Size(139, 100);
            this.gBoxBandType.TabIndex = 1;
            this.gBoxBandType.TabStop = false;
            this.gBoxBandType.Text = "Band Type";
            // 
            // rdoClassical
            // 
            this.rdoClassical.AutoSize = true;
            this.rdoClassical.Location = new System.Drawing.Point(6, 69);
            this.rdoClassical.Name = "rdoClassical";
            this.rdoClassical.Size = new System.Drawing.Size(132, 19);
            this.rdoClassical.TabIndex = 2;
            this.rdoClassical.TabStop = true;
            this.rdoClassical.Text = "Classical: $1200";
            this.rdoClassical.UseVisualStyleBackColor = true;
            // 
            // rdoPop
            // 
            this.rdoPop.AutoSize = true;
            this.rdoPop.Location = new System.Drawing.Point(6, 44);
            this.rdoPop.Name = "rdoPop";
            this.rdoPop.Size = new System.Drawing.Size(97, 19);
            this.rdoPop.TabIndex = 1;
            this.rdoPop.TabStop = true;
            this.rdoPop.Text = "Pop: $2000";
            this.rdoPop.UseVisualStyleBackColor = true;
            // 
            // rdoRock
            // 
            this.rdoRock.AutoSize = true;
            this.rdoRock.Location = new System.Drawing.Point(6, 19);
            this.rdoRock.Name = "rdoRock";
            this.rdoRock.Size = new System.Drawing.Size(104, 19);
            this.rdoRock.TabIndex = 0;
            this.rdoRock.TabStop = true;
            this.rdoRock.Text = "Rock: $1500";
            this.rdoRock.UseVisualStyleBackColor = true;
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueName.Location = new System.Drawing.Point(46, 97);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(93, 15);
            this.lblVenueName.TabIndex = 2;
            this.lblVenueName.Text = "Venue Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(46, 124);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(82, 15);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastName.Location = new System.Drawing.Point(46, 150);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(80, 15);
            this.lblLastName.TabIndex = 4;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(46, 176);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 15);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblEventSize
            // 
            this.lblEventSize.AutoSize = true;
            this.lblEventSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventSize.Location = new System.Drawing.Point(27, 209);
            this.lblEventSize.Name = "lblEventSize";
            this.lblEventSize.Size = new System.Drawing.Size(79, 15);
            this.lblEventSize.TabIndex = 6;
            this.lblEventSize.Text = "Event Size:";
            // 
            // cmbEventSize
            // 
            this.cmbEventSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEventSize.FormattingEnabled = true;
            this.cmbEventSize.Items.AddRange(new object[] {
            "300 and under",
            "301 to 600 spectators",
            "601 to 1200 spectators"});
            this.cmbEventSize.Location = new System.Drawing.Point(30, 227);
            this.cmbEventSize.Name = "cmbEventSize";
            this.cmbEventSize.Size = new System.Drawing.Size(121, 21);
            this.cmbEventSize.TabIndex = 7;
            // 
            // txtVenueName
            // 
            this.txtVenueName.Location = new System.Drawing.Point(147, 95);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(115, 20);
            this.txtVenueName.TabIndex = 8;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(147, 122);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(115, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(147, 148);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(115, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 174);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // richTxtTitle
            // 
            this.richTxtTitle.BackColor = System.Drawing.SystemColors.Control;
            this.richTxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtTitle.Location = new System.Drawing.Point(0, 21);
            this.richTxtTitle.Name = "richTxtTitle";
            this.richTxtTitle.Size = new System.Drawing.Size(349, 68);
            this.richTxtTitle.TabIndex = 12;
            this.richTxtTitle.Text = "              Book Your Event Here!!";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 330);
            this.Controls.Add(this.richTxtTitle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtVenueName);
            this.Controls.Add(this.cmbEventSize);
            this.Controls.Add(this.lblEventSize);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblVenueName);
            this.Controls.Add(this.gBoxBandType);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMain;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Booking Form";
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.gBoxBandType.ResumeLayout(false);
            this.gBoxBandType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.ToolStripMenuItem msEdit;
        private System.Windows.Forms.ToolStripMenuItem msPriceBooking;
        private System.Windows.Forms.ToolStripMenuItem msProcessBooking;
        private System.Windows.Forms.GroupBox gBoxBandType;
        private System.Windows.Forms.RadioButton rdoClassical;
        private System.Windows.Forms.RadioButton rdoPop;
        private System.Windows.Forms.RadioButton rdoRock;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEventSize;
        private System.Windows.Forms.ComboBox cmbEventSize;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.RichTextBox richTxtTitle;
    }
}

