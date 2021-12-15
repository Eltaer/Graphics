using System;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = Convert.ToString(textBox1.Text);
            string[] splitted = text.Split(new[] { ' ', '.', '?', '!', ')', '(', ',', ':' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Введите символ:");
            string symbol = Convert.ToString(textBox3.Text);
            foreach (string s in splitted)
            {
                if (s.Contains(symbol))
                {
                    text = text.Replace(s, string.Empty);
                }
            }
            textBox2.Text = Convert.ToString(text);
        }
    }
}
