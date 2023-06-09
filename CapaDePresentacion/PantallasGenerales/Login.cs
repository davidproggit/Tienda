﻿using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasGenerales
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        #region "Metodos de mover la ventana"
        private void MoverVentana_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion

        #region "Reemplazo campos de login"
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
        #endregion

        #region "Acceder"
        private void botonAcceder_Click(object sender, EventArgs e)
        {
            ComprobarCamposFaltantes();
            IniciarSesion();
        }

        private void IniciarSesion()
        {
            if (txtUsuario.Text != "Usuario" && txtClave.Text != "Clave")
                BusquedaUsuario();
        }

        private void BusquedaUsuario()
        {
            Usuario usuario = new Usuario();

            try
            {
                var loginValido = usuario.IniciarSesion(txtUsuario.Text, txtClave.Text);
                LoginValidado(loginValido);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: No se encontro la base de datos");
            }
        }

        private void CrearInterfazUsuario()
        {
            InterfazUsuario interfazUsuario = new InterfazUsuario();
            interfazUsuario.Show();
            interfazUsuario.FormClosed += LimpiarPantallaInicio;
        }

        #endregion

        #region "Control de campos"

        private void ComprobarCamposFaltantes()
        {
            ComprobarCampos campos = new ComprobarCampos();
            var resultado = campos.ComprobarCamposIndividuales(txtUsuario.Text);
            resultado = campos.ComprobarCamposIndividuales(txtClave.Text);
            resultado = campos.ComprobarCamposConjunto(txtUsuario.Text,txtClave.Text);

            MensajeError(resultado);
        }

        private void LoginValidado(bool loginValido)
        {
            if (loginValido)
            {
                this.Hide();
                CrearInterfazUsuario();
            }
            else
                MensajeError("Usuario o clave incorrecta");
        }

        private void MensajeError(string mensaje)
        {
            lblError.Text = "Error: " + mensaje;
            lblError.Visible = true;
        }

        private void LimpiarPantallaInicio(object sender, FormClosedEventArgs e)
        {
            Usuario usuario = new Usuario();

            usuario.CerrarSesion();

            txtClave.Clear();
            txtUsuario.Clear();
            lblError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

        #endregion
       
    }
}
