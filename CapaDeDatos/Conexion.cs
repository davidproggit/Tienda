using System.Data.SqlClient;
using System.Data;

namespace CapaDeDatos
{
    public class Conexion
    {
        private SqlConnection _conexion = new SqlConnection("Server=(local); DataBase=Tienda;Integrated Security=true");
        //private SqlConnection _conexion = new SqlConnection(@"Data Source=Laptop_Dell\SQLEXPRESS; DataBase=Tienda; integrated security = true");

        public SqlConnection AbrirConexion()
        {
            if (_conexion.State == ConnectionState.Closed)
                _conexion.Open();

            return _conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (_conexion.State == ConnectionState.Open)
                _conexion.Close();

            return _conexion;
        }

        //#endregion

    }
}
