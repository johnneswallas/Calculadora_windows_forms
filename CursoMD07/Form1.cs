using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoMD07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            double n1, n2, res = 0;
            string ope = string.Empty;
        }
        public double n1, n2, res;
        public string ope;
        private bool PrecionouIgual;
        private void AdicionarNumero(string numero)
        {
            if (PrecionouIgual == true)
            {
                Tela.Clear();
                PrecionouIgual = false;
            }
            if (!Tela.Text.Trim().Equals("0"))
            {
                Tela.Text += numero;
            }
            else
            {
                Tela.Text = numero;
            }
        }
        private void AdicionarOperaçao(string operacao)
        {
            if (Tela.Text.Trim().Equals(string.Empty))
            {
                return;
            }
            if (Tela.Text.Trim().Contains("."))
            {
                n1 = double.Parse(Tela.Text.Trim().Replace(".", ","));
            }
            else
            {
                n1 = double.Parse(Tela.Text.Trim());
            }

            ope = operacao;
            Tela.Clear();
        }
        private void Calcular()
        {
            switch (ope)
            {
                case "+":
                    Tela.Text = (n1 + n2).ToString();
                    break;
                case "-":
                    Tela.Text = (n1 - n2).ToString();
                    break;
                case "*":
                    Tela.Text = (n1 * n2).ToString();
                    break;
                case "/":
                    if (n2 == 0)
                    {
                        MessageBox.Show("Divisão por 0!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    Tela.Text = (n1 / n2).ToString();
                    break;

            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            AdicionarNumero("0");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AdicionarNumero("1");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            AdicionarNumero("2");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            AdicionarNumero("3");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            AdicionarNumero("4");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            AdicionarNumero("5");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            AdicionarNumero("6");
        }
        private void button7_Click(object sender, EventArgs e)
        {
            AdicionarNumero("7");
        }
        private void button8_Click(object sender, EventArgs e)
        {
            AdicionarNumero("8");
        }
        private void button9_Click(object sender, EventArgs e)
        {
            AdicionarNumero("9");
        }
        private void buttonPonto_Click(object sender, EventArgs e)
        {
            if (PrecionouIgual)
            {
                Tela.Text = "0.";
                PrecionouIgual = false;
            }
            if (Tela.Text.Trim().Equals(string.Empty)) Tela.Text = "0.";
            if (Tela.Text.Trim().Contains(".")) return;
            else
            {
                Tela.Text += ".";
            }

        }
        private void buttonAdicao_Click(object sender, EventArgs e)
        {
            AdicionarOperaçao("+");
        }
        private void buttonIgual_Click(object sender, EventArgs e)
        {
            if (PrecionouIgual)
            {
                Tela.Clear();
                PrecionouIgual = false;
                return;
            }
            if (!Tela.Text.Trim().Equals(string.Empty))
            {
                if (Tela.Text.Trim().Contains("."))
                {
                    n2 = double.Parse(Tela.Text.Trim().Replace(".", ","));
                }
                else
                {
                    n2 = double.Parse(Tela.Text.Trim());
                }
                Calcular();
                PrecionouIgual = true;
            }
            if (Tela.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Digite algum número", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
        private void buttonLimpaTela_Click(object sender, EventArgs e)
        {
            Tela.Clear();
        }
        private void buttonSubtracao_Click(object sender, EventArgs e)
        {
            AdicionarOperaçao("-");
        }
        private void buttonMultiplicacao_Click(object sender, EventArgs e)
        {
            AdicionarOperaçao("*");
        }
        private void buttonDivisao_Click(object sender, EventArgs e)
        {
            AdicionarOperaçao("/");
        }
        private void buttonQuadrado_Click(object sender, EventArgs e)
        {
            if (!Tela.Text.Trim().Equals(string.Empty))
            {
                double valorBase = Convert.ToDouble(Tela.Text.Trim().Replace(".", ","));
                Tela.Clear();
                Tela.Text = Math.Pow(valorBase, 2).ToString();
                PrecionouIgual = true;
            }
        }
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            if (!Tela.Text.Trim().Equals(string.Empty))
            {
                double valorBase = Convert.ToDouble(Tela.Text.Trim().Replace(".",","));
                Tela.Clear();
                Tela.Text = Math.Sqrt(valorBase).ToString();
            }

        }
        private void buttonLimpaUm_Click(object sender, EventArgs e)
        {
            if (!Tela.Text.Trim().Equals(string.Empty))
            {
                int tamanho = Tela.Text.Trim().Length;
                Tela.Text = Tela.Text.Trim().Remove((tamanho - 1));
            }

        }

        private void button1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            Tela.Text = Convert.ToString(e.KeyValue);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void buttonLimpaTudo_Click(object sender, EventArgs e)
        {
            Tela.Clear();

            n1 = 0;
            n2 = 0;
            res = 0;
            ope = string.Empty;
            PrecionouIgual = false;
        }
       
    }
}

