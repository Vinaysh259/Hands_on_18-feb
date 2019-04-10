using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myresult;
            string num = textBox1.Text;
            int n = int.Parse(num);
            if(n%2==0)
            {
                myresult = "even";
                label1.Text=myresult;
            }
            else
            {
                myresult = "odd";
                label1.Text = myresult;
            }

        }
    }
}
