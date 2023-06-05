using CapaDeDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeEntidades
{
    public class Gerente
    {
        private DatosDeUsuario _datosDeUsuario = new DatosDeUsuario();
        private DataTable _tabla = new DataTable();

        public Gerente() { }

        public DataTable CargarVendedores()
        {
            _tabla = _datosDeUsuario.CargarVendedores();
            return _tabla;
        }
    }
}
