using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class AdminFrontPage : Form
    {
        void HideIcons()
        {
            pictureBox4.Hide();
            pictureBox5.Hide();
            pictureBox1.Hide();
            //pictureBox3.Hide();
            pictureBox6.Hide();
            pictureBox7.Hide();
        }
        bool SideBarExpand = true;

        public AdminFrontPage()
        {
            InitializeComponent();
            HideIcons();

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SideBar_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand == true)
            {
                SideBar.Width -= 10;
                pictureBox4.Hide();
                pictureBox5.Hide();
                pictureBox1.Hide();
                pictureBox2.Show();
                //pictureBox3.Hide();
                pictureBox6.Hide();
                pictureBox7.Hide();
                if (SideBar.Width <= 48)
                {
                    SideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else // SideBarExpand is false
            {
                SideBar.Width += 10;


                pictureBox4.Show();
                pictureBox5.Show();
                pictureBox1.Show();
                //pictureBox3.Show();
                pictureBox6.Show();
                pictureBox7.Show();
                //  pictureBox8.Show();
                pictureBox2.Show();
                if (SideBar.Width >= 228)
                {
                    SideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AddToMenu ATM = new AddToMenu();
            ATM.Show();
            this.Hide();
        }

        private void AdminFrontPage_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpShift empShift = new EmpShift();
            empShift.Show();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
        private void button3_Click_1(object sender, EventArgs e)
        {

        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
         
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
           
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
         
        }
        private void ManageInventory_Click(object sender, EventArgs e)
        {
            Inventory screen = new Inventory();
            screen.Show();
            this.Hide();

        }
        private void button1_Click_3(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmpShift empShift = new EmpShift();
           empShift.Show();
        }
    }
}
