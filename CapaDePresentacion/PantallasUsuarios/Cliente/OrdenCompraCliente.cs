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
    public partial class OrdenCompraCliente : UserControl
    {
        public OrdenCompraCliente()
        {
            InitializeComponent();
        }
        private void OrdenCompraCliente_Load(object sender, EventArgs e)
        {
            CargarInformacion();
        }

        #region "Atributos"
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
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

        private string _estado;

        public string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        #endregion

        private void CargarInformacion()
        {
            lblNombreProducto.Text = nombre;
            lblPrecio.Text = "Precio: $" + precio.ToString();
            lblCantidad.Text = "Cantidad: " + cantidad.ToString();
            lblEstado.Text = estado;
        }
    }
}
