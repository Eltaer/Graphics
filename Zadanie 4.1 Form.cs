using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadanie_4._1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static double cont_recurse(int cur, double n)
        {
            if (cur >= n)
                return n;
            return cur + 1.0 / cont_recurse(cur + 1, n);
        }

        static double continued(double n)
        {
            return 1.0 / cont_recurse(1, n);
        }
        private void button1_Click(object sender, EventArgs e)
        {
                double n;
                n = Convert.ToDouble(textBox1.Text);
                textBox2.Text = Convert.ToString("Ответ: " + continued(n));
        }
    }
}
