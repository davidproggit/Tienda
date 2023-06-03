﻿using CapaDeNegocio;
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

namespace WindowsFormsApp1
{
    public partial class ProductoDetalle : Form
    {
        public ProductoDetalle()
        {
            InitializeComponent();
        }

        private void ProductoDetalle_Load(object sender, EventArgs e)
        {
            Verificar();
            EstablecerCantidadMaxima();
            CargarDatos();
        }

        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        private string _marca;

        public string marca
        {
            get { return lblMarca.Text; }
            set { lblMarca.Text = value; }
        }

        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        private float _precio;

        public float precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private bool _enCarrito;

        public bool enCarrito
        {
            get { return _enCarrito; }
            set { _enCarrito = value; }
        }

        private void CargarDatos()
        {
            lblNombre.Text = nombre;
            lblPrecio.Text = "$" + precio.ToString();
        }

        private void Verificar()
        {
            if (!enCarrito) 
                btnAgregarCarrito.Text = "Agregar al carrito";
            else
            {
                btnAgregarCarrito.Text = "Ya agregado al carrito";
                btnAgregarCarrito.Enabled = false;
                selectorCantidad.Enabled = false;
            }
        }

        private void EstablecerCantidadMaxima()
        {
            selectorCantidad.Maximum = cantidad;
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            AgregarCarrito();
        }

        private void AgregarCarrito()
        {
            Productos productos = new Productos();

            int cantidadSeleccionada = (int)selectorCantidad.Value;

            productos.AgregarCarrito(id, nombre, descripcion, marca, cantidadSeleccionada, precio);

            productos.CambiarEstadoProducto(id, true);
            enCarrito = true;

            Verificar();

            (Application.OpenForms["ProductosVista"] as ProductosVista).LimpiarProductos();
            (Application.OpenForms["ProductosVista"] as ProductosVista).Llenar();
            
        }
    }
}
