using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    public class ComprobarCampos
    {
        public string mensaje = "";

        public string ComprobarCamposIndividuales(string campo)
        {
            if (campo == "Usuario")
                mensaje = "Ingrese su nombre de usuario";

            if (campo == "Clave")
                mensaje = "Ingrese su clave";

            return mensaje;
        }

        public string ComprobarCamposConjunto(string campoUsuario, string campoClave)
        {
            if (campoUsuario == "Usuario" && campoClave == "Clave")
                mensaje = "Debe completar los campos";

            return mensaje;
        }
    }
}
