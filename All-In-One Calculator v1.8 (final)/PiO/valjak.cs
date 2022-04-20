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
    public partial class valjak : Form
    {
        public valjak()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            double H = Convert.ToDouble(textBox2.Text);
            double P =2 * r * Math.PI * (r + H);
            double V = r * r * Math.PI * H;
            textBox3.Text = Convert.ToString(Math.Round(P,2));
            textBox4.Text = Convert.ToString(Math.Round(V,2));
        }
    }
}
