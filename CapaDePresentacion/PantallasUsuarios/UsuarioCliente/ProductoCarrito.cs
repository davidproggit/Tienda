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
        #region "Constructor"

        public ProductoCarrito()
        {
            InitializeComponent();
        }

        #endregion

        #region "Atributos"

        private int _productoId;

        public int productoId
        {
            get { return _productoId; }
            set { _productoId = value; }
        }

        private string _productoNombre;

        public string productoNombre
        {
            get { return _productoNombre; }
            set { _productoNombre = value; }
        }

        private string _productoDescripcion;

        public string productoDescripcion
        {
            get { return _productoDescripcion; }
            set { _productoDescripcion = value; }
        }

        private string _productoMarca;

        public string productoMarca
        {
            get { return _productoMarca; }
            set { _productoMarca = value; }
        }

        private float _productoPrecio;

        public float productoPrecio
        {
            get { return _productoPrecio; }
            set { _productoPrecio = value; }
        }

        private int _productoCantidad;

        public int productoCantidad
        {
            get { return _productoCantidad; }
            set { _productoCantidad = value; }
        }

        private string _productoEstado;

        public string productoEstado
        {
            get { return _productoEstado; }
            set { _productoEstado = value; }
        }

        #endregion

        #region "Cargar datos"

        private void ProductoCarrito_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblNombre.Text = productoNombre;
            lblPrecio.Text = "$" + productoPrecio.ToString();
            lblCantidad.Text = "Cantidad: " + productoCantidad.ToString();
        }

        #endregion

        #region "Opciones"

        private void linkQuitarProducto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ComprobarEliminarProducto();
        }

        #endregion

        #region "Metodos de las opciones"

        private void ComprobarEliminarProducto()
        {
            DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (pantallaAdvertencia == DialogResult.Yes)
                EliminarProducto();
        }

        private void EliminarProducto()
        {
            Productos productos = new Productos();

            productos.CambiarEstadoProducto(productoId, "Disponible");
            productos.EliminarProductoCarrito(productoId);
            productos.EliminarClienteProducto(productoId);

            RecargarPantalla();
        }

        private static void RecargarPantalla()
        {
            (Application.OpenForms["Carrito"] as Carrito).LimpiarProductos();
            (Application.OpenForms["Carrito"] as Carrito).Llenar();
            (Application.OpenForms["ProductosVista"] as ProductosVista).LimpiarProductos();
            (Application.OpenForms["ProductosVista"] as ProductosVista).Llenar();
        }

        #endregion

    }
}
