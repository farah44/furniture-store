using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button_supply_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_orders_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            this.Hide();
            o.ShowDialog();
           
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_suppliers_Click(object sender, EventArgs e)
        {
            R2 r2 = new R2();
            this.Hide();
            r2.ShowDialog();
   
            this.Close();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.ShowDialog();
           
            this.Close();
        }

        private void button_Employee_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Hide();
            emp.ShowDialog();
           
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_cust_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            this.Hide();
            c.ShowDialog();
            
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            this.Hide();
            s.ShowDialog();
            
            this.Close();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            R1 r1 = new R1();
            this.Hide();
            r1.ShowDialog();
           
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            R3 r3 = new R3();
            this.Hide();
            r3.ShowDialog();
           
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsblesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.ShowDialog();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            this.Hide();
            o.ShowDialog();
            this.Close();
            
            
        }

        private void customerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Customer c = new Customer();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Hide();
            emp.ShowDialog();
            this.Close();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product p = new Product();
            this.Hide();
            p.ShowDialog();
            this.Close();
        }

        private void reportOneReviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R1 r1 = new R1();
            this.Hide();
            r1.ShowDialog();
            this.Close();
        }

        private void reportTwoOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R2 r2 = new R2();
            this.Hide();
            r2.ShowDialog();
            this.Close();
        }

        private void reportThreeModelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            R3 r3 = new R3();
            this.Hide();
            r3.ShowDialog();
            this.Close();
        }
        System.Media.SoundPlayer player = new System.Media.SoundPlayer();
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            player.SoundLocation = "st.wav";
            player.Play();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }
    }
}
