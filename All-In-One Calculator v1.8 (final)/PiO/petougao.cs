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
    public partial class petougao : Form
    {
        public petougao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double P = a * a * 1.72;
            textBox2.Text = Convert.ToString(P);
            textBox3.Text = Convert.ToString(5 * a); 
        }
    }
}
