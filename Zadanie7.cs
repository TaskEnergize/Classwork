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
    public partial class Zadanie7 : Form
    {
        public Zadanie7()
        {
            InitializeComponent();
        }
        //14 вариант
        int[] mas1 = new int[15];

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox2.Items.Clear();

            Random ran = new Random();

            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = ran.Next(-50, 50);

                listBox1.Items.Add("Mas1 [" + i + "] = " + mas1[i].ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            for (int i = 0; i < mas1.Length; i++)
            {
                if (mas1[i] > 0)
                {
                    listBox2.Items.Add("Mas2 [" + i + "] = " + mas1[i] * mas1[i]);
                }

                if (mas1[i] < 0)
                {
                    listBox2.Items.Add("Mas2 [" + i + "] = " + mas1[i] * 2);
                }

                if (mas1[i] == 0)
                {
                    listBox2.Items.Add("Mas2 [" + i + "] = " + 0);
                }
            }

        }

    }
}
