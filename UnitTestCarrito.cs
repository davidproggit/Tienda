using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CapaDeEntidades;

namespace Test
{
    [TestClass]
    public class UnitTestCarrito
    {
        [TestMethod]
        public void ComprobarCantidadDeUnProducto()
        {
            int cantidadProducto = 0;
            Cliente clienteTest = new Cliente();
            Carrito carritoTest = new Carrito();

            clienteTest.AgregarCarrito(1, 1, "Puerta", "Madera", "La mejor", 3, 200);
            cantidadProducto = carritoTest.DevolverCantidadCarrito(1);

            Assert.AreEqual(3,cantidadProducto);
        }

        [TestMethod]
        public void ComprobarUnProductoEncontrado()
        {
            int idProducto = 0;
            Cliente clienteTest = new Cliente();
            Carrito carritoTest = new Carrito();

            clienteTest.AgregarCarrito(1, 2, "Escritorio", "Platico", "La mejor", 1, 345);
            idProducto = carritoTest.VerificarProductoCarrito(2);

            Assert.AreEqual(2,idProducto);
        }
    }
}
