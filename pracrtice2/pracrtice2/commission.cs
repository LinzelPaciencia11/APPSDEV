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
    public partial class commission : Form
    {
        public commission()
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Commission_Load(object sender, EventArgs e)
        {

        }
        public void viewResult(string percentage, double com, double finalAmt)
        {
            lbl1.Text = percentage;
            lbl2.Text = com.ToString("N2");
            lbl3.Text = finalAmt.ToString("N2");
        }
    }
}
