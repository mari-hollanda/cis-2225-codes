namespace Animal_Hospital
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
            this.tcAnimal = new System.Windows.Forms.TabControl();
            this.tpWelcome = new System.Windows.Forms.TabPage();
            this.lblPatients = new System.Windows.Forms.Label();
            this.rtxtPatients = new System.Windows.Forms.RichTextBox();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.tpDog = new System.Windows.Forms.TabPage();
            this.btnAddDog = new System.Windows.Forms.Button();
            this.txtDogColor = new System.Windows.Forms.TextBox();
            this.txtDogNumLegs = new System.Windows.Forms.TextBox();
            this.txtDogVisitReason = new System.Windows.Forms.TextBox();
            this.dtpDogVisit = new System.Windows.Forms.DateTimePicker();
            this.cbDogType = new System.Windows.Forms.ComboBox();
            this.lblDogColor = new System.Windows.Forms.Label();
            this.lblNumOfLegs = new System.Windows.Forms.Label();
            this.lblDogType = new System.Windows.Forms.Label();
            this.lblDateVisit = new System.Windows.Forms.Label();
            this.lblVisitReason = new System.Windows.Forms.Label();
            this.txtDogName = new System.Windows.Forms.TextBox();
            this.lblDogName = new System.Windows.Forms.Label();
            this.tpCat = new System.Windows.Forms.TabPage();
            this.tpHorse = new System.Windows.Forms.TabPage();
            this.btnAddCat = new System.Windows.Forms.Button();
            this.txtCatColor = new System.Windows.Forms.TextBox();
            this.txtNumCatLegs = new System.Windows.Forms.TextBox();
            this.txtReasonVisitCat = new System.Windows.Forms.TextBox();
            this.dtpCatVisit = new System.Windows.Forms.DateTimePicker();
            this.cbCatType = new System.Windows.Forms.ComboBox();
            this.lblCatColor = new System.Windows.Forms.Label();
            this.lblNumOfLegsCat = new System.Windows.Forms.Label();
            this.lblCatType = new System.Windows.Forms.Label();
            this.lblDateVisitCat = new System.Windows.Forms.Label();
            this.lblVisitReasonCat = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.btnAddHorse = new System.Windows.Forms.Button();
            this.txtHorseColor = new System.Windows.Forms.TextBox();
            this.txtNumHorseLegs = new System.Windows.Forms.TextBox();
            this.txtReasonVisitHorse = new System.Windows.Forms.TextBox();
            this.dtpHorseVisit = new System.Windows.Forms.DateTimePicker();
            this.cbHorseType = new System.Windows.Forms.ComboBox();
            this.lblHorseColor = new System.Windows.Forms.Label();
            this.lblNumHorseLegs = new System.Windows.Forms.Label();
            this.lblHorseType = new System.Windows.Forms.Label();
            this.lblDateVisitHorse = new System.Windows.Forms.Label();
            this.lblReasonVisitHorse = new System.Windows.Forms.Label();
            this.txtHorseName = new System.Windows.Forms.TextBox();
            this.lblHorseName = new System.Windows.Forms.Label();
            this.tcAnimal.SuspendLayout();
            this.tpWelcome.SuspendLayout();
            this.tpDog.SuspendLayout();
            this.tpCat.SuspendLayout();
            this.tpHorse.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAnimal
            // 
            this.tcAnimal.Controls.Add(this.tpWelcome);
            this.tcAnimal.Controls.Add(this.tpDog);
            this.tcAnimal.Controls.Add(this.tpCat);
            this.tcAnimal.Controls.Add(this.tpHorse);
            this.tcAnimal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAnimal.Location = new System.Drawing.Point(0, 0);
            this.tcAnimal.Name = "tcAnimal";
            this.tcAnimal.SelectedIndex = 0;
            this.tcAnimal.Size = new System.Drawing.Size(441, 296);
            this.tcAnimal.TabIndex = 0;
            // 
            // tpWelcome
            // 
            this.tpWelcome.Controls.Add(this.lblPatients);
            this.tpWelcome.Controls.Add(this.rtxtPatients);
            this.tpWelcome.Controls.Add(this.txtDisplay);
            this.tpWelcome.Location = new System.Drawing.Point(4, 22);
            this.tpWelcome.Name = "tpWelcome";
            this.tpWelcome.Padding = new System.Windows.Forms.Padding(3);
            this.tpWelcome.Size = new System.Drawing.Size(433, 270);
            this.tpWelcome.TabIndex = 0;
            this.tpWelcome.Text = "Home";
            this.tpWelcome.UseVisualStyleBackColor = true;
            // 
            // lblPatients
            // 
            this.lblPatients.AutoSize = true;
            this.lblPatients.Location = new System.Drawing.Point(8, 129);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(85, 13);
            this.lblPatients.TabIndex = 2;
            this.lblPatients.Text = "Current Patients:";
            // 
            // rtxtPatients
            // 
            this.rtxtPatients.Location = new System.Drawing.Point(8, 145);
            this.rtxtPatients.Name = "rtxtPatients";
            this.rtxtPatients.Size = new System.Drawing.Size(417, 104);
            this.rtxtPatients.TabIndex = 1;
            this.rtxtPatients.Text = "";
            // 
            // txtDisplay
            // 
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(8, 54);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(417, 22);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "CIS Animal Hospital";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpDog
            // 
            this.tpDog.Controls.Add(this.btnAddDog);
            this.tpDog.Controls.Add(this.txtDogColor);
            this.tpDog.Controls.Add(this.txtDogNumLegs);
            this.tpDog.Controls.Add(this.txtDogVisitReason);
            this.tpDog.Controls.Add(this.dtpDogVisit);
            this.tpDog.Controls.Add(this.cbDogType);
            this.tpDog.Controls.Add(this.lblDogColor);
            this.tpDog.Controls.Add(this.lblNumOfLegs);
            this.tpDog.Controls.Add(this.lblDogType);
            this.tpDog.Controls.Add(this.lblDateVisit);
            this.tpDog.Controls.Add(this.lblVisitReason);
            this.tpDog.Controls.Add(this.txtDogName);
            this.tpDog.Controls.Add(this.lblDogName);
            this.tpDog.Location = new System.Drawing.Point(4, 22);
            this.tpDog.Name = "tpDog";
            this.tpDog.Padding = new System.Windows.Forms.Padding(3);
            this.tpDog.Size = new System.Drawing.Size(433, 270);
            this.tpDog.TabIndex = 1;
            this.tpDog.Text = "Dog";
            this.tpDog.UseVisualStyleBackColor = true;
            // 
            // btnAddDog
            // 
            this.btnAddDog.Location = new System.Drawing.Point(114, 223);
            this.btnAddDog.Name = "btnAddDog";
            this.btnAddDog.Size = new System.Drawing.Size(75, 23);
            this.btnAddDog.TabIndex = 6;
            this.btnAddDog.Text = "Add Dog";
            this.btnAddDog.UseVisualStyleBackColor = true;
            this.btnAddDog.Click += new System.EventHandler(this.btnAddDog_Click);
            // 
            // txtDogColor
            // 
            this.txtDogColor.Location = new System.Drawing.Point(135, 105);
            this.txtDogColor.Name = "txtDogColor";
            this.txtDogColor.Size = new System.Drawing.Size(100, 20);
            this.txtDogColor.TabIndex = 2;
            // 
            // txtDogNumLegs
            // 
            this.txtDogNumLegs.Location = new System.Drawing.Point(135, 131);
            this.txtDogNumLegs.Name = "txtDogNumLegs";
            this.txtDogNumLegs.Size = new System.Drawing.Size(100, 20);
            this.txtDogNumLegs.TabIndex = 3;
            // 
            // txtDogVisitReason
            // 
            this.txtDogVisitReason.Location = new System.Drawing.Point(135, 157);
            this.txtDogVisitReason.Name = "txtDogVisitReason";
            this.txtDogVisitReason.Size = new System.Drawing.Size(100, 20);
            this.txtDogVisitReason.TabIndex = 4;
            // 
            // dtpDogVisit
            // 
            this.dtpDogVisit.Location = new System.Drawing.Point(135, 183);
            this.dtpDogVisit.Name = "dtpDogVisit";
            this.dtpDogVisit.Size = new System.Drawing.Size(200, 20);
            this.dtpDogVisit.TabIndex = 5;
            // 
            // cbDogType
            // 
            this.cbDogType.FormattingEnabled = true;
            this.cbDogType.Location = new System.Drawing.Point(135, 78);
            this.cbDogType.Name = "cbDogType";
            this.cbDogType.Size = new System.Drawing.Size(121, 21);
            this.cbDogType.TabIndex = 1;
            // 
            // lblDogColor
            // 
            this.lblDogColor.AutoSize = true;
            this.lblDogColor.Location = new System.Drawing.Point(12, 108);
            this.lblDogColor.Name = "lblDogColor";
            this.lblDogColor.Size = new System.Drawing.Size(57, 13);
            this.lblDogColor.TabIndex = 6;
            this.lblDogColor.Text = "Dog Color:";
            // 
            // lblNumOfLegs
            // 
            this.lblNumOfLegs.AutoSize = true;
            this.lblNumOfLegs.Location = new System.Drawing.Point(12, 134);
            this.lblNumOfLegs.Name = "lblNumOfLegs";
            this.lblNumOfLegs.Size = new System.Drawing.Size(85, 13);
            this.lblNumOfLegs.TabIndex = 5;
            this.lblNumOfLegs.Text = "Number of Legs:";
            // 
            // lblDogType
            // 
            this.lblDogType.AutoSize = true;
            this.lblDogType.Location = new System.Drawing.Point(12, 78);
            this.lblDogType.Name = "lblDogType";
            this.lblDogType.Size = new System.Drawing.Size(57, 13);
            this.lblDogType.TabIndex = 4;
            this.lblDogType.Text = "Dog Type:";
            // 
            // lblDateVisit
            // 
            this.lblDateVisit.AutoSize = true;
            this.lblDateVisit.Location = new System.Drawing.Point(12, 190);
            this.lblDateVisit.Name = "lblDateVisit";
            this.lblDateVisit.Size = new System.Drawing.Size(64, 13);
            this.lblDateVisit.TabIndex = 3;
            this.lblDateVisit.Text = "Date of Visit";
            // 
            // lblVisitReason
            // 
            this.lblVisitReason.AutoSize = true;
            this.lblVisitReason.Location = new System.Drawing.Point(12, 160);
            this.lblVisitReason.Name = "lblVisitReason";
            this.lblVisitReason.Size = new System.Drawing.Size(84, 13);
            this.lblVisitReason.TabIndex = 2;
            this.lblVisitReason.Text = "Reason for Visit:";
            // 
            // txtDogName
            // 
            this.txtDogName.Location = new System.Drawing.Point(135, 52);
            this.txtDogName.Name = "txtDogName";
            this.txtDogName.Size = new System.Drawing.Size(123, 20);
            this.txtDogName.TabIndex = 0;
            // 
            // lblDogName
            // 
            this.lblDogName.AutoSize = true;
            this.lblDogName.Location = new System.Drawing.Point(12, 52);
            this.lblDogName.Name = "lblDogName";
            this.lblDogName.Size = new System.Drawing.Size(61, 13);
            this.lblDogName.TabIndex = 0;
            this.lblDogName.Text = "Dog Name:";
            // 
            // tpCat
            // 
            this.tpCat.Controls.Add(this.btnAddCat);
            this.tpCat.Controls.Add(this.txtCatColor);
            this.tpCat.Controls.Add(this.txtNumCatLegs);
            this.tpCat.Controls.Add(this.txtReasonVisitCat);
            this.tpCat.Controls.Add(this.dtpCatVisit);
            this.tpCat.Controls.Add(this.cbCatType);
            this.tpCat.Controls.Add(this.lblCatColor);
            this.tpCat.Controls.Add(this.lblNumOfLegsCat);
            this.tpCat.Controls.Add(this.lblCatType);
            this.tpCat.Controls.Add(this.lblDateVisitCat);
            this.tpCat.Controls.Add(this.lblVisitReasonCat);
            this.tpCat.Controls.Add(this.txtCatName);
            this.tpCat.Controls.Add(this.lblCatName);
            this.tpCat.Location = new System.Drawing.Point(4, 22);
            this.tpCat.Name = "tpCat";
            this.tpCat.Size = new System.Drawing.Size(433, 270);
            this.tpCat.TabIndex = 2;
            this.tpCat.Text = "Cat";
            this.tpCat.UseVisualStyleBackColor = true;
            // 
            // tpHorse
            // 
            this.tpHorse.Controls.Add(this.btnAddHorse);
            this.tpHorse.Controls.Add(this.txtHorseColor);
            this.tpHorse.Controls.Add(this.txtNumHorseLegs);
            this.tpHorse.Controls.Add(this.txtReasonVisitHorse);
            this.tpHorse.Controls.Add(this.dtpHorseVisit);
            this.tpHorse.Controls.Add(this.cbHorseType);
            this.tpHorse.Controls.Add(this.lblHorseColor);
            this.tpHorse.Controls.Add(this.lblNumHorseLegs);
            this.tpHorse.Controls.Add(this.lblHorseType);
            this.tpHorse.Controls.Add(this.lblDateVisitHorse);
            this.tpHorse.Controls.Add(this.lblReasonVisitHorse);
            this.tpHorse.Controls.Add(this.txtHorseName);
            this.tpHorse.Controls.Add(this.lblHorseName);
            this.tpHorse.Location = new System.Drawing.Point(4, 22);
            this.tpHorse.Name = "tpHorse";
            this.tpHorse.Size = new System.Drawing.Size(433, 270);
            this.tpHorse.TabIndex = 3;
            this.tpHorse.Text = "Horse";
            this.tpHorse.UseVisualStyleBackColor = true;
            // 
            // btnAddCat
            // 
            this.btnAddCat.Location = new System.Drawing.Point(114, 223);
            this.btnAddCat.Name = "btnAddCat";
            this.btnAddCat.Size = new System.Drawing.Size(75, 23);
            this.btnAddCat.TabIndex = 6;
            this.btnAddCat.Text = "Add Cat";
            this.btnAddCat.UseVisualStyleBackColor = true;
            this.btnAddCat.Click += new System.EventHandler(this.btnAddCat_Click);
            // 
            // txtCatColor
            // 
            this.txtCatColor.Location = new System.Drawing.Point(135, 105);
            this.txtCatColor.Name = "txtCatColor";
            this.txtCatColor.Size = new System.Drawing.Size(100, 20);
            this.txtCatColor.TabIndex = 2;
            // 
            // txtNumCatLegs
            // 
            this.txtNumCatLegs.Location = new System.Drawing.Point(135, 131);
            this.txtNumCatLegs.Name = "txtNumCatLegs";
            this.txtNumCatLegs.Size = new System.Drawing.Size(100, 20);
            this.txtNumCatLegs.TabIndex = 3;
            // 
            // txtReasonVisitCat
            // 
            this.txtReasonVisitCat.Location = new System.Drawing.Point(135, 157);
            this.txtReasonVisitCat.Name = "txtReasonVisitCat";
            this.txtReasonVisitCat.Size = new System.Drawing.Size(100, 20);
            this.txtReasonVisitCat.TabIndex = 4;
            // 
            // dtpCatVisit
            // 
            this.dtpCatVisit.Location = new System.Drawing.Point(135, 183);
            this.dtpCatVisit.Name = "dtpCatVisit";
            this.dtpCatVisit.Size = new System.Drawing.Size(200, 20);
            this.dtpCatVisit.TabIndex = 5;
            // 
            // cbCatType
            // 
            this.cbCatType.FormattingEnabled = true;
            this.cbCatType.Location = new System.Drawing.Point(135, 78);
            this.cbCatType.Name = "cbCatType";
            this.cbCatType.Size = new System.Drawing.Size(121, 21);
            this.cbCatType.TabIndex = 1;
            // 
            // lblCatColor
            // 
            this.lblCatColor.AutoSize = true;
            this.lblCatColor.Location = new System.Drawing.Point(12, 108);
            this.lblCatColor.Name = "lblCatColor";
            this.lblCatColor.Size = new System.Drawing.Size(53, 13);
            this.lblCatColor.TabIndex = 19;
            this.lblCatColor.Text = "Cat Color:";
            // 
            // lblNumOfLegsCat
            // 
            this.lblNumOfLegsCat.AutoSize = true;
            this.lblNumOfLegsCat.Location = new System.Drawing.Point(12, 134);
            this.lblNumOfLegsCat.Name = "lblNumOfLegsCat";
            this.lblNumOfLegsCat.Size = new System.Drawing.Size(85, 13);
            this.lblNumOfLegsCat.TabIndex = 17;
            this.lblNumOfLegsCat.Text = "Number of Legs:";
            // 
            // lblCatType
            // 
            this.lblCatType.AutoSize = true;
            this.lblCatType.Location = new System.Drawing.Point(12, 81);
            this.lblCatType.Name = "lblCatType";
            this.lblCatType.Size = new System.Drawing.Size(53, 13);
            this.lblCatType.TabIndex = 15;
            this.lblCatType.Text = "Cat Type:";
            // 
            // lblDateVisitCat
            // 
            this.lblDateVisitCat.AutoSize = true;
            this.lblDateVisitCat.Location = new System.Drawing.Point(12, 190);
            this.lblDateVisitCat.Name = "lblDateVisitCat";
            this.lblDateVisitCat.Size = new System.Drawing.Size(64, 13);
            this.lblDateVisitCat.TabIndex = 13;
            this.lblDateVisitCat.Text = "Date of Visit";
            // 
            // lblVisitReasonCat
            // 
            this.lblVisitReasonCat.AutoSize = true;
            this.lblVisitReasonCat.Location = new System.Drawing.Point(12, 160);
            this.lblVisitReasonCat.Name = "lblVisitReasonCat";
            this.lblVisitReasonCat.Size = new System.Drawing.Size(84, 13);
            this.lblVisitReasonCat.TabIndex = 11;
            this.lblVisitReasonCat.Text = "Reason for Visit:";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(135, 52);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(123, 20);
            this.txtCatName.TabIndex = 0;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(12, 52);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(57, 13);
            this.lblCatName.TabIndex = 8;
            this.lblCatName.Text = "Cat Name:";
            // 
            // btnAddHorse
            // 
            this.btnAddHorse.Location = new System.Drawing.Point(114, 223);
            this.btnAddHorse.Name = "btnAddHorse";
            this.btnAddHorse.Size = new System.Drawing.Size(75, 23);
            this.btnAddHorse.TabIndex = 6;
            this.btnAddHorse.Text = "Add Horse";
            this.btnAddHorse.UseVisualStyleBackColor = true;
            this.btnAddHorse.Click += new System.EventHandler(this.btnAddHorse_Click);
            // 
            // txtHorseColor
            // 
            this.txtHorseColor.Location = new System.Drawing.Point(135, 105);
            this.txtHorseColor.Name = "txtHorseColor";
            this.txtHorseColor.Size = new System.Drawing.Size(100, 20);
            this.txtHorseColor.TabIndex = 2;
            // 
            // txtNumHorseLegs
            // 
            this.txtNumHorseLegs.Location = new System.Drawing.Point(135, 131);
            this.txtNumHorseLegs.Name = "txtNumHorseLegs";
            this.txtNumHorseLegs.Size = new System.Drawing.Size(100, 20);
            this.txtNumHorseLegs.TabIndex = 3;
            // 
            // txtReasonVisitHorse
            // 
            this.txtReasonVisitHorse.Location = new System.Drawing.Point(135, 157);
            this.txtReasonVisitHorse.Name = "txtReasonVisitHorse";
            this.txtReasonVisitHorse.Size = new System.Drawing.Size(100, 20);
            this.txtReasonVisitHorse.TabIndex = 4;
            // 
            // dtpHorseVisit
            // 
            this.dtpHorseVisit.Location = new System.Drawing.Point(135, 183);
            this.dtpHorseVisit.Name = "dtpHorseVisit";
            this.dtpHorseVisit.Size = new System.Drawing.Size(200, 20);
            this.dtpHorseVisit.TabIndex = 5;
            // 
            // cbHorseType
            // 
            this.cbHorseType.FormattingEnabled = true;
            this.cbHorseType.Location = new System.Drawing.Point(135, 78);
            this.cbHorseType.Name = "cbHorseType";
            this.cbHorseType.Size = new System.Drawing.Size(121, 21);
            this.cbHorseType.TabIndex = 1;
            // 
            // lblHorseColor
            // 
            this.lblHorseColor.AutoSize = true;
            this.lblHorseColor.Location = new System.Drawing.Point(12, 108);
            this.lblHorseColor.Name = "lblHorseColor";
            this.lblHorseColor.Size = new System.Drawing.Size(65, 13);
            this.lblHorseColor.TabIndex = 32;
            this.lblHorseColor.Text = "Horse Color:";
            // 
            // lblNumHorseLegs
            // 
            this.lblNumHorseLegs.AutoSize = true;
            this.lblNumHorseLegs.Location = new System.Drawing.Point(12, 134);
            this.lblNumHorseLegs.Name = "lblNumHorseLegs";
            this.lblNumHorseLegs.Size = new System.Drawing.Size(85, 13);
            this.lblNumHorseLegs.TabIndex = 30;
            this.lblNumHorseLegs.Text = "Number of Legs:";
            // 
            // lblHorseType
            // 
            this.lblHorseType.AutoSize = true;
            this.lblHorseType.Location = new System.Drawing.Point(12, 81);
            this.lblHorseType.Name = "lblHorseType";
            this.lblHorseType.Size = new System.Drawing.Size(65, 13);
            this.lblHorseType.TabIndex = 28;
            this.lblHorseType.Text = "Horse Type:";
            // 
            // lblDateVisitHorse
            // 
            this.lblDateVisitHorse.AutoSize = true;
            this.lblDateVisitHorse.Location = new System.Drawing.Point(12, 190);
            this.lblDateVisitHorse.Name = "lblDateVisitHorse";
            this.lblDateVisitHorse.Size = new System.Drawing.Size(64, 13);
            this.lblDateVisitHorse.TabIndex = 26;
            this.lblDateVisitHorse.Text = "Date of Visit";
            // 
            // lblReasonVisitHorse
            // 
            this.lblReasonVisitHorse.AutoSize = true;
            this.lblReasonVisitHorse.Location = new System.Drawing.Point(12, 160);
            this.lblReasonVisitHorse.Name = "lblReasonVisitHorse";
            this.lblReasonVisitHorse.Size = new System.Drawing.Size(84, 13);
            this.lblReasonVisitHorse.TabIndex = 24;
            this.lblReasonVisitHorse.Text = "Reason for Visit:";
            // 
            // txtHorseName
            // 
            this.txtHorseName.Location = new System.Drawing.Point(135, 52);
            this.txtHorseName.Name = "txtHorseName";
            this.txtHorseName.Size = new System.Drawing.Size(123, 20);
            this.txtHorseName.TabIndex = 0;
            // 
            // lblHorseName
            // 
            this.lblHorseName.AutoSize = true;
            this.lblHorseName.Location = new System.Drawing.Point(12, 52);
            this.lblHorseName.Name = "lblHorseName";
            this.lblHorseName.Size = new System.Drawing.Size(69, 13);
            this.lblHorseName.TabIndex = 21;
            this.lblHorseName.Text = "Horse Name:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 296);
            this.Controls.Add(this.tcAnimal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Animal Hospital";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tcAnimal.ResumeLayout(false);
            this.tpWelcome.ResumeLayout(false);
            this.tpWelcome.PerformLayout();
            this.tpDog.ResumeLayout(false);
            this.tpDog.PerformLayout();
            this.tpCat.ResumeLayout(false);
            this.tpCat.PerformLayout();
            this.tpHorse.ResumeLayout(false);
            this.tpHorse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAnimal;
        private System.Windows.Forms.TabPage tpWelcome;
        private System.Windows.Forms.TabPage tpDog;
        private System.Windows.Forms.TextBox txtDogName;
        private System.Windows.Forms.Label lblDogName;
        private System.Windows.Forms.Label lblPatients;
        private System.Windows.Forms.RichTextBox rtxtPatients;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Label lblDogColor;
        private System.Windows.Forms.Label lblNumOfLegs;
        private System.Windows.Forms.Label lblDogType;
        private System.Windows.Forms.Label lblDateVisit;
        private System.Windows.Forms.Label lblVisitReason;
        private System.Windows.Forms.TextBox txtDogColor;
        private System.Windows.Forms.TextBox txtDogNumLegs;
        private System.Windows.Forms.TextBox txtDogVisitReason;
        private System.Windows.Forms.DateTimePicker dtpDogVisit;
        private System.Windows.Forms.ComboBox cbDogType;
        private System.Windows.Forms.TabPage tpCat;
        private System.Windows.Forms.TabPage tpHorse;
        private System.Windows.Forms.Button btnAddDog;
        private System.Windows.Forms.Button btnAddCat;
        private System.Windows.Forms.TextBox txtCatColor;
        private System.Windows.Forms.TextBox txtNumCatLegs;
        private System.Windows.Forms.TextBox txtReasonVisitCat;
        private System.Windows.Forms.DateTimePicker dtpCatVisit;
        private System.Windows.Forms.ComboBox cbCatType;
        private System.Windows.Forms.Label lblCatColor;
        private System.Windows.Forms.Label lblNumOfLegsCat;
        private System.Windows.Forms.Label lblCatType;
        private System.Windows.Forms.Label lblDateVisitCat;
        private System.Windows.Forms.Label lblVisitReasonCat;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.Button btnAddHorse;
        private System.Windows.Forms.TextBox txtHorseColor;
        private System.Windows.Forms.TextBox txtNumHorseLegs;
        private System.Windows.Forms.TextBox txtReasonVisitHorse;
        private System.Windows.Forms.DateTimePicker dtpHorseVisit;
        private System.Windows.Forms.ComboBox cbHorseType;
        private System.Windows.Forms.Label lblHorseColor;
        private System.Windows.Forms.Label lblNumHorseLegs;
        private System.Windows.Forms.Label lblHorseType;
        private System.Windows.Forms.Label lblDateVisitHorse;
        private System.Windows.Forms.Label lblReasonVisitHorse;
        private System.Windows.Forms.TextBox txtHorseName;
        private System.Windows.Forms.Label lblHorseName;
    }
}

