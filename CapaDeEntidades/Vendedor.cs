using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaDeEntidades
{
    public class Vendedor : Usuario
    {
        #region "Objetos"

        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DatosProductos _datosProductos = new DatosProductos();

        #endregion

        #region "Constructor"

        public Vendedor() { }

        #endregion

        #region "Cliente"

        public DataTable CargarClientes()
        {
            return _datosDeUsuario.CargarClientes();
        }

        public DataTable FiltrarCliente(string txtBuscar)
        {
            return _datosDeUsuario.FiltrarCliente(txtBuscar);
        }

        public void EditarPerfilCliente(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.EditarPerfilUsuario(id, usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void InsertarNuevoCliente(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        #endregion

        #region "Ordenes"

        public List<FormatoProductos> CargarOrdenesCompra()
        {
            return _datosProductos.CargarOrdenesCompra();
        }

        public void AprobarOrden(int ordenId, string vendedor, int cantidad, int productoId)
        {
            _datosProductos.AprobarOrden(ordenId, vendedor, cantidad, productoId);
        }

        public void CancelarOrden(int ordenId, string vendedor)
        {
            _datosProductos.CancelarOrden(ordenId, vendedor);
        }

        #endregion
    }
}
