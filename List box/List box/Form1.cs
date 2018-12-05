using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //index value
            if (listBox1.SelectedIndex == 0)
            {
                MessageBox.Show("a,b,c");
            }
            if (listBox1.SelectedIndex == 1)
            {
                MessageBox.Show("d,e,f");
            }
            //by text
            /*string num = listBox1.SelectedItem.ToString();
             //MessageBox.Show(num);
             if (num == "1")
             {
                 MessageBox.Show("a,b,c");
             }
             else if (num == "2")
                 {
                     MessageBox.Show("a,b,c");
                 }
            */
        }
    }
}
