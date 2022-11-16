using HollandaCP_Marianna_CIS2225_Practical3.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: Dec 04, 2021
 * Class: CIS-2225
 * Description: Practical 3 - Main Form
 */
namespace HollandaCP_Marianna_CIS2225_Practical3
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //Validate the Form
        private bool ValidateForm()
        {
            string errors = "";
            if (txtLastName.Text == "")
            {
                errors = "Last Name is missing. \n";
            }
            else if (txtFirstName.Text == "")
            {
                errors = "First Name is missing. \n";
            }
            else if (txtEmail.Text == "")
            {
                errors = "Email is missing. \n";
            }
            else if (double.TryParse(txtSalesAmount.Text, out double salesAmount) == false || salesAmount < 0)
            {
                errors = "Sales Amount is missing or is not a number. \n";
            }
            else if (!(rdoAgent.Checked || rdoJuniorAgent.Checked || rdoSeniorAgent.Checked))
            {
                errors = "Agent Type is missing.";
            }

            if (errors.Length > 0)
            {
                MessageBox.Show(errors);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Clear the Form
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtSalesAmount.Clear();

            txtCommissionEarned.Clear();
            txtCommissionRate.Clear();
            txtBonusReduction.Clear();

            if (rdoSeniorAgent.Checked)
            {
                rdoSeniorAgent.Checked = false;
            }
            else if (rdoJuniorAgent.Checked)
            {
                rdoJuniorAgent.Checked = false;
            }
            else if (rdoAgent.Checked)
            {
                rdoAgent.Checked = false;
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                if (rdoJuniorAgent.Checked)
                {
                    JuniorAgent juniorAgent = new JuniorAgent();
                    juniorAgent.FirstName = txtFirstName.Text;
                    juniorAgent.LastName = txtLastName.Text;
                    juniorAgent.Email = txtEmail.Text;
                    if (double.TryParse(txtSalesAmount.Text, out double salesAmount))
                    {
                        juniorAgent.SalesAmount = salesAmount;
                    }
                    juniorAgent.Calculate();
                    txtCommissionEarned.Text = "$" + String.Format("{0:0.00}", juniorAgent.JuniorCEarned); 
                    txtCommissionRate.Text = juniorAgent.CommissionRate.ToString();
                    txtBonusReduction.Text = "-" + juniorAgent.JuniorCRate.ToString();

                }
                else if (rdoAgent.Checked)
                {
                    Agent agent = new Agent();
                    agent.FirstName = txtFirstName.Text;
                    agent.LastName = txtLastName.Text;
                    agent.Email = txtEmail.Text;
                    if (double.TryParse(txtSalesAmount.Text, out double salesAmount))
                    {
                        agent.SalesAmount = salesAmount;
                    }
                    agent.Calculate();
                    txtCommissionEarned.Text = "$" + String.Format("{0:0.00}", agent.CommissionEarned);
                    txtCommissionRate.Text = agent.CommissionRate.ToString();
                    txtBonusReduction.Text = agent.AgentCommissionRate.ToString();

                }
                else if (rdoSeniorAgent.Checked)
                {
                    SeniorAgent seniorAgent = new SeniorAgent();
                    seniorAgent.FirstName = txtFirstName.Text;
                    seniorAgent.LastName = txtLastName.Text;
                    seniorAgent.Email = txtEmail.Text;
                    if (double.TryParse(txtSalesAmount.Text, out double salesAmount))
                    {
                        seniorAgent.SalesAmount = salesAmount;
                    }
                    seniorAgent.Calculate();
                    txtCommissionEarned.Text = "$" + String.Format("{0:0.00}", seniorAgent.SeniorCEarned);
                    txtCommissionRate.Text = seniorAgent.CommissionRate.ToString();
                    txtBonusReduction.Text = seniorAgent.SeniorCRate.ToString();
                }
            }
        }
    }
}
