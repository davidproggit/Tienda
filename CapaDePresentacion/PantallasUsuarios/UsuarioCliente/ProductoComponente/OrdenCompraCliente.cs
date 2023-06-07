using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class OrdenCompraCliente : UserControl
    {
        public OrdenCompraCliente()
        {
            InitializeComponent();
        }

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

        private void OrdenCompraCliente_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblNombreProducto.Text = productoNombre;
            lblPrecio.Text = "Precio: $" + productoPrecio.ToString();
            lblCantidad.Text = "Cantidad: " + productoCantidad.ToString();
            lblEstado.Text = productoEstado;
        }

        #endregion

    }
}
