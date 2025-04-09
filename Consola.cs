using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3erParcial
{
    internal class Consola
    {
        public Consola() { }
        public Consola(int iD, string nombre, DateTime fechaRegistro, bool activo)
        {
            ID = iD;
            Nombre = nombre;
            FechaRegistro = fechaRegistro;
            Activo = activo;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Activo { get; set; }
    }
}
