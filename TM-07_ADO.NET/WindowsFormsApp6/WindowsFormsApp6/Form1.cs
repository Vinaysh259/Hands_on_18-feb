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

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Server =MIT-STD-H7\\SQLEXPRESS; Database = Northwind; Integrated Security = true ");

            //SqlCommand cmd = con.CreateCommand();

            try
            {
                //string query = "select * from Employees;";
                //cmd.CommandText = query;

                con.Open();

                //SqlDataReader reader = cmd.ExecuteReader();
                //DataTable dt = new DataTable();
                //dt.Load(reader);

                //dataGridView1.DataSource = dt;

                //reader.Close();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("Select * from Employees",con);

                da.Fill(dt);

                foreach(DataRow dr in dt.Rows)
                {
                    listBox1.Items.Add(dr["FirstName"].ToString());
                }

            }

            catch
            {
                Console.WriteLine("OOPs somethong went wrong");
            }

            finally
            {
                //cmd.Dispose();
                con.Close();

            }

        }
    }
}



