using System.Drawing.Text;
using Calculadora.Utilitários;

namespace Calculadora
{
    public partial class CalculadoraLayout : Form
    {
        public CalculadoraLayout()
        {
            InitializeComponent();
            calc = new Calculadora1();
        }

        double numero1;
        string operacao;

        private Calculadora1 calc;

        private void Botao1_Click(object sender, EventArgs e)
        {
            Display.Text += "1";
        }

        private void Botao2_Click(object sender, EventArgs e)
        {
            Display.Text += "2";
        }

        private void Botao3_Click(object sender, EventArgs e)
        {
            Display.Text += "3";
        }

        private void Botao4_Click(object sender, EventArgs e)
        {
            Display.Text += "4";
        }

        private void Botao5_Click(object sender, EventArgs e)
        {
            Display.Text += "5";
        }

        private void Botao6_Click(object sender, EventArgs e)
        {
            Display.Text += "6";
        }

        private void Botao7_Click(object sender, EventArgs e)
        {
            Display.Text += "7";
        }

        private void Botao8_Click(object sender, EventArgs e)
        {
            Display.Text += "8";
        }

        private void Botao9_Click(object sender, EventArgs e)
        {
            Display.Text += "9";
        }

        private void Botao0_Click(object sender, EventArgs e)
        {
            Display.Text += "0";
        }

        private void BotaoDec_Click(object sender, EventArgs e)
        {
            if (!Display.Text.Contains("."))
            {
                if (Display.Text == "")
                {
                    Display.Text += "0.";
                }
                else
                {
                    Display.Text += ".";
                }
            }
            else
            {
                MessageBox.Show("Só pode haver um ponto decimal!", "Erro");
            }
        }

        private void BotaoAdc_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Display.Text);

            operacao = "+";
            Display.Text = "";
        }

        private void BotaoSub_Click(object sender, EventArgs e)
        {
            if (Display.Text == "")
            {
                Display.Text = "-";
            }
            else
            {
                numero1 = double.Parse(Display.Text);
                operacao = "-";
                Display.Text = "";
            }
        }

        private void BotaoMult_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Display.Text);

            operacao = "*";
            Display.Text = "";
        }

        private void BotaoDiv_Click(object sender, EventArgs e)
        {

            numero1 = double.Parse(Display.Text);

            operacao = "/";
            Display.Text = "";
        }

        private void BotaoFat_Click(object sender, EventArgs e)
        {
            try
            {
                long numero1 = long.Parse(Display.Text);

                if (numero1 < 0)
                {
                    Display.Text = "Inválido";
                    return;
                }

                long resultado = calc.Fatorial(numero1);
                Display.Text = resultado.ToString();
            }
            catch
            {
                Display.Text = "Erro";
            }
        }

        private void BotaoSen_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Display.Text);

            double resultado = calc.Seno(numero1);
            Display.Text = resultado.ToString();
        }

        private void BotaoCos_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Display.Text);

            double resultado = calc.Cosseno(numero1);
            Display.Text = resultado.ToString();
        }

        private void BotaoTan_Click(object sender, EventArgs e)
        {
            numero1 = double.Parse(Display.Text);

            double resultado = calc.Tangente(numero1);
            Display.Text = resultado.ToString();
        }

        private void BotaoBin_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(Display.Text);

            string resultado = calc.Binario(numero1);
            Display.Text = resultado.ToString();
        }

        private void BotaoClear_Click(object sender, EventArgs e)
        {
            Display.Text = "";
        }

        private void BotaoDel_Click(object sender, EventArgs e)
        {
            if (Display.Text.Length > 0)
            {
                Display.Text = Display.Text.Substring(0, Display.Text.Length - 1);
            }
            else
            {
                Display.Text = "";
            }
        }

        private void BotaoRes_Click(object sender, EventArgs e)
        {
            double numero2 = double.Parse(Display.Text);
            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    break;
            }

            Display.Text = resultado.ToString();
        }
    }
}
