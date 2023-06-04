﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaComun;
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

        public List<FormatoProductos> Rellenar()
        {
            return _datosProductos.Rellenar();
        }

        public List<FormatoProductos> RellenarCarrito()
        {
            return _datosProductos.RellenarCarrito();
        }

        public void AgregarCarrito(int id, string nombre, string descripcion, string marca, int cantidad, float precio)
        {
            _datosProductos.AgregarCarrito(id, nombre, descripcion, marca, cantidad, precio);
        }
        
        public void CambiarEstadoProducto(int id, string estado)
        {
            _datosProductos.CambiarEstadoProducto(id, estado);
        }

        public void EliminarProductoCarrito(int id)
        {
            _datosProductos.EliminarProductoCarrito(id);
        }

        public void EnviarCompra(int id, string nombre, string descripcion, string marca, int cantidad, float precio)
        {
            _datosProductos.EnviarCompra(id, nombre, descripcion, marca, cantidad, precio);
        }

        public void AsignarClienteProducto(int id, int idCliente)
        {
            _datosProductos.AsignarClienteProducto(id, idCliente);
        }

        public void EliminarClienteProducto(int id)
        {
            _datosProductos.EliminarClienteProducto(id);
        }
    }
}