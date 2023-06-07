﻿using CapaDeDatos;
using System.Data;

namespace CapaDeEntidades
{
    public class Gerente : Usuario
    {
        #region "Objetos"

        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DatosProductos _datosProductos = new DatosProductos();
        private DataTable _tabla = new DataTable();

        #endregion

        #region "Constructor"

        public Gerente() { }

        #endregion

        #region "DataTable"

        public DataTable CargarVendedores()
        {
            _tabla = _datosDeUsuario.CargarVendedores();
            return _tabla;
        }

        public DataTable MostrarOrdenes()
        {
            return _datosProductos.MostrarOrdenes();
        }

        public DataTable MostrarOrdenesSemana()
        {
            return _datosProductos.MostrarOrdenesSemana();
        }

        public DataTable MostrarOrdenesMes()
        {
            return _datosProductos.MostrarOrdenesMes(); ;
        }

        public DataTable MostrarOrdenesVendedor(string vendedor)
        {
            return _datosProductos.MostrarOrdenesVendedor(vendedor);
        }

        #endregion


    }
}
