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
    public partial class Zadanie8_1 : Form
    {
        public Zadanie8_1()
        {
            InitializeComponent();
        }
        int[,] masbig = new int[5, 5];
        int[] mas = new int[5];
        int[] masmin = new int[5];
        int[] masmax = new int[5];
        int[] massort = new int[5];
        
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

            



            int a = 0;
            for (int y = 0; y < height; y++)
            {
                
                for (int x = 0; x < width; x++)
                {
                    mas[x] = masbig[y, x];
                }
                masmin[a] = mas.Min();
                a++;
            }

            for (int y = 0; y < height; y++)
            {
                dataGridView1.Rows[y].Cells[6].Value = masmin[y].ToString();
            }

            a = 0;

            for (int y = 0; y < height; y++)
            {

                for (int x = 0; x < width; x++)
                {
                    mas[x] = masbig[x, y];
                }
                masmax[a] = mas.Max();
                a++;
            }

            for (int y = 0; y < height; y++)
            {
                dataGridView1.Rows[6].Cells[y].Value = masmax[y].ToString();
            }

            int sum = masmin.Sum()+masmax.Sum();

            dataGridView1.Rows[6].Cells[6].Value = sum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int height = masbig.GetLength(0);
            int width = masbig.GetLength(1);

            for (int x = 0; x < width; x=x+2)
            {
                for (int y = 0; y < height; y++)
                {

                    massort[y] = masbig[y, x];

                }
                Array.Sort(massort);

                for (int y = 0; y < height; y++)
                {
                    dataGridView1.Rows[y].Cells[x].Value = massort[y].ToString();
                }
            }

            for (int x = 1; x < width; x = x + 2)
            {
                for (int y = 0; y < height; y++)
                {

                    massort[y] = masbig[y, x];

                }
                Array.Sort(massort);
                Array.Reverse(massort);

                for (int y = 0; y < height; y++)
                {
                    dataGridView1.Rows[y].Cells[x].Value = massort[y].ToString();
                }
            }



        }
    }
}
