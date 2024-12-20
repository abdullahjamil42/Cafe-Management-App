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
    public partial class StaffLogin1 : Form
    {

        public StaffLogin1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");
        public static int StaffId;

        private void StaffLogin1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = StaffLoginName.Text;
            string password = StaffLoginPass.Text;
            string query = "SELECT U_id FROM SystemUser WHERE U_email = @email AND U_password = @Password AND U_role = 'Worker';";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@Password", password);

                conn.Open();
                object result = command.ExecuteScalar();
                conn.Close();

                if (result != null)
                {
                    StaffId = Convert.ToInt32(result);
                    this.Hide();
                    StaffFrontPage staffFrontPage = new StaffFrontPage();
                    staffFrontPage.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }
            }
        }

        private void StaffRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffRegister customerRegister = new StaffRegister();
            customerRegister.Show();
            this.Hide();
        }

        private void CustomerRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StaffRegister staffRegister = new StaffRegister();
            staffRegister.Show();
            // this.Hide();  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}

