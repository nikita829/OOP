using System;
using System.Windows.Forms;
namespace ЛР6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите строку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int len = str.Length;
            int count = 0;
            int i = 0;
            while (i < len)
            {
                if (str[i] == '1' || str[i] == '2'|| str[i] == '3' || str[i] == '4' || str[i] == '5' || str[i] == '6' || str[i] == '7' ||
                    str[i] == '8' || str[i] == '9' || str[i] == '0')
                    count++;
                i++;
            }
            label1.Text = "Количество цифр = " +
            count.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
