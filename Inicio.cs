using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3erParcial
{
    public partial class Inicio : Form
    {
        Acciones acc = new Acciones();
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgDatos.DataSource = null;
            dgDatos.DataSource = acc.MostrarInfo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (acc.AgregarConsola(Convert.ToInt32(txbID2.Text), txbNombre.Text, Convert.ToDateTime(txbFecha.Text), Convert.ToBoolean(txbActivo.Text), txbColor.Text))
            {
                MessageBox.Show("Agregado con éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (acc.ActualizarConsola(Convert.ToInt32(txbID2.Text), txbNombre.Text, Convert.ToDateTime(txbFecha.Text), Convert.ToBoolean(txbActivo.Text), txbColor.Text))
            {
                MessageBox.Show("Actualizado con éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (acc.EliminarConsola(Convert.ToInt32(txbID.Text)))
            {
                MessageBox.Show("Eliminado con éxito");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txbID.Text = "";
            txbID2.Text = "";
            txbNombre.Text = "";
            txbFecha.Text = "";
            txbActivo.Text = "";
            txbColor.Text = "";
        }
    }
}
