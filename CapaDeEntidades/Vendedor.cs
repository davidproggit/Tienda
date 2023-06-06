using CapaDeDatos;
using System.Data;

namespace CapaDeEntidades
{
    public class Vendedor
    {
        #region "Objetos"

        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DataTable _tabla = new DataTable();

        #endregion

        #region "Constructor"

        public Vendedor() { }

        #endregion

        #region "DataTable"

        public DataTable CargarClientes()
        {
            _tabla = _datosDeUsuario.CargarClientes();
            return _tabla;
        }

        public DataTable FiltrarCliente(string txtBuscar)
        {
            _tabla = _datosDeUsuario.FiltrarCliente(txtBuscar);
            return _tabla;
        }

        #endregion

        #region "Usuario"

        public void EditarPerfilUsuario(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.EditarPerfilUsuario(id, usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        #endregion

    }
}
