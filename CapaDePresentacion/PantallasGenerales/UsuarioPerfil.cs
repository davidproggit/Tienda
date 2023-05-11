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
        }
       
        private void DatosPerfil()
        {
            etiquetaUsuario.Text = CacheSesionUsuario.NombreLogin;
            etiquetaNombre.Text = CacheSesionUsuario.Nombre;
            etiquetaApellido.Text = CacheSesionUsuario.Apellido;
            etiquetaEmail.Text = CacheSesionUsuario.Email;
            etiquetaCargo.Text = CacheSesionUsuario.Cargo;
        }

    }
}