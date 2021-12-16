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

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox2.Text);
            double[] arr = new double[n];

            string FileName = @"C:\Users\stu-pkspk219\Desktop\file.txt";
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                for (int i = 0; i<n; i++)
                {
                    if (i % 2 == 0)
                    {
                        sw.WriteLine(i);
                    }
                }
            }

            using (StreamReader sr = new StreamReader(FileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    textBox1.Text +=(line) + "\r\n";
                }
            }
        }
    }
}
