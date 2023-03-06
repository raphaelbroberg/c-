using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace knapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Magenta;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Top -= 5;
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Top += 5;
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Left += 5;
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            label1.Left -= 5;
        }

        private void button6_MouseHover(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
        }
    }
}
