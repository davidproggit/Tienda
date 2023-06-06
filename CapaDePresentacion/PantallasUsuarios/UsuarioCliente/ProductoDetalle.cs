using CapaComun.Cache;
using CapaDeNegocio;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductoDetalle : Form
    {
        #region "Constructor"

        public ProductoDetalle()
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
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        private string _productoDescripcion;

        public string productoDescripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        private string _productoMarca;

        public string productoMarca
        {
            get { return lblMarca.Text; }
            set { lblMarca.Text = value; }
        }

        private int _productoCantidad;

        public int productoCantidad
        {
            get { return _productoCantidad; }
            set { _productoCantidad = value; }
        }

        private float _productoPrecio;

        public float productoPrecio
        {
            get { return _productoPrecio; }
            set { _productoPrecio = value; }
        }

        private string _productoEstado;

        public string productoEstado
        {
            get { return _productoEstado; }
            set { _productoEstado = value; }
        }

        private bool _aumentarCantidadCarrito = false;

        #endregion

        #region "Cargar datos"

        private void ProductoDetalle_Load(object sender, EventArgs e)
        {
            Verificar();
            EstablecerCantidadMaxima();
            CargarDatos();
        }

        private void CargarDatos()
        {
            lblNombre.Text = productoNombre;
            lblPrecio.Text = "$" + productoPrecio.ToString();
        }

        #endregion

        #region "Opciones"

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            AgregarCarrito();
        }

        #endregion

        #region "Metodos"

        private void Verificar()
        {
            Productos productos = new Productos();

            int numero = productos.VerificarProductoCarrito(productoId);

            if (numero != productoId) 
                _aumentarCantidadCarrito = true;
        }

        private void EstablecerCantidadMaxima()
        {
            selectorCantidad.Maximum = productoCantidad;
        }

        private void AgregarCarrito()
        {
            Productos productos = new Productos();

            int cantidadSeleccionada = (int)selectorCantidad.Value;

            if (_aumentarCantidadCarrito)
                productos.AgregarCarrito(CacheSesionUsuario.id, productoId, productoNombre, productoDescripcion, productoMarca, cantidadSeleccionada, productoPrecio, "Carrito");
            else
                productos.ModificarCantidadCarrito(productoId, cantidadSeleccionada);

            productos.CambiarEstadoProducto(productoId, "Carrito");
            productos.AsignarClienteProducto(productoId, CacheSesionUsuario.id);
        }

        private void ProductoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Application.OpenForms["ProductosVista"] as ProductosVista).LimpiarProductos();
            (Application.OpenForms["ProductosVista"] as ProductosVista).Llenar();
        }

        #endregion

    }
}
