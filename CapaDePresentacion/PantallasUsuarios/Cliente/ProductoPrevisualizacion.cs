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
    public partial class ProductoPrevisualizacion : UserControl
    {
        public ProductoPrevisualizacion()
        {
            InitializeComponent();
        }

        private void ProductoPrevisualizacion_Load(object sender, EventArgs e)
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
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
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

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            ProductoDetalle productoDetalle = new ProductoDetalle();

            productoDetalle.id = id;
            productoDetalle.nombre = nombre;
            productoDetalle.descripcion = descripcion;
            productoDetalle.marca = marca;
            productoDetalle.precio = precio;
            productoDetalle.cantidad = cantidad;
            productoDetalle.enCarrito = enCarrito;

            productoDetalle.Show();
        }

    }
}
