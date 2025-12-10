using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        void updateproduct()
        {
            try
            {
                con.Open();
                int id=Convert.ToInt32(Products.CurrentRow.Cells[0].Value.ToString());
                int newqty = stock - Convert.ToInt32(QtyTb.Text);
                string query = "update ProductTbl set ProQty=" + newqty + " where ProId=" + id + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                con.Close();
                populateProducts();
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

        int num = 0;
        int n = 0;
        int uprice, totprice, qty;
        string product;

        private void button5_Click(object sender, EventArgs e)
        {
            filterbyCategory();
        }

      

        

        int flag = 0;
        int stock;

       
        private void Products_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Products.Rows[e.RowIndex];

                product = row.Cells["ProName"].Value.ToString();
                stock = Convert.ToInt32(row.Cells["ProQty"].Value.ToString());
                // qty = Convert.ToInt32(QtyTb.Text);
                uprice = Convert.ToInt32(row.Cells["ProPrice"].Value.ToString());

                //totprice = qty * uprice;
                flag = 1;

            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            int sum = 0;
            if (QtyTb.Text == "")
            {
                MessageBox.Show("Select The Product And Enter The Quantity");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select The Product");

            }
            else if (Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("Not Enough In Stock");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;

                dataGridView1.Rows.Add(num,product,qty,uprice,totprice);
                flag = 0;

                updateproduct();

            }
            sum=sum + totprice;
            TotAmount.Text = "Rs"+sum.ToString();
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
