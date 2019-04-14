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

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] Drives = DriveInfo.GetDrives();
            foreach (DriveInfo Drive in Drives)
            {
                comboBox1.Items.Add(Drive);
            }
            //comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string myvariable = comboBox1.Text;
            string[] files = Directory.GetDirectories(myvariable);
             string[] files1 = Directory.GetFiles(myvariable);
            //var files = Directory.EnumerateFiles(myvariable);
            foreach(var val in files)
            {
                listBox1.Items.Add(val);
            }
             foreach(var val in files1)
            {
                listBox1.Items.Add(val);
            }
        }
    }
}
