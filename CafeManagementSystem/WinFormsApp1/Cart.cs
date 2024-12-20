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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
            PopulateListView();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void PopulateListView()
        {
            listView1.Items.Clear();
            try
            {
                conn.Open();
                //4 Table join # 1 
                string query = "  select MI.picture, CI.PK_cartitem_id, CI.Quantity, MI.mn_name, mn_price, mn_description,  (mn_price * CI.Quantity) as Total_price  from Cartitem CI join Menuitem MI on MI.PK_menuitem_id = CI.FK_menultem_id join Cart C on C.PK_Cart_id = CI.FK_cart_id join Customer Cs on Cs.customer_id = C.FK_customer_id where Cs.customer_id = " + CustomerLogin1.customerId;
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["picture"];


                            ListViewItem item = new ListViewItem("       " + reader["PK_cartitem_id"].ToString());
                            item.SubItems.Add(reader["Quantity"].ToString());
                            item.SubItems.Add(reader["mn_name"].ToString());
                            item.SubItems.Add(reader["mn_price"].ToString());
                            item.SubItems.Add(reader["mn_description"].ToString());
                            item.SubItems.Add(reader["Total_price"].ToString());
                            Image image;
                            using (MemoryStream ms = new MemoryStream(imageData))
                            {
                                image = Image.FromStream(ms);
                            }
                            imageList1.Images.Add(image);
                            item.ImageIndex = imageList1.Images.Count - 1;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerFrontPage frontPage = new CustomerFrontPage();
            frontPage.ShowDialog();
        }

        private void Cart_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payement payement = new Payement();
            payement.Show();
            this.Hide();  

        }

        private void DeleteFromCart_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    int cartItemId = int.Parse(item.SubItems[0].Text.Trim());
                    //curd operation # 4
                    string deleteQuery = "DELETE FROM Cartitem WHERE PK_cartitem_id = @CartItemId";
                    using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CartItemId", cartItemId);
                        cmd.ExecuteNonQuery();
                    }
                    listView1.Items.Remove(item);
                }

                MessageBox.Show("Selected items deleted successfully from the cart.");
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
