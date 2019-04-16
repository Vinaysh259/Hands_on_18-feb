using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Company_Database
{
    public partial class Form1 : Form
    {
        string e_id;
        string name;
        string desg;
        string qual;
        DateTime doj;
               
        public Form1()
        {
            InitializeComponent();
        }

        private void refresh()
        {
            SqlConnection con = new SqlConnection("Server =MIT-STDN-H233\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
            SqlCommand cmd = con.CreateCommand();

            try
            {
                con.Open();

                cmd.CommandText = "Select * from Employee;";

                SqlDataReader reader = cmd.ExecuteReader();


                DataTable dt = new DataTable();
                dt.Load(reader);

                dataGridView1.DataSource = dt;

                comboBox3.DisplayMember = "EmployeeID";
                comboBox3.DataSource = dt;

                reader.Close();
            }

            catch (Exception ex)
            {
                string msg = ex.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                cmd.Dispose();
                con.Close();

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            e_id = textBox1.Text;
            name = textBox2.Text;
            desg = comboBox1.SelectedItem.ToString();
            qual = comboBox2.SelectedItem.ToString();
            doj = DateTime.Parse(dateTimePicker1.Text);

            if((e_id == "") || (name == "") || (desg == "") || (qual == "") || (doj == null))
            {
                string msg = "No text box can be empty ";
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                SqlConnection con = new SqlConnection("Server =MIT-STDN-H233\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
                SqlCommand cmd = con.CreateCommand();

                try
                {
                    con.Open();
                    string query = "Insert into Employee values('"
                                + e_id + "','"
                                + name + "','"
                                + desg + "','"
                                + qual + "','"
                                + doj + "');";

                    cmd.CommandText = query;

                    cmd.ExecuteScalar();

                    MessageBox.Show("New Employee is added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

                catch(Exception ex)
                {
                    string msg = ex.Message.ToString();
                    string caption = "Error";
                    MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

                finally
                {
                    cmd.Dispose();
                    con.Close();
                }

               
            }
        }

        private void button5_Click(object sender, EventArgs e) //Refresh
        {
            refresh();
            textBox1.Clear();
            textBox2.Clear();
            dateTimePicker1.ResetText();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void button2_Click(object sender, EventArgs e) // Update
        {

        }

        private void button3_Click(object sender, EventArgs e) // Delete
        {
            SqlConnection con = new SqlConnection("Server =MIT-STDN-H233\\SQLEXPRESS; Database = EmployeeManagement; Integrated Security = true ");
            SqlCommand cmd = con.CreateCommand();
            //char[] id = new char[5];
            var id = int.Parse(comboBox3.Text);
            //char[] id = emp_id_sel.ToArray();
            

            try
            {
                con.Open();
                string query = "Delete from Employee where EmployeeID =" + id ;

                cmd.CommandText = query;
                cmd.ExecuteScalar();



            }

            catch(Exception ex)
            {
                string msg = ex.Message.ToString();
                string caption = "Error";
                MessageBox.Show(msg, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally
            {
                cmd.Dispose();
                con.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e) // Search
        {

        }
    }
}
