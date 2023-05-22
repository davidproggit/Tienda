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
        DatosProductos objetoCapaDatos = new DatosProductos();

        public DataTable MostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCapaDatos.Mostrar();
            return tabla;
        }

        public void InsertarProducto(string nombre, string descripcion, string marca, string precio, string stock)
        {
            objetoCapaDatos.Insertar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock));
        }

        public void EditarProducto(string nombre, string descripcion, string marca, string precio, string stock, string id)
        {
            objetoCapaDatos.Editar(nombre, descripcion, marca, Convert.ToDouble(precio), Convert.ToInt32(stock), Convert.ToInt32(id));
        }

        public void EliminarProducto(string id)
        {
            objetoCapaDatos.Eliminar(Convert.ToInt32(id));
        }

        public DataTable FiltrarProducto(string textoBuscar)
        {
            DataTable tablaFiltrada = new DataTable();
            tablaFiltrada = objetoCapaDatos.Filtrar(textoBuscar);
            return tablaFiltrada;
        }

        public void ModificarAlerta(string id, string mensaje, int cantidadMinima)
        {
            objetoCapaDatos.ModificarAlerta(Convert.ToInt32(id) , mensaje, Convert.ToInt32(cantidadMinima));
        }
    }
}