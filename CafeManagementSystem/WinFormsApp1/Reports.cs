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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            PopulateListView1();
            PopulateListView2();
            PopulateListView3();
            PopulateListView4();
            PopulateListView5();
            PopulateListView6();
            PopulateListView7();
            PopulateListView8();
            PopulateListView9();

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");
        private void PopulateListView1()
        {
            try
            {
                listView1.Items.Clear();
                conn.Open();
                //2 Table Join # 2
                string query = "Select SU.U_name, SU.U_email, C.no_of_orders from Customer C\r\njoin SystemUser SU on SU.U_id = C.customer_id ";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["U_name"].ToString());
                            item.SubItems.Add(reader["U_email"].ToString());
                            item.SubItems.Add(reader["no_of_orders"].ToString());
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
        private void PopulateListView2()
        {
            try
            {
                listView2.Items.Clear();

                conn.Open();
                //Nested Subquery # 1
                String query = "select o.order_id, o.order_date, o.order_status, o.order_amount, su.u_name, o.order_note\r\nfrom \r\n  orders o \r\njoin \r\n    customer c on c.customer_id = o.fk_customer_id\r\njoin \r\n    systemuser su on su.u_id = c.customer_id;\r\n";
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
        private void PopulateListView3()
        {
            try
            {
                listView3.Items.Clear();

                conn.Open();
                // 2 Table Join # 3
                string query = "Select SU.U_name, SU.U_email, W.Schedule from Worker W\r\njoin SystemUser SU on SU.U_id = W.worker_id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["U_name"].ToString());
                            item.SubItems.Add(reader["U_email"].ToString());
                            item.SubItems.Add(reader["Schedule"].ToString());
                            listView3.Items.Add(item);
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
        private void PopulateListView4()
        {
            try
            {
                listView4.Items.Clear();

                conn.Open();
                // 2 Table Join # 4
                string query = " select I.inventory_item_name, I.Quantity, MI.mn_name from inventory I\r\n join Menuitem MI on MI.PK_menuitem_id = I.FK_menultem_id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["inventory_item_name"].ToString());
                            item.SubItems.Add(reader["Quantity"].ToString());
                            item.SubItems.Add(reader["mn_name"].ToString());
                            listView4.Items.Add(item);
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
        private void PopulateListView5()
        {
            try
            {
                listView5.Items.Clear();

                conn.Open();

                string query = "SELECT PK_menuitem_id, mn_name, mn_price, mn_description, m_Availability, Category FROM Menuitem";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem("    " + reader["PK_menuitem_id"].ToString());
                            item.SubItems.Add(reader["mn_name"].ToString());
                            item.SubItems.Add(reader["mn_price"].ToString());
                            item.SubItems.Add(reader["mn_description"].ToString());
                            item.SubItems.Add(reader["m_Availability"].ToString());
                            item.SubItems.Add(reader["Category"].ToString());

                            listView5.Items.Add(item);
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
        private void PopulateListView6()
        {
            try
            {
                listView6.Items.Clear();

                conn.Open();

                //Aggregate with group by(with having) query # 1
                //3 table join # 6
                string query = "\r\nselect C.customer_id, Su.U_name, count(O.order_id) as num_orders\r\nfrom Customer C\r\njoin Orders O on O.FK_Customer_id = C.customer_id\r\njoin SystemUser SU on SU.U_id = C.customer_id\r\ngroup by C.customer_id, SU.U_name\r\nhaving count(O.order_id) > 1\r\n;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem("    " + reader["customer_id"].ToString());
                            item.SubItems.Add(reader["U_name"].ToString());
                            item.SubItems.Add(reader["num_orders"].ToString());
                            listView6.Items.Add(item);
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
        private void PopulateListView7()
        {
            try
            {
                listView7.Items.Clear();

                conn.Open();

                //Aggregate with group by(with having) query # 2
                //3 table join # 6
                string query = "select c.customer_id, SU.U_name,  sum(o.order_amount) as total_order_amount\r\nfrom customer c\r\njoin orders o on c.customer_id = o.fk_customer_id\r\njoin SystemUser SU on SU.U_id = C.customer_id\r\ngroup by c.customer_id,SU.U_name\r\nhaving sum(o.order_amount) > 1000;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem("    " + reader["customer_id"].ToString());
                            item.SubItems.Add(reader["U_name"].ToString());
                            item.SubItems.Add(reader["total_order_amount"].ToString());
                            listView7.Items.Add(item);
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

        private void PopulateListView8()
        {
            try
            {
                listView8.Items.Clear();

                conn.Open();

                //Aggregate with group by(with having) query # 3
                string query = "select o.fk_worker_id, count(o.order_id) as num_orders, sum(o.order_amount) as avg_order_amount\r\nfrom orders o\r\ngroup by o.fk_worker_id\r\nhaving count(o.order_id) > 10  and fk_worker_id is not null;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem("    " + reader["fk_worker_id"].ToString());
                            item.SubItems.Add(reader["num_orders"].ToString());
                            item.SubItems.Add(reader["avg_order_amount"].ToString());
                            listView8.Items.Add(item);
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
        private void PopulateListView9()
        {
            try
            {
                listView9.Items.Clear();

                conn.Open();

                //Aggregate with group by(with having) query # 4
                string query = "select oi.fk_menuitem_id, mi.mn_name, count(oi.pk_orderitem_id) as num_orders\r\nfrom orderitem oi\r\njoin Menuitem mi on mi.PK_menuitem_id = oi.FK_menuitem_id\r\ngroup by oi.fk_menuitem_id, mi.mn_name\r\nhaving count(oi.pk_orderitem_id) > 0\r\norder by num_orders asc;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem("    " + reader["fk_menuitem_id"].ToString());
                            item.SubItems.Add(reader["mn_name"].ToString());
                            item.SubItems.Add(reader["num_orders"].ToString());
                            listView9.Items.Add(item);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void listView6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
