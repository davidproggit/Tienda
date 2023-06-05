using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Administrador
    {
        #region "Objetos"

        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DataTable _tabla = new DataTable();

        #endregion

        #region "Constructor"

        public Administrador() { }

        #endregion

        #region "DataTable"

        public DataTable CargarRoles()
        {
            _tabla = _datosDeUsuario.CargarRoles();
            return _tabla;
        }

        public DataTable CargarUsuarios()
        {
            _tabla = _datosDeUsuario.CargarUsuarios();
            return _tabla;
        }

        public DataTable FiltrarUsuario(string txtBuscar)
        {
            _tabla = _datosDeUsuario.FiltrarUsuario(txtBuscar);
            return _tabla;
        }

        #endregion

        #region "Usuario"

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email, string cargo, string dni, string cuil)
        {
            _datosDeUsuario.InsertarNuevoUsuario(usuario, clave, nombre, apellido, email, cargo, dni, cuil);
        }

        public void EliminarUsuario(int id)
        {
            _datosDeUsuario.EliminarUsuario(id);
        }

        #endregion

    }
}
