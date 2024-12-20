using System;
using System.Collections;
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
    public partial class UpdateMenu : Form
    {
        public UpdateMenu()
        {
            InitializeComponent();
            PopulateListView();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void PopulateListView()
        {
            listView1.Items.Clear();
            ImageList img = new ImageList();
            img.ImageSize = new Size(150, 150);
            String[] paths = { };
            paths = Directory.GetFiles("D:/New folder");
            try
            {
                conn.Open();
                string query = "SELECT mn_name, mn_price, mn_description, m_Availability, Category, Picture FROM Menuitem";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            byte[] imageData = (byte[])reader["Picture"];

                            ListViewItem item = new ListViewItem(reader["mn_name"].ToString());
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
                foreach (string path in paths)
                {
                    img.Images.Add(Image.FromFile(path));
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
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }
        private void backbutton_Click(object sender, EventArgs e)
        {
            AdminFrontPage adminFrontPage = new AdminFrontPage();
            adminFrontPage.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void SideBar_Tick(object sender, EventArgs e)
        {
        }
        private void UpdateMenuItems_Click(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
        }
        private void SideBar_Paint(object sender, PaintEventArgs e)
        {
        }
        private void updatebutton_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.CheckedItems[0];
                string itemName = selectedItem.Text;
                string updatedName = UpdatedItemName.Text;
                decimal updatedPrice = Convert.ToDecimal(UpdatedItemPrice.Text);
                string updatedDescription = UpdatedItemDescription.Text;
                string updatedAvailability = UpdatedItemAvailability.Text;
                string updatedCategory = UpdatedItemCategory.Text;

                try
                {
                    conn.Open();
                    //curd operation 15
                    string updateQuery = "UPDATE Menuitem SET mn_name = @updatedName, mn_price = @updatedPrice, mn_description = @updatedDescription, m_Availability = @updatedAvailability, Category = @updatedCategory WHERE mn_name = @itemName";
                    using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@updatedName", updatedName);
                        cmd.Parameters.AddWithValue("@updatedPrice", updatedPrice);
                        cmd.Parameters.AddWithValue("@updatedDescription", updatedDescription);
                        cmd.Parameters.AddWithValue("@updatedAvailability", updatedAvailability);
                        cmd.Parameters.AddWithValue("@updatedCategory", updatedCategory);
                        cmd.Parameters.AddWithValue("@itemName", itemName);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item updated successfully");
                        conn.Close();
                        listView1.Items.Clear();
                        PopulateListView();
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
            else if (listView1.CheckedItems.Count > 1)
            {
                MessageBox.Show("Please Select Only 1 item");
            }
            else
            {
                MessageBox.Show("Please select an item to update.");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DeleteSelected_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        conn.Open();

                        // Loop through the checked items in the ListView
                        foreach (ListViewItem item in listView1.CheckedItems)
                        {
                            string itemName = item.Text;

                            // Delete the item from the database
                            //curd operation 16
                            string deleteQuery = "DELETE FROM Menuitem WHERE mn_name = @itemName";
                            using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@itemName", itemName);
                                cmd.ExecuteNonQuery();
                            }

                            // Remove the item from the ListView
                            listView1.Items.Remove(item);
                        }

                        MessageBox.Show("Selected item(s) deleted successfully.");
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
            }
            else
            {
                MessageBox.Show("Please select item(s) to delete.");
            }
        }

    }
}
