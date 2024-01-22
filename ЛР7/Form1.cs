using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const int n = 25;
        int[] Mas1 = new int[n];
        int[] Mas2 = new int[n];
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Random rand = new Random();
            for (int i = 1; i <= n; i++)
            {
                Mas1[i-1] = rand.Next(-10, 10);
                listBox1.Items.Add("Mas[" + i + "] = " + Mas1[i-1]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            for (int i = 1; i <= n; i++)
            {
                if (Mas1[i-1] > 0)
                    Mas2[i-1] = Mas1[i-1] + 7;
                if (Mas1[i-1] < 0)
                    Mas2[i-1] = Mas1[i-1] * Mas1[i-1];
                if (Mas1[i-1] == 0)
                    Mas2[i-1] = Mas1[i-1];
                listBox2.Items.Add("Mas[" + i + "] = " + Mas2[i-1]);
            }
        }
    }
}
