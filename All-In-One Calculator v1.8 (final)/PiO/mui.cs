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
    public partial class mui : Form
    {
        public mui()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "mm")
            {
                label1.Text = "mm";
                label2.Text = "cm";
                label3.Text = "dm";
                label4.Text = "m";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";

            }
            if (comboBox1.Text == "cm")
            {
                label1.Text = "cm";
                label2.Text = "mm";
                label3.Text = "dm";
                label4.Text = "m";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }
            if (comboBox1.Text == "dm")
            {
                label1.Text = "dm";
                label2.Text = "mm";
                label3.Text = "cm";
                label4.Text = "m";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }
            if (comboBox1.Text == "m")
            {
                label1.Text = "m";
                label2.Text = "mm";
                label3.Text = "cm";
                label4.Text = "dm";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }
            if (comboBox1.Text == "km")
            {
                label1.Text = "km";
                label2.Text = "mm";
                label3.Text = "cm";
                label4.Text = "dm";
                label5.Text = "m";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }
            if (comboBox1.Text == "Inch")
            {
                label1.Text = "Inch";
                label2.Text = "cm";
                label3.Text = "dm";
                label4.Text = "m";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }
            if (comboBox1.Text == "Foot")
            {
                label1.Text = "Foot";
                label2.Text = "cm";
                label3.Text = "dm";
                label4.Text = "m";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }
            if (comboBox1.Text == "Yard")
            {
                label1.Text = "Yard";
                label2.Text = "cm";
                label3.Text = "dm";
                label4.Text = "m";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }
            if (comboBox1.Text == "Mile")
            {
                label1.Text = "Mile";
                label2.Text = "cm";
                label3.Text = "dm";
                label4.Text = "m";
                label5.Text = "Km";
                label6.Text = "Inch";
                label7.Text = "Foot";
                label8.Text = "Yard";
                label9.Text = "Mile";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "mm")
            {
                int mm = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(mm / 10.0);
                textBox3.Text = Convert.ToString(mm / 100.0);
                textBox4.Text = Convert.ToString(mm / 1000.0);
                textBox5.Text = Convert.ToString(mm / 1000000.0);
                double m = mm / 1000.0;

                textBox6.Text = Convert.ToString(m * 39.3701);
                textBox7.Text = Convert.ToString(m * 3.28084);
                textBox8.Text = Convert.ToString(m * 1.09361);
                textBox9.Text = Convert.ToString(m * 0.000621371);

            }
            if (comboBox1.Text == "cm")
            {
                int cm = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(cm * 10.0);
                textBox3.Text = Convert.ToString(cm / 10.0);
                textBox4.Text = Convert.ToString(cm / 100.0);
                textBox5.Text = Convert.ToString(cm / 100000.0);
                double m = cm / 100.0;

                textBox6.Text = Convert.ToString(m * 39.3701);
                textBox7.Text = Convert.ToString(m * 3.28084);
                textBox8.Text = Convert.ToString(m * 1.09361);
                textBox9.Text = Convert.ToString(m * 0.000621371);

            }
            if (comboBox1.Text == "dm")
            {
                int dm = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(dm * 100.0);
                textBox3.Text = Convert.ToString(dm * 10.0);
                textBox4.Text = Convert.ToString(dm / 10.0);
                textBox5.Text = Convert.ToString(dm / 10000.0);
                double m = dm / 10.0;

                textBox6.Text = Convert.ToString(m * 39.3701);
                textBox7.Text = Convert.ToString(m * 3.28084);
                textBox8.Text = Convert.ToString(m * 1.09361);
                textBox9.Text = Convert.ToString(m * 0.000621371);

            }
            if (comboBox1.Text == "m")
            {
                int m = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(m * 1000.0);
                textBox3.Text = Convert.ToString(m * 100.0);
                textBox4.Text = Convert.ToString(m * 10.0);
                textBox5.Text = Convert.ToString(m / 1000.0);
                textBox6.Text = Convert.ToString(m * 39.3701);
                textBox7.Text = Convert.ToString(m * 3.28084);
                textBox8.Text = Convert.ToString(m * 1.09361);
                textBox9.Text = Convert.ToString(m * 0.000621371);
            }
            if (comboBox1.Text == "km")
            {
                int km = Convert.ToInt32(textBox1.Text);
                textBox2.Text = Convert.ToString(km * 1000000.0);
                textBox3.Text = Convert.ToString(km * 100000.0);
                textBox4.Text = Convert.ToString(km * 10000.0);
                textBox5.Text = Convert.ToString(km * 1000.0);
                double m = km * 1000;

                textBox6.Text = Convert.ToString(m * 39.3701);
                textBox7.Text = Convert.ToString(m * 3.28084);
                textBox8.Text = Convert.ToString(m * 1.09361);
                textBox9.Text = Convert.ToString(m * 0.000621371);

            }
            if (comboBox1.Text == "Inch")
            {
                int inch = Convert.ToInt32(textBox1.Text);
                textBox6.Text = Convert.ToString(inch);
                textBox7.Text = Convert.ToString(inch * 0.0833333);
                textBox8.Text = Convert.ToString(inch * 0.0277778);
                textBox9.Text = Convert.ToString(inch * 0.00157828 / 100);
                double m = inch * 0.0254;

                textBox2.Text = Convert.ToString(m * 100.0);
                textBox3.Text = Convert.ToString(m * 10.0);
                textBox4.Text = Convert.ToString(m);
                textBox5.Text = Convert.ToString(m / 1000.0);

            }
            if (comboBox1.Text == "Foot")
            {
                int Foot = Convert.ToInt32(textBox1.Text);
                textBox6.Text = Convert.ToString(Foot * 12);
                textBox7.Text = Convert.ToString(Foot);
                textBox8.Text = Convert.ToString(Foot * 0.333333);
                textBox9.Text = Convert.ToString(Foot * 0.000189394);
                double m = Foot * 0.3048;

                textBox2.Text = Convert.ToString(m * 100.0);
                textBox3.Text = Convert.ToString(m * 10.0);
                textBox4.Text = Convert.ToString(m);
                textBox5.Text = Convert.ToString(m / 1000.0);

            }
            if (comboBox1.Text == "Yard")
            {
                int Yard = Convert.ToInt32(textBox1.Text);
                textBox6.Text = Convert.ToString(Yard * 36);
                textBox7.Text = Convert.ToString(Yard * 3);
                textBox8.Text = Convert.ToString(Yard);
                textBox9.Text = Convert.ToString(Yard * 0.000568182);
                double m = Yard * 0.9144;

                textBox2.Text = Convert.ToString(m * 100.0);
                textBox3.Text = Convert.ToString(m * 10.0);
                textBox4.Text = Convert.ToString(m);
                textBox5.Text = Convert.ToString(m / 1000.0);

            }
            if (comboBox1.Text == "Mile")
            {
                int Mile = Convert.ToInt32(textBox1.Text);
                textBox6.Text = Convert.ToString(Mile * 63360);
                textBox7.Text = Convert.ToString(Mile * 5280);
                textBox8.Text = Convert.ToString(Mile * 1760);
                textBox9.Text = Convert.ToString(Mile);
                double m = Mile * 1609.34;

                textBox2.Text = Convert.ToString(m * 100.0);
                textBox3.Text = Convert.ToString(m * 10.0);
                textBox4.Text = Convert.ToString(m);
                textBox5.Text = Convert.ToString(m / 1000.0);

            }

        }
    }
}