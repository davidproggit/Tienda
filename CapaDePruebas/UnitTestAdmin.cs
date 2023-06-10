using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data;
using CapaDeEntidades;

namespace Test
{
    [TestClass]
    public class UnitTestAdmin
    {
        [TestMethod]
        public void VerificarNuevoUsuarioAgregado()
        {
            Administrador adminTest = new Administrador();
            DataTable resultado = new DataTable();

            adminTest.InsertarNuevoUsuario("usuarioNuevoTest", "1", "userTest", "new", "usernew@email.com", "Cliente", "1", "1");
            resultado = adminTest.FiltrarUsuario("userTest");

            Assert.IsTrue((resultado.Rows.Count) != 0);
        }

        [TestMethod]
        public void VerificarUsuarioNoAgregado()
        {
            Administrador adminTest = new Administrador();
            DataTable resultado = new DataTable();

            resultado = adminTest.FiltrarUsuario("@@@@@@@@@");

            Assert.IsTrue((resultado.Rows.Count) == 0);
        }
    }
}
