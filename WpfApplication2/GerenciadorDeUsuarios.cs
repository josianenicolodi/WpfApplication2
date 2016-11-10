using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication2
{
    public class GerenciadorDeUsuarios
    {
        List<Usuario> Usuarios;

        public GerenciadorDeUsuarios()
        {
            Usuarios = new List<Usuario>();

            Usuarios.Add(new Usuario("Lola", "Lola"));
            Usuarios.Add(new Usuario("Athena", "Athena"));
            Usuarios.Add(new Usuario("Hanna", "Hanna"));
        }

        public Usuario GetUsuario(string nome)
        {
            foreach (var usuario in Usuarios)
            {
                if (usuario.Nome == nome)
                {
                    return usuario;

                }
            }
            return new Usuario("Invalido!");
        }

        public void AddUsuario(Usuario usuario)
        {
            if (!ExisteUsuario(usuario.Nome))
            {
                Usuarios.Add(usuario);
            }
        }

        public bool ExisteUsuario(string nome)
        {
            foreach (var item in Usuarios)
            {
                if (item.Nome == nome)
                {
                    return true;
                }
            }

            return false;
        }

    }
}
