﻿using CapaComun;
using CapaDeEntidades;
using CapaDePresentacion.PantallasUsuarios.UsuarioVendedor.OrdenComponente;
using System;
using System.Windows.Forms;

namespace CapaDePresentacion.PantallasUsuarios.UsuarioCliente
{
    public partial class OrdenCompraVendedor : UserControl
    {
        public OrdenCompraVendedor()
        {
            InitializeComponent();
        }

        #region "Atributos"

        private int _ordenId;

        public int ordenId
        {
            get { return _ordenId; }
            set { _ordenId = value; }
        }

        private int _productoId;

        public int productoId
        {
            get { return _productoId; }
            set { _productoId = value; }
        }

        private int _idCliente;

        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        private string _productoNombre;

        public string productoNombre
        {
            get { return _productoNombre; }
            set { _productoNombre = value; }
        }

        private string _productoDescripcion;

        public string productoDescripcion
        {
            get { return _productoDescripcion; }
            set { _productoDescripcion = value; }
        }

        private string _productoMarca;

        public string productoMarca
        {
            get { return _productoMarca; }
            set { _productoMarca = value; }
        }

        private float _productoPrecio;

        public float productoPrecio
        {
            get { return _productoPrecio; }
            set { _productoPrecio = value; }
        }

        private int _productoCantidad;

        public int productoCantidad
        {
            get { return _productoCantidad; }
            set { _productoCantidad = value; }
        }

        private string _productoEstado;

        public string productoEstado
        {
            get { return _productoEstado; }
            set { _productoEstado = value; }
        }

        #endregion

        #region "Cargar datos"

        private void OrdenCompraVendedor_Load(object sender, EventArgs e)
        {
            CargarInformacion();
            VerificarEstado();
        }
      
        private void CargarInformacion()
        {
            lblOrden.Text = "Orden nº: " + ordenId;
            lblEstado.Text = productoEstado;
        }

        #endregion

        #region "Opciones"

        private void btnAprobar_Click(object sender, EventArgs e)
        {
            AprobarOrden();
            VerificarEstado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CancelarOrden();
            VerificarEstado();
        }

        private void linkDetalle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AbrirDetalle();
        }

        #endregion

        #region "Metodos de las opciones"

        private void AprobarOrden()
        {
            Vendedor vendedor = new Vendedor();

            vendedor.AprobarOrden(ordenId, DatosUsuario.nombre, productoCantidad,productoId);
            productoEstado = "Aprobado";
            CargarInformacion();
        }

        private void CancelarOrden()
        {
            Vendedor vendedor = new Vendedor();

            vendedor.CancelarOrden(ordenId, DatosUsuario.nombre);
            productoEstado = "Cancelado";
            CargarInformacion();
        }

        private void VerificarEstado()
        {
            if (productoEstado != "Pendiente")
                DesactivarBotones();
        }

        private void DesactivarBotones()
        {
            btnAprobar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void AbrirDetalle()
        {
            OrdenDetalle ordenDetalle = new OrdenDetalle();

            ordenDetalle.ordenId = ordenId;
            ordenDetalle.idCliente = idCliente;
            ordenDetalle.productoNombre = productoNombre;
            ordenDetalle.productoMarca = productoMarca;
            ordenDetalle.productoDescripcion = productoDescripcion;
            ordenDetalle.productoPrecio = productoPrecio;
            ordenDetalle.productoCantidad = productoCantidad;

            ordenDetalle.Show();
        }

        #endregion
    }
}
