namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double input = Convert.ToDouble(textBox1.Text);

            Form2 lo = new Form2();
            lo.display(input);
            lo.Show();
        }
    }
}