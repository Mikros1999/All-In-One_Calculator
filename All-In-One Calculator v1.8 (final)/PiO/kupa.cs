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
    public partial class kupa : Form
    {
        public kupa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            double s = Convert.ToDouble(textBox2.Text);
            double P = r * Math.PI * (r + s);
            double H = Math.Sqrt(s * s - r * r);
            double V = r * r * Math.PI * H  / 3;
            textBox3.Text = Convert.ToString(Math.Round(P,2));
            textBox4.Text = Convert.ToString(Math.Round(V,2));
        }
    }
}
