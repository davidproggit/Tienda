using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;

namespace CapaDeNegocio
{
    public class ModeloUsuario
    {
        DatosDeUsuario datosDeUsuario = new DatosDeUsuario();

        private int id;
        private string usuario;
        private string clave;
        private string nombre;
        private string apellido;
        private string email;
        private string cargo;

        public ModeloUsuario(int id, string usuario, string clave, string nombre, string apellido, string email, string cargo)
        {
            this.id = id;
            this.usuario = usuario;
            this.clave = clave;
            this.nombre = nombre;
            this.apellido = apellido;
            this.email = email;
            this.cargo = cargo;
        }

        public ModeloUsuario()
        {

        }

        public string EditarPerfilUsuario()
        {
            datosDeUsuario.EditarPerfil(id, usuario, clave, nombre, apellido, email);
            LoginUsuario(usuario, clave);
            return "Perfil actualizado";
        }

        public bool LoginUsuario(string usuario, string clave)
        {
            return datosDeUsuario.Login(usuario, clave);
        }
    }
}
