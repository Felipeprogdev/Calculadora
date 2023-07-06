namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultado_mostra_Click(object sender, EventArgs e)
        {

        }

        private void soma_Click(object sender, EventArgs e)
        {
            int primerio = Int32.Parse(texto.Text);
            int segundo = Int32.Parse(textBox2.Text);
            int conta = primerio + segundo;

            resultado_mostra.Text = conta.ToString();

        }
    }
}