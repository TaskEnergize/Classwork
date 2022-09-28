using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Swithc__zadanie
{
    public partial class Zadanie4 : Form
    {
        public Zadanie4()
        {
            InitializeComponent();
        }

        double x, y;

        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text); //Начало
            double xk = double.Parse(textBox2.Text); //Конец
            double dx = double.Parse(textBox3.Text); //Шаг
            double b = double.Parse(textBox4.Text); //Конец

            x = x0;

            while (x <= xk)
            {

                y = (Math.Pow(x, 5 / 2) - b) * (Math.Log10(Math.Pow(x, 2) + 12.7));

                textBox5.Text += "X=" + Convert.ToString(x) + "; Y=" + Convert.ToString(Math.Round(y, 3)) + Environment.NewLine;

                x = x + dx;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x0 = double.Parse(textBox1.Text); //Начало
            double xk = double.Parse(textBox2.Text); //Конец
            double dx = double.Parse(textBox3.Text); //Шаг
            double b = double.Parse(textBox4.Text); //Конец

            x = x0;

            do
            {
                y = (Math.Pow(x, 5 / 2) - b) * (Math.Log10(Math.Pow(x, 2) + 12.7));

                textBox5.Text += "X=" + Convert.ToString(x) + "; Y=" + Convert.ToString(Math.Round(y, 3)) + Environment.NewLine;

                x = x + dx;

            } while (x <= xk);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0,25";
            textBox2.Text = "5,2";
            textBox3.Text = "0,3";
            textBox4.Text = "0,8";
            textBox5.Text = "";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Random ran = new Random();

            int p = ran.Next(100);
            textBox1.Text = Convert.ToString(p);
            p = ran.Next(100);
            textBox2.Text = Convert.ToString(p);
            p = ran.Next(100);
            textBox3.Text = Convert.ToString(p);
            p = ran.Next(100);
            textBox4.Text = Convert.ToString(p);

        }

    }
}
