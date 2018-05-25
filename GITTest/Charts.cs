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
            //This is a hardcoded week - the lowest grade.
            //Ideally this range would come from your database or elsewhere to allow the user to pick which dates they want to see.
            //A good idea could be to create an empty list and then add in the week of dates you need? Up to you!
            List<string> datelist = new List<string>(new string[] { "06/01/2014", "07/01/2014", "08/01/2014", "09/01/2014", "10/01/2014", "11/01/2014", "12/01/2014" });


            //I need somewhere to hold the information pulled from the database! This is an empty dictionary.
            //I am using a dictionary as I can then manually set my own "key" so rather than it being accessed through [0], [1] ect, i can access it via the date.
            //The dictionary type is string, int - date, number of sales.
            Dictionary<string, int> salesCount = new Dictionary<string, int>();


            //Create a connection to the MDF file. We only need this once so its outside my loop.
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            //Run this code once for each date in my list - in my case 7 times.
            foreach (string date in datelist)
            {
                using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
                {

                    // Open the SqlConnection.
                    myConnection.Open();
                    // The following code uses an SqlCommand based on the SqlConnection.
                    SqlCommand command = new SqlCommand("SELECT COUNT(*) AS SalesNumber FROM FactTable JOIN Time " +
                        "ON FactTable.timeId = Time.id WHERE Time.date = @date; ", myConnection);
                    command.Parameters.Add(new SqlParameter("date", date));

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        //If there are rows, it means there were sales. 
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                //This line adds a dictionary item with the key of the date, and the value being the sales number.
                                //I could access this after by doing: int numberOfSales = salesCount["06/01/2014"]; - try it and write it to the console to test!
                                salesCount.Add(date, Int32.Parse(reader["SalesNumber"].ToString()));
                            }
                        }
                        //If there are no rows it means there were 0 sales, so we also need to handle this!
                        else
                        {
                            salesCount.Add(date, 0);
                        }
                    }
                }
            }
            //End of the foreach loop. We now have a (hopefully) filled array.

            //Ignore this block, this is to manually build the dictionary with test data as this code is not complete to prevent copying.
            salesCount.Clear();
            salesCount.Add("06/01/2014", 23);
            salesCount.Add("07/01/2014", 4);
            salesCount.Add("08/01/2014", 5);
            salesCount.Add("09/01/2014", 4);
            salesCount.Add("10/01/2014", 2);
            salesCount.Add("11/01/2014", 1);
            salesCount.Add("12/01/2014", 0);
            //Stop ignoring. If you put the above code in your block you will not score anything in the demo as it will override anything coming out of your database.


            //Now to build a bar chart:
            chart1.DataSource = salesCount;
            chart1.Series[0].XValueMember = "Key";
            chart1.Series[0].YValueMembers = "Value";
            chart1.DataBind();


            //Or a pie chart?
            chart2.DataSource = salesCount;
            chart2.Series[0].XValueMember = "Key";
            chart2.Series[0].YValueMembers = "Value";
            chart2.DataBind();
        }
    }
}

        }
    }
}
