﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.Cliente
{
    public partial class ProductoCarrito : UserControl
    {
        public ProductoCarrito()
        {
            InitializeComponent();
        }

        private void ProductoCarrito_Load(object sender, EventArgs e)
        {
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
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _descripcion;

        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private string _marca;

        public string marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        private float _precio;

        public float precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        private int _cantidad;

        public int cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

      
        private void CargarDatos()
        {
            lblNombre.Text = nombre;
            lblPrecio.Text = "$" + precio.ToString();
            lblCantidad.Text = "Cantidad: " + cantidad.ToString();
        }

    }
}
