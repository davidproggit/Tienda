using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaComun.Cache;

namespace CapaDeDatos
{
    public class DatosDeUsuario : ConexionSQL
    {
        public void EditarPerfil(int id, string usuario, string clave, string nombre, string apellido, string email)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "update Usuarios set NombreLogin=@usuario, Nombre=@nombre, Apellido=@apellido, Email=@email, Clave=@clave where ID=@id";
                    CamposUsuario(id, usuario, clave, nombre, apellido, email, comando);
                    comando.CommandType = CommandType.Text;
                    comando.ExecuteNonQuery();
                }
            }
        }

        private static void CamposUsuario(int id, string usuario, string clave, string nombre, string apellido, string email, SqlCommand comando)
        {
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@id", id);
        }

        public bool Login(string usuario, string clave)
        {
            using (var conexion = ObtenerConexion())
            {
                conexion.Open();

                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexion;
                    comando.CommandText = "select ID, NombreLogin, Clave, Nombre, Apellido, Email, Cargo from Usuarios where NombreLogin=@usuario and Clave=@clave";
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@clave", clave);
                    comando.CommandType = CommandType.Text;

                    SqlDataReader lector = comando.ExecuteReader();

                    return LeerFilas(lector);
                }
            }
        }

        private static bool LeerFilas(SqlDataReader lector)
        {
            if (lector.HasRows)
            {
                while (lector.Read())
                    FormatoCamposCache(lector);

                return true;
            }
            else
                return false;
        }

        private static void FormatoCamposCache(SqlDataReader lector)
        {
            CacheSesionUsuario.ID = lector.GetInt32(0);
            CacheSesionUsuario.NombreLogin = lector.GetString(1);
            CacheSesionUsuario.Clave = lector.GetString(2);
            CacheSesionUsuario.Nombre = lector.GetString(3);
            CacheSesionUsuario.Apellido = lector.GetString(4);
            CacheSesionUsuario.Email = lector.GetString(5);
            CacheSesionUsuario.Cargo = lector.GetString(6);
        }
    }
}