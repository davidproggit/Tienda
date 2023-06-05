using CapaDeEntidades;
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

        #region "Cargar datos"

        private void ABMUsuarios_Load(object sender, EventArgs e)
        {
            CargarListaUsuarios();
            CargarRoles();
        }

        private void CargarListaUsuarios()
        {
            Administrador _administrador = new Administrador();
            grillaUsuarios.DataSource = _administrador.CargarUsuarios();
        }

        private void CargarRoles()
        {
            comboCargo.Items.Add("Cliente");
            comboCargo.Items.Add("Admin");
            comboCargo.Items.Add("Vendedor");
            comboCargo.Items.Add("Proveedor");
            comboCargo.Items.Add("Gerente");
        }

        #endregion

        #region "Control de campos"

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


        #endregion

        #region "Botones"

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            GuardarNuevoUsuario();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            ComprobarEliminarUsuario();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        #endregion

        #region "Metodos de los botones"

        private void GuardarNuevoUsuario()
        {
            Administrador _administrador = new Administrador();

            if (!CamposVacios())
            {
                _administrador.InsertarNuevoUsuario(txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, comboCargo.Text, txtDNI.Text, txtCuil.Text);
                MessageBox.Show("Datos insertados");
                CargarListaUsuarios();
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Error: tiene que completar todos los campos");
        }
      
        private void ComprobarEliminarUsuario()
        {
            if (grillaUsuarios.SelectedRows.Count > 0)
            {
                DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere eliminar al usuario?", "Eliminar usuario", MessageBoxButtons.YesNo);

                if (pantallaAdvertencia == DialogResult.Yes)
                { 
                    BorrarUsuario();
                    CargarListaUsuarios();
                }
            }
            else
                MessageBox.Show("Seleccione una fila por favor");
        }

        private void BorrarUsuario()
        {
            Administrador _administrador = new Administrador();
            int _idUsuario = (int)grillaUsuarios.CurrentRow.Cells["Id"].Value;
            _administrador.EliminarUsuario(_idUsuario);
        }

        private void BuscarUsuario()
        {
            Administrador _administrador = new Administrador();
            grillaUsuarios.DataSource = _administrador.FiltrarUsuario(txtBuscar.Text);
        }

        #endregion

    }
}
