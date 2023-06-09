﻿namespace CapaDeNegocio
{
    public class ComprobarCampos
    {
        private string _mensaje = "";

        #region "Campos"

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
