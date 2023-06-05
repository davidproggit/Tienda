﻿using CapaComun.Cache;
using CapaComun;
using CapaDeNegocio;
using CapaDePresentacion.PantallasUsuarios.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.Vendedor
{
    public partial class OrdenesCompra : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public OrdenesCompra()
        {
            InitializeComponent();
        }

        private void OrdenesCompra_Load(object sender, EventArgs e)
        {
            CargarOrdenesCompra();
        }

        private void CargarOrdenesCompra()
        {
            Productos productos = new Productos();
            _valores = productos.CargarOrdenesCompra();

            foreach (FormatoProductos datos in _valores)
            {
                OrdenCompraVendedor ordenCompraVendedor = new OrdenCompraVendedor();

                ordenCompraVendedor.ordenId = datos.ordenId;
                ordenCompraVendedor.ProductoId = datos.ProductoId;
                ordenCompraVendedor.idCliente = datos.ClienteId;
                ordenCompraVendedor.ProductoNombre = datos.ProductoNombre;
                ordenCompraVendedor.ProductoDescripcion = datos.ProductoDescripcion;
                ordenCompraVendedor.ProductoMarca = datos.ProductoMarca;
                ordenCompraVendedor.ProductoPrecio = datos.ProductoPrecio;
                ordenCompraVendedor.ProductoCantidad = datos.ProductoCantidad;
                ordenCompraVendedor.ProductoEstado = datos.ProductoEstado;

                contenedorProductos.Controls.Add(ordenCompraVendedor);
            }
        }

       
    }
}