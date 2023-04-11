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
        public bool LoginUsuario(string usuario, string clave)
        {
            return datosDeUsuario.Login(usuario,clave);
        }
    }
}
