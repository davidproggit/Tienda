using System;
using System.Data;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Proveedor : Usuario
    {
        private ConsultasProductos _consultasProductos = new ConsultasProductos();

        public Proveedor() { }

        public void ModificarAlerta(int id, string mensaje, string cantidadMinima)
        {
            _consultasProductos.ModificarAlerta(id, mensaje, Convert.ToInt32(cantidadMinima));
        }

        #region "Producto"

        public void InsertarProductoStock(string nombre, string descripcion, string marca, string precio, string stock)
        {
            _consultasProductos.InsertarProductoStock(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProductoStock(string nombre, string descripcion, string marca, string precio, string stock, int id)
        {
            _consultasProductos.EditarProductoStock(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), id);
        }

        public void EliminarProductoStock(int id)
        {
            _consultasProductos.EliminarProductoStock(id);
        }

        public DataTable MostrarProductosStock()
        {
            return _consultasProductos.MostrarProductosStock();
        }

        public DataTable FiltrarProductoStock(string textoBuscar)
        {
            return _consultasProductos.FiltrarProductoStock(textoBuscar);
        }

        #endregion

    }
}
