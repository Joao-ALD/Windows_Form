using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace projeto_6
{
    public partial class Form1 : Form
    {

        List<Pessoa> pessoas;

        public Form1()
        {
            InitializeComponent();

            pessoas = new List<Pessoa> ();

            comboBox_estadoCivil.Items.Add("Casado");
            comboBox_estadoCivil.Items.Add("Solteiro");
            comboBox_estadoCivil.Items.Add("Viúvo");
            comboBox_estadoCivil.Items.Add("Divorciado");

            comboBox_estadoCivil.SelectedIndex = 0;

            //dataGrifView
            dataGridView_pessoa.Columns.Add("Nome", "Nome");
            dataGridView_pessoa.Columns.Add("DataNascimento", "Data de nascimento");
            dataGridView_pessoa.Columns.Add("EstadoCivil", "Estado Civil");
            dataGridView_pessoa.Columns.Add("Telefone", "Telefone");
            dataGridView_pessoa.Columns.Add("CasaPropia", "Casa Propia");
            dataGridView_pessoa.Columns.Add("Veiculo", "Veiculo");
            dataGridView_pessoa.Columns.Add("Sexo", "Sexo");

        }

        private void button_cadastrarAlterar_Click(object sender, EventArgs e)
        {
            int index = -1; // Verifica se o usuario ja esta cadastrado

            //Verifica se os nomes são iguais (Nome é nosso parâmetro)
            foreach (Pessoa pessoa in pessoas)
            {
                if (pessoa.Nome == textBox_nome.Text)
                {
                    index = pessoas.IndexOf(pessoa);
                }
            }

            //Verifica se os campos foram preenchidos
            if(textBox_nome.Text == "")
            {
                MessageBox.Show("Preencha o Campo Nome!", "Caixa de alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox_nome.Focus();
                return;
            }

            if (maskedTextBox_telefone.Text == "(  )       -")
            {
                MessageBox.Show("Preencha o campo Telefone");
                maskedTextBox_telefone.Focus();
                return;
            }

            char sexo;
            if (radioButton_masculino.Checked)
            {
                sexo = 'M';
            }
            else if (radioButton_feminino.Checked)
            {
                sexo = 'F';
            }
            else
            {
                sexo = 'O';
            }

            //Atribuir Valores

            Pessoa p = new Pessoa();

            p.Nome = textBox_nome.Text;
            p.DataNascimento = dateTimePicker_nascimento.Text;
            p.EstadoCivil = comboBox_estadoCivil.SelectedItem.ToString();
            p.Telefone = maskedTextBox_telefone.Text;
            p.CasaPropia = checkBox_casa.Checked;
            p.Veiculo = checkBox_veiculo.Checked;
            p.Sexo = sexo;

            //verifica se já está cadastrado 
            if (index < 0)
            {
                pessoas.Add(p);
            }
            else
            {
                pessoas[index] = p;
            }

            button_limpar_Click(button_limpar, EventArgs.Empty);

            Listar();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            //int indices = listBox_lista.SelectedIndex;
            int indices = dataGridView_pessoa.CurrentCell.RowIndex;

            pessoas.RemoveAt(indices);
            Listar();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_nome.Text = "";
            dateTimePicker_nascimento.Value = DateTime.Now;
            comboBox_estadoCivil.SelectedIndex = 0;
            maskedTextBox_telefone.Text = "";
            checkBox_casa.Checked = false;
            checkBox_veiculo.Checked = false;
            radioButton_feminino.Checked = false;
            radioButton_masculino.Checked = false;
            radioButton_outros.Checked = false;

            textBox_nome.Focus();
        }
        private void Listar()
        {
            //listar
            //listBox_lista.Items.Clear();
            dataGridView_pessoa.Rows.Clear();

            foreach(Pessoa p in pessoas)
            {
                //listBox_lista.Items.Add(p.Nome);
                //listBox_lista.Items.Add(p.Telefone)
                //listBox_lista.Items.Add(p.ToString());

                dataGridView_pessoa.Rows.Add(
                    p.Nome, 
                    p.DataNascimento,
                    p.EstadoCivil,
                    p.Telefone,
                    p.CasaPropia ? "SIM" : "NÃO",
                    p.Veiculo ? "SIM" : "NÃO",
                    p.Sexo
                    );
            }
        }

        private void listBox_lista_DoubleClick(object sender, EventArgs e)
        {
            //Alterar
            int indice = listBox_lista.SelectedIndex;

            Pessoa p = pessoas[indice];

            textBox_nome.Text = p.Nome;
            dateTimePicker_nascimento.Text = p.DataNascimento;
            comboBox_estadoCivil.SelectedItem = p.EstadoCivil;
            maskedTextBox_telefone.Text= p.Telefone;
            checkBox_casa.Checked= p.CasaPropia;
            checkBox_veiculo.Checked= p.Veiculo;

            switch(p.Sexo) 
            {
                case 'M':
                    radioButton_masculino.Checked = true;
                    break;

                case 'F':
                    radioButton_feminino.Checked = true;
                    break;

                default:
                    radioButton_outros.Checked = true;
                    break;
            }
        }

        private void dataGridView_pessoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Alterar
            //int indice = listBox_lista.SelectedIndex;

            int indice = e.RowIndex;

            Pessoa p = pessoas[indice];

            textBox_nome.Text = p.Nome;
            dateTimePicker_nascimento.Text = p.DataNascimento;
            comboBox_estadoCivil.SelectedItem = p.EstadoCivil;
            maskedTextBox_telefone.Text = p.Telefone;
            checkBox_casa.Checked = p.CasaPropia;
            checkBox_veiculo.Checked = p.Veiculo;

            switch (p.Sexo)
            {
                case 'M':
                    radioButton_masculino.Checked = true;
                    break;

                case 'F':
                    radioButton_feminino.Checked = true;
                    break;

                default:
                    radioButton_outros.Checked = true;
                    break;
            }
        }
    }
}