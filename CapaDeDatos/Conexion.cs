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
        //SqlConnection conexion = new SqlConnection("Server=(local); DataBase=Tienda;Integrated Security=true");
        SqlConnection conexion = new SqlConnection(@"Data Source=DESKTOP-PJBV73K\SQLEXPRESS; DataBase=Tienda; integrated security = true");

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            return conexion;
        }
    }
}
