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
using System.Data.SqlClient;

namespace GITTest
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this closes the form
            Application.Exit();
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            //create an instance of the form get dates
            GetDates GetDates = new GetDates();
            //display the form
            GetDates.Show();
        }

        private void btnGetProducts_Click(object sender, EventArgs e)
        {
            //create an instance of the get product form
            GetProducts GetProducts = new GetProducts();
            //display the form
            GetProducts.Show();
        }

        private void btnGetCustomers_Click(object sender, EventArgs e)
        {
            //create an instance of the form get customers
            GetCustomers GetCustomers = new GetCustomers();
            //display the form
            GetCustomers.Show();

        }

        private void btnPopulateFactTable_Click(object sender, EventArgs e)
        {
            //create nbew list to store the results in. edited by palwinder
            List<string> Orders = new List<string>();

            // create the database string 
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //obtains the relevant information for the fact table, using the dates, customer name and product name to find the primary keys in layer function
                OleDbCommand getOrders = new OleDbCommand("SELECT [Order Date], [Customer Name], [Product Name], [Sales], [Discount], [Profit], [Quantity] from sheet1", connection);

                reader = getOrders.ExecuteReader();
                while (reader.Read())
                {
                    //data from different tables is separate with a #, while data from the same table is seperated with an underscore
                    //this allows them to be split into smaller arrays alter in the process 
                    Orders.Add(reader[0].ToString() + "#" + reader[1].ToString() + "#" +
                        reader[2].ToString() + reader[3].ToString() + "_" + reader[4].ToString() + "_" + reader[5].ToString() + "_" + reader[6].ToString());
                }
            }
            //split the orders and insert every order in the list 
            foreach (string order in Orders)
            {
                populateFactTable(order);
            }
        }

        private void populateFactTable(string order)
        {
            //create a list to store the order date BY MOHAMMED
            List<string> Dates = new List<string>();

            //split the received string into an array 
            string[] arrayOrder = order.Split('#');
            //split the array into smaller arrays where there is more than one entry, and create strings to store customer and product name 
            string[] arrayDates = arrayOrder[0].Split('_');
            string customerName = arrayOrder[1];
            string productName = arrayOrder[2];
            string[] arraySales = arrayOrder[3].Split('_');

            //prepare the numerical information to be added to the fact table entry
            decimal value = Convert.ToDecimal(arraySales[0]);
            decimal discount = Convert.ToDecimal(arraySales[1]);
            decimal profit = Convert.ToDecimal(arraySales[2]);
            Int32 quantity = Convert.ToInt32(arraySales[3]);

            //add the date to the date list 
            Dates.Add(arrayOrder[0].ToString());
            //create a new list to format the dates
            List<string> DatesFormatted = new List<string>();
            foreach (string date in Dates)
            {
                //split the string on whitespace and remove anything thats blank.
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //grab the first item (we know this is date) and add it to our new list.
                DatesFormatted.Add(dates[0]);
            }

            foreach (string date in DatesFormatted)
            {
                //split the date down and assign it to variables for later use 
                string[] arrayDate = date.Split('/');
                int year = Convert.ToInt32(arrayDate[2]);
                int month = Convert.ToInt32(arrayDate[2]);
                int day = Convert.ToInt32(arrayDate[2]);

                DateTime dateTime = new DateTime(year, month, day);

                string dbDate = dateTime.ToString("M/dd/yyyy");

                //create a connection to the MDF file 
                string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination)) // Harminder
                {
                    //open the SqlConnection.
                    myConnection.Open();
                    // the follwoing code uses an SqlCommand based on the Sqlconnecion
                    //it selects the primary keys from the three Dimension tables 
                    //this part is to check of the data exists within the tables 
                    SqlCommand command = new SqlCommand("SELECT timeId, procductId FROM Time, Procduct, Customer WHERE date = @date AND productName And customerName = @customerName", myConnection);
                    command.Parameters.Add(new SqlParameter("date", dbDate));
                    command.Parameters.Add(new SqlParameter("productName", productName));
                    command.Parameters.Add(new SqlParameter("customerName", customerName));

                    //create Int32 values to store the primary keys 

                }
            }


        }
    }
}
