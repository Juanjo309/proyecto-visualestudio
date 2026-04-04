namespace DEMOS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1 = 5;
            int numero2 = 8;
            int total = numero1 + numero2;
            textBox1.Text = total.ToString();
        }
    }
}
