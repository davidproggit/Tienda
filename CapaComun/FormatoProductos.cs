namespace CapaComun
{
    public class FormatoProductos
    {
        public int productoId { get; set; }
        public int ordenId { get; set; }
        public int clienteId { get; set; }
        public string productoNombre { get; set; }
        public string clienteNombre { get; set; }
        public string productoDescripcion { get; set; }
        public string productoMarca { get; set; }
        public int productoCantidad { get; set; }
        public float productoPrecio { get; set; }
        public string productoEstado { get; set; }

    }
}
