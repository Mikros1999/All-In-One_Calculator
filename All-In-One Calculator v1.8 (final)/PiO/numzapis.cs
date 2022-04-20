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
    public partial class numzapis : Form
    {
        public numzapis()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Binarni u Decimalni")
            {
                label1.Text = "  Binarni";
                label2.Text = "Decimalni";
                textBox2.Text = "";
                textBox3.Text = "";
            }
            if (comboBox1.Text == "Decimalni u Binarni")
            {
                label1.Text = "Decimalni";
                label2.Text = "   Binarni";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Binarni u Decimalni")
            {
                int binaryval, decimalval = 0, baseval = 1, rem;
                int num = Convert.ToInt32(textBox2.Text);
                binaryval = num;
                while (num > 0)
                {
                    rem = num % 10;
                    decimalval = decimalval + rem * baseval;
                    num = num / 10;
                    baseval = baseval * 2;
                }
                textBox3.Text = Convert.ToString(decimalval);
            }
            if (comboBox1.Text == "Decimalni u Binarni")
            {
                Int64 BinaryHolder;
                char[] BinaryArray;
                string BinaryResult = "";
                int Decimal = Convert.ToInt32(textBox2.Text);
                while (Decimal > 0)
                {
                    BinaryHolder = Decimal % 2;
                    BinaryResult += BinaryHolder;
                    Decimal = Decimal / 2;
                }

                BinaryArray = BinaryResult.ToCharArray();
                Array.Reverse(BinaryArray);
                BinaryResult = new string(BinaryArray);
                textBox3.Text = Convert.ToString(BinaryResult);
            }
        }

        
    }
}
