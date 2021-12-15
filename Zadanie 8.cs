using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = null;
            string stringWithTime = Convert.ToString(textBox1.Text);
            try
            {
                Console.Write("Введите удаляемые часы: ");
                double n = Convert.ToDouble(textBox3.Text);
                result = Regex.Match(stringWithTime, "[0-2][0-9]:[0-5][0-9]", RegexOptions.IgnoreCase).Value;
                DateTime dt = DateTime.Parse(result);
                textBox2.Text = Convert.ToString(dt.AddHours(n - (n + n)));
            }
            catch(Exception exc)
            {
                textBox2.Text = exc.Message;
            }
            Console.Read();
        }
    }
}
