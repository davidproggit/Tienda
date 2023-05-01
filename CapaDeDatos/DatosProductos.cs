using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DatosProductos
    {
        Conexion conexion = new Conexion();
        SqlDataReader lector;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            lector = comando.ExecuteReader();
            comando.CommandType = CommandType.StoredProcedure;
            tabla.Load(lector);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(string nombre, string descripcion, string marca, double precio, int stock)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            CamposProducto(nombre, descripcion, marca, precio, stock);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(string nombre, string descripcion, string marca, double precio, int stock, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            CamposProducto(nombre, descripcion, marca, precio, stock);
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
        private void CamposProducto(string nombre, string descripcion, string marca, double precio, int stock)
        {
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.Parameters.AddWithValue("@marca", marca);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@stock", stock);
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idproductoeliminar", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}