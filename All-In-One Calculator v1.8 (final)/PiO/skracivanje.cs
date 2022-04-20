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
    public partial class skracivanje : Form
    {
        public skracivanje()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int a1 = a, b1 = b;
            while (b1 > 0)
            {
                int rem = a1 % b1;
                a1 = b1;
                b1 = rem;
            }
            textBox3.Text = Convert.ToString(a/a1);
            textBox4.Text = Convert.ToString(b/a1);
        }
    }
}
