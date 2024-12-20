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
    public partial class EmpShift : Form
    {
        public EmpShift()
        {
            InitializeComponent();
            PopulateListView3();
        }

        private void EmpShift_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");
        private void PopulateListView3()
        {
            listView3.Items.Clear();
            try
            {
                conn.Open();
                // 2 Table Join # 1
                string query = "Select W.worker_id, SU.U_name, SU.U_email, W.Schedule from Worker W\r\njoin SystemUser SU on SU.U_id = W.worker_id";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["worker_id"].ToString());
                            item.SubItems.Add(reader["U_name"].ToString());
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

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFrontPage adminFrontPage = new AdminFrontPage();
            adminFrontPage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectedShift = comboBox1.SelectedItem.ToString();

            foreach (ListViewItem item in listView3.CheckedItems)
            {
                item.SubItems[3].Text = selectedShift;
                MessageBox.Show("Shift updated Successfully");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView3.CheckedItems)
            {
                string userId = item.SubItems[0].Text; 
                listView3.Items.Remove(item);
                try
                {
                    conn.Open();
                    //Curd operation # 9
                    string query = "DELETE FROM SystemUser WHERE U_id = @userId";
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@userId", userId);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }

            MessageBox.Show("Employee(s) deleted successfully");
        }

    }
}
