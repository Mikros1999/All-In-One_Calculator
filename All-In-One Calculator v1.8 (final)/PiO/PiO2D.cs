using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PiO
{
    public partial class PiO2D : Form
    {
        public PiO2D()
        {
            InitializeComponent();
        }
      
        private void button1_Click_1(object sender, EventArgs e)
        {
            trougao f = new trougao();
            f.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cetvorougao f = new cetvorougao();
            f.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            petougao f = new petougao();
            f.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            sestougao f = new sestougao();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            krug f = new krug();
            f.Show();
        }

    }
}
