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

        private int _id;
        private string _usuario;
        private string _clave;
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _cargo;

        public ModeloUsuario(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo)
        {
            this._id = id;
            this._usuario = usuario;
            this._clave = clave;
            this._nombre = nombre;
            this._apellido = apellido;
            this._email = email;
            this._cargo = cargo;
        }

        public ModeloUsuario()
        {

        }

        public string EditarPerfilUsuario()
        {
            _datosDeUsuario.EditarPerfil(_id, _usuario, _clave, _nombre, _apellido, _email);
            LoginUsuario(_usuario, _clave);
            return "Perfil actualizado";
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

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email , string cargo, string dni, string cuil)
        {
            _datosDeUsuario.InsertarNuevoUsuario(usuario,clave,nombre,apellido,email,cargo,dni,cuil);
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
