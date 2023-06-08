using System.Data;
using System.Data.SqlClient;
using CapaComun;

namespace CapaDeDatos
{
    public class DatosDeUsuario
    {
        #region "Objetos"

        private Conexion _conexion = new Conexion();
        private SqlDataReader _lector;
        private DataTable _tabla = new DataTable();
        private SqlCommand _comando = new SqlCommand();

        #endregion

        #region "Admin y vendedor"

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "InsertarUsuario";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@clave", clave);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@apellido", apellido);
            _comando.Parameters.AddWithValue("@email", email);
            _comando.Parameters.AddWithValue("@cargo", cargo);
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@cuil", cuil);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        #endregion

        #region "Administrador"

        public DataTable CargarRoles()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CargarRoles";
            _lector = _comando.ExecuteReader();
            _comando.CommandType = CommandType.StoredProcedure;
            _tabla.Load(_lector);
            _conexion.CerrarConexion();
            return _tabla;
        }

        public DataTable FiltrarUsuario(string usuarioCoincidencia)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "FiltrarUsuario";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@usuarioCoincidencia", usuarioCoincidencia);

            _comando.ExecuteNonQuery();

            DataTable tablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(_comando);

            adaptador.Fill(tablaFiltrada);

            _conexion.CerrarConexion();
            return tablaFiltrada;
        }

        public void EliminarUsuario(int id)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EliminarUsuario";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@idUsuario", id);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public DataTable CargarUsuarios()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CargarUsuarios";
            _lector = _comando.ExecuteReader();
            _comando.CommandType = CommandType.StoredProcedure;
            _tabla.Load(_lector);
            _conexion.CerrarConexion();
            return _tabla;
        }

        #endregion

        #region "Vendedor"

        public DataTable FiltrarCliente(string clienteCoincidencia)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "FiltrarCliente";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@clienteCoincidencia", clienteCoincidencia);

            _comando.ExecuteNonQuery();

            DataTable tablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(_comando);

            adaptador.Fill(tablaFiltrada);

            _conexion.CerrarConexion();
            return tablaFiltrada;
        }

        public DataTable CargarClientes()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CargarClientes";
            _lector = _comando.ExecuteReader();
            _comando.CommandType = CommandType.StoredProcedure;
            _tabla.Load(_lector);
            _conexion.CerrarConexion();
            return _tabla;
        }

        public void EditarPerfilUsuario(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EditarPerfilUsuario";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@apellido", apellido);
            _comando.Parameters.AddWithValue("@email", email);
            _comando.Parameters.AddWithValue("@clave", clave);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@cargo", cargo);
            _comando.Parameters.AddWithValue("@dni", dni);
            _comando.Parameters.AddWithValue("@cuil", id);
            _comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
        }


        #endregion
        
        #region "Usuario"

        public bool IniciarSesion(string usuario, string clave)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "UsuarioIniciarSesion";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@clave", clave);

            SqlDataReader lector = _comando.ExecuteReader();

            return LeerFilas(lector, _conexion);
        }

        private static bool LeerFilas(SqlDataReader lector, Conexion conexion)
        {
            if (lector.HasRows)
            {
                while (lector.Read())
                    FormatoCamposCache(lector);

                conexion.CerrarConexion();
                return true;
            }
            else
            {
                conexion.CerrarConexion();
                return false;
            }

        }

        private static void FormatoCamposCache(SqlDataReader lector)
        {
            CacheSesionUsuario.id = lector.GetInt32(0);
            CacheSesionUsuario.usuario = lector.GetString(1);
            CacheSesionUsuario.clave = lector.GetString(2);
            CacheSesionUsuario.nombre = lector.GetString(3);
            CacheSesionUsuario.apellido = lector.GetString(4);
            CacheSesionUsuario.email = lector.GetString(5);
            CacheSesionUsuario.cargo = lector.GetString(6);
        }

        #endregion

        #region "Gerente"

        public DataTable CargarVendedores()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CargarVendedores";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.ExecuteNonQuery();

            DataTable tablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(_comando);

            adaptador.Fill(tablaFiltrada);

            _conexion.CerrarConexion();
            return tablaFiltrada;
        }

        #endregion

    }
}
