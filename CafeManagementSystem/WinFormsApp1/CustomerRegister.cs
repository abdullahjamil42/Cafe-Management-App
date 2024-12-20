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
    public partial class CustomerRegister : Form
    {
        public CustomerRegister()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");
        private void CustomerRegisterUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerCreateAcc_Click(object sender, EventArgs e)
        {

            {
                if (CustomerRegisterUN.Text != "" && CustomerRegisterPass.Text != " " && CustomerRegisterPass2.Text != "" && CustomerRegisterEmail.Text != "")//&& TermsAndConditions.Checked == true)
                {
                    if (CustomerRegisterPass.Text == CustomerRegisterPass2.Text)
                    {
                        if (CustomerTermsAndConditions.Checked)
                        {
                            conn.Close();
                            conn.Open();
                            //curd # 8
                            string insertQuery = "INSERT INTO SystemUser (U_name, U_email, U_password, U_role) VALUES (@U_name, @U_email, @U_password, @U_role)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@U_name", CustomerRegisterUN.Text);
                                cmd.Parameters.AddWithValue("@U_email", CustomerRegisterEmail.Text);
                                cmd.Parameters.AddWithValue("@U_password", CustomerRegisterPass.Text);
                                cmd.Parameters.AddWithValue("@U_role", "Customer");

                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Registered Successfully");
                                CustomerRegisterUN.Text = "";
                                CustomerRegisterEmail.Text = "";
                                CustomerRegisterPass.Text = "";
                                CustomerRegisterPass2.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Agree to the Terms and Conditions");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password doesn't match");
                    }
                }
                else
                {
                    MessageBox.Show("One or More Details Entered is incorrect");
                }
            }
        }
        private void CustomerRegister_Load(object sender, EventArgs e)
        {

        }

        private void CustomerTermsAndConditions_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
