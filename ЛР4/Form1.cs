using System;
using System.Windows.Forms;

namespace ЛР4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "X0: ";
            label7.Text = "Xk: ";
            label8.Text = "Dx: ";
            label9.Text = "A: ";
            label10.Text = "B: ";
            textBox6.Text = "5,3";
            textBox7.Text = "10,3";
            textBox8.Text = "0,25";
            textBox9.Text = "1,35";
            textBox11.Text = "-6,25";
            button2.Text = "Выполнить";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            double x0 = 0, xk = 0, dx = 0, a = 0, b = 0;
            if (!double.TryParse(textBox6.Text, out x0) || !double.TryParse(textBox7.Text, out xk) 
                || !double.TryParse(textBox8.Text, out dx) || !double.TryParse(textBox9.Text, out a) || !double.TryParse(textBox11.Text, out b))
            {
                MessageBox.Show("Некорректный ввод данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (x0 > double.MaxValue || x0 < double.MinValue || xk > double.MaxValue || xk < double.MinValue || dx > double.MaxValue
                || a > double.MaxValue || a < double.MinValue || b > double.MaxValue || b < double.MinValue || x0 > xk || dx<=0)
            {
                MessageBox.Show("Некорректный ввод данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            x0 = Convert.ToDouble(textBox6.Text);
            xk = Convert.ToDouble(textBox7.Text);
            dx = Convert.ToDouble(textBox8.Text);
            a = Convert.ToDouble(textBox9.Text);
            b = Convert.ToDouble(textBox11.Text);
            textBox10.Text += "Лаб.раб.N4 АСУ-22-1б Варов Л.А. Каруба Д.В. Кузнецов Н.И." + Environment.NewLine;
            double x = x0;
            while (x <= (xk + dx / 2))
            {
                double y = a * Math.Pow(x, 3) + Math.Pow(Math.Cos(Math.Pow(x, 3) - b), 2);
                string s = y.ToString("N2");
                textBox10.Text += "x = " + Convert.ToString(x) + "; y = " + Convert.ToString(s) + Environment.NewLine;
                x = x + dx;
            }
        }
    }
}
