using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GITTest
{
    public partial class GetProducts : Form
    {
        public GetProducts()
        {
            InitializeComponent();
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            //Create a list to store the products
            List<string> Products = new List<string>();
            //Clear the listbox of existing contents
            lstboxGetProducts.Items.Clear();

            //Create the database string 
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the product category, subcategory and name from Dataset1
                OleDbCommand getProducts = new OleDbCommand("SELECT [Category], [Sub-Category], [Product Name] from Sheet1", connection);
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this closes the form
            //as a user clicks the button it automatically activates and closes project
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //takes you back to main menu page
            //no need to keep closing down the whole project to go back
            //quick and effective way
            //user friendly 
            MainMenu MainMenu = new MainMenu();
            //display the main menu page
            MainMenu.Show();
        }

        private void btnGetfromDesinitionDb_Click(object sender, EventArgs e)
        {
            // Create new list to store the named results 
            List<string> DestinationDatesNamed = new List<string>();

            //Create the database string
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand timecommand = new SqlCommand("SELECT dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend," +
                    "date, dayOfYear from Time", connection);

                using (SqlDataReader reader = timecommand.ExecuteReader())
                {
                    //If there are rows, get them. 
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            DestinationDatesNamed.Add(reader["dayName"].ToString() + ", " + reader["dayNumber"].ToString() + ", " +
                                reader["monthName"].ToString() + ", " + reader["monthNumber"].ToString() + ", " + reader["weekNumber"].ToString() +
                                ", " + reader["year"].ToString() + ", " + reader["weekend"].ToString() + ", " + reader["date"].ToString() + ", " +
                                reader["dayOfYear"].ToString());
                        }
                    }
                    else
                    {
                        DestinationDatesNamed.Add("No Data present.");
                    }
                }

            }
            //Bind the listbox to the list.
            listBoxFromDbNamed.DataSource = DestinationDatesNamed;
        }

        private void GetProducts_Load(object sender, EventArgs e)
        {

        }
    }
}