﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsExample1
{
    public partial class Form1 : Form
    {
        public Form1()
         {
            InitializeComponent();
        }


        int k = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            k++;
            MessageBox.Show(string.Format("clicked {0} times!",k));
        }


        void myButtonClick(object o, EventArgs e)
        {
            Button b1 = o as Button;

            if(b1.Name == "button1")
            {
                MessageBox.Show(b1.Text);
            }
            else
            {
                MessageBox.Show(b1.Text + "!!!!!!!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            dateInfoLabel.Text = DateTime.Now.ToString(@"HH:MM");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateInfoLabel.Text = DateTime.Now.ToString(@"HH:mm:ss");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
