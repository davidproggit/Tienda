﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun.Cache
{
    public static class CacheSesionUsuario
    {
        public static int ID { get; set; }
        public static string NombreLogin { get; set; }
        public static string Clave { get; set; }
        public static string Nombre { get; set; }
        public static string Apellido { get; set; }
        public static string Email { get; set; }
        public static string Cargo { get; set; }
    }
}
