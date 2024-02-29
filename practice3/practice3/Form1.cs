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
    public partial class Form1 : Form
    {
        public Form1()
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

        private void btnbutton_Click(object sender, EventArgs e)
        {
            double box1 = Convert.ToDouble(txtbox1.Text);
            double box2 = Convert.ToDouble(txtbox2.Text);
            char box3 = Convert.ToChar(txtbox3.Text);

            double add = box1 + box2;
            double sub = box1 - box2;
            double mtp = box1 * box2;
            double div = box1 / box2;

            Form2 hi = new Form2();

            switch (box3)
            {
                case 'A':
                case 'a':
                    hi.displayAdd(add);
                    hi.Show();
                    break;
                case 'B':
                case 'b':
                    hi.displaySub(sub);
                    hi.Show();
                    break;
                case 'C':
                case 'c':
                    hi.displayMtp(mtp);
                    hi.Show();
                    break;
                case 'D':
                case 'd':
                    hi.displayDiv(div);
                    hi.Show();
                    break;
            }

        }
    }
}
