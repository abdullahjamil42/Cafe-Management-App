namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminLogin1 adminLogin1 = new AdminLogin1();
            adminLogin1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CustomerLogin1 form2 = new CustomerLogin1();
            form2.Show();
            this.Hide();  

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StaffLogin1 form2 = new StaffLogin1();
            form2.Show();
            this.Hide();  

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    
    }
}
