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

namespace ЛР2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Введите x: ";
            label2.Text = "Введите y: ";
            label3.Text = "Введите z: ";
            label4.Text = "Результат выполнения программы: ";
            textBox1.Text = "4000";
            textBox2.Text = "-0,875";
            textBox3.Text = "-0,000475";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox4.Text += "Лаб.раб.N2 АСУ-22-1б Варов Л.А. Каруба Д.В. Кузнецов Н.И.";
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double w = Math.Pow(Math.Abs(Math.Cos(x) - Math.Cos(y)), 1 + 2 * Math.Sin(y) * Math.Sin(y)) *
                (1 + z + z * z / 2 + z * z * z / 3 + z * z * z * z / 4);
            textBox4.Text += Environment.NewLine + Environment.NewLine + "Результат W = " + w.ToString();
        }
    }
}
