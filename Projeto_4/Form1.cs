using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class Form_reservaPassagem : Form
    {
        public Form_reservaPassagem()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            //limpar
            //textBox_nome.Text = "";
            textBox_nome.Clear();
            //comboBox_destino.Text= "";
            comboBox_destino.Text = string.Empty;
            radioButton_aviao.Checked = false;
            radioButton_onibus.Checked = false;
            dateTimePicker_data.Value = DateTime.Now;
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            //confirmar
            if (textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite seu nome:");
                textBox_nome.Focus();
            }
            else if (comboBox_destino.Text == "")
            {
                MessageBox.Show("Destino não selecionado");
                comboBox_destino.Focus();
            }

            if (radioButton_aviao.Checked == false && radioButton_onibus.Checked == false)
            {
                MessageBox.Show("Meio de transportenão selecionado");
                radioButton_aviao.Focus();
            }
        }

        private void Form_reservaPassagem_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 170);
            groupBox_valoresPacote.Visible = false;
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            //calcular

            double gasto_destino, gasto_transporte, gasto_total;

            //Destino
            switch (comboBox_destino.Text.ToUpper()) 
            {
                case "SP":
                    gasto_destino = 1000;
                    break;
                case "RJ":
                    gasto_destino = 1500;
                    break;
                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                    break;
            }
            //Meio de transporte
            if (radioButton_aviao.Checked == true)
            {
                gasto_transporte = 100;
            }
            else
            {
                gasto_transporte = 30;
            }
            //calculo valor total
            gasto_total = gasto_transporte + gasto_destino;

            //redimensionamento
            this.ClientSize = new System.Drawing.Size(640, 300);
            groupBox_valoresPacote.Visible = true;

            //Exibir
            label_gastoTransporte.Text = gasto_transporte.ToString("F2");
            label_destino.Text = gasto_destino.ToString("F2");
            label_valorTotal.Text = gasto_total.ToString("F2");
            //C2 = poe o . no milhar e coloca o R$
        }
    }
}