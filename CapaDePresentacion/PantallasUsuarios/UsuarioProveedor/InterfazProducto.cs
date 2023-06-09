﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaComun;
using CapaDeEntidades;

namespace CapaDePresentacion
{
    public partial class InterfazProducto : Form
    {
        private int _idProducto;
        private bool _editar = false;

        public InterfazProducto()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void InterfazProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            Proveedor proveedor = new Proveedor();
            grillaProductos.DataSource = proveedor.MostrarProductosStock();
            grillaProductos.Columns["ID"].Visible = false;
        }

        #endregion

        #region "Control de campos"

        private bool CamposVacios()
        {
            return string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text)
                || string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                || string.IsNullOrEmpty(txtStock.Text);
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        #endregion

        #region "Botones"

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (!_editar)
                GuardarProductoNuevo();
            if (_editar)
                GuardarProductoEditado();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            EditarProducto();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            ComprobarEliminarProducto();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnGenerarAlerta_Click(object sender, EventArgs e)
        {
            EnviarDatosAlerta();
        }

        #endregion

        #region "Metodos de los botones"

        private void GuardarProductoEditado()
        {
            Proveedor proveedor = new Proveedor();

            try
            {
                proveedor.EditarProductoStock(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, _idProducto);
                LimpiarFormulario();
                MostrarProductos();
                _editar = false;
            }
            catch (Exception)
            {
                if (CamposVacios())
                    MessageBox.Show("Error: tiene que completar todos los campos");
                else
                    MessageBox.Show("Error: los campos tienen que tener un valor correcto");
            }
        }

        private void GuardarProductoNuevo()
        {
            Proveedor proveedor = new Proveedor();

            try
            {
                proveedor.InsertarProductoStock(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                LimpiarFormulario();
                MostrarProductos();
            }
            catch (Exception)
            {
                if (CamposVacios())
                    MessageBox.Show("Error: tiene que completar todos los campos");
                else
                    MessageBox.Show("Error: los campos tienen que tener un valor correcto");
            }
        }

        private void EditarProducto()
        {
            if (grillaProductos.SelectedRows.Count > 0)
            {
                _editar = true;
                txtNombre.Text = grillaProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = grillaProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = grillaProductos.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = grillaProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = grillaProductos.CurrentRow.Cells["Stock"].Value.ToString();
                _idProducto = (int)grillaProductos.CurrentRow.Cells["Id"].Value;
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void ComprobarEliminarProducto()
        {
            if (grillaProductos.SelectedRows.Count > 0)
            {
                DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo);

                if (pantallaAdvertencia == DialogResult.Yes)
                { 
                    EliminarProducto();
                    MostrarProductos();
                }
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void EliminarProducto()
        {
            Proveedor proveedor = new Proveedor();

            _idProducto = (int)grillaProductos.CurrentRow.Cells["Id"].Value;
            proveedor.EliminarProductoStock(_idProducto);
        }

        private void BuscarProducto()
        {
            Proveedor proveedor = new Proveedor();
            grillaProductos.DataSource = proveedor.FiltrarProductoStock(txtBuscar.Text);
        }

        private void EnviarDatosAlerta()
        {
            List<DatosAlerta> Valores = new List<DatosAlerta>();

            foreach (DataGridViewRow celda in grillaProductos.Rows)
            {
                if (Convert.ToBoolean(celda.Cells[0].Value))
                {
                    Valores.Add(new DatosAlerta
                    {
                        id = (int)celda.Cells[1].Value,
                        nombre = celda.Cells[2].Value.ToString()
                    });
                }
            }

            AlertadeProducto alertadeProducto = new AlertadeProducto();
            alertadeProducto.valores = Valores;
            alertadeProducto.Show();
        }

        #endregion

    }
}
