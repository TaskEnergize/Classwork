using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swithc__zadanie
{
    public partial class Zadanie8 : Form
    {
        public Zadanie8()
        {
            InitializeComponent();
        }
        int[,] masbig = new int[7, 7];
        int[] mas1 = new int[7];
        int[] mas2 = new int[7];
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 7;
            dataGridView1.ColumnCount = 7;


            int height = masbig.GetLength(0);
            int width = masbig.GetLength(1);

            Random ran = new Random();

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    masbig[y, x] = ran.Next(100);
                }

            }

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    dataGridView1.Rows[y].Cells[x].Value = masbig[y, x].ToString();
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 0, a2 = 0;

            for (int i = 0; i < 7; i++)
            {
                mas1[a] = masbig[i, i];
                a++;
            } //Создаём для главной диагонали отдельный массив

            a = 0;

            for (int x = 6; x > -1; x--)
            {
                mas2[a] = masbig[a2, x];
                a++;
                a2++;

            } //Создаём для второстепенной диагонали отдельный массив

            int g; //сохранение макс числа

            int h; //в каком масиве число

            if (mas1.Max() > mas2.Max())
            {
                g = mas1.Max();
                h = 1;
            } //Ищет в каком массиве самое большое число
            if (mas1.Max() < mas2.Max())
            {
                g = mas2.Max();
                h = 2;
            }
            else
            {
                g = mas1.Max();
                h = 1;
            }

            int p; //сохранение центра

            if (h == 1)
            {
                for (int y = 0; y < 7; y++)
                {

                    if (g == masbig[y, y])
                    {
                        p = masbig[3, 3];
                        dataGridView1.Rows[3].Cells[3].Value = g.ToString();
                        dataGridView1.Rows[y].Cells[y].Value = p.ToString();
                    }

                }
            }

            int y1 = 0;

            if (h == 2)
            {
                for (int x = 6; x > -1; x--)
                {
                    if (g == masbig[y1, x])
                    {
                        p = masbig[3, 3];
                        dataGridView1.Rows[3].Cells[3].Value = g.ToString();
                        dataGridView1.Rows[y1].Cells[x].Value = p.ToString();
                    }
                    y1++;

                }

            }


        }

    }
}
