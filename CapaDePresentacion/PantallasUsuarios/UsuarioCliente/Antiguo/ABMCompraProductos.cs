using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CapaComun.Cache;
using CapaDeEntidades;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuarios.UsuarioCliente;

namespace CapaDePresentacion
{
    public partial class ABMCompraProductos : Form
    {
        #region "Constructor"

        public ABMCompraProductos()
        {
            InitializeComponent();
        }

        #endregion

        #region "Cargar datos"

        private void ABMCompraProductos_Load(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void MostrarProductos()
        {
            Cliente cliente = new Cliente();
            grillaProductos.DataSource = cliente.MostrarProducto();
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
            Cliente cliente = new Cliente();
            grillaProductos.DataSource = cliente.FiltrarProducto(txtBusqueda.Text);
        }

        private void AgregarProducto()
        {
            List<Datos> valores = new List<Datos>();

            foreach (DataGridViewRow celda in grillaProductos.Rows)
            {
                if (Convert.ToBoolean(celda.Cells[0].Value))
                {
                    valores.Add(new Datos
                    {
                        id = (int)celda.Cells[1].Value,
                        nombre = celda.Cells[2].Value.ToString(),
                        precio = float.Parse(celda.Cells[5].Value.ToString()),
                        cantidad = (int)celda.Cells[6].Value
                    });
                }
            }

            ClienteCarrito clienteCarrito = new ClienteCarrito();
            clienteCarrito.valores = valores;
            clienteCarrito.Show();
        }

        #endregion
        
    }
}
