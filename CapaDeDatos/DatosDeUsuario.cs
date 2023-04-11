using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class DatosDeUsuario : ConexionSQL
    {
        public bool Login(string usuario, string clave)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new SqlCommand()) 
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select *from Usuarios where NombreLogin=@usuario and Clave=@clave";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@clave", clave);
                    comando.CommandType = CommandType.Text;

                    SqlDataReader lector = comando.ExecuteReader();

                    if (lector.HasRows)
                    {
                        return true;
                    }
                    else { return false; }
                }
            }
        }
    }
}
