using CapaComun.Cache;
using CapaDeNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class OrdenCompraVendedor : UserControl
    {
        #region "Constructor"

        public OrdenCompraVendedor()
        {
            InitializeComponent();
        }

        #endregion

        #region "Atributos"

        private int _ordenId;

        public int ordenId
        {
            get { return _ordenId; }
            set { _ordenId = value; }
        }

        private int _productoId;

        public int productoId
        {
            get { return _productoId; }
            set { _productoId = value; }
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

        private string _productoEstado;

        public string productoEstado
        {
            get { return _productoEstado; }
            set { _productoEstado = value; }
        }

        #endregion

        #region "Cargar datos"

        private void OrdenCompraVendedor_Load(object sender, EventArgs e)
        {
            CargarInformacion();
            VerificarEstado();
        }
      
        private void CargarInformacion()
        {
            lblNombreCliente.Text = "Cliente nº: " + idCliente;
            lblNombreProducto.Text = productoNombre;
            lblPrecio.Text = "Precio: $" + productoPrecio.ToString();
            lblCantidad.Text = "Cantidad: " + productoCantidad.ToString();
            lblEstado.Text = productoEstado;
        }

        #endregion

        #region "Opciones"

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            AprobarOrden();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarOrden();
        }

        #endregion

        #region "Metodos de las opciones"

        private void AprobarOrden()
        {
            Productos productos = new Productos();

            productos.AprobarOrden(ordenId);
            productoEstado = "Aprobado";
            CargarInformacion();
        }

        private void CancelarOrden()
        {
            Productos productos = new Productos();

            productos.CancelarOrden(ordenId);
            productoEstado = "Cancelado";
            CargarInformacion();
        }

        private void VerificarEstado()
        {
            if (productoEstado != "Pendiente")
                DesactivarBotones();
        }

        private void DesactivarBotones()
        {
            btnAprobar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        #endregion

    }
}
