using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public abstract class ConexionSQL
    {
        private readonly string cadenaConexion;
        public ConexionSQL()
        {
            cadenaConexion = "Server=(local); DataBase=TiendaUPE; integrated security = true";
        }

        protected SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
