﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PiO
{
    public partial class krug : Form
    {
        public krug()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            double P = r * r * Math.PI;
            double O = 2 * r * Math.PI;
            textBox2.Text = Convert.ToString(2 * r);
            textBox3.Text = Convert.ToString(Math.Round(P,2));
            textBox4.Text = Convert.ToString(Math.Round(O,2));
        }
    }
}
