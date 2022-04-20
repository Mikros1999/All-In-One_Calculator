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
    public partial class lopta : Form
    {
        public lopta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text);
            double P = 4* r * r * Math.PI;
            double V = 4 * r * r * r * Math.PI / 3;
            textBox3.Text = Convert.ToString(Math.Round(P,2));
            textBox4.Text = Convert.ToString(Math.Round(V,2));
        }
    }
}
