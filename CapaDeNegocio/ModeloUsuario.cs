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
        DatosDeUsuario datosDeUsuario = new DatosDeUsuario();

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
            datosDeUsuario.EditarPerfil(_id, _usuario, _clave, _nombre, _apellido, _email);
            LoginUsuario(_usuario, _clave);
            return "Perfil actualizado";
        }

        public bool LoginUsuario(string usuario, string clave)
        {
            return datosDeUsuario.Login(usuario, clave);
        }

        public DataTable CargarUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla = datosDeUsuario.CargarUsuarios();
            return tabla;
        }

        public DataTable CargarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = datosDeUsuario.CargarClientes();
            return tabla;
        }

        public void InsertarNuevoUsuario(string usuario, string clave, string nombre, string apellido, string email , string cargo, string dni, string cuil)
        {
            datosDeUsuario.InsertarNuevoUsuario(usuario,clave,nombre,apellido,email,cargo,dni,cuil);
        }
    }
}
