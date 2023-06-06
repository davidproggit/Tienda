using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{
    internal class Empresa
    {
        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _sitioWeb;

        public string sitioWeb
        {
            get { return _sitioWeb; }
            set { _sitioWeb = value; }
        }

        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Empresa() { }

    }
}