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
    public partial class ABMUsuarios : Form
    {
        public ABMUsuarios()
        {
            InitializeComponent();
        }

        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
            CargarListaUsuarios();
            CargarRoles();
        }

        private void CargarListaUsuarios()
        {
            ModeloUsuario objeto = new ModeloUsuario();
            dataGridView1.DataSource = objeto.CargarUsuarios();
        }

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            GuardarNuevoUsuario();
        }
       
        private void GuardarNuevoUsuario()
        {
            ModeloUsuario objetoCapaNegocio = new ModeloUsuario();

            if (!CamposVacios())
            {
                objetoCapaNegocio.InsertarNuevoUsuario(txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, comboCargo.Text, txtDNI.Text, txtCuil.Text);
                MessageBox.Show("Datos insertados");
                CargarListaUsuarios();
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Error: tiene que completar todos los campos");
        }

        private void CargarRoles()
        {
            comboCargo.Items.Add("cliente");
            comboCargo.Items.Add("admin");
            comboCargo.Items.Add("vendedor");
            comboCargo.Items.Add("encargado");
            comboCargo.Items.Add("gerente");
        }

        private bool CamposVacios()
        {
            return string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text)
                 || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
                 || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(comboCargo.Text)
                 || string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrEmpty(txtCuil.Text);
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
            comboCargo.ResetText();
        }
    }
}
