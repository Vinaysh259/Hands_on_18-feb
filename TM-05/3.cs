using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = RandomNumber(10);
            int num2 = RandomNumber(15);
            int num3 = RandomNumber(21);

            label1.Text = num1.ToString();
            label2.Text = num2.ToString();
            label3.Text = num3.ToString();

            if (num1 + num2 + num3 > 21)
                MessageBox.Show("You have won the game...");
            else
                MessageBox.Show("OOPs better luck next time...");


        }

        public int RandomNumber(int max)
        {
            Random random = new Random();
            return random.Next(max);
        }
    }
}
