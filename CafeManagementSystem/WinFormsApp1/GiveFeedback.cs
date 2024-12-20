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
    public partial class GiveFeedback : Form
    {
        private int selectedOrderId = -1;  

        public GiveFeedback()
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
                conn.Close();
                conn.Open();
                // 4 table join # 2
                String query = "select O.Order_id, O.order_date, O.order_status, O.Order_amount, SU.U_name, O.order_note\r\nfrom Orders O \r\njoin Customer C on C.customer_id = O.FK_Customer_id \r\njoin SystemUser SU on SU.U_id = C.customer_id \r\njoin Feedback F on F.order_id = O.Order_id\r\nwhere C.customer_id = " + CustomerLogin1.customerId + " and O.order_status = 'Ready' and F.Feedback is   null";

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFrontPage customerFrontPage = new CustomerFrontPage();
            customerFrontPage.Show();
        }

        private void SubmitFeedback_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int orderId = 0;
                foreach (ListViewItem item in listView2.CheckedItems)
                {
                    orderId = int.Parse(item.SubItems[0].Text.Trim());
                    break;  
                }
                if (orderId == 0)
                {
                    MessageBox.Show("Please select an order to submit feedback.");
                    return;
                }

                if (orderId > 0)
                {
                    int feedbackRating = RatingComboBox.SelectedIndex + 1;  
                    string feedbackText = Feedback.Text.Trim();
                    DateTime feedbackDate = DateTime.Now;
                    //curd operation # 9
                    string insertQuery = "INSERT INTO Feedback (customer_id, order_id, Feedback_date, Feedback_rating, Feedback) " +
                                         "VALUES (@CustomerId, @OrderId, @FeedbackDate, @FeedbackRating, @FeedbackText)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", CustomerLogin1.customerId);
                        cmd.Parameters.AddWithValue("@OrderId", orderId);
                        cmd.Parameters.AddWithValue("@FeedbackDate", feedbackDate);
                        cmd.Parameters.AddWithValue("@FeedbackRating", feedbackRating);
                        cmd.Parameters.AddWithValue("@FeedbackText", feedbackText);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Feedback submitted successfully.");
                    PopulateListView2();
                    conn.Close();
                    RatingComboBox.SelectedIndex = -1;
                    Feedback.Text = "";
               
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


        private void listView2_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
            {
                selectedOrderId = Convert.ToInt32(e.Item.SubItems[0].Text);
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GiveFeedback_Load(object sender, EventArgs e)
        {

        }
    }
}
