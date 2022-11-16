
namespace CIS2225_Assignment3_HollandaCP_Marianna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpHome = new System.Windows.Forms.TabPage();
            this.tpPizza = new System.Windows.Forms.TabPage();
            this.pboxPizza1 = new System.Windows.Forms.PictureBox();
            this.pboxPizza2 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cblIngredients = new System.Windows.Forms.CheckedListBox();
            this.cmbSauces = new System.Windows.Forms.ComboBox();
            this.cmbSizes = new System.Windows.Forms.ComboBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.lblSauce = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.tpSummary = new System.Windows.Forms.TabPage();
            this.lblSummary = new System.Windows.Forms.Label();
            this.richtxtSummary = new System.Windows.Forms.RichTextBox();
            this.pboxPizza3 = new System.Windows.Forms.PictureBox();
            this.pboxPizza4 = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.tcMain.SuspendLayout();
            this.tpPizza.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza2)).BeginInit();
            this.tpSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza4)).BeginInit();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpHome);
            this.tcMain.Controls.Add(this.tpPizza);
            this.tcMain.Controls.Add(this.tpSummary);
            this.tcMain.Location = new System.Drawing.Point(0, -1);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(466, 392);
            this.tcMain.TabIndex = 0;
            // 
            // tpHome
            // 
            this.tpHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tpHome.BackgroundImage")));
            this.tpHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tpHome.Location = new System.Drawing.Point(4, 22);
            this.tpHome.Name = "tpHome";
            this.tpHome.Padding = new System.Windows.Forms.Padding(3);
            this.tpHome.Size = new System.Drawing.Size(458, 366);
            this.tpHome.TabIndex = 0;
            this.tpHome.Text = "Home";
            this.tpHome.UseVisualStyleBackColor = true;
            // 
            // tpPizza
            // 
            this.tpPizza.BackColor = System.Drawing.Color.LightCyan;
            this.tpPizza.Controls.Add(this.pboxPizza1);
            this.tpPizza.Controls.Add(this.pboxPizza2);
            this.tpPizza.Controls.Add(this.btnAdd);
            this.tpPizza.Controls.Add(this.cblIngredients);
            this.tpPizza.Controls.Add(this.cmbSauces);
            this.tpPizza.Controls.Add(this.cmbSizes);
            this.tpPizza.Controls.Add(this.lblIngredients);
            this.tpPizza.Controls.Add(this.lblSauce);
            this.tpPizza.Controls.Add(this.lblSize);
            this.tpPizza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpPizza.Location = new System.Drawing.Point(4, 22);
            this.tpPizza.Name = "tpPizza";
            this.tpPizza.Padding = new System.Windows.Forms.Padding(3);
            this.tpPizza.Size = new System.Drawing.Size(458, 366);
            this.tpPizza.TabIndex = 1;
            this.tpPizza.Text = "Pizza";
            // 
            // pboxPizza1
            // 
            this.pboxPizza1.Image = ((System.Drawing.Image)(resources.GetObject("pboxPizza1.Image")));
            this.pboxPizza1.Location = new System.Drawing.Point(8, 243);
            this.pboxPizza1.Name = "pboxPizza1";
            this.pboxPizza1.Size = new System.Drawing.Size(131, 112);
            this.pboxPizza1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPizza1.TabIndex = 5;
            this.pboxPizza1.TabStop = false;
            // 
            // pboxPizza2
            // 
            this.pboxPizza2.Image = ((System.Drawing.Image)(resources.GetObject("pboxPizza2.Image")));
            this.pboxPizza2.Location = new System.Drawing.Point(318, 0);
            this.pboxPizza2.Name = "pboxPizza2";
            this.pboxPizza2.Size = new System.Drawing.Size(140, 123);
            this.pboxPizza2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPizza2.TabIndex = 4;
            this.pboxPizza2.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(165, 302);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(143, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add to Order";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cblIngredients
            // 
            this.cblIngredients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cblIngredients.FormattingEnabled = true;
            this.cblIngredients.Items.AddRange(new object[] {
            "Pepperoni",
            "Mushroom",
            "Sausage",
            "Onion",
            "Tomato",
            "Black Olives",
            "Garlic",
            "Green Pepper"});
            this.cblIngredients.Location = new System.Drawing.Point(176, 134);
            this.cblIngredients.Name = "cblIngredients";
            this.cblIngredients.Size = new System.Drawing.Size(121, 124);
            this.cblIngredients.TabIndex = 2;
            // 
            // cmbSauces
            // 
            this.cmbSauces.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSauces.FormattingEnabled = true;
            this.cmbSauces.Items.AddRange(new object[] {
            "Regular",
            "Spicy"});
            this.cmbSauces.Location = new System.Drawing.Point(176, 77);
            this.cmbSauces.Name = "cmbSauces";
            this.cmbSauces.Size = new System.Drawing.Size(94, 21);
            this.cmbSauces.TabIndex = 1;
            // 
            // cmbSizes
            // 
            this.cmbSizes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizes.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSizes.FormattingEnabled = true;
            this.cmbSizes.Items.AddRange(new object[] {
            "10\"",
            "12\"",
            "14\""});
            this.cmbSizes.Location = new System.Drawing.Point(176, 30);
            this.cmbSizes.Name = "cmbSizes";
            this.cmbSizes.Size = new System.Drawing.Size(94, 20);
            this.cmbSizes.TabIndex = 0;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredients.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblIngredients.Location = new System.Drawing.Point(72, 134);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(96, 17);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Ingredients:";
            // 
            // lblSauce
            // 
            this.lblSauce.AutoSize = true;
            this.lblSauce.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSauce.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSauce.Location = new System.Drawing.Point(72, 77);
            this.lblSauce.Name = "lblSauce";
            this.lblSauce.Size = new System.Drawing.Size(67, 17);
            this.lblSauce.TabIndex = 1;
            this.lblSauce.Text = "Sauces:";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSize.Location = new System.Drawing.Point(72, 29);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 17);
            this.lblSize.TabIndex = 0;
            this.lblSize.Text = "Sizes:";
            // 
            // tpSummary
            // 
            this.tpSummary.BackColor = System.Drawing.Color.MistyRose;
            this.tpSummary.Controls.Add(this.lblSummary);
            this.tpSummary.Controls.Add(this.richtxtSummary);
            this.tpSummary.Controls.Add(this.pboxPizza3);
            this.tpSummary.Controls.Add(this.pboxPizza4);
            this.tpSummary.Controls.Add(this.btnClear);
            this.tpSummary.Location = new System.Drawing.Point(4, 22);
            this.tpSummary.Name = "tpSummary";
            this.tpSummary.Size = new System.Drawing.Size(458, 366);
            this.tpSummary.TabIndex = 2;
            this.tpSummary.Text = "Summary";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSummary.Location = new System.Drawing.Point(194, 10);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(84, 17);
            this.lblSummary.TabIndex = 5;
            this.lblSummary.Text = "SUMMARY";
            // 
            // richtxtSummary
            // 
            this.richtxtSummary.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtSummary.Location = new System.Drawing.Point(107, 34);
            this.richtxtSummary.Name = "richtxtSummary";
            this.richtxtSummary.Size = new System.Drawing.Size(258, 284);
            this.richtxtSummary.TabIndex = 4;
            this.richtxtSummary.Text = "You have no pizzas ordered! =)";
            // 
            // pboxPizza3
            // 
            this.pboxPizza3.Image = ((System.Drawing.Image)(resources.GetObject("pboxPizza3.Image")));
            this.pboxPizza3.Location = new System.Drawing.Point(3, 271);
            this.pboxPizza3.Name = "pboxPizza3";
            this.pboxPizza3.Size = new System.Drawing.Size(116, 95);
            this.pboxPizza3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPizza3.TabIndex = 3;
            this.pboxPizza3.TabStop = false;
            // 
            // pboxPizza4
            // 
            this.pboxPizza4.Image = ((System.Drawing.Image)(resources.GetObject("pboxPizza4.Image")));
            this.pboxPizza4.Location = new System.Drawing.Point(368, 3);
            this.pboxPizza4.Name = "pboxPizza4";
            this.pboxPizza4.Size = new System.Drawing.Size(87, 83);
            this.pboxPizza4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboxPizza4.TabIndex = 2;
            this.pboxPizza4.TabStop = false;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(171, 324);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 31);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Order";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 388);
            this.Controls.Add(this.tcMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Marianna Hollanda\'s Pizzaria";
            this.tcMain.ResumeLayout(false);
            this.tpPizza.ResumeLayout(false);
            this.tpPizza.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza2)).EndInit();
            this.tpSummary.ResumeLayout(false);
            this.tpSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPizza4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpHome;
        private System.Windows.Forms.TabPage tpPizza;
        private System.Windows.Forms.TabPage tpSummary;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblSauce;
        private System.Windows.Forms.ComboBox cmbSauces;
        private System.Windows.Forms.ComboBox cmbSizes;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckedListBox cblIngredients;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pboxPizza1;
        private System.Windows.Forms.PictureBox pboxPizza2;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.RichTextBox richtxtSummary;
        private System.Windows.Forms.PictureBox pboxPizza3;
        private System.Windows.Forms.PictureBox pboxPizza4;
    }
}

