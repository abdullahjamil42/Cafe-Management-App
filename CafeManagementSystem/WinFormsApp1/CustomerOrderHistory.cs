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
    public partial class CustomerOrderHistory : Form
    {
        public CustomerOrderHistory()
        {
            InitializeComponent();
            PopulateListView2();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void PopulateListView2()
        {
            listView2.Items.Clear();
            try
            {
                conn.Open();
                //3 table join # 2
                String query = "SELECT O.FK_worker_id, O.Order_id, O.order_date, O.order_status, O.Order_amount, SU.U_name, O.order_note\r\nFROM Orders O \r\nJOIN Customer C ON C.customer_id = O.FK_Customer_id \r\nJOIN SystemUser SU ON SU.U_id = C.customer_id where customer_id = " + CustomerLogin1.customerId;

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

                            listView2.Items.Add(item);
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
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CustomerOrderHistory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomerFrontPage customerFrontPage = new CustomerFrontPage();
            customerFrontPage.Show();
            this.Hide();
        }
    }
}
