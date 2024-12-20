using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class OrderDetails : Form
    {
        public OrderDetails()
        {

            InitializeComponent();
            PopulateListView();  
        }

        private void PopulateListView()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;"))
                {
                    conn.Open();
                    if (ShowAllOrders.orderDetailsParent == 1)
                    {
                        //3 table join 3
                        string query = "SELECT OI.Quantity, O.Order_id, MI.mn_name, MI.mn_price " +
                                       "FROM Orders O " +
                                       "JOIN Orderitem OI ON OI.FK_order_id = O.Order_id " +
                                       "JOIN Menuitem MI ON MI.PK_menuitem_id = OI.FK_menuitem_id " +
                                       "WHERE O.Order_id = " + ShowAllOrders.orderId;

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {


                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ListViewItem item = new ListViewItem(reader["Quantity"].ToString());
                                    item.SubItems.Add(reader["Order_id"].ToString());
                                    item.SubItems.Add(reader["mn_name"].ToString());
                                    item.SubItems.Add(reader["mn_price"].ToString());
                                    listView1.Items.Add(item);
                                }
                            }
                        }
                    }
                    //3 table join # 4
                    else if (ShowAllOrders.orderDetailsParent == 2)
                    {
                        string query = "SELECT OI.Quantity, O.Order_id, MI.mn_name, MI.mn_price " +
                                       "FROM Orders O " +
                                       "JOIN Orderitem OI ON OI.FK_order_id = O.Order_id " +
                                       "JOIN Menuitem MI ON MI.PK_menuitem_id = OI.FK_menuitem_id " +
                                       "WHERE O.Order_id = " + AccpetedOrders.orderId;

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {


                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    ListViewItem item = new ListViewItem(reader["Quantity"].ToString());
                                    item.SubItems.Add(reader["Order_id"].ToString());
                                    item.SubItems.Add(reader["mn_name"].ToString());
                                    item.SubItems.Add(reader["mn_price"].ToString());
                                    listView1.Items.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ShowAllOrders.orderDetailsParent == 1)
            {
                ShowAllOrders Orders = new ShowAllOrders();
                Orders.Show();
                this.Hide();    
                ShowAllOrders.orderDetailsParent = 0;
            }
            else if (ShowAllOrders.orderDetailsParent == 2)
            {
                AccpetedOrders Orders = new AccpetedOrders();
                Orders.Show();
                this.Hide();    
                ShowAllOrders.orderDetailsParent = 0;

            }
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
