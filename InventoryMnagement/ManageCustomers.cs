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
                Users.DataSource = ds.Tables[0];
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
    }
}
