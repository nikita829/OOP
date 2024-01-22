using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = "Введите x: ";
            label8.Text = "Введите y: ";
            label7.Text = "Выберите функицию: ";
            label6.Text = "Результат выполнения программы: ";
            radioButton1.Text = "sh(x)";
            radioButton2.Text = "x^2";
            radioButton3.Text = "exp^(x)";;
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e){}
        private void radioButton3_CheckedChanged(object sender, EventArgs e){}
        private void radioButton2_CheckedChanged(object sender, EventArgs e){}

        private void button2_Click_1(object sender, EventArgs e)
        {
            double x = 0, y = 0, z = 0, d = 0;
            if (!double.TryParse(textBox5.Text, out x) || !double.TryParse(textBox6.Text, out y))
            {
                MessageBox.Show("Некорректный ввод данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            textBox8.Clear();
            textBox8.Text += "Лаб.раб.N3 АСУ-22-1б Варов Л.А. Каруба Д.В. Кузнецов Н.И.";
            x = double.Parse(textBox5.Text);
            textBox8.Text += Environment.NewLine + "X = " + x.ToString();
            y = double.Parse(textBox6.Text);
            textBox8.Text += Environment.NewLine + "Y = " + y.ToString();

            if (radioButton1.Checked)
            {
                z = Math.Sinh(x);
            }
            else
            {
                if (radioButton3.Checked)
                {
                    z = Math.Exp(x);
                }
                else
                {
                    z = Math.Pow(x, 2);
                }
            }

            if (x > y)
            {
                d = Math.Pow((z - y), 3) + Math.Atan(z);
            }
            else
            {
                if (x < y)
                {
                    d = Math.Pow((y - z), 3) + Math.Atan(z);
                }
                else
                {
                    d = Math.Pow((y + z), 3) + 0.5;
                }
            }
            textBox8.Text += Environment.NewLine + Environment.NewLine + "Результат D = " + d.ToString();
        }
    }
}
