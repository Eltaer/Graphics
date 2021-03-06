using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_12
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

            public DateTime this[int index]
            {
                get { return date.AddDays(index); }
            }

            public static bool operator !(Date a)
            {
                return DateTime.DaysInMonth(a.Date1.Year, a.Date1.Month) != a.Date1.Day;
            }

            public static bool operator true(Date a)
            {
                return a.date.Day == 1 && a.date.Month == 1;
            }

            public static bool operator false(Date a)
            {
                return a.date.Day != 1 || a.date.Month != 1;
            }

            public static bool operator &(Date a, Date b)
            {
                return a.Date1.Equals(b.Date1);
            }

            public static explicit operator String(Date obj)
            {
                return " ??????: " + obj.date.Year + " ??????????: " + obj.date.Month + " ??????????: " + obj.date.Day;
            }
        }
        private void button1_Click(object sender, EventArgs e)
            {
                string st1 = "2009,1,1";
                Date f = new Date(st1);
                textBox4.Text += ("???????????????????????? ????????: ");
                textBox4.Text += Convert.ToString(f.Date1 + "\r\n");
                textBox4.Text += ("?????????????? ????????: ");
                textBox4.Text += Convert.ToString(f.PrevDay() + "\r\n");
                textBox4.Text += ("?????????????????? ????????: ");
                textBox4.Text += Convert.ToString(f.NextDay() + "\r\n");
                textBox4.Text += ("???????? ???? ?????????? ????????????: ");
                textBox4.Text += Convert.ToString(f.DaysLeft() + "\r\n");
                textBox4.Text += ("???????????????????? ???? ???????: ");
                textBox4.Text += Convert.ToString(f.IsLeap);

                Console.Write("?????????????? i: ");
                string st2 = Convert.ToString(textBox1.Text);
                int i = Convert.ToInt16(st2);

                Console.Write("?????????????? ????????: ");
                string st = Convert.ToString(textBox2.Text);
                Date A = new Date(st);

                textBox3.Text += ("???????????????? ????????: ");
                textBox3.Text += (A.Date1 + "\r\n");
                textBox3.Text += ("?????????????? ????????: ");
                textBox3.Text += (A.PrevDay() + "\r\n");
                textBox3.Text += ("?????????????????? ????????: ");
                textBox3.Text += (A.NextDay() + "\r\n");
                textBox3.Text += ("???????? ???? ?????????? ????????????: ");
                textBox3.Text += (A.DaysLeft() + "\r\n");
                textBox3.Text += ("???????????????????? ???? ???????: ");
                textBox3.Text += (A.IsLeap);
            }
        }
    }
