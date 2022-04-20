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
    public partial class kvadratna : Form
    {
        public kvadratna()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox3.Text);
            int c = Convert.ToInt32(textBox4.Text);
            double det = b * b - 4 * a * c;
            if (det < 0)
            {
                textBox2.Text = "imaginarna resenja";
                textBox5.Text = "imaginarna resenja";
            }
            else
            {
                double x1 = (-1 * b + Math.Sqrt(det)) / (2 * a);
                double x2 = (-1 * b - Math.Sqrt(det)) / (2 * a);
                if (x1 == x2)
                {
                    textBox2.Text = Convert.ToString(Math.Round(x1,2));
                    textBox5.Text = "                          /";
                }
                else
                {
                    textBox2.Text = Convert.ToString(Math.Round(x1,2));
                    textBox5.Text = Convert.ToString(Math.Round(x2,2));
                }
            }
        }
    }
}
