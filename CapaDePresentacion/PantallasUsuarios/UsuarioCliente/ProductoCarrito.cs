using CapaComun.Cache;
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
using WindowsFormsApp1;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class ProductoCarrito : UserControl
    {
        public ProductoCarrito()
        {
            InitializeComponent();
        }

        private void ProductoCarrito_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        #region "Atributos"

        private int _ProductoId;

        public int ProductoId
        {
            get { return _ProductoId; }
            set { _ProductoId = value; }
        }

        private string _ProductoNombre;

        public string ProductoNombre
        {
            get { return _ProductoNombre; }
            set { _ProductoNombre = value; }
        }

        private string _ProductoDescripcion;

        public string ProductoDescripcion
        {
            get { return _ProductoDescripcion; }
            set { _ProductoDescripcion = value; }
        }

        private string _ProductoMarca;

        public string ProductoMarca
        {
            get { return _ProductoMarca; }
            set { _ProductoMarca = value; }
        }

        private float _ProductoPrecio;

        public float ProductoPrecio
        {
            get { return _ProductoPrecio; }
            set { _ProductoPrecio = value; }
        }

        private int _ProductoCantidad;

        public int ProductoCantidad
        {
            get { return _ProductoCantidad; }
            set { _ProductoCantidad = value; }
        }

        private string _ProductoEstado;

        public string ProductoEstado
        {
            get { return _ProductoEstado; }
            set { _ProductoEstado = value; }
        }

        #endregion

        private void CargarDatos()
        {
            lblNombre.Text = ProductoNombre;
            lblPrecio.Text = "$" + ProductoPrecio.ToString();
            lblCantidad.Text = "Cantidad: " + ProductoCantidad.ToString();
        }

        private void linkQuitarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComprobarEliminarProducto();
        }

        private void ComprobarEliminarProducto()
        {
            DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (pantallaAdvertencia == DialogResult.Yes)
            {
                EliminarProducto();
            }
        }

        private void EliminarProducto()
        {
            Productos productos = new Productos();

            productos.CambiarEstadoProducto(ProductoId, "Disponible");
            productos.EliminarProductoCarrito(ProductoId);
            productos.EliminarClienteProducto(ProductoId);

            RecargarPantalla();
        }

        private static void RecargarPantalla()
        {
            (Application.OpenForms["Carrito"] as Carrito).LimpiarProductos();
            (Application.OpenForms["Carrito"] as Carrito).Llenar();
            (Application.OpenForms["ProductosVista"] as ProductosVista).LimpiarProductos();
            (Application.OpenForms["ProductosVista"] as ProductosVista).Llenar();
        }
    }
}
