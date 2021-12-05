using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadanie_3._1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double f(double x)
        {
            return x % 10;
        }
        private void button1_Click(object sender, EventArgs e)
        {

                double a = Convert.ToDouble(textBox1.Text);

                double b = Convert.ToDouble(textBox2.Text);
                double z = f(a) + f(b);
                textBox3.Text = Convert.ToString(z);
        }
    }
}
