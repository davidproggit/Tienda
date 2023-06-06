using CapaDeNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaComun;
using CapaDePresentacion.PantallasUsuarios.UsuarioCliente;

namespace WindowsFormsApp1
{
    public partial class ProductosVista : Form
    {
        #region "Lista"

        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        #endregion

        #region "Constructor"

        public ProductosVista()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        private void ProductosVista_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        public void Llenar()
        {
            Productos productos = new Productos();
            _valores = productos.Rellenar();

            foreach (FormatoProductos datos in _valores)
            {
                ProductoPrevisualizacion productoPrevisualizacion = new ProductoPrevisualizacion();

                productoPrevisualizacion.productoId = datos.productoId;
                productoPrevisualizacion.productoNombre = datos.productoNombre;
                productoPrevisualizacion.productoDescripcion = datos.productoDescripcion;
                productoPrevisualizacion.productoMarca = datos.productoMarca;
                productoPrevisualizacion.productoPrecio = datos.productoPrecio;
                productoPrevisualizacion.productoCantidad = datos.productoCantidad;
                productoPrevisualizacion.productoEstado = datos.productoEstado;

                contenedorProductos.Controls.Add(productoPrevisualizacion);
            }
        }

        #endregion

        #region "Opciones"

        private void linkCarrito_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.Show();
        }

        private void linkHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirOrdenes();
        }

        #endregion

        #region "Metodos"

        public void LimpiarProductos()
        {
            contenedorProductos.Controls.Clear();
        }

        private static void AbrirOrdenes()
        {
            Historial historial = new Historial();
            historial.Show();
        }

        #endregion

    }
}
