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
    public partial class procenti : Form
    {
        public procenti()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "procenat od X") 
            {
                label1.Text = "                procenat";
                label2.Text = "        od";
                label3.Text = "krajnji rezultat";
                label4.Text = "";
                label6.Text = "5% od 80 je 4";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = "                          /";
            }
            if (comboBox1.Text == "X od Y")
            {
                label1.Text = "                       X";
                label2.Text = "            Y";
                label3.Text = "krajnji rezultat";
                label4.Text = "";
                label6.Text = "5  od  85  je  5,88%";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = "                          /";
            }
            if (comboBox1.Text == "popust")
            {
                label1.Text = "pocetna vrednost";
                label2.Text = "popust (%)";
                label3.Text = "krajnji rezultat";
                label4.Text = "popust (vrednost)";
                label6.Text = "ako se vrednost proizvoda koja iznosi 50 din smanji za 15% \n nova vrednost proizvoda je 42.5 din, a popust je 7,5 din";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
            } 
            if (comboBox1.Text == "poskupljenje")
            {
                label1.Text = "pocetna vrednost";
                label2.Text = "porast (%)";
                label3.Text = "krajnji rezultat";
                label4.Text = "porast (vrednost)";
                label6.Text = "ako se vrednost proizvoda koja iznosi 75 din poveca za 40% \n nova vrednost proizvoda je 105 din, a poskupljenje je 30 din";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
            }
            if (comboBox1.Text == "porast/popust u procente")
            {

                label1.Text = "                      od";
                label2.Text = "           do";
                label3.Text = "krajnji rezultat (%)";
                label4.Text = "";
                label6.Text = "ako je proizvod koji je bio 75 din sada 100 din \n povecanje je 33.33%";
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = "                          / ";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "procenat od X")
            {
                double procenat = Convert.ToDouble(textBox1.Text);
                double od = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(Math.Round(procenat * od / 100,2));
            }
            if (comboBox1.Text == "X od Y")
            {
                double X = Convert.ToDouble(textBox1.Text);
                double Y = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(Math.Round(X * 100 / Y,2));
            }
            if (comboBox1.Text == "popust")
            {
                double pocetnaVrednost = Convert.ToDouble(textBox1.Text);
                double popust = Convert.ToDouble(textBox2.Text);
                double popustVrednost = popust / 100 * pocetnaVrednost;
                textBox3.Text = Convert.ToString(Math.Round(pocetnaVrednost - popustVrednost,2));
                textBox4.Text = Convert.ToString(Math.Round(popustVrednost,2));
            }
            if (comboBox1.Text == "poskupljenje")
            {
                double pocetnaVrednost = Convert.ToDouble(textBox1.Text);
                double porast = Convert.ToDouble(textBox2.Text);
                double porastVrednost = porast / 100 * pocetnaVrednost;
                textBox3.Text = Convert.ToString(Math.Round(pocetnaVrednost + porastVrednost,2));
                textBox4.Text = Convert.ToString(Math.Round(porastVrednost,2));
            }
            if (comboBox1.Text == "porast/popust u procente")
            {
                double od = Convert.ToDouble(textBox1.Text);
                double do_ = Convert.ToDouble(textBox2.Text);
                textBox3.Text = Convert.ToString(Math.Round(do_ * 100 / od - 100,2));
            }

        }




    }
}
