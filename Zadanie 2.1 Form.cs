using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadanie_2._1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y;
            x = Convert.ToDouble(textBox1.Text);
            y = Convert.ToDouble(textBox2.Text);

            if ((x * x + y * y < 144) && y - Math.Abs(x) > 0)
            {
                textBox3.Text = Convert.ToString("Точка попала в заштрихованную область");
            }
            else if ((x * x + y * y == 144) && y - Math.Abs(x) == 0)

            {
                textBox3.Text = Convert.ToString("Точка на границе заштрихованной области");
            }
            else
            {
                textBox3.Text = Convert.ToString("Точка не попала в заштрихованную область");
            }
        }
    }
}
