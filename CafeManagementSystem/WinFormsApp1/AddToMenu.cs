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
using System.IO;

namespace WinFormsApp1
{
    public partial class AddToMenu : Form
    {
        public AddToMenu()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-U2AT20C\SQLEXPRESS;Initial Catalog=DBFINAL;Integrated Security=True;Encrypt=False;");
        private void AddItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddItemName.Text != "" && AddItemPrice.Text != "" && AddItemDescription.Text != "" && AddItemAvailability.Text != "" && AddItemCategory.Text != "")
                {
                    conn.Open();
                    //Curd operation # 2
                    string insertQuery = "INSERT INTO Menuitem (mn_name, mn_price, mn_description, m_Availability, Category, Picture) VALUES (@mn_name, @mn_price, @mn_description, @m_Availability, @Category, @Picture)";
                    string imageFilePath = @"" + ImageAddress.Text;
                    byte[] imageBytes = File.ReadAllBytes(imageFilePath);

                    using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@mn_name", AddItemName.Text);
                        cmd.Parameters.AddWithValue("@mn_price", Convert.ToDecimal(AddItemPrice.Text));
                        cmd.Parameters.AddWithValue("@mn_description", AddItemDescription.Text);
                        cmd.Parameters.AddWithValue("@m_Availability", AddItemAvailability.Text);
                        cmd.Parameters.AddWithValue("@Category", AddItemCategory.Text);
                        cmd.Parameters.AddWithValue("@Picture", imageBytes);


                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Item added successfully");
                        AddItemName.Text = "";
                        AddItemPrice.Text = "";
                        AddItemDescription.Text = "";
                        AddItemCategory.Text = "";
                        AddItemAvailability.Text = "";
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
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateItems_Load(object sender, EventArgs e)
        {

        }

        private void AddItemDescription1_Click(object sender, EventArgs e)
        {

        }

        private void BrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All Files (*.*)|*.*";
            openFileDialog1.Title = "Select an Image File";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string imagePath = openFileDialog1.FileName;
                ImageAddress.Text = imagePath;
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {

            AdminFrontPage screen = new AdminFrontPage();
            screen.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AddItemPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
