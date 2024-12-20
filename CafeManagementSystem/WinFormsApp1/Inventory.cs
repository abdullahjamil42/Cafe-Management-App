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
    public partial class Inventory : Form
    {
        public Inventory()
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
                //2 table join 2
                string query = "SELECT i.PK_inventory_id, i.FK_menultem_id, i.Quantity, i.inventory_item_name, m.mn_name FROM Inventory i INNER JOIN Menuitem m ON i.FK_menultem_id = m.PK_menuitem_id;";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["PK_inventory_id"].ToString());
                            item.SubItems.Add(reader["FK_menultem_id"].ToString());
                            item.SubItems.Add(reader["Quantity"].ToString());
                            item.SubItems.Add(reader["inventory_item_name"].ToString());
                            item.SubItems.Add(reader["mn_name"].ToString());
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


        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddInventoryMenuID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddInventoryMenuID.Text != "" && AddInventoryName.Text != "" && AddInventoryQuantity.Text != "")
                {
                    conn.Open();
                    //curd operation # 10
                    string insertQuery = "INSERT INTO Inventory (FK_menultem_id, Quantity, inventory_item_name) " +
                        "VALUES(@FK_menultem_id, @Quantity, @inventory_item_name); ";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@FK_menultem_id", AddInventoryMenuID.Text);
                        cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(AddInventoryQuantity.Text));
                        cmd.Parameters.AddWithValue("@inventory_item_name", AddInventoryName.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item added successfully");
                        AddInventoryMenuID.Text = "";
                        AddInventoryName.Text = "";
                        AddInventoryQuantity.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("One or More Details Entered is incorrect");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Menu Item Does not exist");
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PopulateListView();

        }

        private void inventoryDelete_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to delete.");
                return;
            }

            foreach (ListViewItem item in listView1.SelectedItems)
            {
                int primaryKeyValue = int.Parse(item.SubItems[0].Text);  
                //curd operation # 11
                string deleteQuery = "DELETE FROM inventory WHERE PK_inventory_id = @PrimaryKeyValue";

                try
                {
                    conn.Open();
                    using (SqlCommand command = new SqlCommand(deleteQuery, conn))
                    {
                        command.Parameters.AddWithValue("@PrimaryKeyValue", primaryKeyValue);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting item: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                // Remove the item from the ListView
                listView1.Items.Remove(item);
            }

            MessageBox.Show("Selected item(s) deleted successfully.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminFrontPage adminFrontPage = new AdminFrontPage();
            adminFrontPage.Show();
            this.Hide();  

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
