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

namespace GITTest
{
    public partial class Mohammed : Form
    {
        public Mohammed()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            List<string> Customers = new List<string>();
            //clear the listbox
            //Clear the listbox of existing contents
            listBoxCustomers.Items.Clear();

            //Create the database string for Set 1 and Set 2 testing 
            string connectionStringSet1 = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the customer name, country, city, state, postal code, region and segment from Sheet1
                OleDbCommand getCustomers = new OleDbCommand("SELECT [Customer Name], [Country], [City], [State], [Postal Code], [Region], [Segment] from Sheet1'", connection);

                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    //Add the results to the list, with ceach segment separated by an underscore
                    //This allows them to be separated and divided into their respective database columns through the split command later on
                    Customers.Add(reader[0].ToString());
                    Customers.Add(reader[1].ToString());
                }
            }

            using (OleDbConnection connection = new OleDbConnection(connectionStringSet1))
            {
                connection.Open();
                OleDbDataReader reader = null;
                //Obtain the customer name, country, city, state, postal code, region and segment from Dataset2 in entries where the row is properly formatted (row values match columns)
                OleDbCommand getCustomers = new OleDbCommand("SELECT [Customer Name], [Country], [City], [State], [Postal Code], [Region], [Segment] from [Student Sample 2 - Sheet1] WHERE [Field22] IS NULL", connection);

                reader = getCustomers.ExecuteReader();
                while (reader.Read())
                {
                    //Add the results to the list, with ceach segment separated by an underscore
                    //This allows them to be separated and divided into their respective database columns through the split command later on
                    Customers.Add(reader[0].ToString() + "_" + reader[1].ToString() + "_" + reader[2].ToString() + "_" +
                        reader[3].ToString() + "_" + reader[4].ToString() + "_" + reader[5].ToString() + "_" + reader[6].ToString());
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
    }

}
            
        
    
