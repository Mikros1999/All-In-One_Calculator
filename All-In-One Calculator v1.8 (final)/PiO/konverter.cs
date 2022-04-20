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
    public partial class konverter : Form
    {
        public konverter()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            numzapis f = new numzapis();
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ugao f = new ugao();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mui f = new mui();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            kvaluta f = new kvaluta();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rimskibr f= new rimskibr();
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            temperatura f = new temperatura();
            f.Show();
        }
    }
}
