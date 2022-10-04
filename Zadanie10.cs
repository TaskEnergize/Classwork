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
    public partial class Zadanie10 : Form
    {
        SolidBrush kva = new SolidBrush(Color.Blue);
        SolidBrush mno = new SolidBrush(Color.Red);
        SolidBrush pua = new SolidBrush(Color.Brown);
        SolidBrush cr1 = new SolidBrush(Color.Gold);
        SolidBrush cr2 = new SolidBrush(Color.Aqua);
        Pen pen1 = new Pen(Color.Gold,5);
        Pen pen2 = new Pen(Color.Black, 5);
        Pen pen3 = new Pen(Color.Aqua, 5);
        public Zadanie10()
        {
            InitializeComponent();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            g.FillRectangle(kva, 25, 50, 100, 100);     //Квадрат
            g.FillEllipse(cr2, 300, 200, 50, 50);       //Круг
            g.DrawEllipse(pen1, 300, 100, 100, 50);     //Овал
            g.DrawLine(pen2,0,250,100,200);             //Линия
            g.DrawLine(pen2, 0, 350, 0, 350);

            g.FillEllipse(cr2, 300, 200, 10, 10);

            Point point11 = new Point(450, 200);
            Point point12 = new Point(500, 250);
            Point point13 = new Point(500, 200);
            Point[] curvePoints1 =
            {
                point11,
                point12,
                point13
            };
            g.DrawPolygon(pen3, curvePoints1);

        }

    }
}
