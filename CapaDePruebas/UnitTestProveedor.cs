using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using CapaDeEntidades;

namespace Test
{
    [TestClass]
    public class UnitTestProveedor
    {
        [TestMethod]
        public void VerificarNuevoProductoAgregado()
        {
            Proveedor proveedorTest = new Proveedor();
            DataTable resultados = new DataTable();

            proveedorTest.InsertarProductoStock("MuebleTest","Madera algarrobo","La mejor","1000","10");
            resultados = proveedorTest.FiltrarProductoStock("MuebleTest"); 

            Assert.IsTrue((resultados.Rows.Count) > 0);
        }

        [TestMethod]
        public void BuscarProductoNoAgregado()
        {
            Proveedor proveedorTest = new Proveedor();
            DataTable resultados = new DataTable();

            resultados = proveedorTest.FiltrarProductoStock("@@@@@@@@");

            Assert.IsTrue((resultados.Rows.Count) == 0);

        }
    }
}
