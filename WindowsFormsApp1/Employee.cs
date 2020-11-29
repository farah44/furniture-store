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
    public partial class Employee : Form
    {
        string ordb = @"User Id=scott; Password=tiger;Data source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=
        (PROTOCOL=TCP)(HOST=localhost)(PORT=1521))) (CONNECT_DATA=(SERVICE_NAME=orcl)))";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;

        public Employee()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from Employee";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1_EID.Items.Add(dr[0]);
               
            }
            dr.Close();


        }

        private void comboBox1_EID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;

                cmd.CommandText = "select EmployeeName,supervisor_id from Employee where EmployeeID=:ID";
                cmd.CommandType = CommandType.Text;
                

                cmd.Parameters.Add("ID", comboBox1_EID.SelectedItem.ToString());
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1_EName.Text = dr[0].ToString();
                    textBox1_SID.Text = dr[1].ToString();
                }
                dr.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Connection Lost");
            }


        }

        private void button1_ins_Click(object sender, EventArgs e)
        {


            try
            {
                OracleCommand cmd = new OracleCommand();

                cmd.Connection = conn;
                cmd.CommandText = "insert into employee(EmployeeID,EmployeeName,supervisor_ID) values (:vEmployeeID,:vEmployeeName,:vsupervisorId)";
                cmd.Parameters.Add("vemployeeID", comboBox1_EID.Text);
                cmd.Parameters.Add("vEmployeeName", textBox1_EName.Text);
                cmd.Parameters.Add("vsupervisorid", textBox1_SID.Text);

                int ret_val = cmd.ExecuteNonQuery();
                if (ret_val != -1)
                {
                    comboBox1_EID.Items.Add(comboBox1_EID.Text);
                    MessageBox.Show("Employee is added succesfuly ");
                    
                }
             
                textBox1_EName.Clear();
                comboBox1_EID.ResetText();
                textBox1_SID.Clear();
                

            }
            catch (Exception )
            {
                MessageBox.Show("Can't be added");
            }

            

        }
       

        private void button2_up_Click(object sender, EventArgs e)
        {


            try
            {
                
                    OracleCommand cmd = new OracleCommand();
                    cmd.Connection = conn;

                    cmd.CommandText = "update employee set employeeName=:name, supervisor_id=:sid where employeeID =:id";
                    cmd.CommandType = CommandType.Text;

                    
                    cmd.Parameters.Add("name", textBox1_EName.Text);
                    cmd.Parameters.Add("sid", textBox1_SID.Text);
                cmd.Parameters.Add("id", comboBox1_EID.SelectedItem.ToString());

                int ret_val = cmd.ExecuteNonQuery();
                    if (ret_val != -1)
                    {
                        MessageBox.Show("Employee info updated succesfully ");
                    }

                 
                textBox1_EName.Clear();
                comboBox1_EID.ResetText();
                textBox1_SID.Clear();

            }
            catch (Exception )
            {
                MessageBox.Show("Can't be updated");
            }


        }

        private void button3_del_Click(object sender, EventArgs e)
        {

            try
            {

                OracleCommand cmd = new OracleCommand();
                OracleCommand cmd1 = new OracleCommand();
                OracleCommand cmd2 = new OracleCommand();
                OracleCommand cmd3 = new OracleCommand();
                cmd.Connection = conn;
                cmd1.Connection = conn;
                cmd2.Connection = conn;
                cmd3.Connection = conn;
                cmd.CommandText = "update employee set supervisor_Id=null where supervisor_Id=:id";
                cmd.Parameters.Add("id", comboBox1_EID.Text);
                cmd.ExecuteNonQuery();
                cmd1.CommandText = " Delete from managee_c where employeeid =:id";
                cmd1.Parameters.Add("id", comboBox1_EID.Text);
                cmd1.ExecuteNonQuery();
                cmd2.CommandText = "Delete from managep_e where employeeid =:id";
                cmd2.Parameters.Add("id", comboBox1_EID.Text);
                cmd2.ExecuteNonQuery();
                cmd3.CommandText = "Delete from employee where employeeid=:id";
                cmd3.Parameters.Add("id", comboBox1_EID.Text);
                int ret_val = cmd3.ExecuteNonQuery();
                if (ret_val != -1)
                {
                    MessageBox.Show("Employee deleted");
                    comboBox1_EID.Items.RemoveAt(comboBox1_EID.SelectedIndex);
                    textBox1_EName.Text = "";
                    textBox1_SID.Text = "";
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Can't be Deleted");
            }
           
          
            

        }
        private void Form2_FormClosing(object sender, FormClosedEventArgs e)
        {
            conn.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Product f5 = new Product();
            f5.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {
            string cmdstr = "select* from employee ";
            adapter = new OracleDataAdapter(cmdstr, ordb);
            ds = new DataSet();
            adapter.Fill(ds); 
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Save_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);

        }

        
        private void textBox1_EName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_ln_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_fn_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_cit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_bd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home h = new Home();
            this.Hide();
            h.ShowDialog();
            
            this.Close();
        }
        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            this.Hide();
            c.ShowDialog();
            this.Close();
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
    }
}
