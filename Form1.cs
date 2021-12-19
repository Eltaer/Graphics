using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_11_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        class Date
        {
            DateTime date;

            public Date(DateTime date)
            {
                this.date = date;
            }

            public Date(string dateString)
            {
                date = DateTime.Parse(dateString);
            }

            public DateTime PrevDay()
            {
                return date.Subtract(TimeSpan.FromDays(1));
            }

            public DateTime NextDay()
            {
                return date.Add(TimeSpan.FromDays(1));
            }

            public int DaysLeft()
            {
                return DateTime.DaysInMonth(date.Year, date.Month) - date.Day;
            }

            public DateTime Date1
            {
                get { return date; }
                set { date = value; }
            }

            public bool IsLeap
            {
                get { return DateTime.IsLeapYear(date.Year); }
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string st1 = "2009,1,1";
            Date f = new Date(st1);
            textBox1.Text += ("Определенная дата: ");
            textBox1.Text += Convert.ToString(f.Date1 + "\r\n");
            textBox1.Text += ("Прошлый день: ");
            textBox1.Text += Convert.ToString(f.PrevDay() + "\r\n");
            textBox1.Text += ("Следующий день: ");
            textBox1.Text += Convert.ToString(f.NextDay() + "\r\n");
            textBox1.Text += ("Дней до конца месяца: ");
            textBox1.Text += Convert.ToString(f.DaysLeft() + "\r\n");
            textBox1.Text += ("Високосный ли год?: ");
            textBox1.Text += Convert.ToString(f.IsLeap);

            Console.Write("Введите дату: ");
            string st = Convert.ToString(textBox3.Text);
            Date A = new Date(st);

            textBox2.Text += ("Заданная дата: ");
            textBox2.Text += (A.Date1 + "\r\n");
            textBox2.Text += ("Прошлый день: ");
            textBox2.Text += (A.PrevDay() + "\r\n");
            textBox2.Text += ("Следующий день: ");
            textBox2.Text += (A.NextDay() + "\r\n");
            textBox2.Text += ("Дней до конца месяца: ");
            textBox2.Text += (A.DaysLeft() + "\r\n");
            textBox2.Text += ("Високосный ли год?: ");
            textBox2.Text += (A.IsLeap);
        }
    }
}
