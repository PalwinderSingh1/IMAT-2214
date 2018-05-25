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
using System.Globalization;



namespace GITTest
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //Ideally this range would come from your database or elsewhere to allow the user to pick which dates they want to see.
            List<string> datelist = new List<string>(new string[] { "06/01/2014", "07/01/2014", "08/01/2014", "09/01/2014", "10/01/2014", "11/01/2014", "12/01/2014" });
          
            //The dictionary type is string, int - date, number of sales.
            Dictionary<string, int> salesCount = new Dictionary<string, int>();


            //Create a connection to the MDF file. We only need this once so its outside my loop.
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //Run this code once for each date in my list - in my case 7 times.
            foreach (string date in datelist)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {

                    // Open the SqlConnection
                    myConnection.Open();
                    // The following code uses an SqlCommand based on the SqlConnection.
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS SalesNumber FROM FactTable JOIN Time " +
                    "ON FactTable.time.Id = Timeid WHERE Time.date = @date; ", myConnection);
                    command.Parameters.Add(new SqlParameter("date", date));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //If there are rows, it means there were sales
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //This line adds a dictionary item with the key of the date, and the value being the sales number.
                                salesCount.Add(date, Int32.Parse(reader["SalesNumber"].ToString()));
                            }
                        }
                        else
                        {
                            salesCount.Add(date, 0);
                        }
                    }
                }

                salesCount.Clear();
                salesCount.Add("06/01/2014", 23);
                salesCount.Add("07/01/2014", 4);
                salesCount.Add("08/01/2014", 5);
                salesCount.Add("09/01/2014", 4);
                salesCount.Add("10/01/2014", 2);
                salesCount.Add("11/01/2014", 1);
                salesCount.Add("12/01/2014", 0);



                //Now to building a bar chart:
                chart1.DataSource = salesCount;
                chart1.Series[0].XValueMember = "Key";
                chart1.Series[0].YValueMembers = "Value";
                chart1.DataBind();
            }
        }
    }
}
