using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee
{
    public partial class Form1 : Form
    {
        string e_id;
        string name;
        DateTime doj;
        string dept;
        double salary;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            e_id = textBox1.Text;
            name = textBox3.Text;
            doj = DateTime.Parse(textBox2.Text);
            dept = comboBox1.Text;
            salary = double.Parse(textBox4.Text);

            bool found1 = false, found2 = false, found3 = false;



            if (name == "")
            {
                MessageBox.Show("Name shouldn't left blank", "Error");
                found1 = false;
            }

            else
            {
                found1 = true;

            }

            if (doj < DateTime.Today)
            {
                found2 = true;

            }

            else
            {
                found2 = false;
                MessageBox.Show("Incorrect date", "Error");
            }

            string[] dept_list = { "Physics", "Chemistry", "Maths", "Biology" };

            bool found = false;
            foreach (var val in dept_list)
            {
                if (val == dept)
                {
                    found = true;
                    break;
                }

                else
                {
                    found = false;
                }

            }

            if (found == false)
            {
                MessageBox.Show("Dept doesnot exist", "Error");
            }


            if (salary > 100000 && salary < 50000000)
            {
                found3 = true;

            }

            else
            {
                found3 = false;
                MessageBox.Show("Salary should be between 100000 and 50000000", "Error");
            }

            if (found && found1 && found2 && found3)
            {
                listBox1.Items.Add(name);
                listBox1.Items.Add(e_id);
                listBox1.Items.Add(doj);
                listBox1.Items.Add(dept);
                listBox1.Items.Add(salary);

                MessageBox.Show("An Employee added", "status");

            }

            else
            {
                MessageBox.Show("Check your input", "Error");
            }

        }
    }
}
