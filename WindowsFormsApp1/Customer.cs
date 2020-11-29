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
    public partial class Customer : Form
    {
        string ordb = @"User Id=scott; Password=tiger;Data source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=
        (PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=orcl)))";
        OracleConnection conn;

        public Customer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select customerid from Customer";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {

                comboBox1_ID.Items.Add(dr[0]);
               

            }
            dr.Close();
            

        }


        private void comboBox1_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Sex,birthdate,LastName,firstname,city,street,flat from Customer where CustomerID=:ID";
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("ID", comboBox1_ID.SelectedItem.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox3_sex.Text = dr[0].ToString();
                textBox2_bd.Text = dr[1].ToString();
                textBox2_ln.Text = dr[2].ToString();
                textBox1_fn.Text = dr[3].ToString();
                textBox1_cit.Text = dr[4].ToString();
                textBox2_street.Text = dr[5].ToString();
                textBox1_flat.Text = dr[6].ToString();

            }
            dr.Close();




        }
       

      
           
        private void button1_Click(object sender, EventArgs e)
        {
            Employee f2 = new Employee();
            f2.ShowDialog();
        }
        private void Form1_FormClosing (object sender ,FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Supplier f6 = new Supplier();
            f6.ShowDialog();
        }


        

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            
            this.Close();
        }

        private void textBox2_ln_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
            Supplier ss = new Supplier();
            this.Hide();
            ss.ShowDialog();
            this.Close();
        }

        private void employeeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Employee empp = new Employee();
            this.Hide();
            empp.ShowDialog();
            this.Close();
        }

        private void productToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Product pp = new Product();
            this.Hide();
            pp.ShowDialog();
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
        private void textBox1_fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.SoundLocation = "st.wav";
            player.PlayLooping();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
