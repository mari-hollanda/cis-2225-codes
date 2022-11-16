
namespace CIS2225_Assignment2
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
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtTotalSales = new System.Windows.Forms.TextBox();
            this.txtItemsSold = new System.Windows.Forms.TextBox();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lstSales = new System.Windows.Forms.ListBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblItem = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblSales = new System.Windows.Forms.Label();
            this.lblItemsSold = new System.Windows.Forms.Label();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.lblTotalCommission = new System.Windows.Forms.Label();
            this.txtTotalCommission = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "Home Theatre",
            "Computers",
            "Video Games",
            "Appliances",
            "Car Audio"});
            this.cmbCategory.Location = new System.Drawing.Point(89, 100);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(160, 21);
            this.cmbCategory.TabIndex = 2;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(367, 327);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 48);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(612, 100);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(114, 20);
            this.txtPrice.TabIndex = 4;
            // 
            // txtTotalSales
            // 
            this.txtTotalSales.Location = new System.Drawing.Point(148, 368);
            this.txtTotalSales.Name = "txtTotalSales";
            this.txtTotalSales.ReadOnly = true;
            this.txtTotalSales.Size = new System.Drawing.Size(100, 20);
            this.txtTotalSales.TabIndex = 3;
            this.txtTotalSales.TabStop = false;
            // 
            // txtItemsSold
            // 
            this.txtItemsSold.Location = new System.Drawing.Point(148, 336);
            this.txtItemsSold.Name = "txtItemsSold";
            this.txtItemsSold.ReadOnly = true;
            this.txtItemsSold.Size = new System.Drawing.Size(62, 20);
            this.txtItemsSold.TabIndex = 4;
            this.txtItemsSold.TabStop = false;
            // 
            // cmbItems
            // 
            this.cmbItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Location = new System.Drawing.Point(367, 101);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(160, 21);
            this.cmbItems.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(504, 327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 48);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Salesperson";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(367, 36);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(167, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(89, 36);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(160, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lstSales
            // 
            this.lstSales.FormattingEnabled = true;
            this.lstSales.Location = new System.Drawing.Point(89, 177);
            this.lstSales.Name = "lstSales";
            this.lstSales.Size = new System.Drawing.Size(637, 108);
            this.lstSales.TabIndex = 9;
            this.lstSales.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(1, 36);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 10;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(277, 39);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 11;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(1, 100);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 12;
            this.lblCategory.Text = "Category:";
            // 
            // lblItem
            // 
            this.lblItem.AutoSize = true;
            this.lblItem.Location = new System.Drawing.Point(277, 103);
            this.lblItem.Name = "lblItem";
            this.lblItem.Size = new System.Drawing.Size(30, 13);
            this.lblItem.TabIndex = 13;
            this.lblItem.Text = "Item:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(559, 100);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 14;
            this.lblPrice.Text = "Price:";
            // 
            // lblSales
            // 
            this.lblSales.AutoSize = true;
            this.lblSales.Location = new System.Drawing.Point(75, 142);
            this.lblSales.Name = "lblSales";
            this.lblSales.Size = new System.Drawing.Size(36, 13);
            this.lblSales.TabIndex = 15;
            this.lblSales.Text = "Sales:";
            // 
            // lblItemsSold
            // 
            this.lblItemsSold.AutoSize = true;
            this.lblItemsSold.Location = new System.Drawing.Point(16, 340);
            this.lblItemsSold.Name = "lblItemsSold";
            this.lblItemsSold.Size = new System.Drawing.Size(59, 13);
            this.lblItemsSold.TabIndex = 16;
            this.lblItemsSold.Text = "Items Sold:";
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.AutoSize = true;
            this.lblTotalSales.Location = new System.Drawing.Point(16, 372);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(63, 13);
            this.lblTotalSales.TabIndex = 17;
            this.lblTotalSales.Text = "Total Sales:";
            // 
            // lblTotalCommission
            // 
            this.lblTotalCommission.AutoSize = true;
            this.lblTotalCommission.Location = new System.Drawing.Point(16, 404);
            this.lblTotalCommission.Name = "lblTotalCommission";
            this.lblTotalCommission.Size = new System.Drawing.Size(92, 13);
            this.lblTotalCommission.TabIndex = 18;
            this.lblTotalCommission.Text = "Total Commission:";
            // 
            // txtTotalCommission
            // 
            this.txtTotalCommission.Location = new System.Drawing.Point(148, 400);
            this.txtTotalCommission.Name = "txtTotalCommission";
            this.txtTotalCommission.ReadOnly = true;
            this.txtTotalCommission.Size = new System.Drawing.Size(100, 20);
            this.txtTotalCommission.TabIndex = 19;
            this.txtTotalCommission.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 466);
            this.Controls.Add(this.txtTotalCommission);
            this.Controls.Add(this.lblTotalCommission);
            this.Controls.Add(this.lblTotalSales);
            this.Controls.Add(this.lblItemsSold);
            this.Controls.Add(this.lblSales);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblItem);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lstSales);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.txtItemsSold);
            this.Controls.Add(this.txtTotalSales);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.cmbCategory);
            this.Name = "frmMain";
            this.Text = "Electronic Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtTotalSales;
        private System.Windows.Forms.TextBox txtItemsSold;
        private System.Windows.Forms.ComboBox cmbItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.ListBox lstSales;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblItem;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblSales;
        private System.Windows.Forms.Label lblItemsSold;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label lblTotalCommission;
        private System.Windows.Forms.TextBox txtTotalCommission;
    }
}

