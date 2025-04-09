using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3erParcial
{
    internal class Acciones
    {
        List<PropiedadExtra> ListaConsola = new List<PropiedadExtra>
        {
            new PropiedadExtra(1, "Sergio", DateTime.Today, true, "Verde"),
            new PropiedadExtra(2, "Isma", DateTime.Now, false, "Azul")
        };
        public List<PropiedadExtra> MostrarInfo()
        {
            return ListaConsola;
        }
        PropiedadExtra p = new PropiedadExtra();
        public bool EliminarConsola(int id)
        {
            try
            {
                var ObjetoEliminar = ListaConsola.Find(x => x.ID == id);
                if (ObjetoEliminar != null)
                {
                    ListaConsola.Remove(ObjetoEliminar);
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool AgregarConsola(int id, string nombre, DateTime fechaRegistro, bool activo, string colorInterfaz)
        {
            try
            {
                ListaConsola.Add(new PropiedadExtra(p.ID = id, p.Nombre = nombre, p.FechaRegistro = fechaRegistro, p.Activo = activo, p.ColorInterfaz = colorInterfaz));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public bool ActualizarConsola(int id, string nombre, DateTime fechaRegistro, bool activo, string colorInterfaz)
        {
            try
            {
                var ObjetoEliminar = ListaConsola.Find(x => x.ID == id);
                ObjetoEliminar.ID = id;
                ObjetoEliminar.Nombre = nombre;
                ObjetoEliminar.FechaRegistro = fechaRegistro;
                ObjetoEliminar.Activo = activo;
                ObjetoEliminar.ColorInterfaz = colorInterfaz;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
