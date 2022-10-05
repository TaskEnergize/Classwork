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
    public partial class Zadanie11 : Form
    {
        public Zadanie11()
        {
            InitializeComponent();
        }
        private int x1 = 10, y1 = 10, speed = 5;
        private bool gor=true, ver;
        private double t, fi;
        private Pen pen = new Pen(Color.Gold, 2);

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
                timer1.Enabled = false;
            else
                timer1.Enabled = true;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Form_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawEllipse(pen, x1, y1, 20, 20);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < speed; i++)
            {
                
                if (x1 >= ClientSize.Width)
                {
                    gor = false;
                }

                if (x1<0)
                {
                    gor = true;
                }

                if (gor)
                {
                    x1 = x1 + speed;
                    textBox1.Text = Convert.ToString(x1);
                    textBox2.Text = Convert.ToString(ClientSize.Width);
                }
                else
                {
                    x1 = x1 - speed;
                    textBox1.Text = Convert.ToString(x1);
                    textBox2.Text = Convert.ToString(ClientSize.Width);
                }
                
                
            }
            
            Invalidate();
        }
    }
}
