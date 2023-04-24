using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;

namespace PracticaDatagridviewSql
{
    public partial class InterfazProducto : Form
    {
        CapaNegocioProductos objetoCapaNegocio = new CapaNegocioProductos();
        private string idProducto = null;
        private bool editar = false;

        public InterfazProducto()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            CapaNegocioProductos objeto = new CapaNegocioProductos();
            grillaProductos.DataSource = objeto.MostrarProducto();
        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {
            if (!editar)
                GuardarProductoNuevo();
            if (editar)
                GuardarProductoEditado();
        }

        private void GuardarProductoEditado()
        {
            try
            {
                objetoCapaNegocio.EditarProducto(textoNombre.Text, textoDescripcion.Text, textoMarca.Text, textoPrecio.Text, textoStock.Text, idProducto);
                MessageBox.Show("Datos editados");
                LimpiarFormulario();
                MostrarProductos();
                editar = false;
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
                objetoCapaNegocio.InsertarProducto(textoNombre.Text, textoDescripcion.Text, textoMarca.Text, textoPrecio.Text, textoStock.Text);
                MessageBox.Show("Datos insertados");
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
            return string.IsNullOrEmpty(textoNombre.Text) || string.IsNullOrEmpty(textoDescripcion.Text)
                || string.IsNullOrEmpty(textoMarca.Text) || string.IsNullOrEmpty(textoPrecio.Text)
                || string.IsNullOrEmpty(textoStock.Text);
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (grillaProductos.SelectedRows.Count > 0)
            {
                editar = true;
                textoNombre.Text = grillaProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                textoDescripcion.Text = grillaProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                textoMarca.Text = grillaProductos.CurrentRow.Cells["Marca"].Value.ToString();
                textoPrecio.Text = grillaProductos.CurrentRow.Cells["Precio"].Value.ToString();
                textoStock.Text = grillaProductos.CurrentRow.Cells["Stock"].Value.ToString();
                idProducto = grillaProductos.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }

        private void LimpiarFormulario()
        {
            textoNombre.Clear();
            textoDescripcion.Clear();
            textoMarca.Clear();
            textoPrecio.Clear();
            textoStock.Clear();
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
            idProducto = grillaProductos.CurrentRow.Cells["Id"].Value.ToString();
            objetoCapaNegocio.EliminarProducto(idProducto);
            //MessageBox.Show("Eliminado correctamente");
            MostrarProductos();
        }
    }
}
