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
    public partial class Payement : Form
    {
        public Payement()
        {
            InitializeComponent();
            PopulateListView();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void listView1_ControlAdded(object sender, ControlEventArgs e)
        { }
        private void ConfirmOrder_Click(object sender, EventArgs e)
        {
            if (PayementOptions.CheckedItems.Count == 1)
            {
                try
                {
                    int customerId = CustomerLogin1.customerId;
                    int cartId = CustomerFrontPage.cartId;
                    DateTime currentDateTime = DateTime.Now;
                    int orderId = 0;

                    using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;"))
                    {
                        conn.Open();
                        //curd operation 11
                        string insertOrderQuery = "INSERT INTO Orders (order_note,order_date, Order_amount, order_status, FK_Customer_id, FK_CartID)\r\nSELECT \r\n@OrderNote, @OrderDate, \r\n SUM(MI.mn_price * CI.Quantity), \r\n'Pending',  \r\n@CustomerId, \r\n    @CartId  \r\nFROM \r\n Customer C\r\nJOIN \r\n    Cart CR ON CR.FK_customer_id = C.customer_id \r\nJOIN \r\n    Cartitem CI ON CI.FK_cart_id = CR.PK_Cart_id\r\nJOIN \r\n    Menuitem MI ON MI.PK_menuitem_id = CI.FK_menultem_id\r\nWHERE \r\n    CR.PK_Cart_id = @CartId;\r\n SELECT SCOPE_IDENTITY(); ";
                        using (SqlCommand cmd = new SqlCommand(insertOrderQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@OrderNote", textBox1.Text);
                            cmd.Parameters.AddWithValue("@OrderDate", currentDateTime);
                            cmd.Parameters.AddWithValue("@OrderStatus", "Pending");
                            cmd.Parameters.AddWithValue("@CustomerId", customerId);
                            cmd.Parameters.AddWithValue("@CartId", cartId);
                            orderId = Convert.ToInt32(cmd.ExecuteScalar());
                            MessageBox.Show("Order confirmed successfully");
                        }
                        //curd operation 12
                        string insertOrderItemQuery = "INSERT INTO Orderitem (FK_order_id, FK_menuitem_id, Quantity) SELECT @OrderId, CI.FK_menultem_id, CI.Quantity FROM Cartitem CI WHERE CI.FK_cart_id = @CartId;";
                        using (SqlCommand cmd = new SqlCommand(insertOrderItemQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@OrderId", orderId);
                            cmd.Parameters.AddWithValue("@CartId", cartId);
                            cmd.ExecuteNonQuery();
                        }
                        // curd operation 13
                        string deleteCartItemsQuery = "DELETE FROM Cartitem WHERE FK_cart_id = @CartId";
                        using (SqlCommand cmd = new SqlCommand(deleteCartItemsQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@CartId", cartId);
                            cmd.ExecuteNonQuery();
                        }
                        PopulateListView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (PayementOptions.CheckedItems.Count > 1)
            {
                MessageBox.Show("Kindly Select only one payement option");
            }
            else if (PayementOptions.CheckedItems.Count == 0)
            {
                MessageBox.Show("Kindly Select a payement method");
            }
        }
        private void PopulateListView()
        {
            listView1.Items.Clear();
            try
            {
                conn.Open();
                //4 table join # 3
                String query = "Select MI.mn_name, CI.FK_menultem_id,  MI.mn_price, CI.Quantity, (MI.mn_price * CI.Quantity) as Total_Price\r\nfrom Customer C\r\njoin Cart CR on CR.FK_customer_id = C.customer_id \r\njoin Cartitem CI on CI.FK_cart_id = CR.PK_Cart_id\r\njoin Menuitem MI on MI.PK_menuitem_id = CI.FK_menultem_id  where CR.PK_Cart_id = " + CustomerFrontPage.cartId;
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem("    " + reader["mn_name"].ToString());
                            item.SubItems.Add(reader["FK_menultem_id"].ToString());
                            item.SubItems.Add(reader["mn_price"].ToString());
                            item.SubItems.Add(reader["Quantity"].ToString());
                            item.SubItems.Add(reader["Total_Price"].ToString());
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
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        { }
        private void button1_Click(object sender, EventArgs e)
        {
            CustomerFrontPage customerFrontPage = new CustomerFrontPage();
            customerFrontPage.Show();
            this.Hide();
        }
        private void Payement_Load(object sender, EventArgs e)
        { }

        private void PayementOptions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
