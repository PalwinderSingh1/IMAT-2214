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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void splitDates(string date)
        {
            //split the data down and assign it to variables for later use/ added by harminder
            string[] arrayDate = date.Split('/');
            int year = Convert.ToInt32(arrayDate[2]);
            int month = Convert.ToInt32(arrayDate[1]);
            int day = Convert.ToInt32(arrayDate[0]);

            DateTime dateTime = new DateTime(year, month, day);

            string dayOfWeek = dateTime.DayOfWeek.ToString();
            int dayOfYear = dateTime.DayOfYear;
            string monthName = dateTime.ToString('MMMM');
            int weekNumber = dayOfYear / 7;
            bool Weekend = false;
            if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday") Weekend = true;
            
        }

        private void InsertTimeDimension()
        {
            //to be able to create a connection to the PDF file
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

            }
        }

                    
            





        private void btnGetDates_Click(object sender, EventArgs e)
        {
            //Create a list to store the dates 
            List<string> Dates = new List<string>();
            //clear the listbox of existing content
            listBoxDates.Items.Clear();

            //create the database string for Set 1 and Set 2
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
            int dayOfYear = dateTime.DayOfYear.ToString();
            string monthName = dateTime.ToString("MMMM");
            int weekNumber = dayOfYear / 7;
            bool Weekend = false;
            if (dayofWeek == "Saturday" || dayofWeek == "Sunday") Weekend = true;


            //these two do the same thing, its down to personal coding style only use one of them
                string[] arrayDate = DatesFormatted[0].ToString().Split('/');
            Console.WriteLine("day: " + arrayDate[0] + " Month: " + arrayDate[1] + " Year: " + arrayDate[2]);

            string fullDate = DatesFormatted[0].ToString();
            string[] arrayDate1 = fullDate.Split('/');
            Console.WriteLine("day: " + arrayDate[0] + "Month" + arrayDate1[1] + "Year: " + arrayDate1[2]);
        }
    }
}
