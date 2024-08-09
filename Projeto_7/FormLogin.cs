using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_7
{
    public partial class FormLogin : Form
    {
        public static bool Cancelar = false;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            Cancelar = true;
            Close();
        }

        private void button_entrar_Click(object sender, EventArgs e)
        {
            string nome = txt_usuario.Text;
            string senha = txt_senha.Text;

            if (CadastroUsuarios.Login(nome, senha))
            {
                Close();
            } 
            else
            {
                MessageBox.Show("Acesso Negado!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_usuario.Text = string.Empty;
                txt_senha.Text = string.Empty;
                txt_usuario.Focus();
                Close();
            }
        }
    }
}
