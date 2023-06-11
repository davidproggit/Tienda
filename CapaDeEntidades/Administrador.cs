using System.Data;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Administrador : Usuario
    {
        private ConsultasUsuario _consultasUsuario = new ConsultasUsuario();

        public Administrador() { }

        #region "Usuario"

        public DataTable CargarRoles()
        {
            return _consultasUsuario.CargarRoles();
        }

        public DataTable CargarUsuarios()
        {
            return _consultasUsuario.CargarUsuarios();
        }

        public DataTable FiltrarUsuario(string usuarioCoincidencia)
        {
            return _consultasUsuario.FiltrarUsuario(usuarioCoincidencia);
        }

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _consultasUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void EliminarUsuario(int id)
        {
            _consultasUsuario.EliminarUsuario(id);
        }

        public void EditarPerfilUsuarios(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _consultasUsuario.EditarPerfilUsuario(id, usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        #endregion

    }
}
