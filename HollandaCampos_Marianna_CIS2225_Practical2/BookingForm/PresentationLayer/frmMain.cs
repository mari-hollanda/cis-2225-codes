using BookingForm.BusinessLayer;
using BookingForm.PresentationLayer;
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
 * Date: November 13, 2021
 * Class: CIS-2225
 * Description: Practical 2 - Main Form
 */

namespace BookingForm
{
    public partial class frmMain : Form
    {

        //Creating the object. It is created here since I cannot use the "readonly" 
        //property inside the else at msPriceBooking_Click
        readonly Booking b = new Booking();

        public frmMain()
        {
            InitializeComponent();
        }

        //Method to show the user the final Booking Price
        private void msPriceBooking_Click(object sender, EventArgs e)
        {
            //Validate the form
            if(txtFirstName.Text == "" || txtLastName.Text == "" || txtEmail.Text == "" || txtVenueName.Text == "" || (!(rdoRock.Checked || rdoPop.Checked || rdoClassical.Checked)) || cmbEventSize.Text == "")
            {
                MessageBox.Show("You must fill in the form completely.");
            } else
            {
                b.VenueName = txtVenueName.Text;
                b.FirstName = txtFirstName.Text;
                b.LastName = txtLastName.Text;
                b.Email = txtLastName.Text;
                b.EventSize = cmbEventSize.Text;

                if (rdoRock.Checked)
                {
                    b.BandType = rdoRock.Text;
                } 
                else if (rdoPop.Checked)
                {
                    b.BandType = rdoPop.Text;
                } 
                else if (rdoClassical.Checked)
                {
                    b.BandType = rdoClassical.Text;
                }

                //Calculating the Price
                b.CalculatePrice();

                //Changing the Rich Text Box text
                richTxtTitle.Text = "Your Booking has been submitted.\n" +
                    "Click the Process Booking to see details.";

                //Since the Process Booking cannot be opened until a booking is submitted, we use:
                msProcessBooking.Enabled = true;
            }
        }

        //Process Booking Method
        private void msProcessBooking_Click(object sender, EventArgs e)
        {
            frmSummary vForm = new frmSummary(b.VenueName, b.FirstName, b.LastName, b.Email, b.BandType, b.EventSize, b.TotalCost);
            vForm.Show();
        }

        //Exit Menu Strip
        private void msExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

    }
}
