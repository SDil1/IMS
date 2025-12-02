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
    public partial class ManageCatagorises : Form
    {
        public ManageCatagorises()
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

                string query = "select * from CategoryTbl";
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
                    "INSERT INTO CategoryTbl (CatId, CatName) VALUES ('"
                    + CatId.Text + "', '"
                    + CatName.Text + "')",
                con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Added Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();
        }

        private void ManageCatagorises_Load(object sender, EventArgs e)
        {

            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (CatId.Text == "")
            {
                MessageBox.Show("Enter The Categoy To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from CategoryTbl where CatId='" + CatId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Category Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = Users.Rows[e.RowIndex];

                CatId.Text = row.Cells["CatId"].Value.ToString();
                CatName.Text = row.Cells["CatName"].Value.ToString();
                
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                    "UPDATE CategoryTbl SET CatName = '" + CatName.Text +
                    "' WHERE CatId = '" + CatId.Text + "'",
                    con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully");
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
