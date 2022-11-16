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
 * Date: October 14, 2021
 * Class: CIS-2225
 * Description: Practical 1
 */

namespace Marianna_Campos_CIS2225_Practical1
{
    public partial class frmMain : Form
    {
        //Global array to store the discount percentage. This array is parallel to the items in the Discunt combobox 
        double[] gDiscount = { 0.00, 0.1, 0.2 };

        //Global array to store the prices.
        double[] gPrices = { 0.00, 125.0, 60.0, 35.0, 200.0 };

        //Global variables
        double totalAmount = 0.0;
        string items = "";

        public frmMain()
        {
            InitializeComponent();
        }

        //Calculate Button
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cmbServices.Text) || cmbServices.Text == "None")
            {
                MessageBox.Show("Please make sure a service is selected and name is populated.");
            }
            else
            {
                txtName.ReadOnly = true;
                items = items + " " + cmbServices.Text;
                Calculate();
            }
        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //Method to do the calculation
        //Hello Donnie. I get really confuse with calculations, I need time to think a lot about
        //this part and I ran out of time, so this is what I have. Sorry =)
        //PS: Can you share a solution after? I would appreciate.
        private void Calculate()
        {
            double price = 0;

            if (cmbDiscount.Text == "None")
            {
                if (cmbServices.Text == "Team Building")
                {
                    price = gPrices[1];
                }
                if (cmbServices.Text == "Nutrition")
                {
                    price = gPrices[2];
                }
                if (cmbServices.Text == "Exercise")
                {
                    price = gPrices[3];
                }
                if (cmbServices.Text == "Full Package")
                {
                    price = gPrices[4];
                }
                else
                if (cmbDiscount.Text == "10%")
                {
                if(cmbServices.Text == "Team Building")
                {
                    price = gPrices[1] - (gPrices[1] * gDiscount[1]);
                }
                if (cmbServices.Text == "Nutrition")
                {
                    price = gPrices[2] - (gPrices[1] * gDiscount[1]);
                }
                if (cmbServices.Text == "Exercise")
                {
                    price = gPrices[3] - (gPrices[1] * gDiscount[1]);
                }
                if (cmbServices.Text == "Full Package")
                {
                    price = gPrices[4] - (gPrices[1] * gDiscount[1]);
                }
                else if(cmbDiscount.Text == "20%")
                {
                    if (cmbServices.Text == "Team Building")
                    {
                        price = gPrices[1] - (gPrices[1] * gDiscount[2]);
                    }
                    if (cmbServices.Text == "Nutrition")
                    {
                        price = gPrices[2] - (gPrices[1] * gDiscount[2]);
                    }
                    if (cmbServices.Text == "Exercise")
                    {
                        price = gPrices[3] - (gPrices[1] * gDiscount[2]);
                    }
                    if (cmbServices.Text == "Full Package")
                    {
                        price = gPrices[4] - (gPrices[1] * gDiscount[2]);
                    }
                }

                totalAmount =+ price;

            }

            }

        }


        //Method to clear the form
        private void ClearForm()
        {
            txtName.Text = "";
            txtName.ReadOnly = false;
            cmbServices.SelectedIndex = 0;
            cmbDiscount.SelectedIndex = 0;
            totalAmount = 0;

        }

        //Display the Form
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(cmbServices.Text) || cmbServices.Text == "None")
            {
                MessageBox.Show("Nothing to display");
            }
            else
            {
                MessageBox.Show("Total services for " + txtName.Text + " " + items + " " + "total amount for services: $" + totalAmount);
            }
        }

        //Exit the Form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
