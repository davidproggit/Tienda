using CapaComun;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaDeDatos
{
    public class DatosProductos
    {
        #region "Objetos"

        private Conexion _conexion = new Conexion();
        private SqlDataReader _lector;
        private DataTable _tabla = new DataTable();
        private SqlCommand _comando = new SqlCommand();
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        #endregion

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
                    productoId = productoId,
                    productoNombre = productoNombre,
                    productoDescripcion = productoDescripcion,
                    productoMarca = productoMarca,
                    productoPrecio = productoPrecio,
                    productoCantidad = productoCantidad,
                    productoEstado = productoEstado
                });
            }

            _conexion.CerrarConexion();

            return _valores;
        }
        
        public List<FormatoProductos> RellenarCarrito(int clienteId)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "RellenarCarrito";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@clienteId", clienteId);

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
                    productoId = productoId,
                    productoNombre = productoNombre,
                    productoDescripcion = productoDescripcion,
                    productoMarca = productoMarca,
                    productoCantidad = productoCantidad,
                    productoPrecio = productoPrecio
                });
            }

            _conexion.CerrarConexion();

            return _valores;
        }

        public List<FormatoProductos> CargarHistorialOrdenes(int idCliente)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CargarHistorial";
            _comando.Parameters.AddWithValue("@idCliente", idCliente);

            _comando.CommandType = CommandType.StoredProcedure;

            _lector = _comando.ExecuteReader();

            while (_lector.Read())
            {
                int productoId = int.Parse(_lector["IdProducto"].ToString());
                string productoNombre = _lector["NombreProducto"].ToString();
                string productoDescripcion = _lector["DescripcionProducto"].ToString();
                string productoMarca = _lector["MarcaProducto"].ToString();
                int productoCantidad = int.Parse(_lector["CantidadProducto"].ToString());
                float productoPrecio = float.Parse(_lector["PrecioProducto"].ToString());
                string productoEstado = _lector["EstadoProducto"].ToString();

                _valores.Add(new FormatoProductos
                {
                    productoId = productoId,
                    productoNombre = productoNombre,
                    productoDescripcion = productoDescripcion,
                    productoMarca = productoMarca,
                    productoCantidad = productoCantidad,
                    productoPrecio = productoPrecio,
                    productoEstado = productoEstado
                });
            }

            _conexion.CerrarConexion();

            return _valores;
        }


        public void AgregarCarrito(int idCliente, int idProducto, string nombre, string descripcion, string marca, int cantidad, float precio, string estado)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "AgregarProductoCarrito";
            _comando.CommandType = CommandType.StoredProcedure;

            _comando.Parameters.AddWithValue("@idCliente", idCliente);
            _comando.Parameters.AddWithValue("@idProducto", idProducto);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@descripcion", descripcion);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            _comando.Parameters.AddWithValue("@precio", precio);
            _comando.Parameters.AddWithValue("@estado", estado);
           
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void EliminarProductoCarrito(int productoId, int clienteId)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EliminarProductoCarrito";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@productoId", productoId);
            _comando.Parameters.AddWithValue("@clienteId", clienteId);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void EnviarProductoCompra(int idProducto, int idCLiente, string nombre, string descripcion, string marca, int cantidad, float precio, string estado, string fecha)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "EnviarProductoCompra";
            _comando.CommandType = CommandType.StoredProcedure;

            _comando.Parameters.AddWithValue("@idProducto", idProducto);
            _comando.Parameters.AddWithValue("@idCLiente", idCLiente);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@descripcion", descripcion);
            _comando.Parameters.AddWithValue("@marca", marca);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            _comando.Parameters.AddWithValue("@precio", precio);
            _comando.Parameters.AddWithValue("@estado", estado);
            _comando.Parameters.AddWithValue("@fecha", fecha);

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

        public void VaciarCarrito(int idCliente)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "VaciarCarrito";
            _comando.CommandType = CommandType.StoredProcedure;

            _comando.Parameters.AddWithValue("@idCliente", idCliente);

            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public int VerificarProductoCarrito(int productoId)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "VerificarProductoCarrito";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@productoId", productoId);
            _lector = _comando.ExecuteReader();

            int productoIdEncontrado = 0;

            while (_lector.Read())
            {
                productoIdEncontrado = int.Parse(_lector["IdProducto"].ToString());
            }

            _conexion.CerrarConexion();

            return productoIdEncontrado;
        }

        public void ModificarCantidadCarrito(int productoId, int cantidad)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "ModificarCantidadCarrito";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@productoId", productoId);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public int DevolverCantidadCarrito(int productoId)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "DevolverCantidadCarrito";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@productoId", productoId);
            _lector = _comando.ExecuteReader();

            int cantidadProductoEncontrada = 0;

            while (_lector.Read())
            {
                cantidadProductoEncontrada = int.Parse(_lector["Cantidad"].ToString());
            }

            _conexion.CerrarConexion();

            return cantidadProductoEncontrada;
        }

       
        #endregion

        #region "Vendedor"

        public List<FormatoProductos> CargarOrdenesCompra()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CargarOrdenesCompra";
            _comando.CommandType = CommandType.StoredProcedure;

            _lector = _comando.ExecuteReader();

            while (_lector.Read())
            {
                int ordenId = int.Parse(_lector["IdOrden"].ToString());
                int productoId = int.Parse(_lector["IdProducto"].ToString());
                int clienteId = int.Parse(_lector["IdCliente"].ToString());
                string productoNombre = _lector["NombreProducto"].ToString();
                string productoDescripcion = _lector["DescripcionProducto"].ToString();
                string productoMarca = _lector["MarcaProducto"].ToString();
                int productoCantidad = int.Parse(_lector["CantidadProducto"].ToString());
                float productoPrecio = float.Parse(_lector["PrecioProducto"].ToString());
                string productoEstado = _lector["EstadoProducto"].ToString();

                _valores.Add(new FormatoProductos
                {
                    ordenId = ordenId,
                    productoId = productoId,
                    clienteId = clienteId,
                    productoNombre = productoNombre,
                    productoDescripcion = productoDescripcion,
                    productoMarca = productoMarca,
                    productoCantidad = productoCantidad,
                    productoPrecio = productoPrecio,
                    productoEstado = productoEstado
                });
            }

            _conexion.CerrarConexion();

            return _valores;
        }

        public void AprobarOrden(int ordenId, string vendedor, int cantidad, int productoId)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "AprobarOrden";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ordenId", ordenId);
            _comando.Parameters.AddWithValue("@vendedor", vendedor);
            _comando.Parameters.AddWithValue("@cantidad", cantidad);
            _comando.Parameters.AddWithValue("@productoId", productoId);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        public void CancelarOrden(int ordenId, string vendedor)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "CancelarOrden";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@ordenId", ordenId);
            _comando.Parameters.AddWithValue("@vendedor", vendedor);
            _comando.ExecuteNonQuery();
            _comando.Parameters.Clear();
        }

        #endregion

        #region "Gerente"

        public DataTable MostrarOrdenes()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "MostrarOrdenes";
            _lector = _comando.ExecuteReader();
            _comando.CommandType = CommandType.StoredProcedure;
            _tabla.Load(_lector);
            _conexion.CerrarConexion();
            return _tabla;
        }

        public DataTable MostrarOrdenesSemana()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "MostrarOrdenesSemana";
            _lector = _comando.ExecuteReader();
            _comando.CommandType = CommandType.StoredProcedure;
            _tabla.Load(_lector);
            _conexion.CerrarConexion();
            return _tabla;
        }

        public DataTable MostrarOrdenesMes()
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "MostrarOrdenesMes";
            _lector = _comando.ExecuteReader();
            _comando.CommandType = CommandType.StoredProcedure;
            _tabla.Load(_lector);
            _conexion.CerrarConexion();
            return _tabla;
        }

        public DataTable MostrarOrdenesVendedor(string vendedor)
        {
            _comando.Connection = _conexion.AbrirConexion();
            _comando.CommandText = "MostrarOrdenesVendedor";
            _comando.CommandType = CommandType.StoredProcedure;
            _comando.Parameters.AddWithValue("@vendedor", vendedor);


            _comando.ExecuteNonQuery();

            DataTable tablaFiltrada = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(_comando);

            adaptador.Fill(tablaFiltrada);

            _conexion.CerrarConexion();
            return tablaFiltrada;
        }

        #endregion

    }
}