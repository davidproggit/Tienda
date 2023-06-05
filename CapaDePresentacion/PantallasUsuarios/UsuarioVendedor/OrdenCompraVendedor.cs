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

namespace CapaDePresentacion.PantallasUsuarios.Cliente
{
    public partial class OrdenCompraVendedor : UserControl
    {
        public OrdenCompraVendedor()
        {
            InitializeComponent();
        }

        private void OrdenCompraVendedor_Load(object sender, EventArgs e)
        {
            CargarInformacion();
            VerificarEstado();
        }

        #region "Atributos"

        private int _ordenId;

        public int ordenId
        {
            get { return _ordenId; }
            set { _ordenId = value; }
        }

        private int _ProductoId;

        public int ProductoId
        {
            get { return _ProductoId; }
            set { _ProductoId = value; }
        }  
        
        private int _idCliente;

        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
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

        private void CargarInformacion()
        {
            lblNombreCliente.Text = "Cliente nº: " + idCliente;
            lblNombreProducto.Text = ProductoNombre;
            lblPrecio.Text = "Precio: $" + ProductoPrecio.ToString();
            lblCantidad.Text = "Cantidad: " + ProductoCantidad.ToString();
            lblEstado.Text = ProductoEstado;
        }

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.AprobarOrden(ordenId);
            ProductoEstado = "Aprobado";
            CargarInformacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Productos productos = new Productos();

            productos.CancelarOrden(ordenId);
            ProductoEstado = "Cancelado";
            CargarInformacion();
        }

        private void VerificarEstado()
        {
            if (ProductoEstado != "Pendiente")
                DesactivarBotones();
        }

        private void DesactivarBotones()
        {
            btnAprobar.Enabled = false;
            btnCancelar.Enabled = false;
        }
    }
}
