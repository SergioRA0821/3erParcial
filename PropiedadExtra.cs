using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3erParcial
{
    internal class PropiedadExtra : Consola
    {
        public PropiedadExtra() { }
        public PropiedadExtra(int id, string nombre, DateTime fechaRegistro, bool activo, string colorInterfaz)
            : base (id,nombre, fechaRegistro, activo)
        {
            ColorInterfaz = colorInterfaz;
        }

        public string ColorInterfaz { get; set; }
    }
}
