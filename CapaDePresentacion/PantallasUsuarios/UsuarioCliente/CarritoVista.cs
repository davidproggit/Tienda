using CapaComun;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class CarritoVista : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public CarritoVista()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void Carrito_Load(object sender, EventArgs e)
        {
            RellenarCarrito();
        }

        public void RellenarCarrito()
        {
            Carrito carrito = new Carrito();

            _valores = carrito.RellenarCarrito(CacheSesionUsuario.id);

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
            EnviarProductosCompra();
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            ComprobarVaciarCarrito();
        }

        #endregion

        #region "Metodos de las opciones"

        private void EnviarProductosCompra()
        {
            Carrito carrito = new Carrito();

            string fecha = DateTime.Now.ToString("yyy-MM-dd");

            foreach (FormatoProductos datos in _valores)
            {
                carrito.EnviarProductoCompra(datos.productoId, CacheSesionUsuario.id, datos.productoNombre, datos.productoDescripcion, datos.productoMarca, datos.productoCantidad, datos.productoPrecio, "Pendiente", fecha);
                carrito.VaciarCarrito(CacheSesionUsuario.id);
                LimpiarCarrito();
                RellenarCarrito();
            }
        }

        private void ComprobarVaciarCarrito()
        {
            Carrito carrito = new Carrito();

            DialogResult pantallaAdvertencia = MessageBox.Show("¿Quiere vaciar el carrito?", "Vaciar carrito", MessageBoxButtons.YesNo);

            if (pantallaAdvertencia == DialogResult.Yes)
            {
                carrito.VaciarCarrito(CacheSesionUsuario.id);
                LimpiarCarrito();
                RellenarCarrito();
            }
        }

        public void LimpiarCarrito()
        {
            contenedorProductos.Controls.Clear();
        }

        #endregion

      
    }
}
