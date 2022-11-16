
namespace CIS2225_Assignment6
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
            this.dtpLastVisitDate = new System.Windows.Forms.DateTimePicker();
            this.cbGuestSelector = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.lblGuestId = new System.Windows.Forms.Label();
            this.lblGuestSelector = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblRoom = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastVisitDate = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpLastVisitDate
            // 
            this.dtpLastVisitDate.CustomFormat = "MMMM dd, yyyy";
            this.dtpLastVisitDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLastVisitDate.Location = new System.Drawing.Point(309, 127);
            this.dtpLastVisitDate.Name = "dtpLastVisitDate";
            this.dtpLastVisitDate.Size = new System.Drawing.Size(130, 20);
            this.dtpLastVisitDate.TabIndex = 73;
            // 
            // cbGuestSelector
            // 
            this.cbGuestSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuestSelector.FormattingEnabled = true;
            this.cbGuestSelector.Location = new System.Drawing.Point(192, 12);
            this.cbGuestSelector.Name = "cbGuestSelector";
            this.cbGuestSelector.Size = new System.Drawing.Size(121, 21);
            this.cbGuestSelector.TabIndex = 72;
            this.cbGuestSelector.SelectedIndexChanged += new System.EventHandler(this.cbGuestSelector_SelectedIndexChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(295, 227);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(201, 227);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(108, 227);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 69;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtGuestId
            // 
            this.txtGuestId.Location = new System.Drawing.Point(227, 190);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(69, 20);
            this.txtGuestId.TabIndex = 68;
            // 
            // lblGuestId
            // 
            this.lblGuestId.AutoSize = true;
            this.lblGuestId.Location = new System.Drawing.Point(171, 193);
            this.lblGuestId.Name = "lblGuestId";
            this.lblGuestId.Size = new System.Drawing.Size(50, 13);
            this.lblGuestId.TabIndex = 67;
            this.lblGuestId.Text = "Guest Id:";
            // 
            // lblGuestSelector
            // 
            this.lblGuestSelector.AutoSize = true;
            this.lblGuestSelector.Location = new System.Drawing.Point(115, 15);
            this.lblGuestSelector.Name = "lblGuestSelector";
            this.lblGuestSelector.Size = new System.Drawing.Size(71, 13);
            this.lblGuestSelector.TabIndex = 66;
            this.lblGuestSelector.Text = "Select Guest:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(17, 130);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 65;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(17, 156);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 64;
            this.lblState.Text = "State:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(17, 104);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 63;
            this.lblStreet.Text = "Street:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(225, 52);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(25, 13);
            this.lblZip.TabIndex = 62;
            this.lblZip.Text = "Zip:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 52);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 61;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 78);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 60;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblRoom
            // 
            this.lblRoom.AutoSize = true;
            this.lblRoom.Location = new System.Drawing.Point(225, 156);
            this.lblRoom.Name = "lblRoom";
            this.lblRoom.Size = new System.Drawing.Size(38, 13);
            this.lblRoom.TabIndex = 59;
            this.lblRoom.Text = "Room:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(225, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 58;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastVisitDate
            // 
            this.lblLastVisitDate.AutoSize = true;
            this.lblLastVisitDate.Location = new System.Drawing.Point(225, 130);
            this.lblLastVisitDate.Name = "lblLastVisitDate";
            this.lblLastVisitDate.Size = new System.Drawing.Size(78, 13);
            this.lblLastVisitDate.TabIndex = 57;
            this.lblLastVisitDate.Text = "Last Visit Date:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(225, 78);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 56;
            this.lblPhone.Text = "Phone:";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(309, 153);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(130, 20);
            this.txtRoom.TabIndex = 55;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(309, 49);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(130, 20);
            this.txtZip.TabIndex = 52;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(83, 127);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 20);
            this.txtCity.TabIndex = 50;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(83, 101);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(100, 20);
            this.txtStreet.TabIndex = 49;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(83, 75);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 48;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(309, 75);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(130, 20);
            this.txtPhone.TabIndex = 53;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(84, 49);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 47;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(309, 101);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 20);
            this.txtEmail.TabIndex = 54;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(83, 153);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 20);
            this.txtState.TabIndex = 51;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 273);
            this.Controls.Add(this.dtpLastVisitDate);
            this.Controls.Add(this.cbGuestSelector);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGuestId);
            this.Controls.Add(this.lblGuestId);
            this.Controls.Add(this.lblGuestSelector);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblZip);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblRoom);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastVisitDate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtState);
            this.Name = "frmMain";
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpLastVisitDate;
        private System.Windows.Forms.ComboBox cbGuestSelector;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.Label lblGuestId;
        private System.Windows.Forms.Label lblGuestSelector;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblRoom;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastVisitDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtState;
    }
}

