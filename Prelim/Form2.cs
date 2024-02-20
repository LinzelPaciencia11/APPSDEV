using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form2 : Form

    {
        
        public Form2()
        {
            InitializeComponent();
            
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void display(double input)
        {
           
            double num = 0;
            for (double count = 1; count <= 3; count++)
            {
                num += input;
            }
            label1.Text = num.ToString("N2");
            if (num > 2000)
            {

                label2.Text = "it is saleable.";

            }
            else
            {
                label2.Text = "it is not saleable.";

            }
        }


    }
}
