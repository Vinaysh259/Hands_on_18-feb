using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           // this.ActiveControl = textBox1;
           // textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           listBox1.Items.Clear();
            string myvariable =textBox1.Text;
            string[] files = Directory.GetDirectories(myvariable);
            string[] files1 = Directory.GetFiles(myvariable);
            foreach (var val in files)
            {
                listBox1.Items.Add(val);
            }
            foreach (var val in files1)
            {
                listBox1.Items.Add(val);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
