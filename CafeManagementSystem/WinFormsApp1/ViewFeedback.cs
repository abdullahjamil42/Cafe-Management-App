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
    public partial class ViewFeedback : Form
    {
        public ViewFeedback()
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
                // 3 table join
                String query = "select O.Order_id, O.order_date, F.Feedback, O.Order_amount, Feedback_rating, O.order_note\r\nfrom Orders O \r\njoin Customer C on C.customer_id = O.FK_Customer_id \r\njoin SystemUser SU on SU.U_id = C.customer_id \r\njoin Feedback F on F.order_id = O.Order_id\r\nwhere C.customer_id = " + CustomerLogin1.customerId + " and O.order_status = 'Ready' and F.Feedback_id is not null";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["Order_id"].ToString());
                            item.SubItems.Add(reader["order_date"].ToString());
                            item.SubItems.Add(reader["Feedback"].ToString());
                            item.SubItems.Add(reader["Order_amount"].ToString());
                            item.SubItems.Add(reader["Feedback_rating"].ToString());
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFrontPage customerFrontPage = new CustomerFrontPage();
            customerFrontPage.Show();
        }

        private void SubmitFeedback_Click(object sender, EventArgs e)
        {

        }
    }
}
