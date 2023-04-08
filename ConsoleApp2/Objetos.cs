using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Objetos
    {
        static void Main(string[] args)
        {
        }

        public class Silla
        {
            public static string ActualizarImagen()
            {
                return "../../Resources/silla.jpg";
            }

            public static string ActualizarNombre()
            {
                return "Sillas";
            }

        
        }

        public class Mesa
        {
            public static string ActualizarImagen()
            {
                return "../../Resources/mesa.jpg";
            }

            public static string ActualizarNombre()
            {
                return "Mesas";
            }
        }
        
        public class Puerta
        {
            public static string ActualizarImagen()
            {
                return "../../Resources/puerta.jpg";
            }

            public static string ActualizarNombre()
            {
                return "Puertas";
            }
        }

    }
}
