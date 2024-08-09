using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);
            double mais =  valor1 + valor2;

            textBox_resultado.Text = mais.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);
            double menos = valor1 - valor2;
            textBox_resultado.Text = menos.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor1, valor2;  

            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);
            double divisao = valor1 / valor2;
            textBox_resultado.Text = divisao.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double valor1, valor2;

            valor1 = double.Parse(textBox_valor1.Text);
            valor2 = double.Parse(textBox_valor2.Text);
            double vezes = valor1 + valor2;
            textBox_resultado.Text = vezes.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_valor1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_resultado_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_valor1.Clear();
            textBox_valor2.Clear();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
