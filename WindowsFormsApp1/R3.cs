using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace WindowsFormsApp1
{
    public partial class R3 : Form
    {
        CrystalReport4 cr;
        public R3()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
            this.Close();
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            
            this.Close();
            
        }

        private void Display_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, comboBox1_ID.Text);
            cr.SetParameterValue(1, comboBox1.Text);
            crystalReportViewer1.ReportSource = cr;
        }

        private void R3_Load(object sender, EventArgs e)
        {
            cr = new CrystalReport4();
            foreach (ParameterDiscreteValue v in cr.ParameterFields[0].DefaultValues)
                comboBox1_ID.Items.Add(v.Value);
            foreach (ParameterDiscreteValue v in cr.ParameterFields[1].DefaultValues)
                comboBox1.Items.Add(v.Value);
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void customerToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Customer c = new Customer();
            this.Hide();
            c.ShowDialog();
            this.Close();
        }

        private void orderToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Order o = new Order();
            this.Hide();
            o.ShowDialog();
            this.Close();
        }

        private void supplierToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Supplier s = new Supplier();
            this.Hide();
            s.ShowDialog();
            this.Close();
        }

        private void employeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            this.Hide();
            emp.ShowDialog();
            this.Close();
        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
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
        private void pictureBox2_Click(object sender, EventArgs e)
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
