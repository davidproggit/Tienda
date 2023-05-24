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
        private Conexion _conexion = new Conexion();
        private SqlDataReader _lector;
        private DataTable _tabla = new DataTable();
        private SqlCommand _comando = new SqlCommand();

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
     
        public void EditarPerfil(int id, string usuario, string clave, string nombre, string apellido, string email)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "update Usuarios set Usuario=@usuario, Nombre=@nombre, Apellido=@apellido, Email=@email, Clave=@clave where ID=@id";
            CamposUsuario(id, usuario, clave, nombre, apellido, email, _comando);
            _comando.CommandType = CommandType.Text;
            _comando.ExecuteNonQuery();
            _conexion.CerrarConexion();
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
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "select ID, Usuario, Clave, Nombre, Apellido, Email, Cargo from Usuarios where Usuario=@usuario and Clave=@clave";
            _comando.Parameters.AddWithValue("@usuario", usuario);
            _comando.Parameters.AddWithValue("@clave", clave);
            _comando.CommandType = CommandType.Text;

            SqlDataReader lector = _comando.ExecuteReader();

            return LeerFilas(lector,_conexion);
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