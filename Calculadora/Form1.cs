namespace Calculadora
{
    public partial class Form1 : Form
    {
        static string sinal;
        static string contas;

        static int conta;
        static int primeiro;
        static int segundo;
        static int zerado;
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
            try
            {
                primeiro = Int32.Parse(texto.Text);
            }
            catch
            {

            }
            finally
            {
                texto.Text = "+";
                sinal = "+";


            }
        }

        private void subtracao_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Int32.Parse(texto.Text);
            }
            catch
            {

            }
            finally
            {
                texto.Text = "-";
                sinal = "-";


            }
        }

        private void divisao_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Int32.Parse(texto.Text);
            }
            catch
            {

            }
            finally
            {
                texto.Text = "/";
                sinal = "/";


            }
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            try
            {
                primeiro = Int32.Parse(texto.Text);
            }
            catch
            {

            }
            finally
            {
                texto.Text = "*";
                sinal = "*";


            }


        }

        private void zero_Click(object sender, EventArgs e)
        {

            if (texto.Text == "+" || texto.Text == "-" || texto.Text == "/" || texto.Text == "*")
            {
                texto.Text = "0";
            }

            else if (contas != null)
            {

                contas = null;
                texto.Text = "0";
            }

            else
            {
                texto.Text = texto.Text + "0";
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
            try
            {
                segundo = Int32.Parse(texto.Text);
            }
            catch
            {

            }
            finally
            {
                if (texto.Text == "+" || texto.Text == "-" || texto.Text == "*" || texto.Text == "/")
                {

                }

                else
                {
                    if (sinal == "+")
                    {
                        conta = primeiro + segundo;
                        segundo = zerado;
                        primeiro = zerado;
                        sinal = "n";
                        contas = conta.ToString();
                        texto.Text = conta.ToString();
                    }
                    else if (sinal == "-")
                    {
                        conta = primeiro - segundo;
                        segundo = zerado;
                        primeiro = zerado;
                        sinal = "n";
                        contas = conta.ToString();
                        texto.Text = conta.ToString();
                    }
                    else if (sinal == "*")
                    {
                        conta = primeiro * segundo;
                        segundo = zerado;
                        primeiro = zerado;
                        sinal = "n";
                        contas = conta.ToString();
                        texto.Text = conta.ToString();
                    }
                    else if (sinal == "/")
                    {
                        conta = primeiro / segundo;
                        segundo = zerado;
                        primeiro = zerado;
                        sinal = "n";
                        contas = conta.ToString();
                        texto.Text = conta.ToString();
                    }

                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}