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
    public partial class cetvorougao : Form
    {
        public cetvorougao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "pravougaonik")
            {
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "d";
                label4.Text = "P";
                label5.Text = "O";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            if (comboBox1.Text == "kvadrat")
            {
                label1.Text = "a";
                label2.Text = "";
                label3.Text = "d";
                label4.Text = "P";
                label5.Text = "O";
                textBox1.Text = " ";
                textBox2.Text = "                          /";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            if (comboBox1.Text == "paralelogram")
            {
                label1.Text = "a";
                label2.Text = "h";
                label3.Text = "";
                label4.Text = "P";
                label5.Text = "O";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = "                          /";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            if (comboBox1.Text == "romb")
            {
                label1.Text = "d1";
                label2.Text = "d2";
                label3.Text = "a";
                label4.Text = "P";
                label5.Text = "O";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "pravougaonik")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                //int c = Convert.ToInt32(textBox3.Text);
                double d = Math.Sqrt(a * a + b * b);
                textBox3.Text = Convert.ToString(Math.Round(d , 2));
                textBox4.Text = Convert.ToString(Math.Round(a * b , 2));
                textBox5.Text = Convert.ToString(Math.Round(2 * a + 2 * b , 2));
            }
            else if (comboBox1.Text == "paralelogram")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double h = Convert.ToDouble(textBox2.Text);
                //double d = Math.Sqrt(2) * a;
                //textBox3.Text = Convert.ToString(d);
                textBox4.Text = Convert.ToString(Math.Round(a * h,2));
                textBox5.Text = Convert.ToString(Math.Round(4 * a,2));
            }
            else if (comboBox1.Text == "kvadrat")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double d = Math.Sqrt(2) * a;
                textBox3.Text = Convert.ToString(Math.Round(d,2));
                // textBox3.Text = Convert.ToString(a);
                textBox4.Text = Convert.ToString(Math.Round(a * a,2));
                textBox5.Text = Convert.ToString(Math.Round(4 * a,2));
            }
            else if (comboBox1.Text == "romb")
            {
                double d1 = Convert.ToDouble(textBox1.Text);
                double d2 = Convert.ToDouble(textBox2.Text);
                //double d = Math.Sqrt(2) * a;
                //textBox3.Text = Convert.ToString(d);
                textBox3.Text = Convert.ToString(Math.Round(Math.Sqrt(d1 * d1 + d2 * d2)/4,2));
                textBox4.Text = Convert.ToString(Math.Round(d1 * d2 / 2,2));
                textBox5.Text = Convert.ToString(Math.Round(Math.Sqrt(d1 * d1 + d2 * d2),2));
            }

        }

        
    }
}
