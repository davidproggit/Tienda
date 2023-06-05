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
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public Historial()
        {
            InitializeComponent();
        }

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            Productos productos = new Productos();
            _valores = productos.CargarHistorial(CacheSesionUsuario.ID);

            foreach (FormatoProductos datos in _valores)
            {
                OrdenCompraCliente ordenCompraCliente = new OrdenCompraCliente();

                ordenCompraCliente.ProductoId = datos.ProductoId;
                ordenCompraCliente.ProductoNombre = datos.ProductoNombre;
                ordenCompraCliente.ProductoDescripcion = datos.ProductoDescripcion;
                ordenCompraCliente.ProductoMarca = datos.ProductoMarca;
                ordenCompraCliente.ProductoPrecio = datos.ProductoPrecio;
                ordenCompraCliente.ProductoCantidad = datos.ProductoCantidad;
                ordenCompraCliente.ProductoEstado = datos.ProductoEstado;

                contenedorProductos.Controls.Add(ordenCompraCliente);
            }
        }
       
    }
}
