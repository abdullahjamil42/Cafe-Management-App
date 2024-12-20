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
    public partial class WorkerOrderHstory : Form
    {
        public WorkerOrderHstory()
        {
            InitializeComponent();
            PopulateListView2();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PopulateListView2()
        {
            listView2.Items.Clear();
            try
            {
                conn.Open();
                //3 table join # 2
                String query = "select o.fk_worker_id, o.order_id, o.order_date, o.order_status, o.order_amount, su.u_name, o.order_note\r\nfrom orders o\r\njoin worker w on w.worker_id = o.fk_worker_id\r\njoin systemuser su on su.u_id = w.worker_id\r\nwhere w.worker_id = (select worker_id from worker where worker_id = " + StaffLogin1.StaffId + ");\r\n";

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
            StaffFrontPage staffFrontPage = new StaffFrontPage();
                staffFrontPage.Show();
        }
    }
}
