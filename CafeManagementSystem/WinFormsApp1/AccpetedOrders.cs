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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class AccpetedOrders : Form
    {
        public AccpetedOrders()
        {
            InitializeComponent();
            PopulateListView();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");
        private void AccpetedOrders_Load(object sender, EventArgs e)
        {
        }
        private void PopulateListView()
        {
            listView1.Items.Clear();

            try
            {
                conn.Open();
                //3 table Join # 1
                string query = "SELECT O.Order_id, O.order_date, O.order_status, O.Order_amount, SU.U_name, O.order_note\r\nFROM Orders O \r\nJOIN Customer C ON C.customer_id = O.FK_Customer_id \r\nJOIN SystemUser SU ON SU.U_id = C.customer_id\r\n where O.FK_worker_id = " + StaffLogin1.StaffId + "and order_status = 'pending'";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Order_id"].ToString());
                            item.SubItems.Add(reader["order_date"].ToString());
                            item.SubItems.Add(reader["order_status"].ToString());
                            item.SubItems.Add(reader["Order_amount"].ToString());
                            item.SubItems.Add(reader["U_name"].ToString());
                            if (!reader.IsDBNull(reader.GetOrdinal("order_note")))
                            {
                                item.SubItems.Add(reader["order_note"].ToString());
                            }
                            else
                            {
                                item.SubItems.Add("");  
                            }

                            listView1.Items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            StaffFrontPage staffFrontPage = new StaffFrontPage();
            staffFrontPage.Show();
            this.Hide();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                if (listView1.CheckedItems.Count == 0)
                {
                    MessageBox.Show("No items selected.");
                    return;
                }

                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    if (item.SubItems.Count > 0)
                    {
                        string orderId = item.SubItems[0].Text;
                        //curd operation # 1
                        string updateQuery = "UPDATE Orders SET order_status = 'Ready' WHERE Order_id = @OrderId";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@OrderId", orderId);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Status Changes to Ready.");
                        listView1.Items.Remove(item);


                    }
                    else
                    {
                        MessageBox.Show("No subitems available for the selected item.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public static int orderId;
        private void ShowOrderDetails_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    string orderID = item.SubItems[0].Text;
                    string selectedItem = item.SubItems[0].Text; 
                    orderId = int.Parse(selectedItem);
                    ShowAllOrders.orderDetailsParent = 2;
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.Show();
                    this.Hide();
                }
                else if (listView1.CheckedItems.Count == 0)
                {
                    MessageBox.Show("Please select an order to view its details.");
                }
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
