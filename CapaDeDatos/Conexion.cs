using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDeDatos
{
    public class Conexion
    {
        #region "Cadena"

        private SqlConnection _conexion = new SqlConnection("Server=(local); DataBase=Tienda;Integrated Security=true");
        //private SqlConnection _conexion = new SqlConnection(@"Data Source=DESKTOP-PJBV73K\SQLEXPRESS; DataBase=Tienda; integrated security = true");

        #endregion

        #region "Metodos"

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

        #endregion

    }
}
