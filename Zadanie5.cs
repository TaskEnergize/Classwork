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
    public partial class Zadanie5 : Form
    {
        public Zadanie5()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;

            int x = Convert.ToInt32(textBox2.Text);

            int y = Convert.ToInt32(textBox3.Text);

            if (a == "К" || a == "к")
            {
                Button b = new Button();
                b.Parent = this;
                b.Location = new Point(x, y);
                b.Size = new Size(100, 100);

            }
            if (a == "П" || a == "п")
            {
                TextBox tb = new TextBox();
                tb.Parent = this;
                tb.Location = new Point(x, y);
                tb.Size = new Size(100, 100);
            }
            if (a == "М" || a == "м")
            {
                Label lbl = new Label();
                lbl.Parent = this;
                lbl.Location = new Point(x, y);
                lbl.Size = new Size(100, 100);
                lbl.Text = "Метка";
            }
        }

    }
}
