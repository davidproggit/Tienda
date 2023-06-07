﻿using System.Collections.Generic;
using System.Data;
using CapaComun;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class Productos
    {
        public int DevolverCantidadMaxima(int _cantidadCarrito, int productoCantidad, bool _agregarProductoCarrito)
        {
            int selectorCantidad;

            if (_cantidadCarrito < productoCantidad)
            {
                if (_agregarProductoCarrito)
                    selectorCantidad = productoCantidad;
                else
                    selectorCantidad = productoCantidad - _cantidadCarrito;
            }
            else
                selectorCantidad = productoCantidad;

            return selectorCantidad;
        }

    }
}