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

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            Directories.Items.Clear();
            DriveInfo[] theDrives = DriveInfo.GetDrives();

            foreach (DriveInfo currenntdrive in theDrives)
            {
                this.comboBox1.Items.Add(currenntdrive.Name);
                

            }


            if(comboBox1.Text =="Load Drives")
            {
                return;
            }



            string path = comboBox1.Text;

            label2.Text = path;
            DirectoryInfo obj = new DirectoryInfo(path);
            DirectoryInfo[] folders = obj.GetDirectories();
            Directories.DataSource = folders;
            

        }
    }
}
