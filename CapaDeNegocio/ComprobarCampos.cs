using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class ComprobarCampos
    {
        #region "Atributo"

        private string _mensaje = "";

        #endregion

        #region "Metodo"

        public string ComprobarCamposIndividuales(string campo)
        {
            if (campo == "Usuario")
                _mensaje = "Ingrese su nombre de usuario";

            if (campo == "Clave")
                _mensaje = "Ingrese su clave";

            return _mensaje;
        }

        public string ComprobarCamposConjunto(string campoUsuario, string campoClave)
        {
            if (campoUsuario == "Usuario" && campoClave == "Clave")
                _mensaje = "Debe completar los campos";

            return _mensaje;
        }

        #endregion
    }
}
