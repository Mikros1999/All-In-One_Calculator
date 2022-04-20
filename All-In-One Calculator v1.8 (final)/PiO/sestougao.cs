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
    public partial class sestougao : Form
    {
        public sestougao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double P = a * a * 3 / 2 * Math.Sqrt(3);
            textBox2.Text = Convert.ToString(Math.Round(P,2));
            textBox3.Text = Convert.ToString(Math.Round(6 * a,2));
        }
    }
}
