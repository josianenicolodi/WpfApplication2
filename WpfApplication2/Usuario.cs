using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class Usuario
    {
        string nome;
        string senha;

        public Usuario(string nome, string senha)
        {
            this.nome = nome;
            this.senha = senha;
        }

        public Usuario(string nome)
        {
            this.nome = nome;
        }
        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }
    }
}
