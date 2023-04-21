using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;
using System.Runtime.InteropServices;

namespace Login
{
    public partial class ABMProductos_Load : Form
    {
        public ABMProductos_Load()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,int wparam, int lparam);

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Usuario")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "Usuario";
                txtUsuario.ForeColor = Color.DimGray;
            }
        }

        private void txtClave_Enter(object sender, EventArgs e)
        {
            if (txtClave.Text == "Clave")
            {
                txtClave.Text = "";
                txtClave.ForeColor = Color.Black;
                txtClave.UseSystemPasswordChar = true;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text == "")
            {
                txtClave.Text = "Clave";
                txtClave.ForeColor = Color.DimGray;
                txtClave.UseSystemPasswordChar = false;
            }
        }

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if (txtClave.Text != "Clave")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var loginValido = usuario.LoginUsuario(txtUsuario.Text,txtClave.Text);

                    if (loginValido)
                    {
                        PaginaPrincipal paginaPrincipal = new PaginaPrincipal();
                        paginaPrincipal.Show();
                        paginaPrincipal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        MensajeError("Usuario o clave incorrecta");
                        //txtClave.Clear();
                        //txtUsuario.Focus();
                    }
                }
                else MensajeError("Ingrese su clave");
            }
            else MensajeError("Ingrese su nombre de usuario");
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtClave.Clear();
            txtUsuario.Clear();
            etiquetaError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        private void MensajeError(string mensaje)
        {
            etiquetaError.Text = "Error: " +  mensaje;
            etiquetaError.Visible = true;
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void botonMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }
    }
}
