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
    public partial class Form_inicio : Form
    {
        public Form_inicio()
        {
            InitializeComponent();
        }

        private void Form_inicio_Load(object sender, EventArgs e)
        {
            FormLogin f = new FormLogin();

            while (CadastroUsuarios.UsarioLogado == null) 
            {
                Visible = false;
                f.ShowDialog();

                if (FormLogin.Cancelar == true) 
                {
                    Application.Exit();
                    return;
                }
            }

            Visible = true;

        }
    }
}
