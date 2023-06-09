using CapaDeEntidades;
using System;
using System.Data;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioGerente
{
    public partial class PantallaReporte : Form
    {
        public PantallaReporte()
        {
            InitializeComponent();
        }

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
            Gerente gerente = new Gerente();
            grillaOrdenes.DataSource = gerente.MostrarOrdenes();
        }

        private void MostrarOrdenesSemana()
        {
            Gerente gerente = new Gerente();
            grillaOrdenes.DataSource = gerente.MostrarOrdenesSemana();
        }

        private void MostrarOrdenesMes()
        {
            Gerente gerente = new Gerente();
            grillaOrdenes.DataSource = gerente.MostrarOrdenesMes();
        }

        private void MostrarOrdenesVendedor()
        {
            Gerente gerente = new Gerente();
            grillaOrdenes.DataSource = gerente.MostrarOrdenesVendedor(comboVendedores.Text);
        }

        #endregion

    }
}
