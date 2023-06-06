using CapaDeDatos;
using System.Data;

namespace CapaDeEntidades
{
    public class Gerente
    {
        #region "Objetos"

        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DataTable _tabla = new DataTable();

        #endregion

        #region "Constructor"

        public Gerente() { }

        #endregion

        #region "DataTable"

        public DataTable CargarVendedores()
        {
            _tabla = _datosDeUsuario.CargarVendedores();
            return _tabla;
        }

        #endregion

    }
}
