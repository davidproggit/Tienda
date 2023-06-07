using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaComun;
using CapaDePresentacion.PantallasUsuarios.UsuarioCliente;
using CapaDeEntidades;

namespace WindowsFormsApp1
{
    public partial class ProductosVista : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public ProductosVista()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void ProductosVista_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        public void Llenar()
        {
            Cliente cliente = new Cliente();

            _valores = cliente.CargarProductos();

            foreach (FormatoProductos datos in _valores)
            {
                ProductoPrevisualizacion productoPrevisualizacion = new ProductoPrevisualizacion();

                productoPrevisualizacion.productoId = datos.productoId;
                productoPrevisualizacion.productoNombre = datos.productoNombre;
                productoPrevisualizacion.productoDescripcion = datos.productoDescripcion;
                productoPrevisualizacion.productoMarca = datos.productoMarca;
                productoPrevisualizacion.productoPrecio = datos.productoPrecio;
                productoPrevisualizacion.productoCantidad = datos.productoCantidad;

                contenedorProductos.Controls.Add(productoPrevisualizacion);
            }
        }

        #endregion

        #region "Opciones"

        private void linkCarrito_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CarritoVista carrito = new CarritoVista();
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
            VistaOrdenCompraCliente historial = new VistaOrdenCompraCliente();
            historial.Show();
        }

        #endregion

    }
}
