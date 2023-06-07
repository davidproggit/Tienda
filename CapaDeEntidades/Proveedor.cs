using System;
using System.Data;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Proveedor : Usuario
    {
        private DatosProductos _datosProductos = new DatosProductos();

        public Proveedor() { }

        public void ModificarAlerta(int id, string mensaje, string cantidadMinima)
        {
            _datosProductos.ModificarAlerta(id, mensaje, Convert.ToInt32(cantidadMinima));
        }

        #region "Producto"

        public void InsertarProducto(string nombre, string descripcion, string marca, string precio, string stock)
        {
            _datosProductos.Insertar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProducto(string nombre, string descripcion, string marca, string precio, string stock, int id)
        {
            _datosProductos.Editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), id);
        }

        public void EliminarProducto(int id)
        {
            _datosProductos.Eliminar(id);
        }

        public DataTable MostrarProducto()
        {
            return _datosProductos.Mostrar();
        }

        public DataTable FiltrarProducto(string textoBuscar)
        {
            return _datosProductos.Filtrar(textoBuscar);
        }

        #endregion

    }
}
