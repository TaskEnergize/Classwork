using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swithc__zadanie
{
    public partial class Zadanie9 : Form
    {
        public Zadanie9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double xmin = double.Parse(textBox1.Text);
            double xmax = double.Parse(textBox2.Text);
            double step = double.Parse(textBox3.Text);

            int a = (int)Math.Ceiling((xmax - xmin)/step)+1;

            double[] mas = new double[a];

            double[] y1 = new double[a];
            double[] y2 = new double[a];

            for (int i = 0; i < a; i++)
            {
                mas[i] = xmin + step * i;
                y1[i] = Math.Sin(mas[i]);
                y2[i] = Math.Cos(mas[i]);
            }

            chart1.ChartAreas[0].AxisX.Minimum = xmin;
            chart1.ChartAreas[0].AxisX.Maximum = xmax;

            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = a;

            chart1.Series[0].Points.DataBindXY(mas, y1);
            chart1.Series[1].Points.DataBindXY(mas, y2);
        }

        
    }
}
