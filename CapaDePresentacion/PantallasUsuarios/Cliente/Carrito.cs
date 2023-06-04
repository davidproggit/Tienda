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
using System.Text.RegularExpressions;
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

        public void Llenar()
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

        public void LimpiarProductos()
        {
            contenedorProductos.Controls.Clear();
        }

        private void linkEnviarCompra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Productos productos = new Productos();

            foreach (FormatoProductos datos in _valores)
            {
                productos.CambiarEstadoProducto(datos.id, "Enviado");
                productos.EnviarOrdenCompra(datos.id, CacheSesionUsuario.ID, datos.nombre, datos.descripcion, datos.marca, datos.cantidad, datos.precio, "Pendiente");
                productos.VaciarCarrito(CacheSesionUsuario.ID);
                LimpiarCarrito();
                Llenar();
            }
        }

        private void LimpiarCarrito()
        {
            contenedorProductos.Controls.Clear();
        }
    }
}
