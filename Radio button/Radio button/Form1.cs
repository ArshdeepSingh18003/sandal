﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radio_button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
      
        {
            if (radioButton1.Checked)
            {
                label1.Text = "This is 1st button";
            }
            else if (radioButton2.Checked)
            {
                label1.Text = "This is 2nd button";
            }
            else if (radioButton3.Checked)
            {
                label1.Text = "This is 3rd button";
            }
        }
    }
}
        