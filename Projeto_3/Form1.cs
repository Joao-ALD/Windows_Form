using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3
{
    public partial class Form_calculadora_imc : Form
    {
        public Form_calculadora_imc()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label_resultado_situacao_Click(object sender, EventArgs e)
        {

        }

        private void label_resultado_imc_Click(object sender, EventArgs e)
        {

        }

        private void label_imc_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;

            peso = double.Parse(textBox_peso.Text);
            altura = Convert.ToDouble(textBox_altura.Text); //outra opção de FORMATAÇÃo
            imc = peso / (altura * altura);

            label_resultado_imc.Text = imc .ToString();

            if (imc < 19)
            {
                label_resultado_situacao.Text = "Abaixo do Peso";
            }
            else if (imc >= 19 && imc < 25)
            {
                label_resultado_situacao.Text = "Peso ideal";
            }
            else
            {
                label_resultado_situacao.Text = "Acima do Peso";
            }
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Deseja sair ?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) 
                == DialogResult.Yes) 
            {
                this.Close();
            }
        }

        private void textBox_peso_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
