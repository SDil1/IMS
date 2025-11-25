using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace InventoryMnagement
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\senud\Desktop\practise division\InventoryMnagement\InventoryMnagement\inventorydb.mdf"";Integrated Security=True;");
      

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
               
                string query = "select * from UserTbl";
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
                    "INSERT INTO UserTbl (UfullName, Uname, UPassword, UPhone) VALUES ('"
                    + Ufullname.Text + "', '"
                    + Uname.Text + "', '"
                    + Upassword.Text + "', '"
                    + Uphone.Text + "')",
                con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("User Added Successfully");
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
                    "UPDATE UserTbl SET UfullName = '" + Ufullname.Text +
                    "', Uname = '" + Uname.Text +
                    "', UPassword = '" + Upassword.Text +
                     "' WHERE UPhone = '" + Uphone.Text + "'",
                     con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            populate();

        }

        private void ManageUser_Load(object sender, EventArgs e)
        {

            populate();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if(Uphone.Text == "")
            {
                MessageBox.Show("Enter The User To Be Deleted");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from UserTbl where Uphone='" + Uphone.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        

        private void Users_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                DataGridViewRow row = Users.Rows[e.RowIndex];

                Ufullname.Text = row.Cells["UfullName"].Value.ToString();
                Uname.Text = row.Cells["Uname"].Value.ToString();
                Upassword.Text = row.Cells["UPassword"].Value.ToString();
                Uphone.Text = row.Cells["UPhone"].Value.ToString();
            }
        }
    }
}
