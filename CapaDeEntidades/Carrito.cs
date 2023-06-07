using CapaComun;
using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Carrito
    {
        private DatosProductos _datosProductos = new DatosProductos();

        public Carrito() { }

        public void VaciarCarrito(int idCliente)
        {
            _datosProductos.VaciarCarrito(idCliente);
        }

        public void EnviarOrdenCompra(int idProducto, int idCLiente, string nombre, string descripcion, string marca, int cantidad, float precio, string estado, string fecha)
        {
            _datosProductos.EnviarOrdenCompra(idProducto, idCLiente, nombre, descripcion, marca, cantidad, precio, estado, fecha);
        }

        public void EliminarProductoCarrito(int id)
        {
            _datosProductos.EliminarProductoCarrito(id);
        }

        public int DevolverCantidadCarrito(int productoId)
        {
            return _datosProductos.DevolverCantidadCarrito(productoId);
        }

        public int VerificarProductoCarrito(int productoId)
        {
            return _datosProductos.VerificarProductoCarrito(productoId);
        }

        public List<FormatoProductos> RellenarCarrito()
        {
            return _datosProductos.RellenarCarrito();
        }

    }
}
