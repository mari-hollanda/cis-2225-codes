using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

/*
 * Author: Marianna Hollanda Campos Pedroso
 * Date: December 09, 2021
 * Class: CIS-2225
 * Description: Practical 4 - Main Form
 * Source: Assignment 6
 */
namespace CIS_2225_Practical4
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        string sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=Product.accdb";
        OleDbConnection dbConn;
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            PopulateProductCombo();
        }

        //Populate the select product combo box with the product_id from product table
        private void PopulateProductCombo()
        {
            //Clear the Form
            ClearForm();

            try
            {
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                string sql;
                sql = "SELECT Product_ID from Product;";

                OleDbCommand dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                OleDbDataReader dbReader;
                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    cbProductID.Items.Add(dbReader["Product_ID"]);
                }

                dbReader.Close();
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
            cbProductID.Items.Clear();
            txtDescription.Clear();
            txtMarkUp.Clear();
            txtQuantity.Clear();
            txtRetailPrice.Clear();
        }

        private void cbProductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateProduct();
        }

        //Method to populate the form based off the selection from cbProductID
        private void PopulateProduct()
        {
            try
            {
                dbConn = new OleDbConnection(sConnection);
                dbConn.Open();

                string sql;
                sql = "SELECT(Select count(Product_ID) from Product where Product_ID = " + cbProductID.Text + ") " +
                        "as rowCount, * from Product where Product_ID = " + cbProductID.Text + ";"; 

                OleDbCommand dbCmd = new OleDbCommand();
                dbCmd.CommandText = sql;
                dbCmd.Connection = dbConn;
                int numRows = (Int32)dbCmd.ExecuteScalar();
                OleDbDataReader dbReader;
                dbReader = dbCmd.ExecuteReader();
                dbReader.Read();

                if (dbReader.HasRows && numRows == 1)
                {
                    txtDescription.Text = dbReader["Description"].ToString();
                    txtRetailPrice.Text = dbReader["Retail_Price"].ToString();
                    txtQuantity.Text = dbReader["Quantity"].ToString();
                    txtMarkUp.Text = dbReader["MarkUP"].ToString();
                }

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
            if (txtDescription.Text == "")
            {
                errors = "Description is missing. \n";
            }
            else if (int.TryParse(txtRetailPrice.Text, out int Retail_Price) == false || Retail_Price < 0)
            {
                errors = "Retail Price is missing or is not a number. \n";
            }

            else if (int.TryParse(txtQuantity.Text, out int Quantity) == false || Quantity < 0)
            {
                errors = "Quantity is missing or is not a number. \n";
            }

            else if (int.TryParse(txtMarkUp.Text, out int MarkUP) == false || MarkUP < 0)
            {
                errors = "Mark Up is missing or is not a number. \n";
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            PopulateProductCombo();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cbProductID.Text.Length > 0)
            {
                MessageBox.Show("There is already a record selected. Clear the form first.");

            }
            else if (ValidateForm())
            {

                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    dbConn.Open();

                    string sql;
                    sql = "Insert into Product(Description, Retail_Price, Quantity, MarkUp) Values (@Description, @Retail_Price, @Quantity, MarkUp);";


                    OleDbCommand dbCmd = new OleDbCommand();
                    dbCmd.CommandText = sql;
                    dbCmd.Connection = dbConn;

                    dbCmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                    dbCmd.Parameters.AddWithValue("@Retail_Price", txtRetailPrice.Text);
                    dbCmd.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                    dbCmd.Parameters.AddWithValue("@MarkUp", txtMarkUp.Text);

                    int rowCount = dbCmd.ExecuteNonQuery();
                    dbConn.Close();

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Record inserted successfully.");
                        PopulateProductCombo();

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Delete Product",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dbConn = new OleDbConnection(sConnection);
                    dbConn.Open();

                    string sql;
                    sql = "Delete from Product where Product_ID = @Product_ID";

                    OleDbCommand dbCmd = new OleDbCommand();
                    dbCmd.CommandText = sql;
                    dbCmd.Connection = dbConn;
                    dbCmd.Parameters.AddWithValue("@Product_ID", cbProductID.Text);
                    int rowCount = dbCmd.ExecuteNonQuery();
                    dbConn.Close();

                    if (rowCount == 1)
                    {
                        MessageBox.Show("Product deleted.");
                        PopulateProductCombo();
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

