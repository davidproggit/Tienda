using System.Collections.Generic;
using System.Data;
using CapaComun;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class Productos
    {
        #region "Objetos"

        private DatosProductos _datosProductos = new DatosProductos();
        private DataTable _tabla = new DataTable();

        #endregion

        #region "DataTable"

        public DataTable MostrarProducto()
       {
            _tabla = _datosProductos.Mostrar();
            return _tabla;
       }

        public DataTable FiltrarProducto(string textoBuscar)
       {
            _tabla = _datosProductos.Filtrar(textoBuscar);
            return _tabla;
       }

        public DataTable MostrarOrdenes()
        {
            return _datosProductos.MostrarOrdenes();
        }

        public DataTable MostrarOrdenesSemana()
        {
            return _datosProductos.MostrarOrdenesSemana();
        }

        public DataTable MostrarOrdenesMes()
        {
            return _datosProductos.MostrarOrdenesMes(); ;
        }

        public DataTable MostrarOrdenesVendedor(string vendedor)
        {
            return _datosProductos.MostrarOrdenesVendedor(vendedor);
        }

        #endregion

        #region "List"

        public List<FormatoProductos> Rellenar()
        {
            return _datosProductos.Rellenar();
        }

        public List<FormatoProductos> RellenarCarrito()
        {
            return _datosProductos.RellenarCarrito();
        }

        public List<FormatoProductos> CargarHistorial(int idCliente)
        {
            return _datosProductos.CargarHistorial(idCliente);
        }

        public List<FormatoProductos> CargarOrdenesCompra()
        {
            return _datosProductos.CargarOrdenesCompra();
        }

        #endregion

        #region "Metodos generales"

        public void AgregarCarrito(int idCliente, int idProducto, string nombre, string descripcion, string marca, int cantidad, float precio, string estado)
        {
            _datosProductos.AgregarCarrito(idCliente, idProducto, nombre, descripcion, marca, cantidad, precio, estado);
        }
        
        public void CambiarEstadoProducto(int id, string estado)
        {
            _datosProductos.CambiarEstadoProducto(id, estado);
        }

        public void EliminarProductoCarrito(int id)
        {
            _datosProductos.EliminarProductoCarrito(id);
        }

        public void EnviarOrdenCompra(int idProducto, int idCLiente, string nombre, string descripcion, string marca, int cantidad, float precio, string estado)
        {
            _datosProductos.EnviarOrdenCompra(idProducto, idCLiente, nombre, descripcion, marca, cantidad, precio, estado);
        }

        public void AsignarClienteProducto(int id, int idCliente)
        {
            _datosProductos.AsignarClienteProducto(id, idCliente);
        }

        public void EliminarClienteProducto(int id)
        {
            _datosProductos.EliminarClienteProducto(id);
        }

        public void VaciarCarrito(int idCliente)
        {
            _datosProductos.VaciarCarrito(idCliente);
        }

        public void AprobarOrden(int ordenId)
        {
            _datosProductos.AprobarOrden(ordenId);
        }

        public void CancelarOrden(int ordenId)
        {
            _datosProductos.CancelarOrden(ordenId);
        }

        public int VerificarProductoCarrito(int productoId)
        {
            return _datosProductos.VerificarProductoCarrito(productoId);
        }

        public void ModificarCantidadCarrito(int productoId, int cantidad)
        {
            _datosProductos.ModificarCantidadCarrito(productoId, cantidad);
        }

        public int DevolverCantidadCarrito(int productoId)
        {
            return _datosProductos.DevolverCantidadCarrito(productoId);
        }

        #endregion

    }
}