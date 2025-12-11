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
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\senud\Desktop\practise division\InventoryMnagement\InventoryMnagement\inventorydb.mdf"";Integrated Security=True;");



        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCustomer_Load(object sender, EventArgs e)
        {

            populate();
        }

        void populate()
        {
            try
            {
                con.Open();

                string query = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                customer.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "INSERT INTO CustomerTbl (custId,custName, custPhone) VALUES ('"
                + custId.Text + "', '"
                + custname.Text + "', '"
                + custphone.Text + "')",
                con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Added Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (custId.Text == "")
            {
                MessageBox.Show("Enter The Customer To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from CustomerTbl where custId='" + custId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = customer.Rows[e.RowIndex];

               custId.Text = row.Cells["custId"].Value.ToString();
               custname.Text = row.Cells["custName"].Value.ToString();
               custphone.Text = row.Cells["custPhone"].Value.ToString();
               con.Open();

                SqlDataAdapter sda=new SqlDataAdapter("select count(*) from OrderTbl where custId='" + custId.Text + "'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                orderslb.Text = dt.Rows[0][0].ToString();

                
                SqlDataAdapter sda1 = new SqlDataAdapter("select Sum(TotalAmount) from OrderTbl where custId='" + custId.Text + "'", con);
                DataTable dt1 = new DataTable();
                sda1.Fill(dt1);
                amountlb.Text = dt1.Rows[0][0].ToString();

                SqlDataAdapter sda2 = new SqlDataAdapter("select Max(OrderDate) from OrderTbl where custId='" + custId.Text + "'", con);
                DataTable dt2 = new DataTable();
                sda2.Fill(dt2);
                datelb.Text = dt2.Rows[0][0].ToString();


                con.Close();


            }
            else
            {
                MessageBox.Show("Please select a valid row.");
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE CustomerTbl SET custId = '" + custId.Text +
                    "', custname = '" + custname.Text +
                    
                     "' WHERE custPhone = '" + custphone.Text + "'",
                     con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer details Updated Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();
        }

        private void home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
