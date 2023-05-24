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
        private int _idUsuario;

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
            grillaUsuarios.DataSource = objeto.CargarUsuarios();
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

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (grillaUsuarios.SelectedRows.Count > 0)
            {
                DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere eliminar al usuario?", "Eliminar usuario", MessageBoxButtons.YesNo);

                if (pantallaAdvertencia == DialogResult.Yes)
                    BorrarUsuario();
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        ModeloUsuario modeloUsuario = new ModeloUsuario();

        private void BorrarUsuario()
        {
            _idUsuario = (int)grillaUsuarios.CurrentRow.Cells["Id"].Value;
            modeloUsuario.EliminarUsuario(_idUsuario);
            CargarListaUsuarios();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            grillaUsuarios.DataSource = modeloUsuario.FiltrarUsuario(txtBuscar.Text);
        }

    }
}
