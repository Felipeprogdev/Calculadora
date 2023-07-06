namespace Calculadora
{
    public partial class Form1 : Form
    {
        static string sinal;
        static string contas;

        static int conta;
        static int primeiro;
        static int segundo;
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
            if (texto.Text != null && texto.Text != "+" || texto.Text != "-" || texto.Text != "/" || texto.Text != "*")
            {
                if (primeiro != null && texto.Text != "+" || texto.Text != "-" || texto.Text != "/" || texto.Text != "*")
                    
                    primeiro = Int32.Parse(texto.Text);
                    
                    
                    if (contas != null)
                    {
                        primeiro = conta;
                    }
            }

            texto.Text = "+";
            sinal = "+";
        }

        private void zero_Click(object sender, EventArgs e)
        {

            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "0";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "0";
            }

            else
            {
                texto.Text = texto.Text + "0";
            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            primeiro = Int32.Parse(texto.Text);
            texto.Text = "-";
            sinal = "-";

            if (contas != null)
            {
                primeiro = conta;
            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            primeiro = Int32.Parse(texto.Text);
            texto.Text = "/";
            sinal = "/";

            if (contas != null)
            {
                primeiro = conta;
            }
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            primeiro = Int32.Parse(texto.Text);
            texto.Text = "*";
            sinal = "*";

            if (contas != null)
            {
                primeiro = conta;
            }
        }

        private void um_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "1";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "1";
            }

            else
            {
                texto.Text = texto.Text + "1";
            }
        }

        private void dois_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "2";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "2";
            }

            else
            {
                texto.Text = texto.Text + "2";
            }
        }

        private void tres_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "3";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "3";
            }

            else
            {
                texto.Text = texto.Text + "3";
            }
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "4";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "4";
            }

            else
            {
                texto.Text = texto.Text + "4";
            }
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "5";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "5";
            }

            else
            {
                texto.Text = texto.Text + "5";
            }
        }

        private void seis_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "6";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "6";
            }

            else
            {
                texto.Text = texto.Text + "6";
            }
        }

        private void sete_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "7";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "7";
            }

            else
            {
                texto.Text = texto.Text + "7";
            }
        }

        private void oito_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "8";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "8";
            }

            else
            {
                texto.Text = texto.Text + "8";
            }
        }

        private void nove_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "9";
            }

            else if (contas != null)
            {
                conta = 0;
                contas = null;
                texto.Text = "9";
            }

            else
            {
                texto.Text = texto.Text + "9";
            }
        }

        private void igual_Click(object sender, EventArgs e)
        {
            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*" || texto.Text != null)
            {

            }
            else
            {
                segundo = Int32.Parse(texto.Text);

                if (sinal == "+")
                {
                    conta = primeiro + segundo;
                }
                else if (sinal == "-")
                {
                    conta = primeiro - segundo;
                }
                else if (sinal == "*")
                {
                    conta = primeiro * segundo;
                }
                else if (sinal == "/")
                {
                    conta = primeiro / segundo;
                }
                contas = conta.ToString();
                texto.Text = conta.ToString();
            }

        }
    }
}