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

                productoPrevisualizacion.ProductoId = datos.ProductoId;
                productoPrevisualizacion.ProductoNombre = datos.ProductoNombre;
                productoPrevisualizacion.ProductoDescripcion = datos.ProductoDescripcion;
                productoPrevisualizacion.ProductoMarca = datos.ProductoMarca;
                productoPrevisualizacion.ProductoPrecio = datos.ProductoPrecio;
                productoPrevisualizacion.ProductoCantidad = datos.ProductoCantidad;
                productoPrevisualizacion.ProductoEstado = datos.ProductoEstado;

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
