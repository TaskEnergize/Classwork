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
    public partial class Sverh : Form
    {
        public Sverh()
        {
            InitializeComponent();
            label1.Text = "";
            label2.Text = "";
        }
        int[] mas1 = new int[50];
        
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            int g = 0, h = 50;

            Random ran = new Random();

            for (int i = 0; i < mas1.Length; i++)
            {
                mas1[i] = ran.Next(g,h+1);

                listBox1.Items.Add($"Mas1 [{i}] = {mas1[i]}");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int j = mas1.Max();
            
            int[] mas2 = Array.FindAll(mas1, i => i == j);

            label1.Text = $"Количество максимальных чисел в массиве: {mas2.Length}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int j = Array.FindLastIndex(mas1, i => i == mas1.Max());
            int f = Array.FindLastIndex(mas1, i => i == mas1.Min());
            
            label2.Text = $"Идекс max: {j}  и  min: {f}";
        }
    }
}
