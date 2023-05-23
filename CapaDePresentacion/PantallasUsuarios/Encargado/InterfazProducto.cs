﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaDeNegocio;

namespace CapaDePresentacion
{
    public partial class InterfazProducto : Form
    {
        Productos objetoCapaNegocio = new Productos();
        private string _idProducto = null;
        private bool _editar = false;

        public InterfazProducto()
        {
            InitializeComponent();
        }

        private void InterfazProducto_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            Productos objeto = new Productos();
            grillaProductos.DataSource = objeto.MostrarProducto();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (!_editar)
                GuardarProductoNuevo();
            if (_editar)
                GuardarProductoEditado();
        }

        private void GuardarProductoEditado()
        {
            try
            {
                objetoCapaNegocio.EditarProducto(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, _idProducto);
                LimpiarFormulario();
                MostrarProductos();
                _editar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void GuardarProductoNuevo()
        {
            try
            {
                objetoCapaNegocio.InsertarProducto(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
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

        private bool CamposVacios()
        {
            return string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text)
                || string.IsNullOrEmpty(txtMarca.Text) || string.IsNullOrEmpty(txtPrecio.Text)
                || string.IsNullOrEmpty(txtStock.Text);
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (grillaProductos.SelectedRows.Count > 0)
            {
                _editar = true;
                txtNombre.Text = grillaProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = grillaProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtMarca.Text = grillaProductos.CurrentRow.Cells["Marca"].Value.ToString();
                txtPrecio.Text = grillaProductos.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = grillaProductos.CurrentRow.Cells["Stock"].Value.ToString();
                _idProducto = grillaProductos.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtMarca.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            if (grillaProductos.SelectedRows.Count > 0)
            {
                DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere eliminar este producto?", "Eliminar producto", MessageBoxButtons.YesNo);

                if (pantallaAdvertencia == DialogResult.Yes)
                    BorrarProducto();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void BorrarProducto()
        {
            _idProducto = grillaProductos.CurrentRow.Cells["Id"].Value.ToString();
            objetoCapaNegocio.EliminarProducto(_idProducto);
            MostrarProductos();
        }

        private void botonCancelar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            Productos objeto2 = new Productos();
            grillaProductos.DataSource = objeto2.FiltrarProducto(txtBuscar.Text);
        }

        private void btnGenerarAlerta_Click(object sender, EventArgs e)
        {
            List<Datos> Valores = new List<Datos>();

            foreach (DataGridViewRow celda in grillaProductos.Rows)
            {
                if (Convert.ToBoolean(celda.Cells[0].Value))
                {
                    Valores.Add(new Datos
                    {
                        id = (int) celda.Cells[1].Value,
                        nombre = celda.Cells[2].Value.ToString()
                    });
                }
            }

            AlertadeProducto alertadeProducto = new AlertadeProducto();
            alertadeProducto.Valores = Valores;
            alertadeProducto.Show();
        }
    }
}
