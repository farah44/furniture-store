using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace WindowsFormsApp1
{
    public partial class Product : Form
    {
        string ordb = @"User Id=scott; Password=tiger;Data source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=
        (PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=orcl)))";
        OracleConnection conn;
        public Product()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from product";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                comboBox2.Items.Add(dr[2]);

            }
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c3 = new OracleCommand();
            c3.Connection = conn;
            c3.CommandText = "Display_Prdouct";
            c3.CommandType = CommandType.StoredProcedure;
            c3.Parameters.Add("id1", comboBox1.Text);
            c3.Parameters.Add("id2", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr2 = c3.ExecuteReader();
            while (dr2.Read())
            {
                textBox1.Text = dr2[1].ToString();
                comboBox2.Text = dr2[2].ToString();
                textBox3.Text = dr2[3].ToString();
            }
            dr2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "Insert_Product";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("PID", comboBox1.Text);
            c.Parameters.Add("ProName", textBox1.Text);
            c.Parameters.Add("Modelnum", int.Parse(comboBox2.Text));
            c.Parameters.Add("Cost", textBox3.Text);

            c.ExecuteNonQuery();
            textBox1.Clear();
            comboBox2.ResetText();
            textBox3.Clear();
            comboBox1.ResetText();

            MessageBox.Show("Done");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand ca2 = new OracleCommand();
            ca2.Connection = conn;
            ca2.CommandText = "Delete_Row";
            ca2.CommandType = CommandType.StoredProcedure;
            int x = int.Parse(comboBox1.Text);
            ca2.Parameters.Add("id1", x);
            ca2.ExecuteNonQuery();
            textBox1.Clear();
            comboBox2.ResetText();
            textBox3.Clear();
            comboBox1.ResetText();
            MessageBox.Show("Delete Done");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
           
            this.Close();
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
