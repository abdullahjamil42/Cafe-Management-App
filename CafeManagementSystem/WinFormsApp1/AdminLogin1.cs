using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Data.SqlClient;
using System.Configuration;

namespace WinFormsApp1
{
    public partial class AdminLogin1 : Form
    {
        public AdminLogin1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
            this.Hide();    

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            String email, Password;
            email = AdminUserName.Text;
            Password = AdminPassword.Text;

            String Query = "Select * from SystemUser where U_email = '" + AdminUserName.Text + "'and U_password = '" + AdminPassword.Text + "'and U_role = 'Admin'; ";
            SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            if (dtable.Rows.Count > 0)
            {
                email = AdminUserName.Text;
                Password = AdminPassword.Text;
                this.Hide();
                AdminFrontPage front = new AdminFrontPage();
                front.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid Details");
            }

        }

        private void AdminPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminRegister RegisterPage = new AdminRegister();
            RegisterPage.ShowDialog();
        }

        private void AdminLogin1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
