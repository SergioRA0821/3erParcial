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
    public partial class Form1 : Form
    {
        Usuario usuarios = new Usuario();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string user = txbUsuario.Text;
            string password = txbContra.Text;


            var lista = usuarios.ObtenerUsuarios();
            var validar = lista.FirstOrDefault(u => u.NombreUsuario == user && u.Contrasenia == password);
            if (validar != null)
            {
                this.Hide();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            else
            {
                MessageBox.Show("Fallaste...");
            }
        }
    }
}
