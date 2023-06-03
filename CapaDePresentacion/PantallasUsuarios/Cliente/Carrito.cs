using CapaComun;
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
    public partial class Carrito : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public Carrito()
        {
            InitializeComponent();
        }

        private void Carrito_Load(object sender, EventArgs e)
        {
            Llenar();
        }

        private void Llenar()
        {
            Productos productos = new Productos();
            _valores = productos.RellenarCarrito();

            foreach (FormatoProductos datos in _valores)
            {
                ProductoCarrito productoCarrito = new ProductoCarrito();

                productoCarrito.id = datos.id;
                productoCarrito.nombre = datos.nombre;
                productoCarrito.descripcion = datos.descripcion;
                productoCarrito.marca = datos.marca;
                productoCarrito.precio = datos.precio;
                productoCarrito.cantidad = datos.cantidad;

                contenedorProductos.Controls.Add(productoCarrito);
            }
        }
       
    }
}
