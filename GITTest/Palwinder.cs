using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GITTest
{
    public partial class GetDates : Form
    {

        List<string> DatesFormatted = new List<string>();
        private object dbdate;

        public GetDates()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            //comment here
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            //Create a list to store the dates
            List<string> Dates = new List<string>();
            //clear the listbox of existing content
            listBoxDates.Items.Clear();

            //create the database string 
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
            //Create a new list for the formatted date
            List<string> DatesFormatted = new List<string>();

            foreach (string date in Dates)
            {
                //Split the string on whitespace and remove anything thats blan.
                var dates = date.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                //Grab the first item (we know this is the date) and add it to our new lists
                DatesFormatted.Add(dates[0]);
            }

            //Bind the listbox to the list.
            listBoxDates.DataSource = DatesFormatted;

            //split the data down and assign it to variable for later use.
            string[] arrayDate = DatesFormatted[0].ToString().Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);
            Console.WriteLine("Day of week: " + dateTime.DayOfWeek);

            string dayofWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool weekend = false;
            if (dayofWeek == "Saturday" || dayofWeek == "Sunday") weekend = true;


            //these two do the same thing, its down to personal coding style only use one of them
            //string[] arrayDate = DatesFormatted[0].ToString().Split('/');
            Console.WriteLine("day: " + arrayDate[0] + " Month: " + arrayDate[1] + " Year: " + arrayDate[2]);

            string fullDate = DatesFormatted[0].ToString();
            string[] arrayDate1 = fullDate.Split('/');
            Console.WriteLine("day: " + arrayDate[0] + "Month" + arrayDate1[1] + "Year: " + arrayDate1[2]);
            Console.WriteLine(Dates[0].ToString());

            listBoxDates.DataSource = Dates;
        }


        private void splitDates(string date)
        {
            //split the data down and assign it to variables for later use
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool Weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") Weekend = true;
            string dbDate = dateTime.ToString("M/dd/yyyy");

            insertTimeDimension(dbdate, dayOfWeek, day, monthName, weekNumber, year, Weekend, dayOfYear);

        }

        private void insertTimeDimension(object dbdate, string dayOfWeek, int day, string monthName, int weekNumber, int year, bool weekend, int dayOfYear)
        {
            throw new NotImplementedException();
        }

        

        private void insertTimeDimension(string date, string dayName, int dayNumber, string monthName, int monthNumber, int weekNumber, int year, bool weekend, int dayOfYear)
        {
            //to be able to create a connection to the MDF file
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the SqlConnection
                myConnection.Open();
                //the following code uses an SqlCommand based on SQLconnection
                SqlCommand command = new SqlCommand("SELECT id FROM time WHERE date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", date));

                //run the command and read results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //create a variable and assign it to false by default
                    bool exists = false;
                    //if there are rows , it means the date exists so change the exists variable
                    if (reader.HasRows) exists = true;
                }
                //      if (exists = false)
                {
                    SqlCommand insertCommand = new SqlCommand(
                "INSERT ONTO TIME(dayNumber, monthName, monthNumber, weekNumber, year, weekend, datedayOfYear)" + "VALUES @dayName, @DayNumber, @monthName, @monthNumber, @date, @dayOfYear", myConnection);
                    insertCommand.Parameters.Add(new SqlParameter("dayName", dayName));
                    insertCommand.Parameters.Add(new SqlParameter("dayNumber", dayNumber));
                    insertCommand.Parameters.Add(new SqlParameter("monthName", monthName));
                    insertCommand.Parameters.Add(new SqlParameter("monthNumber", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("weekNumber", monthNumber));
                    insertCommand.Parameters.Add(new SqlParameter("year", year));
                    insertCommand.Parameters.Add(new SqlParameter("weekend", weekend));
                    insertCommand.Parameters.Add(new SqlParameter("date", date));
                    insertCommand.Parameters.Add(new SqlParameter("dayOfYear", dayOfYear));

                    //insert the line
                    int recordsAffected = insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Records Affected: " + recordsAffected);
                }
                command.Parameters.Add(new SqlParameter("date", date));
            }
        }

        private int GetDateID(string date)
        {
            //split the date down and assign it to variable for later use.
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dbDate = dateTime.ToString("m/dd/yyyy");


            //create a connecting to the MDF file 
            string connectionStringDestination = Properties.Settings.Default.DestinationDatabaseConnectionString;

            using (SqlConnection myConnection = new SqlConnection(connectionStringDestination))
            {
                //open the sqlConnection.
                myConnection.Open();
                // the follwing code uses an SqlCommand based on the SqlConnection.
                SqlCommand command = new SqlCommand("SELECT it FROM TIME WHERE date = @date", myConnection);
                command.Parameters.Add(new SqlParameter("date", dbDate));

                //create a variable and assign it to false by default.
                bool exists = false;

                //Run the command & read the results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    //if there are rows, it means the data exists so change the exists variable.
                    if (reader.HasRows)
                    {
                        exists = true;
                        Console.WriteLine("Data exists!");
                    }
                }

                if (exists == false)
                {

                }
                return 0;
            }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this closes the form
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //takes you back to main menu page
            MainMenu MainMenu = new MainMenu();
            //display the main menu page
            MainMenu.Show();
        }
    }
}


