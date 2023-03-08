using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textbox
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("welcome " + text1.Text + " " + textBox6.Text);
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            int firstnum, secondnum;

            firstnum = Convert.ToInt32(textBox1.Text);
            secondnum = Convert.ToInt32(textBox2.Text);

            int result = firstnum + secondnum;


            textBox3.Text = Convert.ToString(result);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            label4.Text = "Antal tecken: " + textBox4.Text.Length;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int firstnum, secondnum;

            firstnum = Convert.ToInt32(textBox1.Text);
            secondnum = Convert.ToInt32(textBox2.Text);

            int result = firstnum / secondnum;


            textBox3.Text = Convert.ToString(result);
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            int firstnum, secondnum;

            firstnum = Convert.ToInt32(textBox1.Text);
            secondnum = Convert.ToInt32(textBox2.Text);

            int result = firstnum / secondnum;


            textBox3.Text = Convert.ToString(result);
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            int firstnum, secondnum;

            firstnum = Convert.ToInt32(textBox1.Text);
            secondnum = Convert.ToInt32(textBox2.Text);

            int result = firstnum * secondnum;


            textBox3.Text = Convert.ToString(result);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            int firstnum, secondnum;

            firstnum = Convert.ToInt32(textBox1.Text);
            secondnum = Convert.ToInt32(textBox2.Text);

            int result = firstnum - secondnum;


            textBox3.Text = Convert.ToString(result);
        }
    }
}
