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
    public partial class Dni : Form
    {
        public Dni()
        {
            InitializeComponent();
        }

        int a,b;
        string c, f;
        
        private void button1_Click(object sender, EventArgs e)
        {
            //Проверка на ввод дня
            if (textBox1.Text == "" )
            {
                a = 0;
            }
            else
            {
                a = int.Parse(textBox1.Text);
            }

            //Проверка на ввод месяца
            if (textBox2.Text == "")
            {
                b = 0;
            }
            else
            {
                b = int.Parse(textBox2.Text);
            }

            //Поиск дня недели
            switch (a)
                {
                    case 1: case 8: case 15: case 22: case 29:
                        c = "Понедельник";
                        break;
                    case 2: case 9: case 16: case 23: case 30:
                        c="Вторник";
                        break;
                    case 3: case 10: case 17: case 24: case 31:
                        c="Среда";
                        break;
                    case 4: case 11: case 18: case 25:
                        c="Четверг";
                        break;
                    case 5: case 12: case 19: case 26:
                        c="Пятница";
                        break;
                    case 6: case 13: case 20: case 27:
                        c="Суббота";
                        break;
                    case 7: case 14: case 21: case 28:
                        c="Воскресенье";
                        break;

                    default:
                        c="Введён неправильный день!";
                        break;

                }
            a = 0;

            //Поиск месяца
            switch (b)
            {
                case 1:
                    f = "Январь";
                    break;

                case 2:
                    f = "Февраль";
                    break;

                case 3:
                    f = "Март";
                    break;

                case 4:
                    f = "Апрель";
                    break;

                case 5:
                    f = ("Май");
                    break;

                case 6:
                    f = ("Июнь");
                    break;

                case 7:
                    f = ("Июль");
                    break;

                case 8:
                    f = ("Август");
                    break;

                case 9:
                    f = ("Сентябрь");
                    break;

                case 10:
                    f = ("Октябрь");
                    break;

                case 11:
                    f = ("Ноябрь");
                    break;

                case 12:
                    f = ("Декабрь");
                    break;

                default:
                    f = ("Введён неправильный месяц!");
                    break;
            }
            b = 0;

            MessageBox.Show("День недели: " + c + Environment.NewLine + "Месяц: " + f);

            c = "";
            f = "";
        }

        //Очистка ввода
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

    }
}
