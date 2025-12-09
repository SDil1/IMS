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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\senud\Desktop\practise division\InventoryMnagement\InventoryMnagement\inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");

        void populate()
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
                categories.ValueMember = "CatName";
                categories.DataSource = dt;
                searchCombo.ValueMember = "CatName";
                searchCombo.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

       
        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void ManageProducts_Load(object sender, EventArgs e)
        {
            
            fillCategory();
            
            populate();
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                 "INSERT INTO ProductTbl (ProId, ProName, ProQty, ProPrice, ProDescription, ProCategory) VALUES ('"
                    + productId.Text + "', '"
                    + productName.Text + "', '"
                    + productQty.Text + "', '"
                    + productPrice.Text + "', '"
                    + productDescription.Text + "', '"
                    + categories.SelectedValue.ToString() + "')",
                 con);


                if (categories.SelectedItem == null)
                {
                    MessageBox.Show("Please select a category!");
                    return;
                }


                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();

        }

        private void edit_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(
                "UPDATE ProductTbl SET " +
                "ProName = '" + productName.Text + "', " +
                "ProQty = '" + productQty.Text + "', " +
                "ProPrice = '" + productPrice.Text + "', " +
                "ProDescription = '" + productDescription.Text + "', " +
                "ProCategory = '" + categories.SelectedValue.ToString() + "' " +
                "WHERE ProId = '" + productId.Text + "'",
                con);



                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();
        }

        private void Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
              if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = Products.Rows[e.RowIndex];

                    productId.Text = row.Cells["ProId"].Value.ToString();
                    productName.Text = row.Cells["ProName"].Value.ToString();
                    productQty.Text = row.Cells["ProQty"].Value.ToString();
                    productPrice.Text = row.Cells["ProPrice"].Value.ToString();
                    productDescription.Text = row.Cells["ProDescription"].Value.ToString();
                    categories.SelectedValue = row.Cells["ProCategory"].Value.ToString();
               }
            

        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (productId.Text == "")
            {
                MessageBox.Show("Enter The Product To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from ProductTbl where ProId='" + productId.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
             
            filterbyCategory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
