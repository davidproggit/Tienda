﻿using CapaComun;
using CapaDeEntidades;
using System;
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

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            ComprobarEliminarProducto();
        }

        private void btnEnviarProducto_Click(object sender, EventArgs e)
        {
            EnviarProductoCompra();
        }

        #endregion

        #region "Metodos"

        private void ComprobarEliminarProducto()
        {
            DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere eliminar el producto?", "Eliminar producto", MessageBoxButtons.YesNo);

            if (pantallaAdvertencia == DialogResult.Yes)
                EliminarProducto();
        }

        private void EliminarProducto()
        {
            Carrito carrito = new Carrito();

            carrito.EliminarProductoCarrito(productoId, DatosUsuario.id);

            RecargarPantalla();
        }

        private static void RecargarPantalla()
        {
            (Application.OpenForms["CarritoVista"] as CarritoVista).LimpiarVistaCarrito();
            (Application.OpenForms["CarritoVista"] as CarritoVista).RellenarVistaCarrito();
            (Application.OpenForms["ProductosVista"] as ProductosVista).LimpiarVistaProductos();
            (Application.OpenForms["ProductosVista"] as ProductosVista).RellenarVistaProductos();
        }

        private void EnviarProductoCompra()
        {
            Carrito carrito = new Carrito();

            string fecha = DateTime.Now.ToString("yyy-MM-dd");

            carrito.EnviarProductoCompra(productoId, DatosUsuario.id, productoNombre, productoDescripcion, productoMarca, productoCantidad, productoPrecio, "Pendiente", fecha);
            EliminarProducto();
            RecargarPantalla();
        }

        #endregion

    }
}
