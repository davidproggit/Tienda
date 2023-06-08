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

        public void InsertarProductoStock(string nombre, string descripcion, string marca, string precio, string stock)
        {
            _datosProductos.InsertarProductoStock(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProductoStock(string nombre, string descripcion, string marca, string precio, string stock, int id)
        {
            _datosProductos.EditarProductoStock(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), id);
        }

        public void EliminarProductoStock(int id)
        {
            _datosProductos.EliminarProductoStock(id);
        }

        public DataTable MostrarProductosStock()
        {
            return _datosProductos.MostrarProductosStock();
        }

        public DataTable FiltrarProductoStock(string textoBuscar)
        {
            return _datosProductos.FiltrarProductoStock(textoBuscar);
        }

        #endregion

    }
}
