using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracrtice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbutton_Click(object sender, EventArgs e)
        {
            double january = Convert.ToDouble(txtjan.Text);
            double february = Convert.ToDouble(txtfeb.Text);
            double march = Convert.ToDouble(txtmar.Text);

            double total = january + february + march;
            txtcom.Text = total.ToString("N2");

            string percentage = " ";
            double com = 0, finalAmt = 0;

            if (chb1.Checked)
            {
                percentage = "50%";
                com = total * 0.50;
                finalAmt = total + com;
            }
            else if (chb2.Checked)
            {
                percentage = "10%";
                com = total * 0.10;
                finalAmt = total + com;
            }
            else if (chb3.Checked)
            {
                percentage = "15%";
                com = total * 0.15;
                finalAmt = total + com;
            }

            commission tally = new commission();
            tally.viewResult(percentage, com, finalAmt);
            tally.Show();
        }
    }
}
