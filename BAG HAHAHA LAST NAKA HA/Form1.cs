namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Move these declarations to the class level to make them accessible throughout the class
        int lrg = 2, md = 1, sm = 1;
        double lp = 3.00, mp = 2.50, sp = 2.00;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Move the declaration of tCost here, and calculate it based on user input
            double tCost = (52 * 5.50) + (lp * lrg) + (mp * md) + (sp * sm);

            label3.Text = "Your total cost is: $" + tCost.ToString("N2");
        }

        private void txtlrg_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}