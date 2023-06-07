using System.Data;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Administrador : Usuario
    {
        #region "Objetos"

        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();

        #endregion

        #region "Constructor"

        public Administrador() { }

        #endregion

        #region "DataTable"

        public DataTable CargarRoles()
        {
            return _datosDeUsuario.CargarRoles();
        }

        public DataTable CargarUsuarios()
        {
            return _datosDeUsuario.CargarUsuarios();
        }

        public DataTable FiltrarUsuario(string txtBuscar)
        {
            return _datosDeUsuario.FiltrarUsuario(txtBuscar);
        }

        #endregion

        #region "Usuario"

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void EliminarUsuario(int id)
        {
            _datosDeUsuario.EliminarUsuario(id);
        }

        #endregion

    }
}
