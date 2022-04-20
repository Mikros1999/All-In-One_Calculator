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
    public partial class temperatura : Form
    {
        public temperatura()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Celzijus u Kelvin") 
            {
                label1.Text = "C";
                label2.Text = "K";
                textBox1.Text = "";
                textBox2.Text = "";
            }
            if (comboBox1.Text == "Kelvin u Ceclzijus")
            {
                label1.Text = "K";
                label2.Text = "C";
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Celzijus u Kelvin")
            {
                double C = Convert.ToDouble(textBox1.Text);
                double K = C + 273.15;
                textBox2.Text = Convert.ToString(K);
            }
            if (comboBox1.Text == "Kelvin u Ceclzijus")
            {
                double K = Convert.ToDouble(textBox1.Text);
                double C = K - 273.15;
                textBox2.Text = Convert.ToString(C);
            }
        }
    }
}
