using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_butt
{
    public partial class Form1 : Form
    {
        int click = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Form form2 = new Form();
            form2.Show();
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Text = "hejhej";
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            click++;
            label2.Text = click.ToString();
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            button3.BackColor = Color.AliceBlue;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            label3.Location = new Point(Width, Height);
        }
    }
}
