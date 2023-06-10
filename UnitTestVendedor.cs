using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using CapaDeEntidades;

namespace Test
{
    [TestClass]
    public class UnitTestVendedor
    {
        [TestMethod]
        public void VerificarNuevoClienteCreado()
        {
            Vendedor vendedorTest = new Vendedor();
            DataTable resultado = new DataTable();

            vendedorTest.InsertarNuevoCliente("usuarioTest","1","user","test","userTest@gmail.com","Cliente","4444","1112");
            resultado = vendedorTest.FiltrarCliente("user");

            Assert.IsTrue((resultado.Rows.Count) != 0);

        }

        [TestMethod]
        public void VerificarClienteEditado()
        {
            Vendedor vendedorTest = new Vendedor();
            Vendedor vendedorTest1 = new Vendedor();
            DataTable resultados = new DataTable();
            string nombreUsuarioEditado;

            
            vendedorTest.EditarPerfilCliente(6,"ClienteTest", "1","Carlos", "testapellido", "a@email.com","Cliente", "1", "22");
            resultados = vendedorTest1.FiltrarCliente("Carlos");
            nombreUsuarioEditado = resultados.Rows[0]["Usuario"].ToString();

            Assert.AreEqual("ClienteTest",nombreUsuarioEditado);
        }
    }
}
