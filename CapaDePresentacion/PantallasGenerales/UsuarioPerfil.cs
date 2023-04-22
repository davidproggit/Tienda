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
            CargarPerfil();
            IniciarEdicionClave();
        }

        private void CargarPerfil()
        {
            DatosVisibles();
            VentanaEdicion();
        }

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

        private void DatosVisibles()
        {
            etiquetaUsuario.Text = CacheSesionUsuario.NombreLogin;
            etiquetaNombre.Text = CacheSesionUsuario.Nombre;
            etiquetaApellido.Text = CacheSesionUsuario.Apellido;
            etiquetaEmail.Text = CacheSesionUsuario.Email;
            etiquetaCargo.Text = CacheSesionUsuario.Cargo;
        }

        private void IniciarEdicionClave()
        {
            linkClave.Text = "Editar";
            textoClaveNueva.Enabled = false;
            textoClaveNueva.UseSystemPasswordChar = true;
            textoClaveConfirmacion.Enabled = false;
            textoClaveConfirmacion.UseSystemPasswordChar = true;
        }

        private void ReiniciarInformacionPerfil()
        {
            CargarPerfil();
            IniciarEdicionClave();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            panelEdicion.Visible = true;
            CargarPerfil();
        }

        private void linkClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkClave.Text == "Editar")
            {
                linkClave.Text = "Cancelar";
                textoClaveNueva.Enabled = true;
                textoClaveNueva.Text = "";
                textoClaveConfirmacion.Enabled = true;
                textoClaveConfirmacion.Text = "";

                textoClaveNueva.Visible = true;
                textoClaveConfirmacion.Visible = true;
                etiquetaClaveNueva.Visible = true;
                etiquetaClaveConfirmacion.Visible = true;
            }
            else if (linkClave.Text == "Cancelar")
            {
                IniciarEdicionClave();
                textoClaveNueva.Text = CacheSesionUsuario.Clave;
                textoClaveConfirmacion.Text = CacheSesionUsuario.Clave;

                textoClaveNueva.Visible = false;
                textoClaveConfirmacion.Visible = false;
                etiquetaClaveNueva.Visible = false;
                etiquetaClaveConfirmacion.Visible = false;
            }
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (textoClaveNueva.Text == textoClaveConfirmacion.Text)
            {
                if (textoClaveActual.Text == CacheSesionUsuario.Clave)
                {
                    var modeloUsuario = new ModeloUsuario(
                        id: CacheSesionUsuario.ID,
                        usuario: textoUsuario.Text,
                        clave: textoClaveNueva.Text,
                        nombre: textoNombre.Text,
                        apellido: textoApellido.Text,
                        email: textoEmail.Text,
                        cargo: null
                        );

                    var resultado = modeloUsuario.EditarPerfilUsuario();
                    MessageBox.Show(resultado);
                    ReiniciarInformacionPerfil();
                    panelEdicion.Visible = false;
                }
                else
                    MessageBox.Show("Error: clave incorrecta");
            }
            else
                MessageBox.Show("Error: las claves no coinciden");
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            panelEdicion.Visible = false;
            ReiniciarInformacionPerfil();
        }
    }
}
