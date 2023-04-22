using CapaComun.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class InterfazUsuario : Form
    {
        public InterfazUsuario()
        {
            InitializeComponent();
        }
        private void InterfazUsuario_Load(object sender, EventArgs e)
        {
            CargarDatosUsuario();
            CargarPantallas();
        }

        private void CerrarFormulario()
        {
            this.Close();
        }

        private void MoverVentana_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Metodos para poder mover la ventana
        #region "Metodos"
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        private void CargarPantallas()
        {
            /*if (CacheSesionUsuario.Cargo == Cargos.Admin)
                AbrirFormulario<interfazAdmin>();

            if (CacheSesionUsuario.Cargo == Cargos.Vendedor)
                AbrirFormulario<interfazVendedor>();

            if (CacheSesionUsuario.Cargo == Cargos.Encargado)
                AbrirFormulario<interfazEncargado>();

            if (CacheSesionUsuario.Cargo == Cargos.Gerente)
                AbrirFormulario<interfazGerente>();

            if (CacheSesionUsuario.Cargo == Cargos.Cliente)
                AbrirFormulario<interfazCliente>();*/
        }

        private bool perfil = false;

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!perfil)
                CargarPantallaPerfil();
            else
                CerrarPantallaPerfil();
        }

        private void CargarPantallaPerfil()
        {
            AbrirFormulario<UsuarioPerfil>();
            linkPerfil.Text = "Cerrar perfil";
            perfil = true;
        }
        private void CerrarPantallaPerfil()
        {
            CargarPantallas();
            linkPerfil.Text = "Mi perfil";
            perfil = false;
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarFormulario();
        }

        private void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form formulario = new Form();
            formulario = panelFormulario.Controls.OfType<MiFormulario>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiFormulario();
                formulario.TopLevel = false;
                panelFormulario.Controls.Add(formulario);
                panelFormulario.Tag = formulario;
                formulario.BringToFront();
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
            }
            else
                formulario.BringToFront();
        }

        private void CargarDatosUsuario()
        {
            etiqueta2.Text = CacheSesionUsuario.Nombre;
        }

      
    }
}
