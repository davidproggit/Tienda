using CapaComun;
using CapaDeEntidades;
using CapaDeNegocio;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProductoDetalle : Form
    {
        public ProductoDetalle()
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

        private bool _agregarProductoCarrito = true;
        private int _cantidadCarrito=0;

        #endregion

        #region "Cargar datos"

        private void ProductoDetalle_Load(object sender, EventArgs e)
        {
            VerificarProductoCarrito();
            EstablecerCantidadMaxima();
            CargarDatos();
            VerificarProductoDisponible();
        }

        private void CargarDatos()
        {
            lblNombre.Text = productoNombre;
            lblPrecio.Text = "$" + productoPrecio.ToString();
        }

        #endregion

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            AgregarCarrito();
        }

        #region "Metodos"

        private void VerificarProductoCarrito()
        {
            Carrito carritoVerificar = new Carrito();
            Carrito carritoCantidad = new Carrito();

            int productoCarrito = carritoVerificar.VerificarProductoCarrito(productoId);

            if (productoCarrito == productoId)
            {
                _agregarProductoCarrito = false;
                _cantidadCarrito = carritoCantidad.DevolverCantidadCarrito(productoId);
            }
        }

        private void EstablecerCantidadMaxima()
        {
            CantidadMaxima cantidadMaxima = new CantidadMaxima();
            selectorCantidad.Maximum = cantidadMaxima.DevolverCantidadMaxima(_cantidadCarrito, productoCantidad, _agregarProductoCarrito);
        }

        private void AgregarCarrito()
        {
            Cliente cliente = new Cliente();

            int cantidadSeleccionada = (int)selectorCantidad.Value;

            if (_agregarProductoCarrito)
                cliente.AgregarCarrito(CacheSesionUsuario.id, productoId, productoNombre, productoDescripcion, productoMarca, cantidadSeleccionada, productoPrecio, "Carrito");
            else
                cliente.ModificarCantidadCarrito(productoId, cantidadSeleccionada);

            cliente.AsignarClienteProducto(productoId, CacheSesionUsuario.id);

            MessageBox.Show("Agrego: " + selectorCantidad.Value + " " + productoNombre);
        }

        private void VerificarProductoDisponible()
        {
            if (productoCantidad==0)
            {
                selectorCantidad.Enabled = false;
                btnAgregarCarrito.Enabled = false;
            }
        }

        private void ProductoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Application.OpenForms["ProductosVista"] as ProductosVista).LimpiarVistaProductos();
            (Application.OpenForms["ProductosVista"] as ProductosVista).RellenarVistaProductos();
        }

        #endregion

    }
}
