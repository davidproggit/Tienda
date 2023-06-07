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

        public void EliminarProductoCliente(int id)
        {
            _datosProductos.EliminarClienteProducto(id);
        }

        public void ModificarCantidadCarrito(int productoId, int cantidad)
        {
            _datosProductos.ModificarCantidadCarrito(productoId, cantidad);
        }

        public DataTable MostrarProducto()
        {
            return _datosProductos.Mostrar();
        }

        public DataTable FiltrarProducto(string textoBuscar)
        {
            return _datosProductos.Filtrar(textoBuscar);
        }

        public List<FormatoProductos> CargarProductos()
        {
            return _datosProductos.Rellenar();
        }

        public List<FormatoProductos> CargarHistorialOrdenes(int idCliente)
        {
            return _datosProductos.CargarHistorialOrdenes(idCliente);
        }

        #endregion
    }
}
