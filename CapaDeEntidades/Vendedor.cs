using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Vendedor
    {
        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DataTable _tabla = new DataTable();

        public Vendedor() { }

        public DataTable CargarClientes()
        {
            _tabla = _datosDeUsuario.CargarClientes();
            return _tabla;
        }
        public DataTable FiltrarCliente(string txtBuscar)
        {
            _tabla = _datosDeUsuario.FiltrarCliente(txtBuscar);
            return _tabla;
        }

        public void EditarPerfilUsuario(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.EditarPerfilUsuario(id, usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }
  
    }
}
