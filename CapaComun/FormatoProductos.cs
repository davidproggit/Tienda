using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun
{
    public class FormatoProductos
    {
        public int ProductoId { get; set; }
        public int ordenId { get; set; }
        public int ClienteId { get; set; }
        public string ProductoNombre { get; set; }
        public string ClienteNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public string ProductoMarca { get; set; }
        public int ProductoCantidad { get; set; }
        public float ProductoPrecio { get; set; }
        public string ProductoEstado { get; set; }
    }
}
