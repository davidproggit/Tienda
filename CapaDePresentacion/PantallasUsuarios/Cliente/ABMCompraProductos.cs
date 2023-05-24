using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;

namespace CapaDePresentacion
{
    public partial class ABMCompraProductos : Form
    {
        public ABMCompraProductos()
        {
            InitializeComponent();
        }

        private void ABMCompraProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            Productos productos = new Productos();
            grillaProductos.DataSource = productos.MostrarProductosCliente();
        }
    }
}
