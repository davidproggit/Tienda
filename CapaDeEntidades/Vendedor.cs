using CapaComun;
using CapaDeDatos;
using System.Collections.Generic;
using System.Data;

namespace CapaDeEntidades
{
    public class Vendedor : Usuario
    {
        private ConsultasUsuario _consultasUsuario = new ConsultasUsuario();
        private ConsultasProductos _consultasProductos = new ConsultasProductos();

        public Vendedor() { }

        #region "Cliente"

        public DataTable CargarClientes()
        {
            return _consultasUsuario.CargarClientes();
        }

        public DataTable FiltrarCliente(string clienteCoincidencia)
        {
            return _consultasUsuario.FiltrarCliente(clienteCoincidencia);
        }

        public void EditarPerfilCliente(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _consultasUsuario.EditarPerfilUsuario(id, usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void InsertarNuevoCliente(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _consultasUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        #endregion

        #region "Ordenes"

        public List<FormatoProductos> CargarOrdenesCompra()
        {
            return _consultasProductos.CargarOrdenesCompra();
        }

        public void AprobarOrden(int ordenId, string vendedor, int cantidad, int productoId)
        {
            _consultasProductos.AprobarOrden(ordenId, vendedor, cantidad, productoId);
        }

        public void CancelarOrden(int ordenId, string vendedor)
        {
            _consultasProductos.CancelarOrden(ordenId, vendedor);
        }

        #endregion
    }
}
