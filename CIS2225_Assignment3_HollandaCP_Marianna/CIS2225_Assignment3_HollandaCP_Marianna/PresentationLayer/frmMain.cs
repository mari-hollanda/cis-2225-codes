/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: October 21, 2021
 * Class: CIS-2225
 * Description: Assignment 3 - Main Form
 */

using CIS2225_Assignment3_HollandaCP_Marianna.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS2225_Assignment3_HollandaCP_Marianna
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //Load the form 
        //Add the ingredients to the form
        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string s in Pizza.ingredientsList)
            {
                cblIngredients.Items.Add(s);

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Pizza newPizza = new Pizza();
                newPizza.Size = cmbSizes.Text;
                newPizza.SauceType = cmbSauces.Text;

                //Creating the list of ingredients
                List<string> ingredients = new List<string>();

                //Adding the ingredients to the list
                for (int i = 0; i < cblIngredients.Items.Count; i++)
                {
                    if (cblIngredients.GetItemChecked(i))
                    {
                        string value = (string)cblIngredients.Items[i];
                        ingredients.Add(value);

                    }
                }

                newPizza.Ingredients = ingredients;
                Pizza.pizza.Add(newPizza);
                richtxtSummary.Clear();

                //Printing the Pizza
                foreach (Pizza p in Pizza.pizza)
                {

                    richtxtSummary.Text += p.ToString();
                }

                richtxtSummary.Text += "\nTotal Cost: $" + Pizza.CostTotal().ToString("c", CultureInfo.CurrentCulture) +
                   "\n---------------------------";

            }
        }

        //Form Validation.
        private bool ValidateForm()
        {
            bool returnValue = true;

            if (cmbSizes.SelectedIndex == -1)
            {
                returnValue = false;
                MessageBox.Show("No Pizza Size selected.");
                lblSize.ForeColor = Color.Red;
                lblSize.Focus();
            }
            else
            {
                lblSize.ForeColor = Color.Black;
            }

            if (cmbSauces.SelectedIndex == -1)
            {
                returnValue = false;
                MessageBox.Show("No Pizza Sauce selected.");
                lblSauce.ForeColor = Color.Red;
                lblSauce.Focus();
            }
            else
            {
                lblSauce.ForeColor = Color.Black;
            }

            return returnValue;
        }

        //Clearing the Form
        private void btnClear_Click(object sender, EventArgs e)
        {
            Pizza.pizza.Clear();
            richtxtSummary.Clear();
            cmbSizes.SelectedIndex = -1;
            cmbSauces.SelectedIndex = -1;
        }
    }
}
