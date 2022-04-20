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
    public partial class trougao : Form
    {
        public trougao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "jednakostranicni")
            {
                label1.Text = "a";
                label2.Text = "";
                label3.Text = "";
                label4.Text = "P";
                label5.Text = "O";
                textBox1.Text = " ";
                textBox2.Text = "                          /";
                textBox3.Text = "                          /";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            if (comboBox1.Text == "pravougli")
            {
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "c";
                label4.Text = "P";
                label5.Text = "O";
                textBox1.Text = " ";
                textBox1.Text = " ";
                textBox3.Text = "                          /";
                textBox4.Text = " ";
                textBox5.Text = " ";
            } 
            if (comboBox1.Text == "jednakokraki")
            {
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "";
                label4.Text = "P";
                label5.Text = "O";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = "                          /";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            if (comboBox1.Text == "raznostranicni")
            {
                label1.Text = "a";
                label2.Text = "b";
                label3.Text = "c";
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
          if( comboBox1.Text == "pravougli")
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
            //int c = Convert.ToInt32(textBox3.Text);
                textBox4.Text = Convert.ToString(Math.Round(a * b / 2, 2) );
            double c = Math.Sqrt(a * a + b * b);
            textBox5.Text = Convert.ToString(Math.Round(a + b + c, 2));
            }
          else if (comboBox1.Text == "jednakostranicni")
          {
              double a = Convert.ToDouble(textBox1.Text);
             // textBox2.Text = Convert.ToString(a);
             // textBox3.Text = Convert.ToString(a);
              textBox4.Text = Convert.ToString(Math.Round(Math.Pow(a, 2) * Math.Sqrt(3) / 4,2));
              textBox5.Text = Convert.ToString(Math.Round(a + a + a,2));
          }
          else if (comboBox1.Text == "jednakokraki")
          {
              double a = Convert.ToDouble(textBox1.Text);
              double b = Convert.ToDouble(textBox2.Text);
              // textBox3.Text = Convert.ToString(a);
              textBox4.Text = Convert.ToString(Math.Round(Math.Pow(a, 2) * Math.Sqrt(3) / 2,2));
              textBox5.Text = Convert.ToString(Math.Round(a + a + a,2));
          }
          else if (comboBox1.Text == "raznostranicni")
          {
              double a = Convert.ToDouble(textBox1.Text);
              double b = Convert.ToDouble(textBox2.Text);
              double c = Convert.ToDouble(textBox3.Text);
              double S = (a + b + c) / 2;
              double P = (Math.Sqrt(S * (S - a) * (S - b) * (S - c)));
              if (P <= 0)
              {
                  textBox4.Text = "trougao ne postoji";
                  textBox5.Text = "trougao ne postoji";
              }
              else
              {
                  textBox4.Text = Convert.ToString(Math.Round(P,2));
                  textBox5.Text = Convert.ToString(Math.Round(a + b + c,2));
                  
              }
              
          }
       
        }

        
    }
}
