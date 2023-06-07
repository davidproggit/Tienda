﻿using CapaComun;
using CapaDeEntidades;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class VistaOrdenCompraCliente : Form
    {
        private List<FormatoProductos> _valores = new List<FormatoProductos>();

        public VistaOrdenCompraCliente()
        {
            InitializeComponent();
        }

        #region "Cargar datos"

        private void Historial_Load(object sender, EventArgs e)
        {
            CargarHistorial();
        }

        private void CargarHistorial()
        {
            Cliente cliente = new Cliente();

            _valores = cliente.CargarHistorialOrdenes(CacheSesionUsuario.id);

            foreach (FormatoProductos datos in _valores)
            {
                OrdenCompraCliente ordenCompraCliente = new OrdenCompraCliente();

                ordenCompraCliente.productoId = datos.productoId;
                ordenCompraCliente.productoNombre = datos.productoNombre;
                ordenCompraCliente.productoDescripcion = datos.productoDescripcion;
                ordenCompraCliente.productoMarca = datos.productoMarca;
                ordenCompraCliente.productoPrecio = datos.productoPrecio;
                ordenCompraCliente.productoCantidad = datos.productoCantidad;
                ordenCompraCliente.productoEstado = datos.productoEstado;

                contenedorProductos.Controls.Add(ordenCompraCliente);
            }
        }

        #endregion

    }
}
