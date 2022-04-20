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
    public partial class ugao : Form
    {
        public ugao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "radijan u stepen") 
            {
                label1.Text = "Radijan";
                label2.Text = "Stepen";
                label3.Text = "Kvadrant";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (comboBox1.Text == "stepen u radijan")
            {
                label1.Text = "Stepen";
                label2.Text = "Radijan";
                label3.Text = "Kvadrant";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "radijan u stepen")
            {
                double radijan = Convert.ToDouble(textBox1.Text);
                double stepen = radijan * 180 / Math.PI;
                textBox2.Text = Convert.ToString(Math.Round(stepen,2));

                while (stepen > 360) stepen -= 360;
                if (stepen < 90 && stepen >= 0) textBox3.Text = "prvi kvadrant";
                    else if (stepen < 180 && stepen >= 90) textBox3.Text = "drugi kvadrant";
                        else if (stepen < 270 && stepen >= 180) textBox3.Text = "treci kvadrant";
                            else if (stepen < 360 && stepen >= 270) textBox3.Text = "cetvrti kvadrant";
            }
            if (comboBox1.Text == "stepen u radijan")
            {
                double stepen = Convert.ToDouble(textBox1.Text);
                double radijan = stepen * Math.PI / 180;
                textBox2.Text = Convert.ToString(Math.Round(radijan,2));
                while (stepen > 360) stepen -= 360;
                if (stepen < 90 && stepen >= 0) textBox3.Text = "prvi kvadrant";
                    else if (stepen < 180 && stepen >= 90) textBox3.Text = "drugi kvadrant";
                        else if (stepen < 270 && stepen >= 180) textBox3.Text = "treci kvadrant";
                            else if (stepen < 360 && stepen >= 270) textBox3.Text = "cetvrti kvadrant";
            }
        }


    }
}
