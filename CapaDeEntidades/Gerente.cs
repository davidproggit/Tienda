using CapaDeDatos;
using System.Data;

namespace CapaDeEntidades
{
    public class Gerente : Usuario
    {
        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DatosProductos _datosProductos = new DatosProductos();

        public Gerente() { }

        #region "Metodos"

        public DataTable CargarVendedores()
        {
            return _datosDeUsuario.CargarVendedores();
        }

        public DataTable MostrarOrdenes()
        {
            return _datosProductos.MostrarOrdenes();
        }

        public DataTable MostrarOrdenesSemana()
        {
            return _datosProductos.MostrarOrdenesSemana();
        }

        public DataTable MostrarOrdenesMes()
        {
            return _datosProductos.MostrarOrdenesMes();
        }

        public DataTable MostrarOrdenesVendedor(string vendedor)
        {
            return _datosProductos.MostrarOrdenesVendedor(vendedor);
        }

        #endregion


    }
}
