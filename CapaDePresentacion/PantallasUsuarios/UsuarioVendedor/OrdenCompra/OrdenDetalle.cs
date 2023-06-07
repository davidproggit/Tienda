using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioVendedor.OrdenComponente
{
    public partial class OrdenDetalle : Form
    {
        public OrdenDetalle()
        {
            InitializeComponent();
        }

        #region "Atributos"

        private int _ordenId;

        public int ordenId
        {
            get { return _ordenId; }
            set { _ordenId = value; }
        }

        private int _idCliente;

        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
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

        #endregion

        private void OrdenDetalle_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            lblDetalle.Text = "Detalle de orden nº " + ordenId;
            lblNombreCliente.Text = "Cliente nº: " + idCliente;
            lblNombreProducto.Text = "Producto: " + productoNombre;
            lblPrecio.Text = "Precio: $" + productoPrecio.ToString();
            lblCantidad.Text = "Cantidad: " + productoCantidad.ToString();
        }
    }
}
