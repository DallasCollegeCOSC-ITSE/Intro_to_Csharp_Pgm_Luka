﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.SALES_TAX_AND_TOTAL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            //2%
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //4%
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal userin = decimal.Parse(textBox1.Text);
            //2%
            
            //now we codeing :3
            label4.Text = ((userin * 0.02m) + userin).ToString();

            //4%
            label3.Text = ((userin * 0.04m) + userin).ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
