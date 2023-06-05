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
        #region "Constructor"

        public ProductoPrevisualizacion()
        {
            InitializeComponent();
        }

        #endregion

        #region "Atributos"

        private int _productoId;

        public int productoId
        {
            get { return _productoId; }
            set { _productoId = value; }
        }

        private string _productoNombre;

        public string productoNombre
        {
            get { return _productoNombre; }
            set { _productoNombre = value; }
        }

        private string _productoDescripcion;

        public string productoDescripcion
        {
            get { return _productoDescripcion; }
            set { _productoDescripcion = value; }
        }

        private string _productoMarca;

        public string productoMarca
        {
            get { return _productoMarca; }
            set { _productoMarca = value; }
        }

        private float _productoPrecio;

        public float productoPrecio
        {
            get { return _productoPrecio; }
            set { _productoPrecio = value; }
        }

        private int _productoCantidad;

        public int productoCantidad
        {
            get { return _productoCantidad; }
            set { _productoCantidad = value; }
        }

        private string _productoEstado;

        public string productoEstado
        {
            get { return _productoEstado; }
            set { _productoEstado = value; }
        }

        #endregion

        #region "Cargar datos"

        private void ProductoPrevisualizacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblNombre.Text = productoNombre;
            lblPrecio.Text = "$" + productoPrecio.ToString();
        }

        #endregion

        #region "Opciones"

        private void btnVerMas_Click(object sender, EventArgs e)
        {
            VerMas();
        }

        #endregion

        #region "Metodos"

        private void VerMas()
        {
            ProductoDetalle productoDetalle = new ProductoDetalle();

            productoDetalle.productoId = productoId;
            productoDetalle.productoNombre = productoNombre;
            productoDetalle.productoDescripcion = productoDescripcion;
            productoDetalle.productoMarca = productoMarca;
            productoDetalle.productoPrecio = productoPrecio;
            productoDetalle.productoCantidad = productoCantidad;
            productoDetalle.productoEstado = productoEstado;

            productoDetalle.Show();
        }

        #endregion

    }
}
