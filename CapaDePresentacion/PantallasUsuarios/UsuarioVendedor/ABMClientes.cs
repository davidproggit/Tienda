﻿using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuarios.UsuarioVendedor;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class ABMClientes : Form
    {
        private bool _editar = false;
        private int _idCliente;

        public ABMClientes()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void ABMClientes_Load(object sender, EventArgs e)
        {
            CargarListaUsuarios();
        }

        private void CargarListaUsuarios()
        {
            Vendedor vendedor = new Vendedor();
            grillaClientes.DataSource = vendedor.CargarClientes();
            grillaClientes.Columns["ID"].Visible = false;
        }

        #endregion

        #region "Botones"

        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if (!_editar)
                GuardarNuevoCliente();
            if (_editar)
                GuardarClienteEditado();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            RellenarCamposEdicion();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirOrdenesCompra();
        }

        #endregion

        #region "Metodos de los botones"

        private void GuardarNuevoCliente()
        {
            Vendedor vendedor = new Vendedor();

            if (!CamposVacios())
            {
                vendedor.InsertarNuevoCliente(txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, "Cliente", txtDNI.Text, txtCuil.Text);
                MessageBox.Show("Datos insertados");
                CargarListaUsuarios();
                LimpiarFormulario();
            }
            else
                MessageBox.Show("Error: tiene que completar todos los campos");
        }

        private void BuscarCliente()
        {
            Vendedor vendedor = new Vendedor();
            grillaClientes.DataSource = vendedor.FiltrarCliente(txtBuscar.Text);
        }

        private void RellenarCamposEdicion()
        {
            if (grillaClientes.SelectedRows.Count > 0)
            {
                _editar = true;
                txtNombre.Text = grillaClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                txtApellido.Text = grillaClientes.CurrentRow.Cells["Apellido"].Value.ToString();
                txtEmail.Text = grillaClientes.CurrentRow.Cells["Email"].Value.ToString();
                txtDNI.Text = grillaClientes.CurrentRow.Cells["DNI"].Value.ToString();
                txtClave.Text = grillaClientes.CurrentRow.Cells["Clave"].Value.ToString();
                txtCuil.Text = grillaClientes.CurrentRow.Cells["Cuil"].Value.ToString();
                txtUsuario.Text = grillaClientes.CurrentRow.Cells["Usuario"].Value.ToString();
                _idCliente = (int)grillaClientes.CurrentRow.Cells["Id"].Value;
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void GuardarClienteEditado()
        {
            Vendedor vendedor = new Vendedor();

            if (!CamposVacios())
            {
                vendedor.EditarPerfilCliente(_idCliente, txtUsuario.Text, txtClave.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text, "Cliente", txtDNI.Text, txtCuil.Text);
                LimpiarFormulario();
                CargarListaUsuarios();
                _editar = false;
            }
            else
                MessageBox.Show("Error: tiene que completar todos los campos");
        }

        private static void AbrirOrdenesCompra()
        {
            OrdenesCompraClientes ordenesCompra = new OrdenesCompraClientes();
            ordenesCompra.Show();
        }

        #endregion

        #region "Control de campos"

        private bool CamposVacios()
        {
            return string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtClave.Text)
                 || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellido.Text)
                 || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtDNI.Text)
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

        #endregion

    }
}
