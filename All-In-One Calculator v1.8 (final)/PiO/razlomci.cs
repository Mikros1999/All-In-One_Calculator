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
    public partial class razlomci : Form
    {
        public razlomci()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            skracivanje f = new skracivanje();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            operacije f = new operacije();
            f.Show();
        }

    }
}
