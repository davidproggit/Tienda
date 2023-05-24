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

namespace CapaDePresentacion
{
    public partial class ABMClientes : Form
    {
        public ABMClientes()
        {
            InitializeComponent();
        }

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            CargarListaUsuarios();
        }

        private void CargarListaUsuarios()
        {
            ModeloUsuario objeto = new ModeloUsuario();
            grillaClientes.DataSource = objeto.CargarClientes();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            GuardarNuevoCliente();
        }

        private void GuardarNuevoCliente()
        {
            ModeloUsuario objetoCapaNegocio = new ModeloUsuario();

            if (!CamposVacios())
            {
                objetoCapaNegocio.InsertarNuevoUsuario(txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, "cliente", txtDNI.Text, txtCuil.Text);
                MessageBox.Show("Datos insertados");
                CargarListaUsuarios();
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Error: tiene que completar todos los campos");
        }

        private bool CamposVacios()
        {
            return string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text)
                 || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
                 || string.IsNullOrEmpty(txtEmail.Text)  || string.IsNullOrEmpty(txtDNI.Text) 
                 || string.IsNullOrEmpty(txtCuil.Text);
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtCuil.Clear();
            txtUsuario.Clear();
            txtEmail.Clear();
            txtClave.Clear();
        }
        
    }
}
