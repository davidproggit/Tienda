using CapaComun;
using CapaComun.Cache;
using CapaDeNegocio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class Carrito : Form
    {
        #region "Lista"

        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        #endregion

        #region "Constructor"

        public Carrito()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        private void Carrito_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        public void Llenar()
        {
            Productos productos = new Productos();
            _valores = productos.RellenarCarrito();

            foreach (FormatoProductos datos in _valores)
            {
                ProductoCarrito productoCarrito = new ProductoCarrito();

                productoCarrito.productoId = datos.productoId;
                productoCarrito.productoNombre = datos.productoNombre;
                productoCarrito.productoDescripcion = datos.productoDescripcion;
                productoCarrito.productoMarca = datos.productoMarca;
                productoCarrito.productoPrecio = datos.productoPrecio;
                productoCarrito.productoCantidad = datos.productoCantidad;

                contenedorProductos.Controls.Add(productoCarrito);
            }
        }

        #endregion

        #region "Opciones"

        private void btnEnviarCompra_Click(object sender, EventArgs e)
        {
            EnviarOrdenCompra();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            ComprobarVaciarCarrito();
        }

        #endregion

        #region "Metodos de las opciones"

        private void EnviarOrdenCompra()
        {
            Productos productos = new Productos();
            string fecha = DateTime.Now.ToString("yyy-MM-dd");

            foreach (FormatoProductos datos in _valores)
            {
                productos.CambiarEstadoProducto(datos.productoId, "Enviado");
                productos.EnviarOrdenCompra(datos.productoId, CacheSesionUsuario.id, datos.productoNombre, datos.productoDescripcion, datos.productoMarca, datos.productoCantidad, datos.productoPrecio, "Pendiente", fecha);
                productos.VaciarCarrito(CacheSesionUsuario.id);
                LimpiarCarrito();
                Llenar();
            }
        }

        private void ComprobarVaciarCarrito()
        {
            Productos productos = new Productos();

            DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere vaciar el carrito?", "Vaciar carrito", MessageBoxButtons.YesNo);

            if (pantallaAdvertencia == DialogResult.Yes)
            {
                productos.VaciarCarrito(CacheSesionUsuario.id);
                LimpiarCarrito();
                Llenar();
            }
        }

        public void LimpiarCarrito()
        {
            contenedorProductos.Controls.Clear();
        }

        #endregion

      
    }
}
