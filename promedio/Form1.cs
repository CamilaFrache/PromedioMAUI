namespace promedio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(textBox1.Text);
            double numero2 = double.Parse(textBox2.Text);
            double numero3 = double.Parse(textBox3.Text);

            double Promedio = (numero1 + numero2 + numero3) / 3;

            MessageBox.Show("El promedio es " + Promedio);


        }
    }
}