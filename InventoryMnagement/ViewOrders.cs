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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\senud\Desktop\practise division\InventoryMnagement\InventoryMnagement\inventorydb.mdf"";Integrated Security=True;Connect Timeout=30");
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populateOrders()
        {
            try
            {
                con.Open();

                string query = "select * from OrderTbl";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ViewOrderGv.DataSource = ds.Tables[0];
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {

            populateOrders();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ViewOrderGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(printPreviewDialog1.ShowDialog() == DialogResult.OK) {
                printDocument1.Print(); 
            }
               
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                if (ViewOrderGv.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to print.");
                    return;
                }

                var row = ViewOrderGv.SelectedRows[0];

                e.Graphics.DrawString("Order Details", new Font("Arial", 20, FontStyle.Bold), Brushes.Blue, new Point(230, 20));
                e.Graphics.DrawString("Order ID: " + row.Cells[0].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, 100));
                e.Graphics.DrawString("Customer Name: " + row.Cells[1].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, 140));
                e.Graphics.DrawString("Order Date: " + row.Cells[2].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, 180));
                e.Graphics.DrawString("Total Amount: " + row.Cells[3].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(100, 220));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
    }
}
