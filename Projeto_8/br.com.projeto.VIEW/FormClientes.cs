using Google.Protobuf.WellKnownTypes;
using Projeto_8.br.com.projeto.DAO;
using Projeto_8.br.com.projeto.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_8.br.com.projeto.VIEW
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        #region miss click
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button_salvar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1° paso - Receber os dados
            obj.nome = textBox_nome.Text;
            obj.rg = maskedTextBox_rg.Text.Replace(",",".");
            obj.cpf = maskedTextBox_cpf.Text.Replace(",",".");
            obj.email = textBox_email.Text;
            obj.telefone = maskedTextBox_telefone.Text;
            obj.celular = maskedTextBox_celular.Text;
            obj.cep = maskedTextBox_CEP.Text;
            obj.Endereco = textBox_endereco.Text;
            obj.numero = int.Parse(textBox_numero.Text);
            obj.complemento = textBox_complemento.Text;
            obj.bairro = textBox_bairro.Text;
            obj.cidade = textBox_cidade.Text;
            obj.estado = comboBox_UF.Text;

            //2° passo - Criar o objeto e chamar o metodo 
            ClienteDAO dao = new ClienteDAO();
            dao.cadastrarCliente(obj);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO dao = new ClienteDAO();
            dataGridView_Consulta.DataSource = dao.listarCliente();
        }

        private void dataGridView_Consulta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar o dados 
            textBox_codigo.Text = dataGridView_Consulta.CurrentRow.Cells[0].Value.ToString();
            textBox_nome.Text = dataGridView_Consulta.CurrentRow.Cells[1].Value.ToString();
            maskedTextBox_rg.Text = dataGridView_Consulta.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox_cpf.Text = dataGridView_Consulta.CurrentRow.Cells[3].Value.ToString();
            textBox_email.Text = dataGridView_Consulta.CurrentRow.Cells[4].Value.ToString();
            maskedTextBox_celular.Text = dataGridView_Consulta.CurrentRow.Cells[5].Value.ToString();
            maskedTextBox_telefone.Text = dataGridView_Consulta.CurrentRow.Cells[6].Value.ToString();
            textBox_endereco.Text = dataGridView_Consulta.CurrentRow.Cells[7].Value.ToString();
            textBox_complemento.Text = dataGridView_Consulta.CurrentRow.Cells[8].Value.ToString();
            textBox_numero.Text = dataGridView_Consulta.CurrentRow.Cells[9].Value.ToString();
            maskedTextBox_CEP.Text = dataGridView_Consulta.CurrentRow.Cells[10].Value.ToString();
            textBox_bairro.Text = dataGridView_Consulta.CurrentRow.Cells[11].Value.ToString();
            textBox_cidade.Text = dataGridView_Consulta.CurrentRow.Cells[12].Value.ToString();
            comboBox_UF.Text = dataGridView_Consulta.CurrentRow.Cells[13].Value.ToString();

            //Alterrar para a guia DadosPessoais
            tabControl_Clientes.SelectedTab = tabPage_DadosPessoais;
        }

        private void button_editar_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1° paso - Receber os dados
            obj.nome = textBox_nome.Text;
            obj.rg = maskedTextBox_rg.Text.Replace(",", ".");
            obj.cpf = maskedTextBox_cpf.Text.Replace(",", ".");
            obj.email = textBox_email.Text;
            obj.telefone = maskedTextBox_telefone.Text;
            obj.celular = maskedTextBox_celular.Text;
            obj.cep = maskedTextBox_CEP.Text;
            obj.Endereco = textBox_endereco.Text;
            obj.numero = int.Parse(textBox_numero.Text);
            obj.complemento = textBox_complemento.Text;
            obj.bairro = textBox_bairro.Text;
            obj.cidade = textBox_cidade.Text;
            obj.estado = comboBox_UF.Text;

            obj.codigo = int.Parse(textBox_codigo.Text);

            //2° passo - Criar o objeto e chamar o metodo 
            ClienteDAO dao = new ClienteDAO();
            dao.alterarCliente(obj);

            //recarregar o DataGrid
            dataGridView_Consulta.DataSource = dao.listarCliente();
        }

        private void button_excluir_Click(object sender, EventArgs e)
        {
            Clientes obj = new Clientes();

            //1° paso - Receber os dados
            obj.codigo = int.Parse(textBox_codigo.Text);

            //2° passo - Criar o objeto e chamar o metodo 
            ClienteDAO dao = new ClienteDAO();
            dao.excluirCliente(obj);

            //recarregar o DataGrid
            dataGridView_Consulta.DataSource = dao.listarCliente();

            //Alterrar para a guia Consulta
            tabControl_Clientes.SelectedTab = tabPage_consulta;
        }

        private void button_novo_Click(object sender, EventArgs e)
        {
            new Helpers().limparTela(this);
        }
    }
}