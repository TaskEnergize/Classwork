using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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

        private int     x1 = 10, y1 = 10, 
                        x2 = 550, y2 = 300, 
                        x3 = 240, y3 = 230, 
                        speed = 3, 
                        size = 10;

        private bool    gor1, ver1, 
                        gor2, ver2, 
                        gor3, ver3;

        private SolidBrush sb = new SolidBrush(Color.Gold);

        private void Form_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void Form_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillEllipse(sb, x1, y1, size, size);
            g.FillEllipse(sb, x2, y2, size, size);
            g.FillEllipse(sb, x3, y3, size, size);

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i1 = 0; i1 < speed; i1++)
            {
                
                if (x1 + size >= ClientSize.Width)
                {
                    gor1 = false;
                }

                if (x1 + size <= 0)
                {
                    gor1 = true;
                }

                if (gor1)
                {
                    x1 += speed;
                }
                else
                {
                    x1 -= speed;
                }
                
                if (y1 + size >= ClientSize.Height)
                {
                    ver1 = false;
                }

                if (y1 + size < 0)
                {
                    ver1 = true;
                }

                if (ver1)
                {
                    y1 += speed;
                }
                else
                {
                    y1 -= speed;
                }
            }

            for (int i2 = 0; i2 < speed; i2++)
            {

                if (x2 + size >= ClientSize.Width)
                {
                    gor2 = false;
                }

                if (x2 + size <= 0)
                {
                    gor2 = true;
                }

                if (gor2)
                {
                    x2 += speed;
                }
                else
                {
                    x2 -= speed;
                }

                if (y2 + size >= ClientSize.Height)
                {
                    ver2 = false;
                }

                if (y2 + size <= 0)
                {
                    ver2 = true;
                }

                if (ver2)
                {
                    y2 += speed;
                }
                else
                {
                    y2 -= speed;
                }
            }

            for (int i3 = 0; i3 < speed; i3++)
            {

                if (x3 + size >= ClientSize.Width)
                {
                    gor3 = false;
                }

                if (x3 + size <= 0)
                {
                    gor3 = true;
                }

                if (gor3)
                {
                    x3 += speed;
                }
                else
                {
                    x3 -= speed;
                }

                if (y3 + size >= ClientSize.Height)
                {
                    ver3 = false;
                }

                if (y3 + size <= 0)
                {
                    ver3 = true;
                }

                if (ver3)
                {
                    y3 += speed;
                }
                else
                {
                    y3 -= speed;
                }
            }

            Invalidate();
        }
    }
}
