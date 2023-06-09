using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeNegocio
{

    public abstract class Empleado
    {


        private int _id;

        public int id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _nombre;

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private string _apellido;

        public string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        private double _sueldo;

        public double sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public Empleado() 
        
        {

        }
    }
    
}