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
    public partial class kvaluta : Form
    {
        public kvaluta()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Dinar u Evro")
            {
                label1.Text = "Dinarski kurs Evra";
                label7.Text = "din";
                label8.Text = "eur";
                textBox2.Text = "";
                textBox3.Text = "";
                double kurs = 118.08;
                textBox1.Text = Convert.ToString(kurs);
            }
            if (comboBox1.Text == "Evro u Dinar")
            {
                label1.Text = "Dinarski kurs Evra";
                label7.Text = "eur";
                label8.Text = "din";
                textBox2.Text = "";
                textBox3.Text = "";
                double kurs = 118.08;
                textBox1.Text = Convert.ToString(kurs);
               
            }
            if (comboBox1.Text == "Dinar u Dolar")
            {
                label1.Text = "Dinarski kurs Dolara";
                label7.Text = "din";
                label8.Text = "$";
                textBox2.Text = "";
                textBox3.Text = "";
                double kurs = 95.05;
                textBox1.Text = Convert.ToString(kurs);
                
            }
            if (comboBox1.Text == "Dolar u Dinar")
            {
                label1.Text = "Dinarski kurs Dolara";
                label7.Text = "$";
                label8.Text = "din";
                textBox2.Text = "";
                textBox3.Text = "";
                double kurs = 95.05;
                textBox1.Text = Convert.ToString(kurs);
 
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Dinar u Evro")
            {
                int vr = Convert.ToInt32(textBox2.Text);
                double kurs = 118.08;
                textBox1.Text = Convert.ToString(kurs);
                textBox3.Text = Convert.ToString(Math.Round(vr / kurs,2));
            }
            if (comboBox1.Text == "Evro u Dinar")
            {
                int vr = Convert.ToInt32(textBox2.Text);
                double kurs = 118.08;
                textBox1.Text = Convert.ToString(kurs);
                textBox3.Text = Convert.ToString(Math.Round(vr * kurs,2));
            }
            if (comboBox1.Text == "Dinar u Dolar")
            {
                int vr = Convert.ToInt32(textBox2.Text);
                double kurs = 95.05;
                textBox1.Text = Convert.ToString(kurs);
                textBox3.Text = Convert.ToString(Math.Round(vr / kurs,2));
            }
            if (comboBox1.Text == "Dolar u Dinar")
            {
                int vr = Convert.ToInt32(textBox2.Text);
                double kurs = 95.05;
                textBox1.Text = Convert.ToString(kurs);
                textBox3.Text = Convert.ToString(Math.Round(vr * kurs,2));
            }
        }

        
    }
}
