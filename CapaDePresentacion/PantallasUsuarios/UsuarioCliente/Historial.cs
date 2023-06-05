using CapaComun;
using CapaComun.Cache;
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
    public partial class Historial : Form
    {
        #region "Lista"

        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        #endregion

        #region "Constructor"

        public Historial()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            Productos productos = new Productos();
            _valores = productos.CargarHistorial(CacheSesionUsuario.id);

            foreach (FormatoProductos datos in _valores)
            {
                OrdenCompraCliente ordenCompraCliente = new OrdenCompraCliente();

                ordenCompraCliente.productoId = datos.productoId;
                ordenCompraCliente.productoNombre = datos.productoNombre;
                ordenCompraCliente.productoDescripcion = datos.productoDescripcion;
                ordenCompraCliente.productoMarca = datos.productoMarca;
                ordenCompraCliente.productoPrecio = datos.productoPrecio;
                ordenCompraCliente.productoCantidad = datos.productoCantidad;
                ordenCompraCliente.productoEstado = datos.productoEstado;

                contenedorProductos.Controls.Add(ordenCompraCliente);
            }
        }

        #endregion

    }
}
