using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;

namespace CapaDeEntidades
{
    public class Carrito
    {
        private ConsultasProductos _consultasProductos = new ConsultasProductos();

        public Carrito() { }

        #region "Metodos"

        public void VaciarCarrito(int idCliente)
        {
            _consultasProductos.VaciarCarrito(idCliente);
        }

        public void EnviarProductoCompra(int idProducto, int idCLiente, string nombre, string descripcion, string marca, int cantidad, float precio, string estado, string fecha)
        {
            _consultasProductos.EnviarProductoCompra(idProducto, idCLiente, nombre, descripcion, marca, cantidad, precio, estado, fecha);
        }

        public void EliminarProductoCarrito(int productoId, int clienteId)
        {
            _consultasProductos.EliminarProductoCarrito(productoId, clienteId);
        }

        public int DevolverCantidadCarrito(int productoId)
        {
            return _consultasProductos.DevolverCantidadCarrito(productoId);
        }

        public int VerificarProductoCarrito(int productoId)
        {
            return _consultasProductos.VerificarProductoCarrito(productoId);
        }

        public List<FormatoProductos> RellenarCarrito(int clienteId)
        {
            return _consultasProductos.RellenarCarrito(clienteId);
        }

        #endregion

    }
}
