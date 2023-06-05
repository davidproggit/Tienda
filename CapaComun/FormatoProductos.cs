using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaComun
{
    public class FormatoProductos
    {
        public int idProducto { get; set; }
        public int idCliente { get; set; }
        public string nombreProducto { get; set; }
        public string nombreCliente { get; set; }
        public string descripcionProducto { get; set; }
        public string marcaProducto { get; set; }
        public int cantidadProducto { get; set; }
        public float precioProducto { get; set; }
        public string estadoProducto { get; set; }
    }
}
