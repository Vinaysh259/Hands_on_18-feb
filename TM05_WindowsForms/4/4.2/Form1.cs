using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._2
{
    public partial class Form1 : Form
    {
        string operation_performed = "";
        double myresult = 0;
        bool is_operation_performed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0")||(is_operation_performed))
                textBox1.Clear();
            is_operation_performed = false;
            Button button = (Button)sender;
            if(button.Text==".")
                {
                if(!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + button.Text;
                }
            else
            textBox1.Text = textBox1.Text + button.Text;
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Button button = (Button)sender;
            if(myresult!=0)
                {
                operation_performed = button.Text;
                button17.PerformClick();   
                label1.Text = myresult + "" + operation_performed;
                 is_operation_performed = true;
                }
            else
            {
            operation_performed = button.Text;
            myresult = double.Parse(textBox1.Text);
            label1.Text = myresult + "" + operation_performed;
            is_operation_performed = true;
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            myresult = 0;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            switch (operation_performed)
            {
                case "+":
                    textBox1.Text = (myresult + double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (myresult - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (myresult * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (myresult / double.Parse(textBox1.Text)).ToString();
                    break;
            }
            myresult=double.Parse(textBox1.Text);
            label1.Text="";

        }
    }
}
