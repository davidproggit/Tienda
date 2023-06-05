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

namespace CapaDePresentacion.PantallasUsuarios.Cliente
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

                ordenCompraCliente.id = datos.id;
                ordenCompraCliente.nombre = datos.nombre;
                ordenCompraCliente.descripcion = datos.descripcion;
                ordenCompraCliente.marca = datos.marca;
                ordenCompraCliente.precio = datos.precio;
                ordenCompraCliente.cantidad = datos.cantidad;
                ordenCompraCliente.estado = datos.estado;

                contenedorProductos.Controls.Add(ordenCompraCliente);
            }
        }
       
    }
}
