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
 * Description: Practical 2 - Summary Form
 */

namespace BookingForm.PresentationLayer
{
    public partial class frmSummary : Form
    {
        //Since we cannot use the "txtFirstName.Text" notation, we create the attributes again.
        private string venueName;
        private string firstName;
        private string lastName;
        private string email;
        private string bandType;
        private string eventSize;
        private double totalCost;

        public frmSummary(string vName, string fName, string lName, string cEmail, string bType, string eSize, double cost)
        {
            InitializeComponent();

            //Now we assign the attributes at the constructor.
            venueName = vName;
            firstName = fName;
            lastName = lName;
            email = cEmail;
            bandType = bType;
            eventSize = eSize;
            totalCost = cost;
        }

        private void frmSummary_Load(object sender, EventArgs e)
        {
            txtVenueName.Text = venueName;
            txtFirstName.Text = firstName;
            txtLastName.Text = lastName;
            txtEmail.Text = email;
            txtBandType.Text = bandType.Substring(0, bandType.IndexOf(":"));
            txtVenueSize.Text = eventSize;
            txtTotalCost.Text = String.Format("{0:C}", totalCost);
        }
    }
}
