using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_6
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string DataNascimento { get; set; }
        public string EstadoCivil { get; set; }
        public string Telefone { get; set; }
        public bool CasaPropia { get; set; }
        public bool Veiculo { get; set; }
        public char Sexo { get; set; }
        // GET = Leiturta
        // SET = Modificação

        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}";
        }

    }
}
