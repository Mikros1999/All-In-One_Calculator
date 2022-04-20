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
    public partial class PiO3D : Form
    {
        public PiO3D()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prizma f = new prizma();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            piramida f = new piramida();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            valjak f = new valjak();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            kupa f = new kupa();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lopta f = new lopta();
            f.Show();
        }
    }
}
