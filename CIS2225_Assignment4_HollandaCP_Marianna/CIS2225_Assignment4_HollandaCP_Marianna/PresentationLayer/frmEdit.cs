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
 * Description: Assignment 4 - Edit Form
 */

namespace CIS2225_Assignment4_HollandaCP_Marianna.PresentationLayer
{
    public partial class frmEdit : Form
    {
        public frmEdit()
        {
            InitializeComponent();
        }

        private void frmEdit_Load(object sender, EventArgs e)
        {
            if(Villagers.villagersList.Count > 0)
            {
                foreach(Villagers v in Villagers.villagersList)
                {
                    cmbVillager.Items.Add(v.Name);
                }
            }

            foreach (string p in Villagers.personalityType)
            {
                cmbPersonality.Items.Add(p);
            }
        }

        private void cmbVillager_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbVillager.SelectedIndex >= 0)
            {
                txtName.Text = Villagers.villagersList[cmbVillager.SelectedIndex].Name;
                txtSpecie.Text = Villagers.villagersList[cmbVillager.SelectedIndex].Specie;
                txtBirthday.Text = Villagers.villagersList[cmbVillager.SelectedIndex].Birthday;
                txtHobby.Text = Villagers.villagersList[cmbVillager.SelectedIndex].Hobby;

                int count = 0;
                foreach (string p in Villagers.personalityType)
                {
                    if (p == Villagers.villagersList[cmbVillager.SelectedIndex].Personality)
                    {
                        cmbPersonality.SelectedIndex = count;
                    }
                    count++;
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Validate the form
            if (txtName.Text == "" || txtSpecie.Text == "" || cmbPersonality.SelectedIndex == -1 || txtBirthday.Text == "" || txtHobby.Text == "")
            {
                MessageBox.Show("No options can be blank. Try again.");
            }
            else
            {
                Villagers.villagersList[cmbVillager.SelectedIndex].Name = txtName.Text;
                Villagers.villagersList[cmbVillager.SelectedIndex].Specie = txtSpecie.Text;
                Villagers.villagersList[cmbVillager.SelectedIndex].Birthday = txtBirthday.Text;
                Villagers.villagersList[cmbVillager.SelectedIndex].Hobby = txtHobby.Text;

                MessageBox.Show("Villager Updated! =)");

                //Clear the form
                cmbVillager.SelectedIndex = -1;
                txtName.Clear();
                txtSpecie.Clear();
                cmbPersonality.SelectedIndex = -1;
                txtBirthday.Clear();
                txtHobby.Clear();
            }
        }
    }
}
