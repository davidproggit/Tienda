using CapaDeDatos;
using System.Data;

namespace CapaDeEntidades
{
    public class Gerente : Usuario
    {
        private ConsultasUsuario _consultasUsuario = new ConsultasUsuario();
        private ConsultasProductos _consultasProductos = new ConsultasProductos();

        public Gerente() { }

        #region "Metodos"

        public DataTable CargarVendedores()
        {
            return _consultasUsuario.CargarVendedores();
        }

        public DataTable MostrarOrdenes()
        {
            return _consultasProductos.MostrarOrdenes();
        }

        public DataTable MostrarOrdenesSemana()
        {
            return _consultasProductos.MostrarOrdenesSemana();
        }

        public DataTable MostrarOrdenesMes()
        {
            return _consultasProductos.MostrarOrdenesMes();
        }

        public DataTable MostrarOrdenesVendedor(string vendedor)
        {
            return _consultasProductos.MostrarOrdenesVendedor(vendedor);
        }

        #endregion


    }
}
