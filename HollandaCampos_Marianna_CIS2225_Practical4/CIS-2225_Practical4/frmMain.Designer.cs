
namespace CIS_2225_Practical4
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblRetailPrice = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cbProductID = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtRetailPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMarkUp = new System.Windows.Forms.Label();
            this.txtMarkUp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(99, 31);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(73, 16);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(99, 76);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(79, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description:";
            // 
            // lblRetailPrice
            // 
            this.lblRetailPrice.AutoSize = true;
            this.lblRetailPrice.Location = new System.Drawing.Point(99, 104);
            this.lblRetailPrice.Name = "lblRetailPrice";
            this.lblRetailPrice.Size = new System.Drawing.Size(80, 16);
            this.lblRetailPrice.TabIndex = 2;
            this.lblRetailPrice.Text = "Retail Price:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(99, 132);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(59, 16);
            this.lblQuantity.TabIndex = 3;
            this.lblQuantity.Text = "Quantity:";
            // 
            // cbProductID
            // 
            this.cbProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductID.FormattingEnabled = true;
            this.cbProductID.Location = new System.Drawing.Point(190, 28);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(121, 24);
            this.cbProductID.TabIndex = 0;
            this.cbProductID.SelectedIndexChanged += new System.EventHandler(this.cbProductID_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(202, 73);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 22);
            this.txtDescription.TabIndex = 1;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Location = new System.Drawing.Point(202, 101);
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(100, 22);
            this.txtRetailPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(202, 129);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 3;
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(19, 208);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(113, 23);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(138, 208);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(257, 208);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(113, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMarkUp
            // 
            this.lblMarkUp.AutoSize = true;
            this.lblMarkUp.Location = new System.Drawing.Point(99, 160);
            this.lblMarkUp.Name = "lblMarkUp";
            this.lblMarkUp.Size = new System.Drawing.Size(62, 16);
            this.lblMarkUp.TabIndex = 11;
            this.lblMarkUp.Text = "Mark Up:";
            // 
            // txtMarkUp
            // 
            this.txtMarkUp.Location = new System.Drawing.Point(202, 157);
            this.txtMarkUp.Name = "txtMarkUp";
            this.txtMarkUp.Size = new System.Drawing.Size(100, 22);
            this.txtMarkUp.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 259);
            this.Controls.Add(this.txtMarkUp);
            this.Controls.Add(this.lblMarkUp);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtRetailPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cbProductID);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblRetailPrice);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblProductID);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblRetailPrice;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cbProductID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtRetailPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMarkUp;
        private System.Windows.Forms.TextBox txtMarkUp;
    }
}

