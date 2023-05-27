using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuarios.Cliente;

namespace CapaDePresentacion
{
    public partial class ABMCompraProductos : Form
    {
        public ABMCompraProductos()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void ABMCompraProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            Productos productos = new Productos();
            grillaProductos.DataSource = productos.MostrarProducto();
            grillaProductos.Columns["ID"].Visible = false;
        }

        #endregion

        #region "Botones"

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btnCompraProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto();
        }

        #endregion

        #region "Metodos de los botones"

        private void BuscarProducto()
        {
            Productos productos = new Productos();
            grillaProductos.DataSource = productos.FiltrarProducto(txtBusqueda.Text);
        }

        private void AgregarProducto()
        {
            List<Datos> Valores = new List<Datos>();

            foreach (DataGridViewRow celda in grillaProductos.Rows)
            {
                if (Convert.ToBoolean(celda.Cells[0].Value))
                {
                    Valores.Add(new Datos
                    {
                        id = (int)celda.Cells[1].Value,
                        nombre = celda.Cells[2].Value.ToString(),
                        precio = float.Parse(celda.Cells[5].Value.ToString()),
                        cantidad = (int)celda.Cells[6].Value
                    });
                }
            }

            ClienteCarrito clienteCarrito = new ClienteCarrito();
            clienteCarrito.Valores = Valores;
            clienteCarrito.Show();
        }

        #endregion

        
    }
}
