using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labelevent
{
    
    public partial class Form1 : Form
    {
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Magenta;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.BackColor = Color.Magenta;
            label2.ForeColor = Color.White;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            score++;
            this.Text = score.ToString();
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label5.Text = "Tack för att du besökte oss";
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label5.Text = "hej hej";
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            int x, y;

            Random random = new Random();
            x = random.Next(0, 818);
            y = random.Next(0, 497);

            label6.Left = x;
            label6.Top = y;
        }
    }
}
