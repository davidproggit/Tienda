using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaDeEntidades
{
    public class Cliente : Usuario
    {
        public Cliente() { }

        private ConsultasProductos _consultasProductos = new ConsultasProductos();

        #region "Metodos"

        public void AgregarCarrito(int idCliente, int idProducto, string nombre, string descripcion, string marca, int cantidad, float precio)
        {
            _consultasProductos.AgregarCarrito(idCliente, idProducto, nombre, descripcion, marca, cantidad, precio);
        }

        public void AsignarClienteProducto(int id, int idCliente)
        {
            _consultasProductos.AsignarClienteProducto(id, idCliente);
        }

        public void ModificarCantidadCarrito(int productoId, int cantidad)
        {
            _consultasProductos.ModificarCantidadCarrito(productoId, cantidad);
        }

        public DataTable MostrarProductosStock()
        {
            return _consultasProductos.MostrarProductosStock();
        }

        public DataTable FiltrarProductoStock(string productoCoincidencia)
        {
            return _consultasProductos.FiltrarProductoStock(productoCoincidencia);
        }

        public List<FormatoProductos> CargarVistaProductos()
        {
            return _consultasProductos.CargarVistaProductos();
        }

        public List<FormatoProductos> CargarHistorialOrdenes(int idCliente)
        {
            return _consultasProductos.CargarHistorialOrdenes(idCliente);
        }

        #endregion
    }
}
