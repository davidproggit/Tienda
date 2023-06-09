using CapaComun;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Usuario
    {
        private ConsultasUsuario _consultasUsuario = new ConsultasUsuario();

        public Usuario() { }

        #region "Sesion"

        public bool IniciarSesion(string usuario, string clave)
        {
            return _consultasUsuario.IniciarSesion(usuario, clave);
        }

        public void CerrarSesion()
        {
            DatosUsuario.id = 0;
            DatosUsuario.usuario = "";
            DatosUsuario.clave = "";
            DatosUsuario.nombre = "";
            DatosUsuario.email = "";
            DatosUsuario.cargo = "";
        }

        #endregion
    }
}
