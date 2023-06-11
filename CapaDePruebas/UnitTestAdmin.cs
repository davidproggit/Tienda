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

        //Leandro
        [DataTestMethod]
        [DataRow("admin", "1", true)]
        [DataRow("proveedor", "1", true)]
        [DataRow("gerente", "1", true)]
        [DataRow("vendedor", "1", true)]
        [DataRow("cliente", "1", true)]
        [DataRow("usuario_inexistente", "contraseña_incorrecta", false)]
        [DataRow("admin", "contraseña_incorrecta", false)]
        public void ValidarLogin(string usuarioNombre, string clave, bool resultadoEsperado)
        {
            Usuario usuario = new Usuario();

            bool resultadoLogin = usuario.IniciarSesion(usuarioNombre, clave);

            Assert.AreEqual(resultadoEsperado, resultadoLogin);
        }
    }
}
