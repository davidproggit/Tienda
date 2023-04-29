using CapaComun.Cache;
using CapaDeNegocio;
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
        public UsuarioPerfil()
        {
            InitializeComponent();
        }

        private void UsuarioPerfil_Load(object sender, EventArgs e)
        {
            DatosPerfil();
            VentanaEdicion();
        }
        private void ActualizarInformacionPerfil()
        {
            DatosPerfil();
            VentanaEdicion();
            IniciarEdicionClave();
        }
        private void botonEditar_Click(object sender, EventArgs e)
        {
            panelEdicion.Visible = true;
            VentanaEdicion();
        }

        #region "Rellenar campos"
        private void VentanaEdicion()
        {
            textoUsuario.Text = CacheSesionUsuario.NombreLogin;
            textoNombre.Text = CacheSesionUsuario.Nombre;
            textoApellido.Text = CacheSesionUsuario.Apellido;
            textoEmail.Text = CacheSesionUsuario.Email;
            textoClaveActual.Text = "";
            textoClaveNueva.Text = CacheSesionUsuario.Clave;
            textoClaveConfirmacion.Text = CacheSesionUsuario.Clave;
        }

        private void DatosPerfil()
        {
            etiquetaUsuario.Text = CacheSesionUsuario.NombreLogin;
            etiquetaNombre.Text = CacheSesionUsuario.Nombre;
            etiquetaApellido.Text = CacheSesionUsuario.Apellido;
            etiquetaEmail.Text = CacheSesionUsuario.Email;
            etiquetaCargo.Text = CacheSesionUsuario.Cargo;
        }
        #endregion

        private void linkClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkClave.Text == "Editar")
                HabilitarCamposEdicionClave();
            else 
                DeshabilitarCamposEdicionClave();
        }

        #region "Activar o desactivar campos"
        private void IniciarEdicionClave()
        {
            linkClave.Text = "Editar";
            textoClaveNueva.Enabled = false;
            textoClaveNueva.UseSystemPasswordChar = true;
            textoClaveConfirmacion.Enabled = false;
            textoClaveConfirmacion.UseSystemPasswordChar = true;
        }

        private void HabilitarCamposEdicionClave()
        {
            linkClave.Text = "Cancelar";

            textoClaveNueva.Enabled = true;
            textoClaveNueva.Visible = true;
            textoClaveNueva.Text = "";

            textoClaveConfirmacion.Enabled = true;
            textoClaveConfirmacion.Visible = true;
            textoClaveConfirmacion.Text = "";

            etiquetaClaveNueva.Visible = true;
            etiquetaClaveConfirmacion.Visible = true;
        }

        private void DeshabilitarCamposEdicionClave()
        {
            IniciarEdicionClave();
            textoClaveNueva.Text = CacheSesionUsuario.Clave;
            textoClaveNueva.Visible = false;

            textoClaveConfirmacion.Text = CacheSesionUsuario.Clave;
            textoClaveConfirmacion.Visible = false;

            etiquetaClaveNueva.Visible = false;
            etiquetaClaveConfirmacion.Visible = false;
        }
        #endregion

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (textoClaveNueva.Text == textoClaveConfirmacion.Text)
                ConfirmarGuardado();
            else
                MessageBox.Show("Error: las claves no coinciden");
        }

        private void ConfirmarGuardado()
        {
            if (textoClaveActual.Text == CacheSesionUsuario.Clave)
                EditarPerfilUsuario();
            else
                MessageBox.Show("Error: Debe ingresar la clave");
        }

        private void EditarPerfilUsuario()
        {
            var modeloUsuario = new ModeloUsuario(id: CacheSesionUsuario.ID, usuario: textoUsuario.Text, clave: textoClaveNueva.Text, nombre: textoNombre.Text, apellido: textoApellido.Text, email: textoEmail.Text, cargo: null);
            var resultado = modeloUsuario.EditarPerfilUsuario();
            MessageBox.Show(resultado);

            ActualizarInformacionPerfil();
            panelEdicion.Visible = false;
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            panelEdicion.Visible = false;
        }
    }
}
