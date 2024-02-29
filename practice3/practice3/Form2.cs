using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practice3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtbox4_TextChanged(object sender, EventArgs e)
        {

        }
        public void displayAdd(double add)
        {
            txtbox4.Text = add.ToString("N2");
        }
        public void displaySub(double sub)
        {
            txtbox4.Text = sub.ToString("N2");
        }
        public void displayMtp(double mtp)
        {
            txtbox4.Text = mtp.ToString("N2");
        }
        public void displayDiv(double div)
        {
            txtbox4.Text = div.ToString("N2");
        }
    }
}
