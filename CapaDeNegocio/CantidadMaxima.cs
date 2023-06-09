namespace CapaDeNegocio
{
    public class CantidadMaxima
    {
        public int DevolverCantidadMaxima(int _cantidadCarrito, int productoCantidad, bool _agregarProductoCarrito)
        {
            int selectorCantidad;

            if (_cantidadCarrito < productoCantidad)
            {
                if (_agregarProductoCarrito)
                    selectorCantidad = productoCantidad;
                else
                    selectorCantidad = productoCantidad - _cantidadCarrito;
            }
            else
                selectorCantidad = productoCantidad;

            return selectorCantidad;
        }

    }
}