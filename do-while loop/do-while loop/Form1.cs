using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace do_while_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int b = int.Parse(textBox1.Text);
            int i = 0;
            do
            {
                label1.Text += i;
                i++;
            } while (i < b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = int.Parse(textBox2.Text);
            for(int i=0; i<7; i++)
            {
                textBox3.Text += i;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double c = double.Parse(textBox4.Text);
  
        }
    }
}
