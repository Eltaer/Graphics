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

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string GetLongestString(string fileName)
        {
            string currentString, longestString = "";
            using (StreamReader reader = new StreamReader(fileName))
            {
                while (!reader.EndOfStream)
                {
                    currentString = reader.ReadLine();
                    if (currentString.Length > longestString.Length)
                        longestString = currentString;
                }
                return longestString;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

                string fileName = @"C:\Users\stu-pkspk219\Desktop\file2.txt";
                string longestString = GetLongestString(fileName);
                textBox1.Text += (longestString) + "\r\n";
                textBox1.Text += ("Длина строки: " + longestString.Length) + "\r\n";
        }
    }
}
