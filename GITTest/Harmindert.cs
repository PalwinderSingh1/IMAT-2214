using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GITTest
{
    public partial class Harminder : Form
    {
        public Harminder()
        {
            InitializeComponent();
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            //Create a list to store the products
            List<string> Products = new List<string>();
            //Clear the listbox of existing contents
            lstboxGetProducts.Items.Clear();

            //Create the database string for Set 1 and Set 2
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the product category, subcategory and name from Dataset1
                OleDbCommand getProducts = new OleDbCommand("SELECT [Category], [Sub-Category], [Product Name] from Sheet1'", connection);
                reader = getProducts.ExecuteReader();
                while (reader.Read())
                {
                    //Add the results to the list, with category, subcategory and product name separated by an underscore
                    //This allows them to be separated and divided into their respective database columns through the split command later on
                    Products.Add(reader[0].ToString());
                    Products.Add(reader[1].ToString());
                    
                }
            }

            //create a new list for the formatted data 
            List<string> ProductsFormatted = new List<String>();

            foreach (string product in Products)
            {
                //split the string on whitespace and remove anything thats blank 
                var products = product.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //grab first item (we know this is the date ) and add it to your own list 
                ProductsFormatted.Add(Products[0]);
            }


            //blind the listbox to the list
            lstboxGetProducts.DataSource = ProductsFormatted;

                
            }

        }
    }