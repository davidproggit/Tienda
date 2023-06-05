using CapaComun.Cache;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuarios.UsuarioCliente;
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
        #region "Constructor"

        public ProductoDetalle()
        {
            InitializeComponent();
        }

        #endregion

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
            get { return lblNombre.Text; }
            set { lblNombre.Text = value; }
        }

        private string _ProductoDescripcion;

        public string ProductoDescripcion
        {
            get { return lblDescripcion.Text; }
            set { lblDescripcion.Text = value; }
        }

        private string _ProductoMarca;

        public string ProductoMarca
        {
            get { return lblMarca.Text; }
            set { lblMarca.Text = value; }
        }

        private int _ProductoCantidad;

        public int ProductoCantidad
        {
            get { return _ProductoCantidad; }
            set { _ProductoCantidad = value; }
        }

        private float _ProductoPrecio;

        public float ProductoPrecio
        {
            get { return _ProductoPrecio; }
            set { _ProductoPrecio = value; }
        }

        private string _ProductoEstado;

        public string ProductoEstado
        {
            get { return _ProductoEstado; }
            set { _ProductoEstado = value; }
        }

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
            lblNombre.Text = ProductoNombre;
            lblPrecio.Text = "$" + ProductoPrecio.ToString();
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
            if (ProductoEstado == "Disponible") 
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
            selectorCantidad.Maximum = ProductoCantidad;
        }

        private void AgregarCarrito()
        {
            Productos productos = new Productos();

            int cantidadSeleccionada = (int)selectorCantidad.Value;

            productos.AgregarCarrito(CacheSesionUsuario.ID, ProductoId, ProductoNombre, ProductoDescripcion, ProductoMarca, cantidadSeleccionada, ProductoPrecio, "Carrito");
            productos.CambiarEstadoProducto(ProductoId, "Carrito");
            productos.AsignarClienteProducto(ProductoId, CacheSesionUsuario.ID);

            ProductoEstado = "Carrito";

            Verificar();
        }

        private void ProductoDetalle_FormClosed(object sender, FormClosedEventArgs e)
        {
            (Application.OpenForms["ProductosVista"] as ProductosVista).LimpiarProductos();
            (Application.OpenForms["ProductosVista"] as ProductosVista).Llenar();
        }

        #endregion

    }
}
