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
    public partial class GetCustomers : Form
    {
        public GetCustomers()
        {
            InitializeComponent();
        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            //Create a list to store the dates
            List<string> Customers = new List<string>();
            //Clear the listbox of existing contents
            listBoxCustomers.Items.Clear();

            //Create the database string 
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;               
                OleDbCommand getCustomers = new OleDbCommand("SELECT [Customer Name], [Country], [City], [State], [Postal Code], [Region], [Segment] from Sheet1'", connection);

                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    Customers.Add(reader[0].ToString());
                    Customers.Add(reader[1].ToString());
                }
            }
           
            // create a new list for the formatted customer.
            List<String> CustomersFormatted = new List<string>();
            foreach (string customer in Customers)
            {

                //split the string on whitespace and remove anything thats blank
                var dates = customer.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //Grab the first item [we know this the data] and add it to our new lisst.
                CustomersFormatted.Add(dates[0]);
            }
            //Bind the listbox to th list
            listBoxCustomers.DataSource = CustomersFormatted;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this closes the form
            //when a user clicks on the close button it will activate and play its role
            //closes the program
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //takes you back to main menu page
            //no need to keep closing the whole project
            MainMenu MainMenu = new MainMenu();
            //display the main menu page
            MainMenu.Show();
        }

        private void btnGetfromDestinationDb_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void GetCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
