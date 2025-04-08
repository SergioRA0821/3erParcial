using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3erParcial
{
    internal class Usuario
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario{NombreUsuario = "Sergio", Contrasenia = "0000"},
        };

        public Usuario() { }

        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }

        public string NombreUsuario { get; set; }
        public string Contrasenia { get; set; }
    }
}
