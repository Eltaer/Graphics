using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zadanie_1_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num; 
            num  = Convert.ToDouble(textBox1.Text);
            double sum = num % 10 + (num / 10) % 10;

            textBox2.Text = Convert.ToString((sum % 3) == 0 ? "Кратно" : "Не кратно");
        }
    }
}
