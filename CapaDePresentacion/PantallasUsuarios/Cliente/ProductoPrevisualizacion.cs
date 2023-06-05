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

        #region "Atributos"

        private int _ProductoId;

        public int ProductoId
        {
            get { return _ProductoId; }
            set { _ProductoId = value; }
        }

        private string _ProductoNombre;

        public string ProductoNombre
        {
            get { return _ProductoNombre; }
            set { _ProductoNombre = value; }
        }

        private string _ProductoDescripcion;

        public string ProductoDescripcion
        {
            get { return _ProductoDescripcion; }
            set { _ProductoDescripcion = value; }
        }

        private string _ProductoMarca;

        public string ProductoMarca
        {
            get { return _ProductoMarca; }
            set { _ProductoMarca = value; }
        }

        private float _ProductoPrecio;

        public float ProductoPrecio
        {
            get { return _ProductoPrecio; }
            set { _ProductoPrecio = value; }
        }

        private int _ProductoCantidad;

        public int ProductoCantidad
        {
            get { return _ProductoCantidad; }
            set { _ProductoCantidad = value; }
        }

        private string _ProductoEstado;

        public string ProductoEstado
        {
            get { return _ProductoEstado; }
            set { _ProductoEstado = value; }
        }

        #endregion

        private void CargarDatos()
        {
            lblNombre.Text = ProductoNombre;
            lblPrecio.Text = "$" + ProductoPrecio.ToString();
        }

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            ProductoDetalle productoDetalle = new ProductoDetalle();

            productoDetalle.ProductoId = ProductoId;
            productoDetalle.ProductoNombre = ProductoNombre;
            productoDetalle.ProductoDescripcion = ProductoDescripcion;
            productoDetalle.ProductoMarca = ProductoMarca;
            productoDetalle.ProductoPrecio = ProductoPrecio;
            productoDetalle.ProductoCantidad = ProductoCantidad;
            productoDetalle.ProductoEstado = ProductoEstado;

            productoDetalle.Show();
        }

    }
}
