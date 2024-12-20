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
    public partial class CustomerFrontPage : Form
    {
        public CustomerFrontPage()
        {
            InitializeComponent();
            PopulateListView();
            HideIcons();
            SetCartID();
            comboBox1.Text = "Food";
        }
        bool SideBarExpanded;
        int id = CustomerLogin1.customerId;
        private void HideIcons()
        {
            pictureBox1.Hide();
            //pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox6.Hide();
            //pictureBox7.Hide();
            pictureBox5.Hide();
            pictureBox9.Hide();
        }

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (SideBarExpanded)
            {
                SideBar.Width -= 10;
                pictureBox1.Hide();
                pictureBox2.Show();
                //pictureBox3.Hide();
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox6.Hide();
                //pictureBox7.Hide();
                pictureBox9.Hide();


                if (SideBar.Width <= 48)
                {
                    SideBarExpanded = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                pictureBox1.Show();
                pictureBox2.Show();
                //pictureBox3.Show();
                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox6.Show();
                //pictureBox7.Show();
                pictureBox9.Show();


                if (SideBar.Width >= 228)
                {
                    SideBarExpanded = true;
                    SideBarTimer.Stop();
                }
            }
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        //private void PopulateListView()
        //{
        //    listView1.Items.Clear();
        //    try
        //    {
        //        conn.Open();
        //        string query = "SELECT PK_menuitem_id, mn_name, mn_price, mn_description, m_Availability, Category, Picture FROM Menuitem";
        //        using (SqlCommand command = new SqlCommand(query, conn))
        //        {
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                while (reader.Read())
        //                {
        //                    byte[] imageData = (byte[])reader["Picture"];
        //                    ListViewItem item = new ListViewItem("    " + reader["PK_menuitem_id"].ToString());
        //                    item.SubItems.Add(reader["mn_name"].ToString());
        //                    item.SubItems.Add(reader["mn_price"].ToString());
        //                    item.SubItems.Add(reader["mn_description"].ToString());
        //                    item.SubItems.Add(reader["Category"].ToString());
        //                    item.SubItems.Add(reader["m_Availability"].ToString());

        //                    Image image;
        //                    using (MemoryStream ms = new MemoryStream(imageData))
        //                    {
        //                        image = Image.FromStream(ms);
        //                    }

        //                    imageList1.Images.Add(image);
        //                    item.ImageIndex = imageList1.Images.Count - 1;
        //                    listView1.Items.Add(item);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        private void PopulateListView()
        {
            listView1.Items.Clear();
            try
            {
                conn.Open();

                string selectedMenuType = comboBox1.SelectedItem.ToString();
                string query = "SELECT PK_menuitem_id, mn_name, mn_price, mn_description, m_Availability, Category, Picture FROM Menuitem WHERE Category = @MenuType";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@MenuType", selectedMenuType);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Picture"];
                            ListViewItem item = new ListViewItem("    " + reader["PK_menuitem_id"].ToString());
                            item.SubItems.Add(reader["mn_name"].ToString());
                            item.SubItems.Add(reader["mn_price"].ToString());
                            item.SubItems.Add(reader["mn_description"].ToString());
                            item.SubItems.Add(reader["Category"].ToString());
                            item.SubItems.Add(reader["m_Availability"].ToString());

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
               // MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void PopulateSearchListView(string searchTerm)
        {
            listView1.Items.Clear();

            try
            {
                conn.Open();

                string query = "SELECT PK_menuitem_id, mn_name, mn_price, mn_description, m_Availability, Category, Picture " +
                               "FROM Menuitem WHERE mn_name LIKE '%' + @SearchTerm + '%'";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Picture"];

                            ListViewItem item = new ListViewItem("    " + reader["PK_menuitem_id"].ToString());
                            item.SubItems.Add(reader["mn_name"].ToString());
                            item.SubItems.Add(reader["mn_price"].ToString());
                            item.SubItems.Add(reader["mn_description"].ToString());
                            item.SubItems.Add(reader["m_Availability"].ToString());
                            item.SubItems.Add(reader["Category"].ToString());


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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void CustomerFrontPage_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.FindStringExact("Food");
        }
        void SetCartID()
        {
            string query = "SELECT PK_Cart_id FROM Cart WHERE FK_customer_id = @CustomerId";
            conn.Open();
            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@CustomerId", id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        cartId = reader.GetInt32(0);
                        Console.WriteLine("Cart_id: " + cartId);
                    }
                    else
                    {

                    }
                }
            }
            conn.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        public static int cartId = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                conn.Open();
                try
                {
                    //curd operation # 5
                    string insertQuery = "INSERT INTO Cart (FK_customer_id) VALUES (@CustomerId)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerId", id);
                        cmd.ExecuteNonQuery();

                    }
                }
                catch
                { }

                string query = "SELECT PK_Cart_id FROM Cart WHERE FK_customer_id = @CustomerId";

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@CustomerId", id);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cartId = reader.GetInt32(0);
                            Console.WriteLine("Cart_id: " + cartId);
                        }
                        else
                        {

                        }
                    }
                }
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    string menuItemId = item.SubItems[0].Text;
                    string checkQuery = "SELECT COUNT(*) FROM Cartitem WHERE FK_menultem_id = @MenuId AND FK_cart_id = @CartId";
                    using (SqlCommand cmdCheck = new SqlCommand(checkQuery, conn))
                    {
                        cmdCheck.Parameters.AddWithValue("@MenuId", menuItemId);
                        cmdCheck.Parameters.AddWithValue("@CartId", cartId);
                        int count = (int)cmdCheck.ExecuteScalar();

                        if (count == 0)
                        {
                            //Curd # 6
                            string insertCartItemQuery = "INSERT INTO Cartitem (FK_cart_id, FK_menultem_id) VALUES (@CartId, @MenuId)";
                            using (SqlCommand cmdInsertCartItem = new SqlCommand(insertCartItemQuery, conn))
                            {
                                cmdInsertCartItem.Parameters.AddWithValue("@CartId", cartId);
                                cmdInsertCartItem.Parameters.AddWithValue("@MenuId", menuItemId);
                                cmdInsertCartItem.ExecuteNonQuery();
                            }
                        }
                        else
                        {
                            //curd # 7
                            string updateCartItemQuery = "UPDATE Cartitem SET Quantity = Quantity + 1 WHERE FK_menultem_id = @MenuId AND FK_cart_id = @CartId";
                            using (SqlCommand cmdUpdateCartItem = new SqlCommand(updateCartItemQuery, conn))
                            {
                                cmdUpdateCartItem.Parameters.AddWithValue("@MenuId", menuItemId);
                                cmdUpdateCartItem.Parameters.AddWithValue("@CartId", cartId);
                                cmdUpdateCartItem.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Items added to cart successfully");


                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select an item to proceed");
            }
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = Search.Text;
            PopulateSearchListView(a);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 form = new Form1();
            form.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();

        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ShowAllAcceptedOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Cart cart = new Cart();
            cart.ShowDialog();
            this.Hide();
        }

        private void ShowAllOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerOrderHistory customerOrderHistory = new CustomerOrderHistory();
            customerOrderHistory.ShowDialog();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiveFeedback givef = new GiveFeedback();
            givef.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Hide();
            GiveFeedback givef = new GiveFeedback();
            givef.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewFeedback viewFeedback = new ViewFeedback();
            viewFeedback.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            this.Hide();

            ViewFeedback viewFeedback = new ViewFeedback();
            viewFeedback.Show();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateListView();

        }
    }
}
