using CIS2225_Assignment4_HollandaCP_Marianna.BusinessLayer;
using CIS2225_Assignment4_HollandaCP_Marianna.PresentationLayer;
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
 * Description: Assignment 4 - Main Form
 */

namespace CIS2225_Assignment4_HollandaCP_Marianna
{
    public partial class frmMain : Form
    {

        bool gFormChanged = false;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach(string p in Villagers.personalityType)
            {
                cmbPersonality.Items.Add(p);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Validate the form
            if (txtName.Text == "" || txtSpecie.Text == "" || cmbPersonality.SelectedIndex == -1 || txtBirthday.Text == "" || txtHobby.Text == "")
            {
                MessageBox.Show("No options can be blank. Try again.");
            } else
            {
                Villagers v = new Villagers();

                v.Name = txtName.Text;
                v.Specie = txtSpecie.Text;
                v.Birthday = txtBirthday.Text;
                v.Hobby = txtHobby.Text;
                v.Personality = cmbPersonality.Text;

                Villagers.villagersList.Add(v);

                MessageBox.Show("Villager Registrated! =)");

                //Clear the form
                txtName.Clear();
                txtSpecie.Clear();
                cmbPersonality.SelectedIndex = -1;
                txtBirthday.Clear();
                txtHobby.Clear();
                gFormChanged = false;
            }   
        }

        //View Menu Strip
        private void msView_Click(object sender, EventArgs e)
        {
            frmView vForm = new frmView();
            vForm.Show();
        }

        //Edit Menu Strip
        private void msEdit_Click(object sender, EventArgs e)
        {
            frmEdit vForm = new frmEdit();
            vForm.Show();
        }

        //Exit Menu Strip
        private void msExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Methods to make the code notice if the form was modified
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            gFormChanged = true;
        }

        private void txtSpecie_TextChanged(object sender, EventArgs e)
        {
            gFormChanged = true;
        }

        private void cmbPersonality_SelectedIndexChanged(object sender, EventArgs e)
        {
            gFormChanged = true;
        }

        private void txtBirthday_TextChanged(object sender, EventArgs e)
        {
            gFormChanged = true;
        }

        private void txtHobby_TextChanged(object sender, EventArgs e)
        {
            gFormChanged = true;
        }

        //Closing the form
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gFormChanged)
            {
                DialogResult answer = MessageBox.Show("You haven't saved the form. Are you sure you want to close?",
                    "Close Form?", MessageBoxButtons.YesNo);
                if(answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
