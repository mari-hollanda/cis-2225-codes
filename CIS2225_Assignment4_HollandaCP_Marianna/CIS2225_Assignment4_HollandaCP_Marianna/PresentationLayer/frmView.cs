using CIS2225_Assignment4_HollandaCP_Marianna.BusinessLayer;
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
 * Date: October 28, 2021
 * Class: CIS-2225
 * Description: Assignment 4 - View Form
 */

namespace CIS2225_Assignment4_HollandaCP_Marianna.PresentationLayer
{
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            //Printing the List
            if(Villagers.villagersList.Count > 0)
            {
                richtxtSummary.Clear();
                foreach (Villagers v in Villagers.villagersList)
                {
                    richtxtSummary.Text += v.ToString() + "\n";
                }
            }
        }
    }
}
