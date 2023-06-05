using CapaComun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class UsuarioPerfil : Form
    {

        #region "Constructor"

        public UsuarioPerfil()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        private void UsuarioPerfil_Load(object sender, EventArgs e)
        {
            DatosPerfil();
        }

        private void DatosPerfil()
        {
            lblUsuario.Text = CacheSesionUsuario.Usuario;
            lblNombre.Text = CacheSesionUsuario.Nombre;
            lblApellido.Text = CacheSesionUsuario.Apellido;
            lblEmail.Text = CacheSesionUsuario.Email;
            lblCargo.Text = CacheSesionUsuario.Cargo;
        }

        #endregion
     
    }
}