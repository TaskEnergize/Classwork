using Microsoft.VisualBasic;
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
    public partial class Igra : Form
    {
        public Igra()
        {
            InitializeComponent();
        }

        int h = 3;
        private void button1_Click(object sender, EventArgs e)
        {
            int a,g;
            Random random = new Random();

            a = random.Next(9);
            a = a + 1;
            
            g = Convert.ToInt32 (textBox1.Text);
            
            

            while (a==g | h!=0)
            {
                if (a == g)
                {
                    MessageBox.Show("Угадал число");
                    h = 3;
                }
                else
                {
                    if (h > 1)
                    {
                        h--;
                        MessageBox.Show("У тебя есть ещё " + h + " попытки!");
                    }
                    else
                    {
                        textBox2.Text = a.ToString();
                        MessageBox.Show("Не угадал число");
                    }
                    Interaction.InputBox("");
                }
            }
        }
    }
}
