using CapaComun;
using System;
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
            lblUsuario.Text = CacheSesionUsuario.usuario;
            lblNombre.Text = CacheSesionUsuario.nombre;
            lblApellido.Text = CacheSesionUsuario.apellido;
            lblEmail.Text = CacheSesionUsuario.email;
            lblCargo.Text = CacheSesionUsuario.cargo;
        }

        #endregion
     
    }
}