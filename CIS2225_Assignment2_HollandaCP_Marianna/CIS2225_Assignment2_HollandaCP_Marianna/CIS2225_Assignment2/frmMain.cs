/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: October 07, 2021
 * Class: CIS-2225
 * Description: Assignment 2
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS2225_Assignment2
{
    public partial class frmMain : Form
    {
        //Global array to store commision percentage rates. This array is parallel to the items in the Category combobox
        double[] gRates = { 0.03, 0.02, 0.01, 0.07, 0.05 };

        //Global variables
        public double commissionRate = 0;
        public double salesCount = 0;
        public double totalSales = 0;
        public double totalCommissionEarned = 0;      

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbItems.ResetText();
            cmbItems.Items.Clear();

            if (cmbCategory.SelectedIndex > 0)
            {
                commissionRate = gRates[cmbCategory.SelectedIndex];
            }
            else
            {
                commissionRate = gRates[0];
            }

            string[] homeTheatre = { "TV", "Sound Bar", "Reciever", "Stream Box" };
            string[] videoGames = { "XBOX", "PS5", "Switch", "Game" };
            string[] carAudio = { "Car Stereo", "Speakers", "Subwoofer" };
            string[] computers = { "PC Desktop", "PC Laptop", "Mac Desktop", "Mac Laptop" };
            string[] appliances = { "Dish Washer", "Fridge", "Air Conditioner" };

            if (cmbCategory.Text == "Home Theatre")
            {
                foreach (string h in homeTheatre)
                {
                    cmbItems.Items.Add(h);
                }
            }

            if (cmbCategory.Text == "Video Games")
            {
                foreach (string v in videoGames)
                {
                    cmbItems.Items.Add(v);
                }
            }

            if (cmbCategory.Text == "Car Audio")
            {
                foreach (string ca in carAudio)
                {
                    cmbItems.Items.Add(ca);
                }
            }

            if (cmbCategory.Text == "Computers")
            {
                foreach (string c in computers)
                {
                    cmbItems.Items.Add(c);
                }
            }

            if (cmbCategory.Text == "Appliances")
            {
                foreach (string a in appliances)
                {
                    cmbItems.Items.Add(a);
                }
            }


        }

        //Form Validation.
        private bool ValidateForm()
        {
            bool returnValue = true;

            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                returnValue = false;
                lblFirstName.ForeColor = Color.Red;
                lblFirstName.Focus();
            }
            else
            {
                lblFirstName.ForeColor = Color.Black;
            }

            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                returnValue = false;
                lblLastName.ForeColor = Color.Red;
                lblLastName.Focus();
            }
            else
            {
                lblLastName.ForeColor = Color.Black;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                returnValue = false;
                lblCategory.ForeColor = Color.Red;
                lblCategory.Focus();
            }
            else
            {
                lblCategory.ForeColor = Color.Black;
            }

            if (cmbItems.SelectedIndex == -1)
            {
                returnValue = false;
                lblItem.ForeColor = Color.Red;
                lblItem.Focus();
            }
            else
            {
                lblItem.ForeColor = Color.Black;
            }

            //Price Validation.
            double price = 0;

            if (double.TryParse(txtPrice.Text, out price) == false)
            {
                MessageBox.Show("Value for price is non numeric or less than 0");
                lblPrice.ForeColor = Color.Red;
                lblPrice.Focus();
            }
            else if (price < 0)
            {
                MessageBox.Show("Value for price is non numeric or less than 0");
                lblPrice.ForeColor = Color.Red;
                lblPrice.Focus();
            }
            else
            {
                lblPrice.ForeColor = Color.Black;              
            }

            return returnValue;
        }

        //Calculate button
        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                txtFirstName.ReadOnly = true;
                txtLastName.ReadOnly = true;
                txtFirstName.TabStop = false;
                txtLastName.TabStop = false;

                Calculate();

                txtItemsSold.Text = salesCount.ToString();
                txtTotalSales.Text = totalSales.ToString();
                txtTotalCommission.Text = totalCommissionEarned.ToString();
            }

        }

        //Clear button
        private void btnClear_Click(object sender, EventArgs e)
        {
            string messageStop = "Stop entered sales for: " + txtFirstName.Text + " " + txtLastName.Text + "?";
            string caption = "Stop Entering Sales.";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(messageStop, caption, buttons);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("The total commission earned: " + totalCommissionEarned + " for " + txtFirstName.Text + " " + txtLastName.Text);

                ClearForm();
            }

        }

        //Method to do the calculations.
        private void Calculate()
        {
            double price = 0;
            double commissionItem = 0;

            if (double.TryParse(txtPrice.Text, out price) == true)
            {
                commissionItem = (price * commissionRate);
            }

            totalCommissionEarned = (totalCommissionEarned + commissionItem);
            salesCount = salesCount + 1;
            totalSales = totalSales + price;

            string data = "Category: " + cmbCategory.Text + ". Item: " + cmbItems.Text + ". Price: " + price + ". Commission Rate: " + commissionRate + ". Commission Earned: " + commissionItem + ".";
            lstSales.Items.Add(data);

        }

        //Method to clear the form.
        private void ClearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPrice.Text = "";
            txtTotalSales.Text = "";
            txtTotalCommission.Text = "";
            txtItemsSold.Text = "";


            txtFirstName.ReadOnly = false;
            txtLastName.ReadOnly = false;
            txtFirstName.TabStop = true;
            txtLastName.TabStop = true;

            cmbCategory.SelectedIndex = -1;
            cmbItems.SelectedIndex = -1;

            lstSales.Items.Clear();
            salesCount = 0;
            totalSales = 0;
            totalCommissionEarned = 0;
        }

    }
}
