using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaDeEntidades
{
    public class Cliente : Usuario
    {
        public Cliente() { }

        private DatosProductos _datosProductos = new DatosProductos();

        #region "Metodos"

        public void AgregarCarrito(int idCliente, int idProducto, string nombre, string descripcion, string marca, int cantidad, float precio, string estado)
        {
            _datosProductos.AgregarCarrito(idCliente, idProducto, nombre, descripcion, marca, cantidad, precio, estado);
        }

        public void AsignarClienteProducto(int id, int idCliente)
        {
            _datosProductos.AsignarClienteProducto(id, idCliente);
        }

        public void ModificarCantidadCarrito(int productoId, int cantidad)
        {
            _datosProductos.ModificarCantidadCarrito(productoId, cantidad);
        }

        public DataTable MostrarProductosStock()
        {
            return _datosProductos.MostrarProductosStock();
        }

        public DataTable FiltrarProductoStock(string productoCoincidencia)
        {
            return _datosProductos.FiltrarProductoStock(productoCoincidencia);
        }

        public List<FormatoProductos> CargarVistaProductos()
        {
            return _datosProductos.CargarVistaProductos();
        }

        public List<FormatoProductos> CargarHistorialOrdenes(int idCliente)
        {
            return _datosProductos.CargarHistorialOrdenes(idCliente);
        }

        #endregion
    }
}
