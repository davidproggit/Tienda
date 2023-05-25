using System;
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
        private DatosProductos datosProductos = new DatosProductos();
        private DataTable tabla = new DataTable();

        public DataTable MostrarProductosCliente()
        {
            tabla = datosProductos.MostrarProductosCliente();
            return tabla;
        }

        public DataTable MostrarProducto()
        {
            tabla = datosProductos.Mostrar();
            return tabla;
        }

        public void InsertarProducto(string nombre, string descripcion, string marca, string precio, string stock)
        {
            datosProductos.Insertar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProducto(string nombre, string descripcion, string marca, string precio, string stock, string id)
        {
            datosProductos.Editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void EliminarProducto(string id)
        {
            datosProductos.Eliminar(Convert.ToInt32(id));
        }

        public DataTable FiltrarProducto(string textoBuscar)
        {
            tabla = datosProductos.Filtrar(textoBuscar);
            return tabla;
        }

        public void ModificarAlerta(string id, string mensaje, int cantidadMinima)
        {
            datosProductos.ModificarAlerta(Convert.ToInt32(id) , mensaje, Convert.ToInt32(cantidadMinima));
        }
    }
}