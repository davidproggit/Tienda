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

        public DataTable Filtrar(string textoBuscar)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "SELECT Id,Nombre, Descripcion, Marca, Precio, Stock FROM Productos where Nombre like ('" + textoBuscar + "%')";
            comando.CommandType = CommandType.Text;
            comando.ExecuteNonQuery();

            DataTable tablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(tablaFiltrada);

            conexion.CerrarConexion();
            return tablaFiltrada;
        }

        public void ModificarAlerta(int id, string mensaje, int cantidadMinima)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "ActualizarAlerta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@mensaje", mensaje);
            comando.Parameters.AddWithValue("@cantidadMinima", cantidadMinima);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}