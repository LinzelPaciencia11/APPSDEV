namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        int yards, remainingCm, feet, cInches;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cLength = Convert.ToInt32(txtlength.Text);
            yards = cLength / 91;
            remainingCm = cLength % 91;
            feet = remainingCm / 30;
            cInches = (int)((remainingCm % 30) / 2.54);

            label6.Text = yards + " yards, " + feet + " feet (foot), " + cInches + " inches";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}