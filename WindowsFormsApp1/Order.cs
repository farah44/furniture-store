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
    public partial class Order : Form
    {
        string ordb = @"User Id=scott; Password=tiger;Data source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=
        (PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=orcl)))";
        OracleConnection conn;
        public Order()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "OneRow";

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("statuss", OracleDbType.Varchar2, 20, null, ParameterDirection.Output);
            cmd.Parameters.Add("order_cost", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("customer_id", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("currentlocation", OracleDbType.Varchar2, 20, null, ParameterDirection.Output);
            cmd.ExecuteNonQuery();


            comboBox1.Text = cmd.Parameters["id"].Value.ToString();
            comboBox2.Text = cmd.Parameters["statuss"].Value.ToString();
            textBox2.Text = cmd.Parameters["order_cost"].Value.ToString();
            textBox3.Text = cmd.Parameters["customer_id"].Value.ToString();
            textBox4.Text = cmd.Parameters["currentlocation"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand ca = new OracleCommand();
            ca.Connection = conn;
            ca.CommandText = "Update_Statue";
            ca.CommandType = CommandType.StoredProcedure;
            ca.Parameters.Add("iddd", comboBox1.Text);
            ca.Parameters.Add("stat", comboBox2.Text);
            ca.Parameters.Add("cost", textBox2.Text);
            ca.Parameters.Add("loca", textBox4.Text);
            ca.ExecuteNonQuery();
            MessageBox.Show("Update Done");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand c2 = new OracleCommand();
            c2.Connection = conn;
            c2.CommandText = "Display_Multiple";
            c2.CommandType = CommandType.StoredProcedure;
            c2.Parameters.Add("id1", comboBox1.Text);
            c2.Parameters.Add("id2", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr2 = c2.ExecuteReader();
            while (dr2.Read())
            {
               
                comboBox2.Text = dr2[1].ToString();
                textBox2.Text = dr2[2].ToString();
                textBox3.Text = dr2[3].ToString();
                textBox4.Text = dr2[4].ToString();


            }
            dr2.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select orderid,status from orderr";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                if(comboBox2.Items.Contains(dr[1])==false)
                comboBox2.Items.Add(dr[1]);

            }
            dr.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();

            this.Close();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
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
