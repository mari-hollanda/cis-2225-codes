
namespace HollandaCP_Marianna_CIS2225_Practical3
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
            this.txtCommissionEarned = new System.Windows.Forms.TextBox();
            this.txtCommissionRate = new System.Windows.Forms.TextBox();
            this.txtBonusReduction = new System.Windows.Forms.TextBox();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBonusReduction = new System.Windows.Forms.Label();
            this.lblCommissionRate = new System.Windows.Forms.Label();
            this.lblCommissionEarned = new System.Windows.Forms.Label();
            this.lblSalesAmount = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.grpAgentType = new System.Windows.Forms.GroupBox();
            this.rdoJuniorAgent = new System.Windows.Forms.RadioButton();
            this.rdoSeniorAgent = new System.Windows.Forms.RadioButton();
            this.rdoAgent = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grpAgentType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCommissionEarned
            // 
            this.txtCommissionEarned.Location = new System.Drawing.Point(471, 217);
            this.txtCommissionEarned.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommissionEarned.Name = "txtCommissionEarned";
            this.txtCommissionEarned.ReadOnly = true;
            this.txtCommissionEarned.Size = new System.Drawing.Size(132, 22);
            this.txtCommissionEarned.TabIndex = 10;
            // 
            // txtCommissionRate
            // 
            this.txtCommissionRate.Location = new System.Drawing.Point(471, 249);
            this.txtCommissionRate.Margin = new System.Windows.Forms.Padding(4);
            this.txtCommissionRate.Name = "txtCommissionRate";
            this.txtCommissionRate.ReadOnly = true;
            this.txtCommissionRate.Size = new System.Drawing.Size(132, 22);
            this.txtCommissionRate.TabIndex = 11;
            // 
            // txtBonusReduction
            // 
            this.txtBonusReduction.Location = new System.Drawing.Point(471, 281);
            this.txtBonusReduction.Margin = new System.Windows.Forms.Padding(4);
            this.txtBonusReduction.Name = "txtBonusReduction";
            this.txtBonusReduction.ReadOnly = true;
            this.txtBonusReduction.Size = new System.Drawing.Size(132, 22);
            this.txtBonusReduction.TabIndex = 12;
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Location = new System.Drawing.Point(133, 120);
            this.txtSalesAmount.Margin = new System.Windows.Forms.Padding(4);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(132, 22);
            this.txtSalesAmount.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 88);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(133, 56);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(133, 24);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(132, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblBonusReduction
            // 
            this.lblBonusReduction.AutoSize = true;
            this.lblBonusReduction.Location = new System.Drawing.Point(327, 284);
            this.lblBonusReduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBonusReduction.Name = "lblBonusReduction";
            this.lblBonusReduction.Size = new System.Drawing.Size(114, 16);
            this.lblBonusReduction.TabIndex = 33;
            this.lblBonusReduction.Text = "Bonus/Reduction:";
            // 
            // lblCommissionRate
            // 
            this.lblCommissionRate.AutoSize = true;
            this.lblCommissionRate.Location = new System.Drawing.Point(327, 252);
            this.lblCommissionRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommissionRate.Name = "lblCommissionRate";
            this.lblCommissionRate.Size = new System.Drawing.Size(117, 16);
            this.lblCommissionRate.TabIndex = 32;
            this.lblCommissionRate.Text = "Commission Rate:";
            // 
            // lblCommissionEarned
            // 
            this.lblCommissionEarned.AutoSize = true;
            this.lblCommissionEarned.Location = new System.Drawing.Point(327, 220);
            this.lblCommissionEarned.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommissionEarned.Name = "lblCommissionEarned";
            this.lblCommissionEarned.Size = new System.Drawing.Size(132, 16);
            this.lblCommissionEarned.TabIndex = 31;
            this.lblCommissionEarned.Text = "Commission Earned:";
            // 
            // lblSalesAmount
            // 
            this.lblSalesAmount.AutoSize = true;
            this.lblSalesAmount.Location = new System.Drawing.Point(29, 123);
            this.lblSalesAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSalesAmount.Name = "lblSalesAmount";
            this.lblSalesAmount.Size = new System.Drawing.Size(94, 16);
            this.lblSalesAmount.TabIndex = 30;
            this.lblSalesAmount.Text = "Sales Amount:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 91);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "Email:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(29, 59);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(76, 16);
            this.lblLastName.TabIndex = 27;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(29, 27);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(76, 16);
            this.lblFirstName.TabIndex = 25;
            this.lblFirstName.Text = "First Name:";
            // 
            // grpAgentType
            // 
            this.grpAgentType.Controls.Add(this.rdoJuniorAgent);
            this.grpAgentType.Controls.Add(this.rdoSeniorAgent);
            this.grpAgentType.Controls.Add(this.rdoAgent);
            this.grpAgentType.Location = new System.Drawing.Point(331, 24);
            this.grpAgentType.Margin = new System.Windows.Forms.Padding(4);
            this.grpAgentType.Name = "grpAgentType";
            this.grpAgentType.Padding = new System.Windows.Forms.Padding(4);
            this.grpAgentType.Size = new System.Drawing.Size(247, 123);
            this.grpAgentType.TabIndex = 4;
            this.grpAgentType.TabStop = false;
            this.grpAgentType.Text = "Agent Type";
            // 
            // rdoJuniorAgent
            // 
            this.rdoJuniorAgent.AutoSize = true;
            this.rdoJuniorAgent.Location = new System.Drawing.Point(20, 30);
            this.rdoJuniorAgent.Margin = new System.Windows.Forms.Padding(4);
            this.rdoJuniorAgent.Name = "rdoJuniorAgent";
            this.rdoJuniorAgent.Size = new System.Drawing.Size(100, 20);
            this.rdoJuniorAgent.TabIndex = 5;
            this.rdoJuniorAgent.TabStop = true;
            this.rdoJuniorAgent.Text = "Junior Agent";
            this.rdoJuniorAgent.UseVisualStyleBackColor = true;
            // 
            // rdoSeniorAgent
            // 
            this.rdoSeniorAgent.AutoSize = true;
            this.rdoSeniorAgent.Location = new System.Drawing.Point(20, 86);
            this.rdoSeniorAgent.Margin = new System.Windows.Forms.Padding(4);
            this.rdoSeniorAgent.Name = "rdoSeniorAgent";
            this.rdoSeniorAgent.Size = new System.Drawing.Size(103, 20);
            this.rdoSeniorAgent.TabIndex = 7;
            this.rdoSeniorAgent.TabStop = true;
            this.rdoSeniorAgent.Text = "Senior Agent";
            this.rdoSeniorAgent.UseVisualStyleBackColor = true;
            // 
            // rdoAgent
            // 
            this.rdoAgent.AutoSize = true;
            this.rdoAgent.Location = new System.Drawing.Point(20, 58);
            this.rdoAgent.Margin = new System.Windows.Forms.Padding(4);
            this.rdoAgent.Name = "rdoAgent";
            this.rdoAgent.Size = new System.Drawing.Size(61, 20);
            this.rdoAgent.TabIndex = 6;
            this.rdoAgent.TabStop = true;
            this.rdoAgent.Text = "Agent";
            this.rdoAgent.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(166, 188);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 28);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 188);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 28);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 326);
            this.Controls.Add(this.txtCommissionEarned);
            this.Controls.Add(this.txtCommissionRate);
            this.Controls.Add(this.txtBonusReduction);
            this.Controls.Add(this.txtSalesAmount);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblBonusReduction);
            this.Controls.Add(this.lblCommissionRate);
            this.Controls.Add(this.lblCommissionEarned);
            this.Controls.Add(this.lblSalesAmount);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.grpAgentType);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Sales";
            this.grpAgentType.ResumeLayout(false);
            this.grpAgentType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommissionEarned;
        private System.Windows.Forms.TextBox txtCommissionRate;
        private System.Windows.Forms.TextBox txtBonusReduction;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblBonusReduction;
        private System.Windows.Forms.Label lblCommissionRate;
        private System.Windows.Forms.Label lblCommissionEarned;
        private System.Windows.Forms.Label lblSalesAmount;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.GroupBox grpAgentType;
        private System.Windows.Forms.RadioButton rdoJuniorAgent;
        private System.Windows.Forms.RadioButton rdoSeniorAgent;
        private System.Windows.Forms.RadioButton rdoAgent;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
    }
}

