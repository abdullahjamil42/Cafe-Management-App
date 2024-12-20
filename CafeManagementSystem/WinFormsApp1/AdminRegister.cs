using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WinFormsApp1
{
    public partial class AdminRegister : Form
    {
        public AdminRegister()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");

        private void AdminRegisterUN_TextChanged(object sender, EventArgs e)
        {

        }

        private void TermsAndConditions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AdminCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (AdminRegisterUN.Text != "" && AdminRegisterPass.Text != " " && AdminRegisterPass2.Text != "" && AdminRegisterEmail.Text != "")//&& TermsAndConditions.Checked == true)
                {
                    if (AdminRegisterPass.Text == AdminRegisterPass2.Text)
                    {
                        if (TermsAndConditions.Checked)
                        {
                            conn.Open();
                            //curd operation # 3
                            string insertQuery = "INSERT INTO SystemUser (U_name, U_email, U_password, U_role) VALUES (@U_name, @U_email, @U_password, @U_role)";

                            using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                            {
                                cmd.Parameters.AddWithValue("@U_name", AdminRegisterUN.Text);
                                cmd.Parameters.AddWithValue("@U_email", AdminRegisterEmail.Text);
                                cmd.Parameters.AddWithValue("@U_password", AdminRegisterPass.Text);
                                cmd.Parameters.AddWithValue("@U_role", "Admin");

                                cmd.ExecuteNonQuery();
                                conn.Close();
                                MessageBox.Show("Registered Successfully");
                                AdminRegisterUN.Text = "";
                                AdminRegisterEmail.Text = "";
                                AdminRegisterPass.Text = "";
                                AdminRegisterPass2.Text = "";
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

        private void AdminRegister_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
