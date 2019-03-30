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
namespace _5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DriveInfo[] theDrives = DriveInfo.GetDrives();

            foreach (DriveInfo currenntdrive in theDrives)
            {
                comboBox1.Items.Add(currenntdrive.Name);
            }
            string path = comboBox1.GetItemText(comboBox1.SelectedText);

            DirectoryInfo directoryInfo = new DirectoryInfo(path);
            
            DirectoryInfo[] folders = directoryInfo.GetDirectories();
            foreach (DirectoryInfo drs in folders)
            {
                listBox1.Items.Add(drs.Name);
            }
          
        }
    }
}
    
