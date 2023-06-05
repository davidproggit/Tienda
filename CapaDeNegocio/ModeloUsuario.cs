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
        #region "Objeto"

        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();

        #endregion

        #region "Constructor"

        public ModeloUsuario() {}

        #endregion

        #region "Metodo"

        public bool LoginUsuario(string usuario, string clave)
        {
            return _datosDeUsuario.IniciarSesion(usuario, clave);
        }

        #endregion

    }
}
