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
    public partial class piramida : Form
    {
        public piramida()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "trostrana")
            {  
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
            }
            if (comboBox1.Text == "četvorostrana")
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
            }
            if (comboBox1.Text == "šestostrana")
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "trostrana")
            {

                double a = Convert.ToDouble(textBox1.Text);
                double s = Convert.ToDouble(textBox2.Text);
                double ha = Math.Sqrt(s * s + Math.Pow(a/2,2));
                double P = (a * a * Math.Sqrt(3) / 4) + (3 * a * ha / 2);
                double h = a * Math.Sqrt(3) / 2;
                double H = Math.Sqrt(ha * ha - Math.Pow(h / 2, 2));
                double V = a * a * H * Math.Sqrt(3) / 12;
                textBox4.Text = Convert.ToString(Math.Round(P,2));
                textBox5.Text = Convert.ToString(Math.Round(3 * a + 3 * s,2));
                textBox6.Text = Convert.ToString(Math.Round(V,2));

            }
            if (comboBox1.Text == "četvorostrana")
            {

                double a = Convert.ToDouble(textBox1.Text);
                double s = Convert.ToDouble(textBox2.Text);
                double ha = Math.Sqrt(s * s + Math.Pow(a / 2, 2));
                double P = a * a  + 2 * a * ha;
                double d = a * Math.Sqrt(2);
                double H = Math.Sqrt(s * s - Math.Pow(d / 2, 2));
                double V = a * a * H  / 3;
                textBox4.Text = Convert.ToString(Math.Round(P,2));
                textBox5.Text = Convert.ToString(Math.Round(4 * a + 4 * s,2));
                textBox6.Text = Convert.ToString(Math.Round(V,2));

            }

            if (comboBox1.Text == "šestostrana")
            {

                double a = Convert.ToDouble(textBox1.Text);
                double s = Convert.ToDouble(textBox2.Text);
                double ha = Math.Sqrt(s * s + Math.Pow(a / 2, 2));
                double P = 3 * a * a * Math.Sqrt(3) / 2 + 3 * a * ha;
                double H = Math.Sqrt(s * s - a * a);
                double V = a * a * H * Math.Sqrt(3) / 2;
                textBox4.Text = Convert.ToString(Math.Round(P,2));
                textBox5.Text = Convert.ToString(Math.Round(6 * a + 6 * s,2));
                textBox6.Text = Convert.ToString(Math.Round(V,2));

            }
        }
    }
}
