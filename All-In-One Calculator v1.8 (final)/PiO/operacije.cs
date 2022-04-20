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
    public partial class operacije : Form
    {
        public operacije()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "sabiranje")
            {
                label8.Text = "+";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            if (comboBox1.Text == "oduzimanje")
            {
                label8.Text = "-";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            if (comboBox1.Text == "množenje")
            {
                label8.Text = "*";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
            }
            if (comboBox1.Text == "deljenje")
            {
                label8.Text = "/";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox6.Text = "";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "sabiranje")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int d = Convert.ToInt32(textBox4.Text);
                int gornji = a * d + b * c;
                int donji = b * d;

                int a1 = gornji, b1 = donji;
                while (b1 > 0)
                {
                    int rem = a1 % b1;
                    a1 = b1;
                    b1 = rem;
                }
                textBox5.Text = Convert.ToString(gornji / a1);
                textBox6.Text = Convert.ToString(donji / a1);

            }
            if (comboBox1.Text == "oduzimanje")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int d = Convert.ToInt32(textBox4.Text);
                int gornji = a * d - b * c;
                int donji = b * d;

                int a1 = gornji, b1 = donji;
                while (b1 > 0)
                {
                    int rem = a1 % b1;
                    a1 = b1;
                    b1 = rem;
                }
                textBox5.Text = Convert.ToString(gornji / a1);
                textBox6.Text = Convert.ToString(donji / a1);
            }
            if (comboBox1.Text == "množenje")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int d = Convert.ToInt32(textBox4.Text);
                int gornji = a * c ;
                int donji = b * d;

                int a1 = gornji, b1 = donji;
                while (b1 > 0)
                {
                    int rem = a1 % b1;
                    a1 = b1;
                    b1 = rem;
                }
                textBox5.Text = Convert.ToString(gornji / a1);
                textBox6.Text = Convert.ToString(donji / a1);
            }
            if (comboBox1.Text == "deljenje")
            {
                int a = Convert.ToInt32(textBox1.Text);
                int b = Convert.ToInt32(textBox2.Text);
                int c = Convert.ToInt32(textBox3.Text);
                int d = Convert.ToInt32(textBox4.Text);
                int gornji = a * d;
                int donji = b * c;

                int a1 = gornji, b1 = donji;
                while (b1 > 0)
                {
                    int rem = a1 % b1;
                    a1 = b1;
                    b1 = rem;
                }
                textBox5.Text = Convert.ToString(gornji / a1);
                textBox6.Text = Convert.ToString(donji / a1);
            }

        }
    }
}
