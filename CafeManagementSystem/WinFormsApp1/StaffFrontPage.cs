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
    public partial class StaffFrontPage : Form
    {
        public StaffFrontPage()
        {
            InitializeComponent();
            HideIcons();
        }
        void HideIcons()
        {
            pictureBox1.Hide();
            pictureBox3.Hide();
            pictureBox6.Hide();
        }
        bool SideBarExpand = true;

        private void SideBarTimer_Tick(object sender, EventArgs e)
        {
            if (SideBarExpand == true)
            {
                SideBar.Width -= 10;
                pictureBox1.Hide();
                pictureBox2.Show();
                pictureBox3.Hide();
                pictureBox6.Hide();
                if (SideBar.Width <= 48)
                {
                    SideBarExpand = false;
                    SideBarTimer.Stop();
                }
            }
            else
            {
                SideBar.Width += 10;
                pictureBox1.Show();
                pictureBox3.Show();
                pictureBox6.Show();
                pictureBox2.Show();
                if (SideBar.Width >= 228)
                {
                    SideBarExpand = true;
                    SideBarTimer.Stop();
                }
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            SideBarTimer.Start();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ShowAllOrders_Click(object sender, EventArgs e)
        {
            ShowAllOrders showAllOrders = new ShowAllOrders();
            showAllOrders.Show();
            this.Hide();
        }

        private void ShowAllAcceptedOrders_Click(object sender, EventArgs e)
        {
            AccpetedOrders showAllOrders = new AccpetedOrders();
            showAllOrders.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private void StaffFrontPage_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WorkerOrderHstory workerOrderHstory     = new WorkerOrderHstory();
            workerOrderHstory.Show();
            this.Hide();
        }
    }
}
