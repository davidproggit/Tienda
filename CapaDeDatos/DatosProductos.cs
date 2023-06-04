﻿using CapaComun;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CapaDeDatos
{
    public class DatosProductos
    {
        private Conexion _conexion = new Conexion();
        private SqlDataReader _lector;
        private DataTable _tabla = new DataTable();
        private SqlCommand _comando = new SqlCommand();
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        #region "Proveedor"

        public void Insertar(string nombre, string descripcion, string marca, double precio, int stock)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "InsertarProducto";
            _comando.CommandType = CommandType.StoredProcedure;
            CamposProducto(nombre, descripcion, marca, precio, stock);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void Editar(string nombre, string descripcion, string marca, double precio, int stock, int id)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EditarProducto";
            _comando.CommandType = CommandType.StoredProcedure;
            CamposProducto(nombre, descripcion, marca, precio, stock);
            _comando.Parameters.AddWithValue("@id", id);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        private void CamposProducto(string nombre, string descripcion, string marca, double precio, int stock)
        {
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@descripcion", descripcion);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@precio", precio);
            _comando.Parameters.AddWithValue("@stock", stock);
        }

        public void Eliminar(int id)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EliminarProducto";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@idproductoeliminar", id);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void ModificarAlerta(int id, string mensaje, int cantidadMinima)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "ActualizarAlerta";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@mensaje", mensaje);
            _comando.Parameters.AddWithValue("@cantidadMinima", cantidadMinima);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        #endregion

        #region "Cliente y proveedor"

        public DataTable Mostrar()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "MostrarProductos";
            _lector = _comando.ExecuteReader();
            _comando.CommandType = CommandType.StoredProcedure;
            _tabla.Load(_lector);
            _conexion.CerrarConexion();
            return _tabla;
        }

        public DataTable Filtrar(string textoBuscar)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "SELECT Id,Nombre, Descripcion, Marca, Precio, Stock FROM Productos where Nombre like ('" + textoBuscar + "%')";
            _comando.CommandType = CommandType.Text;
            _comando.ExecuteNonQuery();

            DataTable tablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(_comando);

            adaptador.Fill(tablaFiltrada);

            _conexion.CerrarConexion();
            return tablaFiltrada;
        }

        #endregion

        #region "Cliente"

        public List<FormatoProductos> Rellenar()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "select Id, Nombre, Descripcion, Marca, Precio, Stock, Estado from Productos";
            _comando.CommandType = CommandType.Text;
            _lector = _comando.ExecuteReader();

            while (_lector.Read())
            {
                int productoId = int.Parse(_lector["Id"].ToString());
                string productoNombre = _lector["Nombre"].ToString();
                string productoDescripcion = _lector["Descripcion"].ToString();
                string productoMarca = _lector["Marca"].ToString();
                float productoPrecio = float.Parse(_lector["Precio"].ToString());
                int productoCantidad = int.Parse(_lector["Stock"].ToString());
                string productoEstado = _lector["Estado"].ToString();

                _valores.Add(new FormatoProductos
                {
                    id = productoId,
                    nombre = productoNombre,
                    descripcion = productoDescripcion,
                    marca = productoMarca,
                    precio = productoPrecio,
                    cantidad = productoCantidad,
                    estado = productoEstado
                });
            }

            _conexion.CerrarConexion();

            return _valores;
        }
        
        public List<FormatoProductos> RellenarCarrito()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "select Id, Nombre, Descripcion, Marca, Cantidad, Precio from Carrito";
            _comando.CommandType = CommandType.Text;
            _lector = _comando.ExecuteReader();

            while (_lector.Read())
            {
                int productoId = int.Parse(_lector["Id"].ToString());
                string productoNombre = _lector["Nombre"].ToString();
                string productoDescripcion = _lector["Descripcion"].ToString();
                string productoMarca = _lector["Marca"].ToString();
                int productoCantidad = int.Parse(_lector["Cantidad"].ToString());
                float productoPrecio = float.Parse(_lector["Precio"].ToString());

                _valores.Add(new FormatoProductos
                {
                    id = productoId,
                    nombre = productoNombre,
                    descripcion = productoDescripcion,
                    marca = productoMarca,
                    cantidad = productoCantidad,
                    precio = productoPrecio
                });
            }

            _conexion.CerrarConexion();

            return _valores;
        }

        public void AgregarCarrito(int id, string nombre, string descripcion, string marca, int cantidad, float precio)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "AgregarProductoCarrito";
            _comando.CommandType = CommandType.StoredProcedure;

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@descripcion", descripcion);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            _comando.Parameters.AddWithValue("@precio", precio);
           
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void CambiarEstadoProducto(int id, string estado)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CambiarEstadoProducto";
            _comando.CommandType = CommandType.StoredProcedure;

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@estado", estado);

            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void EliminarProductoCarrito(int id)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EliminarProductoCarrito";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@id", id);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void EnviarCompra(int id, string nombre, string descripcion, string marca, int cantidad, float precio)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EnviarCompra";
            _comando.CommandType = CommandType.StoredProcedure;

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@descripcion", descripcion);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            _comando.Parameters.AddWithValue("@precio", precio);

            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void AsignarClienteProducto(int id, int idCliente)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "AsignarClienteProducto";
            _comando.CommandType = CommandType.StoredProcedure;

            _comando.Parameters.AddWithValue("@id", id);
            _comando.Parameters.AddWithValue("@idCliente", idCliente);

            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void EliminarClienteProducto(int id)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EliminarClienteProducto";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@id", id);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        #endregion

    }
}