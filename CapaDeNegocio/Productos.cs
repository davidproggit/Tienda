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

       public DataTable FiltrarProducto(string textoBuscar)
       {
            _tabla = _datosProductos.Filtrar(textoBuscar);
            return _tabla;
       }
       
    }
}