using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static bool IsThere(string s)
        {
            for (int i = 0; i < s.Length - 1; i++)
                if (s[i] == s[i + 1])
                    return true;
            return false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
                string s = Convert.ToString(textBox1.Text);
                textBox2.Text = Convert.ToString(IsThere(s));
        }
    }
}
