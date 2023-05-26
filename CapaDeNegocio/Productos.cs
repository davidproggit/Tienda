using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class Productos
    {
        private DatosProductos _datosProductos = new DatosProductos();
        private DataTable _tabla = new DataTable();

        public DataTable MostrarProducto()
        {
            _tabla = _datosProductos.Mostrar();
            return _tabla;
        }

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

        public DataTable FiltrarProducto(string textoBuscar)
        {
            _tabla = _datosProductos.Filtrar(textoBuscar);
            return _tabla;
        }

        public void ModificarAlerta(int id, string mensaje, string cantidadMinima)
        {
            _datosProductos.ModificarAlerta(id, mensaje, Convert.ToInt32(cantidadMinima));
        }
    }
}