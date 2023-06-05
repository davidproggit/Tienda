using CapaDeEntidades;
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

namespace CapaDePresentacion.PantallasUsuarios.UsuarioGerente
{
    public partial class PantallaReporte : Form
    {
        #region "Constructor"

        public PantallaReporte()
        {
            InitializeComponent();
        }

        #endregion

        #region "Carga de datos"

        private void PantallaReporte_Load(object sender, EventArgs e)
        {
            MostrarOrdenes();
            CargarVendedores();
        }

        private void CargarVendedores()
        {
            Gerente gerente = new Gerente();
            DataTable vendedores = new DataTable();

            vendedores = gerente.CargarVendedores();

            foreach (DataRow vendedor in vendedores.Rows)
                comboVendedores.Items.Add(vendedor["Nombre"].ToString());
        }

        #endregion

        #region "Botones"

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            MostrarOrdenes();
        }

        private void btnUltimaSemana_Click(object sender, EventArgs e)
        {
            MostrarOrdenesSemana();
        }

        private void btnUltimoMes_Click(object sender, EventArgs e)
        {
            MostrarOrdenesMes();
        }

        private void comboVendedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarOrdenesVendedor();
        }

        #endregion

        #region "Metodos de los botones"

        private void MostrarOrdenes()
        {
            Productos productos = new Productos();
            grillaOrdenes.DataSource = productos.MostrarOrdenes();
        }

        private void MostrarOrdenesSemana()
        {
            Productos productos = new Productos();
            grillaOrdenes.DataSource = productos.MostrarOrdenesSemana();
        }

        private void MostrarOrdenesMes()
        {
            Productos productos = new Productos();
            grillaOrdenes.DataSource = productos.MostrarOrdenesMes();
        }

        private void MostrarOrdenesVendedor()
        {
            Productos productos = new Productos();
            grillaOrdenes.DataSource = productos.MostrarOrdenesVendedor(comboVendedores.Text);
        }

        #endregion

    }
}
