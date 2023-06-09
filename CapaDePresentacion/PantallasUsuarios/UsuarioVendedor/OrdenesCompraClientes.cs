using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuarios.UsuarioCliente;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioVendedor
{
    public partial class OrdenesCompraClientes : Form
    {
        public OrdenesCompraClientes()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void OrdenesCompra_Load(object sender, EventArgs e)
        {
            CargarOrdenesCompra();
        }

        private void CargarOrdenesCompra()
        {
            Vendedor vendedor = new Vendedor();
            List<FormatoProductos> listaOrdenes = new List<FormatoProductos>();

            listaOrdenes = vendedor.CargarOrdenesCompra();

            foreach (FormatoProductos datos in listaOrdenes)
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
