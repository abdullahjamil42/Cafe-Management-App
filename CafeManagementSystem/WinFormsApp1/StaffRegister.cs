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
    public partial class StaffRegister : Form
    {
        public StaffRegister()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void StaffCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (StaffRegisterUN.Text != "" && StaffRegisterPass.Text != " " && StaffRegisterPass2.Text != "" && StaffRegisterEmail.Text != "")//&& TermsAndConditions.Checked == true)
                {
                    if (StaffRegisterPass.Text == StaffRegisterPass2.Text)
                    {
                        if (CustomerTermsAndConditions.Checked)
                        {
                            conn.Close();
                            conn.Open();
                            //curd operation 15
                            string insertQuery = "INSERT INTO SystemUser (U_name, U_email, U_password, U_role) VALUES (@U_name, @U_email, @U_password, @U_role)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@U_name", StaffRegisterUN.Text);
                                cmd.Parameters.AddWithValue("@U_email", StaffRegisterEmail.Text);
                                cmd.Parameters.AddWithValue("@U_password", StaffRegisterPass.Text);
                                cmd.Parameters.AddWithValue("@U_role", "Worker");

                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Registered Successfully");
                                StaffRegisterUN.Text = "";
                                StaffRegisterEmail.Text = "";
                                StaffRegisterPass.Text = "";
                                StaffRegisterPass2.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Agree to Terms and Conditions");
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void StaffRegister_Load(object sender, EventArgs e)
        {

        }

        private void CustomerTermsAndConditions_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
