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
        private bool _editarClave = false;

        public UsuarioPerfil()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void UsuarioPerfil_Load(object sender, EventArgs e)
        {
            DatosPerfil();
            VentanaEdicion();
        }

        private void VentanaEdicion()
        {
            txtUsuario.Text = CacheSesionUsuario.Usuario;
            txtNombre.Text = CacheSesionUsuario.Nombre;
            txtApellido.Text = CacheSesionUsuario.Apellido;
            txtEmail.Text = CacheSesionUsuario.Email;
            txtClaveActual.Text = "";
            txtClaveNueva.Text = CacheSesionUsuario.Clave;
            txtClaveConfirmacion.Text = CacheSesionUsuario.Clave;
        }

        private void DatosPerfil()
        {
            lblUsuario.Text = CacheSesionUsuario.Usuario;
            lblNombre.Text = CacheSesionUsuario.Nombre;
            lblApellido.Text = CacheSesionUsuario.Apellido;
            lblEmail.Text = CacheSesionUsuario.Email;
            lblCargo.Text = CacheSesionUsuario.Cargo;
        }

        private void ActualizarInformacionPerfil()
        {
            DatosPerfil();
            VentanaEdicion();
            IniciarEdicionClave();
        }

        #endregion

        #region "Botones"

        private void linkClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClaveComprobarEditar();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }
     
        #endregion

        #region "Metodo de los botones"

        private void ClaveComprobarEditar()
        {
            if (linkClave.Text == "Editar")
            {
                MensajeEstado("", "vacio");
                HabilitarCamposEdicionClave();
            }
            else
            {
                MensajeEstado("", "vacio");
                DeshabilitarCamposEdicionClave();
            }
        }

        private void Guardar()
        {
            if (txtClaveActual.Text == CacheSesionUsuario.Clave && txtClaveNueva.Text == txtClaveConfirmacion.Text && txtClaveNueva.Text != "" && txtClaveConfirmacion.Text != "")
            {
                EditarPerfilUsuario();
                DeshabilitarCamposEdicionClave();
                _editarClave = false;
            }
            else if (_editarClave)
                MensajeEstado("Las claves no coinciden", "error");
        }

        private void EditarPerfilUsuario()
        {
            var modeloUsuario = new ModeloUsuario(id: CacheSesionUsuario.ID, usuario: txtUsuario.Text, clave: txtClaveNueva.Text, nombre: txtNombre.Text, apellido: txtApellido.Text, email: txtEmail.Text, cargo: null);
            var resultado = modeloUsuario.EditarPerfilUsuario();
            MensajeEstado(resultado, "ok");

            ActualizarInformacionPerfil();
        }

        #endregion

        #region "Activar o desactivar campos"
        private void IniciarEdicionClave()
        {
            linkClave.Text = "Editar";
            txtClaveActual.Enabled = false;
            txtClaveActual.UseSystemPasswordChar = true;   
            txtClaveNueva.Enabled = false;
            txtClaveNueva.UseSystemPasswordChar = true;
            txtClaveConfirmacion.Enabled = false;
            txtClaveConfirmacion.UseSystemPasswordChar = true;
        }

        private void HabilitarCamposEdicionClave()
        {
            IniciarEdicionClave();
            _editarClave = true;

            linkClave.Text = "Cancelar";

            txtClaveActual.Enabled = true;
            txtClaveActual.Visible = true;
            txtClaveActual.Text = "";

            txtClaveNueva.Enabled = true;
            txtClaveNueva.Visible = true;
            txtClaveNueva.Text = "";

            txtClaveConfirmacion.Enabled = true;
            txtClaveConfirmacion.Visible = true;
            txtClaveConfirmacion.Text = "";

            lblClaveActual.Visible = true;
            lblClaveNueva.Visible = true;
            lblClaveConfirmacion.Visible = true;
        }

        private void DeshabilitarCamposEdicionClave()
        {
            IniciarEdicionClave();
            _editarClave = false;
            

            txtClaveActual.Visible = false;
            txtClaveNueva.Visible = false;
            txtClaveConfirmacion.Visible = false;

            lblClaveActual.Visible = false;
            lblClaveNueva.Visible = false;
            lblClaveConfirmacion.Visible = false;
        }
        #endregion

        #region "Mensajes"

        private void MensajeEstado(string mensaje, string tipo)
        {
            lblMensaje.Visible = true;

            switch (tipo)
            {
                case "ok":
                    lblMensaje.Text = mensaje;
                    lblMensaje.ForeColor = Color.Green;
                    break;
                case "error":
                    lblMensaje.Text = "Error: " + mensaje;
                    lblMensaje.ForeColor = Color.Red;
                    break;
                case "vacio":
                    lblMensaje.Text = "";
                    break;
            }

        }

        #endregion
    }
}