using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadanie_1._1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s, r;
            s = Convert.ToDouble(textBox1.Text);
            r = Math.Sqrt(s / 6);
            textBox2.Text = Convert.ToString(r);
        }
    }
}
