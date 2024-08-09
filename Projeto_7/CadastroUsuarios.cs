using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_7
{
    static class CadastroUsuarios
    {
        // crinado usuariuos que podem acessar
        private static Usuario[] usuarios =
        {
            new Usuario(){Nome = "Joao", Senha = "1234"},
            new Usuario(){Nome = "User1", Senha = "abc1234"},
            new Usuario(){Nome = "User2", Senha = "def1234"}
        };

        //Verificar usuario que esta logado
        private static Usuario _userLogado = null;

        //Definir o valor e ativar o array acima 
        public static Usuario UsarioLogado
        {
            get { return _userLogado; }
            set { _userLogado = value; }
        }

        //Controle de login
        public static bool Login(string nome, string senha)
        {
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.Nome == nome && usuario.Senha == senha)
                {
                    UsarioLogado = usuario;
                    return true;
                }
            }
            return false;
        }

    }
}
