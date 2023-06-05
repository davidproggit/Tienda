using CapaComun.Cache;
using CapaComun;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuarios.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioVendedor
{
    public partial class OrdenesCompra : Form
    {
        #region "Lista"

        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        #endregion

        #region "Constructor"

        public OrdenesCompra()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        private void OrdenesCompra_Load(object sender, EventArgs e)
        {
            CargarOrdenesCompra();
        }

        private void CargarOrdenesCompra()
        {
            Productos productos = new Productos();
            _valores = productos.CargarOrdenesCompra();

            foreach (FormatoProductos datos in _valores)
            {
                OrdenCompraVendedor ordenCompraVendedor = new OrdenCompraVendedor();

                ordenCompraVendedor.ordenId = datos.ordenId;
                ordenCompraVendedor.productoId = datos.productoId;
                ordenCompraVendedor.idCliente = datos.clienteId;
                ordenCompraVendedor.productoNombre = datos.productoNombre;
                ordenCompraVendedor.productoDescripcion = datos.productoDescripcion;
                ordenCompraVendedor.productoMarca = datos.productoMarca;
                ordenCompraVendedor.productoPrecio = datos.productoPrecio;
                ordenCompraVendedor.productoCantidad = datos.productoCantidad;
                ordenCompraVendedor.productoEstado = datos.productoEstado;

                contenedorProductos.Controls.Add(ordenCompraVendedor);
            }
        }

        #endregion

    }
}
