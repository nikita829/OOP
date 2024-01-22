using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛР5
{
    //public partial class Form1 : Form
    //{
    //    List<Panel> p = new List<Panel>();
    //    public Form1()
    //    {
    //        InitializeComponent();
    //        for (int i = 0; i < 3; i++)
    //        {
    //            p.Add(new Panel()
    //            {
    //                Location = new Point(50 + 150 * i, 50),
    //                Size = new Size(100, 100),
    //                BackColor = Color.Green,
    //                Tag = i,
    //            });
    //            Controls.Add(p[i]);
    //            p[i].MouseClick += PanelClick;
    //        }
    //        InitParams();
    //    }
    //    private void PanelClick(object s, EventArgs e)
    //    {
    //        int tag = (int)((Panel)s).Tag;
    //        int control = tag + 1;
    //        if (control == 3) control = 0;
    //        p[control].Controls.Add(AddedControls(tag));
    //    }
    //    Size size; Point point;
    //    private void InitParams()
    //    {
    //        size = new Size(p[1].Width / 2, p[1].Height / 2);
    //        point = new Point(p[1].Width / 4, p[1].Height / 4);
    //    }
    //    private Control AddedControls(int tag)
    //    {
    //        switch (tag)
    //        {
    //            case 0:
    //                return new Button() { Size = size, Location = point };
    //            case 1:
    //                return new TextBox() { Size = size, Location = point };
    //            default:
    //                return new Label() { Size = size, Location = point, Text = "Привет!" };
    //        }
    //    }
    //}
    public class MainForm : Form
    {
        private Panel panel;

        public MainForm()
        {
            panel = new Panel();
            panel.Dock = DockStyle.Fill;

            panel.Click += Panel_Click;
            this.Click += MainForm_Click;

            this.Controls.Add(panel);
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Button";
            button.Click += Button_Click;

            panel.Controls.Add(button);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            TextBox textBox = new TextBox();

            panel.Controls.Add(textBox);
        }

        [STAThread]
        static void Main()
        {
            Application.Run(new MainForm());
        }
    }
}