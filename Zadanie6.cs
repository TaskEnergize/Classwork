using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Swithc__zadanie
{
    public partial class Zadanie6 : Form
    {
        public Zadanie6()
        {
            InitializeComponent();

            listBox1.Items.Add("Text amogus armagedon");
            listBox1.Items.Add("Helow friends!");
            listBox1.Items.Add("Doom crossing");
            listBox1.Items.Add("Gun, FIRE!!!");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Regex.Replace(listBox1.Text, "[a-z]", "+", RegexOptions.IgnoreCase));
        }
    }
}
