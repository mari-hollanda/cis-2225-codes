
namespace CIS2225_Assignment4_HollandaCP_Marianna
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblSpecie = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblHobby = new System.Windows.Forms.Label();
            this.lblPersonality = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msView = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msExit = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbPersonality = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSpecie = new System.Windows.Forms.TextBox();
            this.txtHobby = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(305, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Villager Registration";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblSpecie
            // 
            this.lblSpecie.AutoSize = true;
            this.lblSpecie.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpecie.Location = new System.Drawing.Point(35, 117);
            this.lblSpecie.Name = "lblSpecie";
            this.lblSpecie.Size = new System.Drawing.Size(63, 17);
            this.lblSpecie.TabIndex = 2;
            this.lblSpecie.Text = "Specie:";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirthday.Location = new System.Drawing.Point(35, 176);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(75, 17);
            this.lblBirthday.TabIndex = 3;
            this.lblBirthday.Text = "Birthday:";
            // 
            // lblHobby
            // 
            this.lblHobby.AutoSize = true;
            this.lblHobby.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHobby.Location = new System.Drawing.Point(35, 205);
            this.lblHobby.Name = "lblHobby";
            this.lblHobby.Size = new System.Drawing.Size(59, 17);
            this.lblHobby.TabIndex = 4;
            this.lblHobby.Text = "Hobby:";
            // 
            // lblPersonality
            // 
            this.lblPersonality.AutoSize = true;
            this.lblPersonality.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonality.Location = new System.Drawing.Point(35, 146);
            this.lblPersonality.Name = "lblPersonality";
            this.lblPersonality.Size = new System.Drawing.Size(95, 17);
            this.lblPersonality.TabIndex = 5;
            this.lblPersonality.Text = "Personality:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(94, 244);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(90, 25);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(555, 24);
            this.msMain.TabIndex = 7;
            this.msMain.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msView,
            this.msEdit,
            this.msExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "File";
            // 
            // msView
            // 
            this.msView.Name = "msView";
            this.msView.Size = new System.Drawing.Size(99, 22);
            this.msView.Text = "View";
            this.msView.Click += new System.EventHandler(this.msView_Click);
            // 
            // msEdit
            // 
            this.msEdit.Name = "msEdit";
            this.msEdit.Size = new System.Drawing.Size(99, 22);
            this.msEdit.Text = "Edit";
            this.msEdit.Click += new System.EventHandler(this.msEdit_Click);
            // 
            // msExit
            // 
            this.msExit.Name = "msExit";
            this.msExit.Size = new System.Drawing.Size(99, 22);
            this.msExit.Text = "Exit";
            this.msExit.Click += new System.EventHandler(this.msExit_Click);
            // 
            // cmbPersonality
            // 
            this.cmbPersonality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonality.FormattingEnabled = true;
            this.cmbPersonality.Location = new System.Drawing.Point(142, 146);
            this.cmbPersonality.Name = "cmbPersonality";
            this.cmbPersonality.Size = new System.Drawing.Size(121, 21);
            this.cmbPersonality.TabIndex = 2;
            this.cmbPersonality.SelectedIndexChanged += new System.EventHandler(this.cmbPersonality_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtSpecie
            // 
            this.txtSpecie.Location = new System.Drawing.Point(142, 117);
            this.txtSpecie.Name = "txtSpecie";
            this.txtSpecie.Size = new System.Drawing.Size(121, 20);
            this.txtSpecie.TabIndex = 1;
            this.txtSpecie.TextChanged += new System.EventHandler(this.txtSpecie_TextChanged);
            // 
            // txtHobby
            // 
            this.txtHobby.Location = new System.Drawing.Point(142, 205);
            this.txtHobby.Name = "txtHobby";
            this.txtHobby.Size = new System.Drawing.Size(121, 20);
            this.txtHobby.TabIndex = 4;
            this.txtHobby.TextChanged += new System.EventHandler(this.txtHobby_TextChanged);
            // 
            // txtBirthday
            // 
            this.txtBirthday.Location = new System.Drawing.Point(142, 176);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(121, 20);
            this.txtBirthday.TabIndex = 3;
            this.txtBirthday.TextChanged += new System.EventHandler(this.txtBirthday_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(245)))), ((int)(((byte)(230)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(555, 343);
            this.Controls.Add(this.txtBirthday);
            this.Controls.Add(this.txtHobby);
            this.Controls.Add(this.txtSpecie);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cmbPersonality);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblPersonality);
            this.Controls.Add(this.lblHobby);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblSpecie);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.msMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Villager Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblSpecie;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblHobby;
        private System.Windows.Forms.Label lblPersonality;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msView;
        private System.Windows.Forms.ToolStripMenuItem msEdit;
        private System.Windows.Forms.ToolStripMenuItem msExit;
        private System.Windows.Forms.ComboBox cmbPersonality;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSpecie;
        private System.Windows.Forms.TextBox txtHobby;
        private System.Windows.Forms.TextBox txtBirthday;
    }
}

