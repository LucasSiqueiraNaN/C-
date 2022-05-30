using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto
{
    public partial class Form1 : Form
    {
        double valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }
        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttoNumber1_Click(object sender, EventArgs e)
        {
            textResultado.Text += "1";
        }

        private void buttonNumber2_Click(object sender, EventArgs e)
        {
            textResultado.Text += "2";
        }

        private void buttonNumber3_Click(object sender, EventArgs e)
        {
            textResultado.Text += "3";
        }

        private void buttonNumber4_Click(object sender, EventArgs e)
        {
            textResultado.Text += "4";
        }

        private void buttonNumber5_Click(object sender, EventArgs e)
        {
            textResultado.Text += "5";
        }

        private void buttonNumber6_Click(object sender, EventArgs e)
        {
            textResultado.Text += "6";
        }

        private void buttonNumber7_Click(object sender, EventArgs e)
        {
            textResultado.Text += "7";
        }

        private void buttonNumber8_Click(object sender, EventArgs e)
        {
            textResultado.Text += "8";
        }

        private void buttonNumber9_Click(object sender, EventArgs e)
        {
            textResultado.Text += "9";
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            valor2 = double.Parse(textResultado.Text);

            if (operacao == "SOMA")
            {
                textResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUBTRACAO")
            {
                textResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULTIPLICACAO")
            {
                textResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else if (operacao == "DIVISAO")
            {
                textResultado.Text = Convert.ToString(valor1 / valor2);
            }
            else if (operacao == "MOD")
            {
                textResultado.Text = Convert.ToString(valor1 % valor2);
            }
            else if (operacao == "POTENCIACAO")
            {
                textResultado.Text = Convert.ToString(Math.Pow(valor1, valor2));
            }
            else if (operacao == "RAIZ")
            {
                textResultado.Text = Convert.ToString(Math.Pow(valor1, 1.0 / valor2));
            }
        }

        private void buttonSoma_Click(object sender, EventArgs e)
        {
            if (valor1 != 0)
            {
                valor1 += double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "SOMA";
            }
            else if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "SOMA";
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar a soma!");
            }

        }

        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            if (textResultado.Text == "")
            {
                textResultado.Text += "-";

            }
            else if (valor1 != 0)
            {
                valor1 -= double.Parse(textResultado.Text);
                textResultado.Text = "";
            }
            else if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "SUBTRACAO";
            }
        }

        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            if (valor1 != 0)
            {
                valor1 *= double.Parse(textResultado.Text);
                textResultado.Text = "";

            }
            else if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "MULTIPLICACAO";
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar a Multiplicacao!");
            }

        }

        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            if (valor1 != 0)
            {
                valor1 /= double.Parse(textResultado.Text);
                textResultado.Text = "";

            }
            else if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "DIVISAO";
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar a Divisao!");
            }
        }


        private void buttonSeno_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Sin(valor1 * Math.PI / 180));
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular o Seno!");
            }
        }

        private void buttonCosseno_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Cos(valor1 * Math.PI / 180));
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular o Cosseno!");
            }
        }

        private void buttonTangente_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Tan(valor1 * Math.PI / 180));
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular a Tangente!");
            }
        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "MOD";
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar o Módulo!");
            }
        }

        private void buttonPotencia_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "POTENCIACAO";
            }
            else
            {
                MessageBox.Show("Informe um valor para efetuar a Potenciacao!");
            }
        }


        private void buttonPotencia2_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Pow(valor1, 2));
            }
            else
            {
                MessageBox.Show("Informe um valor para elevar a 2!");
            }
        }



        private void buttonPotencia3_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Pow(valor1, 3));
            }
            else
            {
                MessageBox.Show("Informe um valor para elevar a 3!");
            }
        }

        private void buttonLogaritmo_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Log10(valor1));
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar o Logaritmo!");
            }
        }

        private void buttonFatorial_Click(object sender, EventArgs e)
        {
            if ((double.Parse(textResultado.Text)) <= 0)
            {
                MessageBox.Show("Nao eh possivel fazer fatorial de numero negativo e nulo!");

            }
            else if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                double resultado = 1;

                while (valor1 != 1)
                {
                    resultado *= valor1;
                    valor1 -= 1;
                }
                valor1 = 0;

                textResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular a Fatoriacao!");
            }
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = "";
                operacao = "RAIZ";
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular a Raiz!");
            }
        }

        private void buttonRaizCubica_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Pow(valor1, 1.0 / 3.0));
            }
            else
            {
                MessageBox.Show("Informe um valor para calcular a Raiz Cubica!");
            }
        }

        private void buttoneBase10_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Pow(10, valor1));
            }
            else
            {
                MessageBox.Show("Informe um valor para elevar 10!");
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            int x = textResultado.Text.Length - 1;
            if (x >= 0)
            {
                textResultado.Text = textResultado.Text.Substring(0, x);
            }
        }

        private void buttoNumber0_Click(object sender, EventArgs e)
        {
            textResultado.Text += "0";
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            textResultado.Text += ",";
        }

        private void buttoNegative_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                double aux = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(aux * -1);
            }
            else
            {
                MessageBox.Show("Informe um valor primeiro!");
            }
        }

        private void buttonRaizQuadrada_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                textResultado.Text = Convert.ToString(Math.Sqrt(valor1));
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar a Raiz!");
            }
        }

        private void buttonPorcentagem_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                valor1 /= 100;
                textResultado.Text = Convert.ToString(valor1);
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar a Porcentagem!");
            }
        }

        private void buttonPotenciacaoeRaiz_Click(object sender, EventArgs e)
        {
            if (textResultado.Text != "")
            {
                valor1 = double.Parse(textResultado.Text);
                valor1 = 1 / valor1;
                textResultado.Text = Convert.ToString(valor1);
            }
            else
            {
                MessageBox.Show("Informe um valor para efeturar a Potencia e Raiz!");
            }
        }
    }
}
