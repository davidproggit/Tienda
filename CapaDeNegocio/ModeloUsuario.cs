using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class ModeloUsuario
    {
        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DataTable _tabla = new DataTable();

        public ModeloUsuario() {}

        public void EditarPerfilUsuario(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.EditarPerfilUsuario(id, usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public bool LoginUsuario(string usuario, string clave)
        {
            return _datosDeUsuario.Login(usuario, clave);
        }

        public DataTable CargarUsuarios()
        {
            _tabla = _datosDeUsuario.CargarUsuarios();
            return _tabla;
        }

        public DataTable CargarClientes()
        {
            _tabla = _datosDeUsuario.CargarClientes();
            return _tabla;
        }

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void EliminarUsuario(int id)
        {
            _datosDeUsuario.EliminarUsuario(id);
        }

        public DataTable FiltrarUsuario(string txtBuscar)
        {
            _tabla = _datosDeUsuario.FiltrarUsuario(txtBuscar);
            return _tabla;
        }

        public DataTable FiltrarCliente(string txtBuscar)
        {
            _tabla = _datosDeUsuario.FiltrarCliente(txtBuscar);
            return _tabla;
        }
    }
}
