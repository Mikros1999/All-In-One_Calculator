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
    public partial class prizma : Form
    {
        public prizma()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "kvadar")
            {
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "c (H)";
                label4.Text = "P";
                label5.Text = "O";
                label6.Text = "V";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
            }
            if (comboBox1.Text == "kocka")
            {
                label1.Text = "a";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "P";
                label5.Text = "O";
                label6.Text = "V";
                textBox1.Text = " ";
                textBox2.Text = "                          /";
                textBox3.Text = "                          /";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "kvadar")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                
                textBox4.Text = Convert.ToString(Math.Round(2 * ( a * b + a * c + c * b),2));
                textBox5.Text = Convert.ToString(Math.Round(4 * (a + b + c ),2));
                textBox6.Text = Convert.ToString(Math.Round(a * b * c,2));
            }
            else if (comboBox1.Text == "kocka")
            {
                double a = Convert.ToDouble(textBox1.Text);
                textBox4.Text = Convert.ToString(Math.Round(6 * a * a,2));
                textBox5.Text = Convert.ToString(Math.Round(12 * a,2));
                textBox6.Text = Convert.ToString(Math.Round(a * a * a,2));
            }

        }
    }
}
