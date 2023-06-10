using CapaComun;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class UsuarioPerfil : Form
    {
        public UsuarioPerfil()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void UsuarioPerfil_Load(object sender, EventArgs e)
        {
            DatosPerfil();
        }

        private void DatosPerfil()
        {
            lblUsuario.Text = DatosUsuario.usuario;
            lblNombre.Text = DatosUsuario.nombre;
            lblApellido.Text = DatosUsuario.apellido;
            lblEmail.Text = DatosUsuario.email;
            lblCargo.Text = DatosUsuario.cargo;
        }

        #endregion
     
    }
}