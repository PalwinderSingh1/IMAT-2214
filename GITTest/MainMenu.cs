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
            //once the users clicks close the button will play its part and activate
            Application.Exit();
        }

        private void btnGetDates_Click(object sender, EventArgs e)
        {
            //create an instance of the form get dates
            //if a user clicks on get dates 
            //a whole set of data will be displayed
            GetDates GetDates = new GetDates();
            //display the form
            //this will display all the dates within the listbox
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
            //if a user clicks on get customers
            //a whole set of data will be displayed
            GetCustomers GetCustomers = new GetCustomers();
            //display the form of customer
            //all customers names will be displayed within the listbox
            GetCustomers.Show();

        }

        private void btnCharts_Click(object sender, EventArgs e)
        {
            //create an instance of the form get charts mohammed
            Charts Charts = new Charts();
            //display the form
            Charts.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            //when a user clicks on the help button a help message will appear
            //help guide
            //this buttons enables to help out a user because , some users may struggle
            MessageBox.Show("You have succesfully loaded up the page");
            MessageBox.Show("Make sure you go through each part step by step to see work in action");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
