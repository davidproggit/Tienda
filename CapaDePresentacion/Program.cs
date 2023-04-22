using CapaDePresentacion.PantallasGenerales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
           /* Application.Run(new InterfazBienvenida());
            Application.Run(new InterfazUsuario());
            Application.Run(new UsuarioPerfil());*/
        }
    }
}
