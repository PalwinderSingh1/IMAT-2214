using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GITTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitDates(string date)
        {
            //Split the date down and assign it to variables for later use.
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") weekend = true;
            string dbDate = dateTime.ToString("M/dd/yyyy");

            insertTimeDimension(dbDate, dayOfWeek, day, monthName, month, weekNumber, year, weekend, dayOfYear);
        }

        private void insertTimeDimension(string date, string dayName, int dayNumber, string monthName, int monthNumber, int weekNumber, int year, bool weekend, int dayOfYear)
        {
            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {

                // Open the SqlConnection.
                myConnection.Open();
                // The following code uses an SqlCommand based on the SqlConnection.
                SqlCommand command = new SqlCommand("SELECT id FROM Time WHERE date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));

                //Create a variable and assign it to false by default.
                bool exists = false;

                //Run the command & read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exsists so change the exsists variable. 
                    if (reader.HasRows)
                    {
                        exists = true;
                        Console.WriteLine("Data exsists!");
                    }
                }

                if (exists == false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                        "INSERT INTO Time (dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend, date, dayOfYear) " +
                    " VALUES (@dayName, @dayNumber, @monthName, @monthNumber, @weekNumber, @year, @weekend, @date, @dayOfYear) ", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("dayName", dayName));
                    insertCommand.Parameters.Add(new SqlParameter("dayNumber", dayNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthName", monthName));
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", weekNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfYear", dayOfYear));


                    try
                    {
                        //insert the line
                        int recordsAffected = insertCommand.ExecuteNonQuery();
                        Console.WriteLine("Records affected: " + recordsAffected);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine(dayName + " " + dayNumber + " " + monthName + " " + monthNumber + " " + weekNumber + " " + year + " " + weekend + " " + date + " " + dayOfYear);
                        throw;
                    }
                }
            }
        }


        private void GetDates_Click(object sender, EventArgs e)
        {
            //Create new list to store the results in.
            List<string> Dates = new List<string>();
            //clear the listbox
            listBoxDates.Items.Clear();

            //Create the database string
            string connectionString = Properties.Settings.Default.Data_set_1ConnectionString;

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand getDates = new OleDbCommand("SELECT [Order Date], [Ship Date] from Sheet1'", connection);

                reader = getDates.ExecuteReader();
                while (reader.Read())
                {
                    Dates.Add(reader[0].ToString());
                    Dates.Add(reader[1].ToString());
                }
            }

            //Create a new list for the formatted data.
            List<string> DatesFormatted = new List<string>();

            foreach (string date in Dates)
            {
                //Split the string on whitespace and remove anything thats blank.
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //Grab the first item (we know this is the date) and add it to our new list.
                DatesFormatted.Add(dates[0]);
            }

            //Bind the listbox to the list.
            listBoxDates.DataSource = DatesFormatted;


            //split the dates and insert every date in the list!
            foreach (string date in DatesFormatted)
            {
                splitDates(date);
            }
        }

        private int GetDateId(string date)
        {

            //Split the date down and assign it to variables for later use.
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dbDate = dateTime.ToString("M/dd/yyyy");


            //Create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {

                // Open the SqlConnection.
                myConnection.Open();
                // The following code uses an SqlCommand based on the SqlConnection.
                SqlCommand command = new SqlCommand("SELECT id FROM Time WHERE date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", dbDate));

                //Create a variable and assign it to false by default.
                bool exists = false;

                //Run the command & read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //If there are rows, it means the date exsists so change the exsists variable. 
                    if (reader.HasRows)
                    {
                        exists = true;
                        Console.WriteLine("Data exsists!");
                    }
                }

                if (exists == false)
                {

                }
            }
            return 0;
        }

        private void GetFromDestinationButton_Click(object sender, EventArgs e)
        {
            //Create new list to store the named results in.
            List<string> DestinationDatesNamed = new List<string>();

            //Create the database string
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection connection = new SqlConnection(connectionStringDestination))
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT dayName, dayNumber, monthName, monthNumber, weekNumber, year, weekend," +
                    "date, dayOfYear from Time", connection);

                using (SqlDataReader reader = command.ExecuteReader())
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLoadData_Click(object sender, EventArgs e)
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
