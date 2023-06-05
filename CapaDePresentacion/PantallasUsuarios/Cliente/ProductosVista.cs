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
using CapaDePresentacion.PantallasUsuarios.Cliente;

namespace WindowsFormsApp1
{
    public partial class ProductosVista : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public ProductosVista()
        {
            InitializeComponent();
        }

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

                productoPrevisualizacion.id = datos.id;
                productoPrevisualizacion.nombre = datos.nombre;
                productoPrevisualizacion.descripcion = datos.descripcion;
                productoPrevisualizacion.marca = datos.marca;
                productoPrevisualizacion.precio = datos.precio;
                productoPrevisualizacion.cantidad = datos.cantidad;
                productoPrevisualizacion.estado = datos.estado;

                contenedorProductos.Controls.Add(productoPrevisualizacion);
            }
        }

        private void linkCarrito_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Carrito carrito = new Carrito();
            carrito.Show();
        }

        public void LimpiarProductos()
        {
            contenedorProductos.Controls.Clear();
        }

        private void linkHistorial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Historial historial = new Historial();
            historial.Show();
        }
       
    }
}
