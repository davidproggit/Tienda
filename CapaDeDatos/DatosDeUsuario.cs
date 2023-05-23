using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaComun.Cache;
using System.Collections;
using System.Text.RegularExpressions;

namespace CapaDeDatos
{
    public class DatosDeUsuario
    {
        Conexion conexion = new Conexion();
        SqlDataReader lector;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@email", email);
            comando.Parameters.AddWithValue("@cargo", cargo);
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@cuil", cuil);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable CargarUsuarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "CargarUsuarios";
            lector = comando.ExecuteReader();
            comando.CommandType = CommandType.StoredProcedure;
            tabla.Load(lector);
            conexion.CerrarConexion();
            return tabla;
        }
     
        public void EditarPerfil(int id, string usuario, string clave, string nombre, string apellido, string email)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "update Usuarios set Usuario=@usuario, Nombre=@nombre, Apellido=@apellido, Email=@email, Clave=@clave where ID=@id";
            CamposUsuario(id, usuario, clave, nombre, apellido, email, comando);
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();
            conexion.CerrarConexion();
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
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select ID, Usuario, Clave, Nombre, Apellido, Email, Cargo from Usuarios where Usuario=@usuario and Clave=@clave";
            comando.Parameters.AddWithValue("@usuario", usuario);
            comando.Parameters.AddWithValue("@clave", clave);
            comando.CommandType = CommandType.Text;

            SqlDataReader lector = comando.ExecuteReader();

            return LeerFilas(lector,conexion);
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
            CacheSesionUsuario.ID = lector.GetInt32(0);
            CacheSesionUsuario.Usuario = lector.GetString(1);
            CacheSesionUsuario.Clave = lector.GetString(2);
            CacheSesionUsuario.Nombre = lector.GetString(3);
            CacheSesionUsuario.Apellido = lector.GetString(4);
            CacheSesionUsuario.Email = lector.GetString(5);
            CacheSesionUsuario.Cargo = lector.GetString(6);
        }
    }
}