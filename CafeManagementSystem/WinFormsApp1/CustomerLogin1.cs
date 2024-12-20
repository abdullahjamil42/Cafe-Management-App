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

    public partial class CustomerLogin1 : Form
    {
        public static int customerId;
        public static int CartId;
        public CustomerLogin1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");


        private void CostumerLogin1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();  

        }
 
        private void CustomerLogin_Click(object sender, EventArgs e)
        {
            string Email = CustomerUserName.Text;
            string password = CustomerPassword.Text;
            string query = "SELECT U_id FROM SystemUser WHERE U_email = @Email AND U_password = @Password AND U_role = 'Customer';";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Email", Email);
                command.Parameters.AddWithValue("@Password", password);

                conn.Open();
                object result = command.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    customerId = Convert.ToInt32(result);
                    string queryCartId = "SELECT PK_Cart_id FROM Cart WHERE FK_customer_id = @CustomerId;";
                    using (SqlCommand commandCartId = new SqlCommand(queryCartId, conn))
                    {
                        commandCartId.Parameters.AddWithValue("@CustomerId", customerId);
                        conn.Open();
                        object resultCartId = commandCartId.ExecuteScalar();
                        conn.Close();
                        CartId = Convert.ToInt32(resultCartId);
                        this.Hide();

                        CustomerFrontPage front = new CustomerFrontPage();
                        front.ShowDialog();

                    }
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerRegister RegisterPage = new CustomerRegister();         
            RegisterPage.ShowDialog();  
        }
    }
}
