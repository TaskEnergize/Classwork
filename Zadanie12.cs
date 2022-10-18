using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Swithc__zadanie
{
    public partial class Zadanie12 : Form
    {
        public Zadanie12()
        {
            InitializeComponent();
        }
        private Point PreviousPiont, point;
        private Bitmap bmp1,bmp2;
        private Pen blackPen;
        private Graphics g;
        private int bb = 0;
        private int R, G, B;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "Image files (*.BMP, *.JPG, " + "*.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                int width = image.Width;
                int height = image.Height;

                bmp1 = new Bitmap(image, width, height);

                pictureBox1.Image = bmp1;

                g = Graphics.FromImage(pictureBox1.Image);

                bmp2 = new Bitmap(image, width, height);

                pictureBox2.Image = bmp2;

                g = Graphics.FromImage(pictureBox2.Image);
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point.X = e.X;
                point.Y = e.Y;

                g.DrawLine(blackPen, PreviousPiont, point);

                PreviousPiont.X = point.X;
                PreviousPiont.Y = point.Y;

                pictureBox1.Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog savedialog = new SaveFileDialog();

            savedialog.Title = "Сохранить картинку как ...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckFileExists = true;
            savedialog.Filter =
                "Bitmap File(*.bmp)|*.bmp|" +
                "GIF File(*.gif)|*.gif|" +
                "JPEG File(*.jpg)|*.jpg|" +
                "PNG File(*.png)|*.png";
            if (savedialog.ShowDialog()==DialogResult.OK)
            {
                string fileName = savedialog.FileName;

                string strFilExtn = fileName.Remove(0,fileName.Length - 3);

                switch (strFilExtn)
                {
                    case "bmp":
                        bmp2.Save(fileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp2.Save(fileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp2.Save(fileName, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                    case "tif":
                        bmp2.Save(fileName, System.Drawing.Imaging.ImageFormat.Tiff);
                        break;
                    case "png":
                        bmp2.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    default:
                        break;
                }
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < bmp2.Width; i++)
            {
                for (int j = 0; j < bmp2.Height; j++)
                {
                    //R = bmp.GetPixel(i, j).R;
                    
                    G = bmp2.GetPixel(i, j).G;

                    //B = bmp.GetPixel(i, j).B;
                    
                    int Gray = (G + G + G) / 3;

                    Color p = Color.FromArgb(Convert.ToInt32(textBox1.Text), Gray, Gray,Gray);

                    bmp2.SetPixel(i, j, p);
                }
                Refresh();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bb = 1;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            bb = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bb = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bb = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = RgbChannel((Bitmap)pictureBox1.Image, bb);
        }
        static Bitmap RgbChannel(Bitmap pict, int str)
        {
            Bitmap res = new Bitmap(pict.Width, pict.Height);
            for (int i = 0; i < pict.Width; i++)
            {
                for (int j = 0; j < pict.Height; j++)
                {
                    Color color = pict.GetPixel(i, j);
                    if (str == 1) res.SetPixel(i, j, Color.FromArgb(0, color.G, color.B));
                    if (str == 2) res.SetPixel(i, j, Color.FromArgb(color.R, 0, color.B));
                    if (str == 3) res.SetPixel(i, j, Color.FromArgb(color.R, color.G, 0));
                    if (str == 0) res.SetPixel(i, j, Color.FromArgb(color.R, color.G, color.B));
                }
            }
            return res;
        }
        private void Load1(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4);
            textBox1.Text = "100";
        }


    }
}
