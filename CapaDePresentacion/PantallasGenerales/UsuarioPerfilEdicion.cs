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
    public partial class UsuarioPerfilEdicion : Form
    {
        public UsuarioPerfilEdicion()
        {
            InitializeComponent();
        }

        private void UsuarioPerfilEdicion_Load(object sender, EventArgs e)
        {
            VentanaEdicion();
        }

        private void VentanaEdicion()
        {
            textoUsuario.Text = CacheSesionUsuario.Usuario;
            textoNombre.Text = CacheSesionUsuario.Nombre;
            textoApellido.Text = CacheSesionUsuario.Apellido;
            textoEmail.Text = CacheSesionUsuario.Email;
            textoClaveActual.Text = "";
            textoClaveNueva.Text = CacheSesionUsuario.Clave;
            textoClaveConfirmacion.Text = CacheSesionUsuario.Clave;
        }
    }
}
