﻿using System;
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

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            //Create a list to store the dates 
            List<string> Dates = new List<string>();
            //clear the listbox of existing contents
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

            //Create a new list for the formatted dates
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
        }
    }
}
