using CapaComun;
using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Cliente : Usuario
    {
        public Cliente() { }

        private DatosProductos _datosProductos = new DatosProductos();
        private DataTable _tabla = new DataTable();
        
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
            _tabla = _datosProductos.Mostrar();
            return _tabla;
        }

        public DataTable FiltrarProducto(string textoBuscar)
        {
            _tabla = _datosProductos.Filtrar(textoBuscar);
            return _tabla;
        }

        public List<FormatoProductos> CargarProductos()
        {
            return _datosProductos.Rellenar();
        }

        public List<FormatoProductos> CargarHistorialOrdenes(int idCliente)
        {
            return _datosProductos.CargarHistorialOrdenes(idCliente);
        }

    }
}
