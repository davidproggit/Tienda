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
using WindowsFormsApp1;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class InterfazUsuario : Form
    {
        public InterfazUsuario()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        #region "Cargar datos principales"

        private void InterfazUsuario_Load(object sender, EventArgs e)
        {
            CargarNombreUsuario();
            CargarPantallasUsuarios();
        }

        private void CargarPantallasUsuarios()
        {
            if (CacheSesionUsuario.Cargo == Cargos.Admin)
                AbrirFormulario<ABMUsuarios>();

            if (CacheSesionUsuario.Cargo == Cargos.Vendedor)
                AbrirFormulario<ABMClientes>();

            if (CacheSesionUsuario.Cargo == Cargos.Encargado)
                AbrirFormulario<InterfazProducto>();

            if (CacheSesionUsuario.Cargo == Cargos.Gerente)
                AbrirFormulario<Reportes>();

            if (CacheSesionUsuario.Cargo == Cargos.Cliente)
                AbrirFormulario<ProductosVista>();
        }

        #endregion

        #region "Mover la ventana"
        private void MoverVentana_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region "Cargar pantalla generica"
        private bool _perfil = false;

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!_perfil)
                CargarPantallaPerfil();
            else
                CerrarPantallaPerfil();
        }

        private void CargarPantallaPerfil()
        {
            AbrirFormulario<UsuarioPerfil>();
            linkPerfil.Text = "Cerrar perfil";
            _perfil = true;
        }
        private void CerrarPantallaPerfil()
        {
            CargarPantallasUsuarios();
            linkPerfil.Text = "Mi perfil";
            _perfil = false;
        }
        private void CargarNombreUsuario()
        {
            lblNombre.Text = CacheSesionUsuario.Nombre;
        }

        private void linkCerrarSesion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CerrarFormulario();
        }

        private void CerrarFormulario()
        {
            this.Close();
        }

        #endregion

        #region "Cargar formulario"

        private void AbrirFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form formulario = new Form();
            formulario = panelFormulario.Controls.OfType<MiFormulario>().FirstOrDefault();
            formulario = CrearFormulario<MiFormulario>(formulario);
        }

        private Form CrearFormulario<MiFormulario>(Form formulario) where MiFormulario : Form, new()
        {
            if (formulario == null)
                formulario = CargarFormulario<MiFormulario>();
            else
                formulario.BringToFront();

            return formulario;
        }

        private Form CargarFormulario<MiFormulario>() where MiFormulario : Form, new()
        {
            Form formulario = new MiFormulario();

            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;

            panelFormulario.Controls.Add(formulario);
            panelFormulario.Tag = formulario;

            formulario.Show();
            formulario.BringToFront();

            return formulario;
        }

        #endregion

    }
}