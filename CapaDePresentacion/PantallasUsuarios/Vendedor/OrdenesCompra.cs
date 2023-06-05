using CapaComun.Cache;
using CapaComun;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuarios.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.Vendedor
{
    public partial class OrdenesCompra : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public OrdenesCompra()
        {
            InitializeComponent();
        }

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

                ordenCompraVendedor.id = datos.idProducto;
                ordenCompraVendedor.idCliente = datos.idCliente;
                ordenCompraVendedor.nombre = datos.nombreProducto;
                ordenCompraVendedor.descripcion = datos.descripcionProducto;
                ordenCompraVendedor.marca = datos.marcaProducto;
                ordenCompraVendedor.precio = datos.precioProducto;
                ordenCompraVendedor.cantidad = datos.cantidadProducto;
                ordenCompraVendedor.estado = datos.estadoProducto;

                contenedorProductos.Controls.Add(ordenCompraVendedor);
            }
        }

       
    }
}
