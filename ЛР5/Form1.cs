using System;
using System.Windows.Forms;
using System.Drawing;

namespace ЛР_5___3
{
    public partial class Form1 : Form
    {
        private void MainForm_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();
            panel.Controls.Add(textBox);
            textBox.Location = new Point(157, 100);
        }
        public Form1() 
        { 
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel = new Panel();
            panel.BackColor = Color.HotPink;
            Controls.Add(panel); panel.Location = new Point(10, 10); panel.Size = new Size(450, 300);
            panel.Click += Panel_Click;
            Click += MainForm_Click;
        }
        private Panel panel;
        private void Panel_Click(object sender, EventArgs e)
        {
            Button button = new Button(); button.Text = "Кнопка"; button.Click += Button_Click;

            panel.Controls.Add(button);
            button.BackColor = Color.LightBlue;
            button.Location = new Point(170, 150);
        }

        private void Button_Click(object sender, EventArgs e) 
        { 
            MessageBox.Show("Вы нажали на кнопку!"); 
        }
    }
}