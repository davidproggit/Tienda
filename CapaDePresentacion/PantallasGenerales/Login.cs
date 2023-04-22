using CapaDeNegocio;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void MoverVentana_MouseDown(object sender, MouseEventArgs e)
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

        //Reemplazar los textos de entrada (usuario y clave)
        #region "Reemplazo"
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

        private void botonAcceder_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "Usuario")
            {
                if (txtClave.Text != "Clave")
                {
                    ModeloUsuario usuario = new ModeloUsuario();
                    var loginValido = usuario.LoginUsuario(txtUsuario.Text, txtClave.Text);

                    if (loginValido)
                    {
                        this.Hide();

                        InterfazUsuario interfazUsuario = new InterfazUsuario();
                        interfazUsuario.Show();
                        interfazUsuario.FormClosed += CerrarSesion;
                    }
                    else
                        MensajeError("Usuario o clave incorrecta");
                }
                else MensajeError("Ingrese su clave");
            }
            else MensajeError("Ingrese su nombre de usuario");
        }

        private void MensajeError(string mensaje)
        {
            etiquetaError.Text = "Error: " + mensaje;
            etiquetaError.Visible = true;
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            txtClave.Clear();
            txtUsuario.Clear();
            etiquetaError.Visible = false;
            this.Show();
            txtUsuario.Focus();
        }

    
    }
}
