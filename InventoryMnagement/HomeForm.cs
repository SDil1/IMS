using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMnagement
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       //products

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ManageProducts prod= new ManageProducts();
            prod.Show();
            this.Hide();
        }

        //users
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ManageUser users = new ManageUser();
            users.Show();
            this.Hide();
        }

        //categories
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ManageCatagorises categories = new ManageCatagorises();
            categories.Show();
            this.Hide();

        }
        //orders
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ManageOrders orders = new ManageOrders();
            orders.Show();
            this.Hide();
        }

        //customers
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ManageCustomers customers=new ManageCustomers();
            customers.Show();
            this.Hide();
        }

        private void home_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }
    }
}
