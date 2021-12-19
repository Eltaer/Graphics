using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadanie_10_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static void CreateFile(string path)
        {
            StreamWriter t1 = new StreamWriter(new FileStream(path + "\\K1\\t1.txt", FileMode.Create));
            t1.WriteLine("Тимофеев Никита Александрович, 2002 года рождения, место жительства: г.Владимир");
            StreamWriter t2 = new StreamWriter(new FileStream(path + "\\K1\\t2.txt", FileMode.Create));
            t2.WriteLine("Журавлева Татья Валентиновна, 1971 года рождения, место жительства: г.Владимир");
            StreamWriter t3 = new StreamWriter(new FileStream(path + "\\K2\\t3.txt", FileMode.Create));
            t1.Close();
            t2.Close();
            t3.Close();
        }

        public void InformationAboutFiles(string path)
        {
            textBox1.Text += ("\rПодкаталоги в " + path + ":");

            string[] dirs = Directory.GetDirectories(path);
            foreach (string s in dirs)
            {
                textBox1.Text += "\r\n" + (s);
            }
            textBox1.Text += "\r\n";

            string[] files;
            if (Directory.Exists(path + "\\K1"))
            {
                textBox1.Text += ("\r\nФайлы в " + path + "\\K1" + ":");
                files = Directory.GetFiles(path + "\\K1");
                foreach (string s in files)
                {
                    textBox1.Text += "\r\n" + (s);
                }
                textBox1.Text += "\r\n";
            }


            if (Directory.Exists(path + "\\K2"))
            {
                textBox1.Text += ("\r\nФайлы в " + path + "\\K2");
                files = Directory.GetFiles(path + "\\K2");
                foreach (string s in files)
                {
                    textBox1.Text += "\r\n" + (s);
                }
                textBox1.Text += "\r\n";
            }


            if (Directory.Exists(path + "\\ALL"))
            {
                textBox1.Text += ("\r\nФайлы в " + path + "\\ALL");
                files = Directory.GetFiles(path + "\\ALL");
                foreach (string s in files)
                {
                    textBox1.Text += "\r\n" + (s);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\temp";

            if (Directory.Exists(path))
                Directory.Delete(path, true);

            DirectoryInfo dirInfo = new DirectoryInfo(path);
            dirInfo.CreateSubdirectory("K1");
            dirInfo.CreateSubdirectory("K2");

            CreateFile(path);

            File.AppendAllText(path + "\\K2\\t3.txt", File.ReadAllText(path + "\\K1\\t1.txt"));
            File.AppendAllText(path + "\\K2\\t3.txt", File.ReadAllText(path + "\\K1\\t2.txt"));

            InformationAboutFiles(path);

            File.Move(path + "\\K1\\t2.txt", path + "\\K2\\t2.txt");
            File.Copy(path + "\\K1\\t1.txt", path + "\\K2\\t1.txt");

            Directory.Move(path + "\\K2", path + "\\ALL");
            Directory.Delete(path + "\\K1", true);

            Console.WriteLine();
            InformationAboutFiles(path);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

    }
}
