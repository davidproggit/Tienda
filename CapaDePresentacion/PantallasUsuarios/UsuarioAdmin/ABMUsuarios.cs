using CapaDeEntidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class ABMUsuarios : Form
    {
        private bool _editar = false;
        private int _idUsuario;
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
            Administrador administrador = new Administrador();
            grillaUsuarios.DataSource = administrador.CargarUsuarios();
            grillaUsuarios.Columns["ID"].Visible = false;
        }

        private void CargarRoles()
        {
            Administrador administrador = new Administrador();
            DataTable cargos = new DataTable();

            cargos = administrador.CargarRoles();

            foreach (DataRow vendedor in cargos.Rows)
                comboCargo.Items.Add(vendedor["Cargo"].ToString());
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
            if (!_editar)
                GuardarNuevoUsuario();
            if (_editar)
                GuardarUsuariosEditado();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            ComprobarEliminarUsuario();
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            RellenarEdicion();
        }

        #endregion

        #region "Metodos de los botones"

        private void GuardarNuevoUsuario()
        {
            Administrador administrador = new Administrador();

            if (!CamposVacios())
            {
                administrador.InsertarNuevoUsuario(txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, comboCargo.Text, txtDNI.Text, txtCuil.Text);
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
            Administrador administrador = new Administrador();
            int _idUsuario = (int)grillaUsuarios.CurrentRow.Cells["Id"].Value;
            administrador.EliminarUsuario(_idUsuario);
        }

        private void BuscarUsuario()
        {
            Administrador administrador = new Administrador();
            grillaUsuarios.DataSource = administrador.FiltrarUsuario(txtBuscar.Text);
        }

        private void RellenarEdicion()
        {
            if (grillaUsuarios.SelectedRows.Count > 0)
            {
                _editar = true;
                txtNombre.Text = grillaUsuarios.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = grillaUsuarios.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEmail.Text = grillaUsuarios.CurrentRow.Cells["Email"].Value.ToString();
                txtDNI.Text = grillaUsuarios.CurrentRow.Cells["DNI"].Value.ToString();
                txtClave.Text = grillaUsuarios.CurrentRow.Cells["Clave"].Value.ToString();
                txtCuil.Text = grillaUsuarios.CurrentRow.Cells["Cuil"].Value.ToString();
                txtUsuario.Text = grillaUsuarios.CurrentRow.Cells["Usuario"].Value.ToString();
                comboCargo.Text = grillaUsuarios.CurrentRow.Cells["Cargo"].Value.ToString();
                _idUsuario = (int)grillaUsuarios.CurrentRow.Cells["Id"].Value;
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void GuardarUsuariosEditado()
        {
            Administrador administrador = new Administrador();

            if (!CamposVacios())
            {
                administrador.EditarPerfilUsuarios(_idUsuario, txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, comboCargo.Text, txtDNI.Text, txtCuil.Text);
                LimpiarFormulario();
                CargarListaUsuarios();
                _editar = false;
            }
            else
                MessageBox.Show("Error: tiene que completar todos los campos");
        }

        #endregion

    }
}
