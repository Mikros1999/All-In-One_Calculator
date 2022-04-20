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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PiO2D f = new PiO2D();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PiO3D f = new PiO3D();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            procenti f = new procenti();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            jednacine f = new jednacine();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            konverter f = new konverter();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _dig f = new _dig();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            razlomci f = new razlomci();
            f.Show();
        }
     
        
    }
}
