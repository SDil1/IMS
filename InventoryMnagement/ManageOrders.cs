using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMnagement
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\senud\Desktop\practise division\InventoryMnagement\InventoryMnagement\inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populateProducts()
        {
            try
            {
                con.Open();

                string query = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Products.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        void populateCustomer()
        {
            try
            {
                con.Open();

                string query = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customers.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void fillCategory()
        {
            try
            {
                con.Open();
                string query = "select * from CategoryTbl";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader rdr;
                rdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                dt.Load(rdr);
                searchCombo.ValueMember = "CatName";
                searchCombo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void filterbyCategory()
        {
            try
            {
                con.Open();

                string query = "select * from ProductTbl where ProCategory = '" + searchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                Products.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populateProducts();
            populateCustomer();
            fillCategory();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            filterbyCategory();
        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labe9_Click(object sender, EventArgs e)
        {

        }

        private void customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customers.Rows[e.RowIndex];

                customerId.Text = row.Cells["custId"].Value.ToString();
                custName.Text = row.Cells["custName"].Value.ToString();


            }
            else
            {
                MessageBox.Show("Please select a valid row.");
            }
        }
    }
}
