using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Carrito
    {
        private DatosProductos _datosProductos = new DatosProductos();

        public Carrito() { }

        #region "Metodos"

        public void VaciarCarrito(int idCliente)
        {
            _datosProductos.VaciarCarrito(idCliente);
        }

        public void EnviarProductoCompra(int idProducto, int idCLiente, string nombre, string descripcion, string marca, int cantidad, float precio, string estado, string fecha)
        {
            _datosProductos.EnviarProductoCompra(idProducto, idCLiente, nombre, descripcion, marca, cantidad, precio, estado, fecha);
        }

        public void EliminarProductoCarrito(int productoId, int clienteId)
        {
            _datosProductos.EliminarProductoCarrito(productoId, clienteId);
        }

        public int DevolverCantidadCarrito(int productoId)
        {
            return _datosProductos.DevolverCantidadCarrito(productoId);
        }

        public int VerificarProductoCarrito(int productoId)
        {
            return _datosProductos.VerificarProductoCarrito(productoId);
        }

        public List<FormatoProductos> RellenarCarrito(int clienteId)
        {
            return _datosProductos.RellenarCarrito(clienteId);
        }

        #endregion

    }
}
