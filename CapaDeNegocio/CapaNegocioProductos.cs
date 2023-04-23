using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class CapaNegocioProductos
    {
        CapaDatosProductos objetoCapaDatos = new CapaDatosProductos();

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
    }
}