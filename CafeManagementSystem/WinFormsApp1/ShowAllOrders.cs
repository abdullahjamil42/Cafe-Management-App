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

namespace WinFormsApp1
{
    public partial class ShowAllOrders : Form
    {
        public ShowAllOrders()
        {
            InitializeComponent();
            PopulateListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void PopulateListView()
        {
            listView1.Items.Clear();
            try
            {
                conn.Open();
                //nested Subquery # 2
                String query = "select O.FK_worker_id, O.Order_id, O.order_date, O.order_status, O.Order_amount, SU.U_name, O.order_note " +
               "from Orders O " +
               "join Customer C ON C.customer_id = O.FK_Customer_id " +
               "join SystemUser SU ON SU.U_id = C.customer_id " +
               "where O.Order_id IN (select O2.Order_id " +
                                    "from Orders O2 " +
                                    "where O2.FK_worker_id IS NULL AND O2.order_status = 'pending')";

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
                conn.Close();
            }
        }

        private void AcceptOrder_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.Checked)
                    {
                        string orderId = item.SubItems[0].Text;
                        //curd operation # 13
                        string insertQuery = "INSERT INTO WorkerOrder (worker_id, order_id) VALUES (@WorkerId, @OrderId)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@WorkerId", StaffLogin1.StaffId);
                            cmd.Parameters.AddWithValue("@OrderId", orderId);
                            cmd.ExecuteNonQuery();
                        }

                        //curd operation # 14
                        string updateQuery = "UPDATE Orders SET FK_Worker_id = @WorkerId WHERE Order_id = @OrderId";
                        using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@WorkerId", StaffLogin1.StaffId);
                            cmd.Parameters.AddWithValue("@OrderId", orderId);
                            cmd.ExecuteNonQuery();
                        }

                        listView1.Items.Remove(item);
                    }
                }

                MessageBox.Show("Selected orders accepted successfully and assigned to worker.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            StaffFrontPage staffFrontPage = new StaffFrontPage();
            staffFrontPage.Show();
            this.Hide();  

        }
        bool itemcheck = false;
        public static int orderId;
        public static int orderDetailsParent;
        private void ShowOrderDetails_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Checked)
                {
                    string orderID = item.SubItems[0].Text;
                    string selectedItem = item.SubItems[0].Text;
                    orderId = int.Parse(selectedItem);
                    orderDetailsParent = 1;
                    OrderDetails orderDetails = new OrderDetails();
                    orderDetails.Show();
                    this.Hide();
                    itemcheck = true;
                }
               
            }
            if (itemcheck == false)
            {
                MessageBox.Show("Please select an order to view its details.");
            }
        }



        private void ShowAllOrders_Load(object sender, EventArgs e)
        {


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


