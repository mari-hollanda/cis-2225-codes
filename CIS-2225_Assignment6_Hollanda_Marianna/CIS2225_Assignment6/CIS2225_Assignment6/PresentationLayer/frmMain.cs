using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CIS2225_Assignment6.BusinessObjects;
using System.Data.OleDb;


/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: November 30, 2021
 * Class: CIS-2225
 * Description: Assignment 6 - Main Form
 * Source: Topic6ExamplesInsertUpdateNov18
 */
namespace CIS2225_Assignment6
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        //build connection to Cottages
        //create connection string for Cottages database
        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Cottages.accdb";

        //Create OldDbConnection
        OleDbConnection dbConn;

        private void frmMain_Load(object sender, EventArgs e)
        {
            //Populate the select guest combo box with the guest id from guest table
            PopulateGuestCombo();
        }

        public void PopulateGuestCombo()
        {
            ClearForm();

            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Guest table
                string sql;
                sql = "SELECT GuestID, FirstName, LastName from Guests;"; //note the two semicolons

                OleDbCommand dbCmd = new OleDbCommand();
                //set command SQL string
                dbCmd.CommandText = sql;
                //set the command connection
                dbCmd.Connection = dbConn;
                //create OleDbDataReader dbReader
                OleDbDataReader dbReader;
                //Read data into dbReader
                dbReader = dbCmd.ExecuteReader();
                //Read first record
                while (dbReader.Read())
                {
                    //Create a guest object populate the firstName, lastName and guestID attibutes
                    Guest gst = new Guest(dbReader["FirstName"].ToString(), dbReader["LastName"].ToString(), (int)dbReader["GuestId"]);

                    //load the Guest object per into the combobox
                    //when displayed the combo box will call toString by default on the Guest object.
                    //the toString only displays the FirstName and LastName of the Guest.
                    cbGuestSelector.Items.Add(gst);
                }
                //close Reader
                dbReader.Close();
                //close database connection
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Clear the Form
        private void ClearForm()
        {
            cbGuestSelector.Items.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtCity.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtRoom.Clear();
            txtState.Clear();
            txtStreet.Clear();
            txtZip.Clear();
            txtGuestId.Clear();
        }

        private void cbGuestSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Call method to populate the form based off the selection from cbGuestSelector
            PopulateGuest();
        }

        private void PopulateGuest()
        {
            //the combobox is populated with Guest objects. Cast the selected value as a Guest and then you can 
            //access the public property GuestID;
            int guestSelection = ((Guest)cbGuestSelector.SelectedItem).GuestId;

            try
            {
                dbConn = new OleDbConnection(sConnection);
                //open connection to database
                dbConn.Open();
                //create query to select all rows from Person table
                string sql;

                //Add a subquery to get the record count
                //Using a variable to identify the PersonId to search for
                sql = "SELECT(Select count(GuestId) from Guests where GuestId = " + guestSelection + ") " +
                        "as rowCount, * from Guests where GuestId = " + guestSelection + ";"; //note the two semicolons
                OleDbCommand dbCmd = new OleDbCommand();

                //set command SQL string
                dbCmd.CommandText = sql;

                //set the command connection
                dbCmd.Connection = dbConn;

                //get number of rows
                //ExecuteScalar just returns the value of the first column
                int numRows = (Int32)dbCmd.ExecuteScalar();

                //create OleDbDataReader dbReader
                OleDbDataReader dbReader;

                //Read data into dbReader
                dbReader = dbCmd.ExecuteReader();

                //Read first record
                dbReader.Read();
                if (dbReader.HasRows && numRows == 1)
                {
                    //get data from dbReader by column name and assing to text boxes
                    txtLastName.Text = dbReader["LastName"].ToString();
                    txtFirstName.Text = dbReader["FirstName"].ToString();
                    txtStreet.Text = dbReader["Street"].ToString();
                    txtCity.Text = dbReader["City"].ToString();
                    txtState.Text = dbReader["State"].ToString();
                    txtZip.Text = dbReader["Zip"].ToString();
                    txtPhone.Text = dbReader["Phone"].ToString();
                    txtEmail.Text = dbReader["Email"].ToString();
                    dtpLastVisitDate.Text = dbReader["LastVisitDate"].ToString();
                    txtRoom.Text = dbReader["Room"].ToString();
                    txtGuestId.Text = dbReader["GuestId"].ToString();
                }
                //Close open connections
                dbReader.Close();
                dbConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
            else if (txtStreet.Text == "")
            {
                errors = "Street is missing. \n";
            }
            else if (txtCity.Text == "")
            {
                errors = "City is missing. \n";
            }
            else if (txtState.Text == "")
            {
                errors = "State is missing. \n";
            }
            else if (txtState.Text.Length > 2)
            {
                errors = "Only 2 characters are allowed. \n";
            }
            else if (txtZip.Text == "")
            {
                errors = "Zip is missing. \n";
            }
            else if (txtPhone.Text == "")
            {
                errors = "Phone Number is missing. \n";
            }
            else if (txtEmail.Text == "")
            {
                errors = "Email is missing. \n";
            }
            else if (txtRoom.Text == "")
            {
                errors = "Room is missing. \n";
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to select all rows from Guest table
                    string sql;
                    sql = "Insert into Guests(LastName, FirstName, Street, City, State, Zip, Phone, Email, LastVisitDate, Room) Values (@FirstName, @LastName, @Street, @City, @State, @Zip, @Phone, @Email, @LastVisitDate, @Room);"; //note the two semicolons

                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    dbCmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    dbCmd.Parameters.AddWithValue("@Street", txtStreet.Text);
                    dbCmd.Parameters.AddWithValue("@City", txtCity.Text);
                    dbCmd.Parameters.AddWithValue("@State", txtState.Text);
                    dbCmd.Parameters.AddWithValue("@Zip", txtZip.Text);
                    dbCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    dbCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    dbCmd.Parameters.AddWithValue("@LastVisitDate", dtpLastVisitDate.Value.ToShortDateString());
                    dbCmd.Parameters.AddWithValue("@Room", txtRoom.Text);

                    //execute insert. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();
                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record inserted successfully");
                        //Update the form
                        PopulateGuestCombo();

                    }
                    else
                    {
                        MessageBox.Show("Error inserting record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //Check to see if they want to update the curren record
            DialogResult result = MessageBox.Show("Do you want to update this record?", "Update Record",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //update the record
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to update selected guest record
                    string sql;
                    sql = "Update Guests set LastName = @LastName, FirstName = @FirstName, Street = @Street , City = @City, State = @State, Zip = @Zip, Phone = @Phone, Email = @Email, LastVisitDate = @LastVisitDate, Room = @Room where GuestId = @GuestId";

                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    dbCmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    dbCmd.Parameters.AddWithValue("@Street", txtStreet.Text);
                    dbCmd.Parameters.AddWithValue("@City", txtCity.Text);
                    dbCmd.Parameters.AddWithValue("@State", txtState.Text);
                    dbCmd.Parameters.AddWithValue("@Zip", txtZip.Text);
                    dbCmd.Parameters.AddWithValue("@Phone", txtPhone.Text);
                    dbCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                    dbCmd.Parameters.AddWithValue("@LastVisitDate", dtpLastVisitDate.Value.ToShortDateString());
                    dbCmd.Parameters.AddWithValue("@Room", txtRoom.Text);
                    dbCmd.Parameters.AddWithValue("@GuestId", txtGuestId.Text);

                    //execute update. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record updated successfully");
                        ClearForm();
                        PopulateGuestCombo();
                    }
                    else
                    {
                        MessageBox.Show("Error updating record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Check to see if they want to update the curren record
            DialogResult result = MessageBox.Show("Do you want to delete this record?", "Delete Record",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //update the record
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    //open connection to database
                    dbConn.Open();
                    //create query to update selected person record
                    string sql;
                    sql = "Delete from Guests where GuestId = @GuestId";

                    //create database command
                    OleDbCommand dbCmd = new OleDbCommand();

                    //set command SQL string
                    dbCmd.CommandText = sql;
                    //set the command connection
                    dbCmd.Connection = dbConn;

                    //bind parameters
                    dbCmd.Parameters.AddWithValue("@GuestId", txtGuestId.Text);

                    //execute update. Check to see how many rows were affected
                    int rowCount = dbCmd.ExecuteNonQuery();

                    //close database connection
                    dbConn.Close();

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record deleted successfully");
                        PopulateGuestCombo();
                    }
                    else
                    {
                        MessageBox.Show("Error deleting record. Please try again.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

    }
}

