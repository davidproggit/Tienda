using CapaComun;
using CapaDeDatos;

namespace CapaDeEntidades
{
    public class Usuario
    {
        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();

        public Usuario() { }

        public bool IniciarSesion(string usuario, string clave)
        {
            return _datosDeUsuario.IniciarSesion(usuario, clave);
        }

        public void CerrarSesion()
        {
            CacheSesionUsuario.id = 0;
            CacheSesionUsuario.usuario = "";
            CacheSesionUsuario.clave = "";
            CacheSesionUsuario.nombre = "";
            CacheSesionUsuario.email = "";
            CacheSesionUsuario.cargo = "";
        }

    }
}
