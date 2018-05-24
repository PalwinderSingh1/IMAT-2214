using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
