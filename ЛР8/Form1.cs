using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace ЛР8{
    public partial class Form1 : Form{
        Button b = new Button();
        const int n = 15;
        int[,] Mas = new int[n, n];
        public Form1(){
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e){
            Random rand = new Random();
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = n;
            dataGridView1.AutoResizeRows();
            for (int i = 0; i < n; i++)
            {
           DataGridViewColumn column = dataGridView1.Columns[i];
            column.Width = 25;
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Mas[i, j] = rand.Next(-10, 10);
                    dataGridView1.Rows[i].Cells[j].Value = Mas[i, j];
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            double sr = 0;
            int num = 0;
            bool b = true;
            for (int i = 0; i < n; i++)
            {
                sr = 0;
                num = 0;
                if (Mas[i,0]==1)
                {
                    b = false;
                    num = i;
                    for (int j = 0; j < n; j++)
                    {
                        sr += Mas[i, j];
                    }
                    sr = sr / n;
                    string s = sr.ToString("N2");
                    textBox1.Text += "В строке " + Convert.ToString(num+1) + " среднее арифметическое значение = " + Convert.ToString(s) + "." + Environment.NewLine;
                }
            }
            if (b)
            {
                MessageBox.Show("нет строки с первым элементом = 1", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
