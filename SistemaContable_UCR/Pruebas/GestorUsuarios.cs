using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContable_UCR_Busisness;
namespace Pruebas
{
    [TestClass]
    public class GestorUsuarios
    {
        [TestMethod]
        public void TestMethod1()
        {
            CoordinadorDeUsuarios coordinadorUsuarios = new CoordinadorDeUsuarios();
            Console.Write(coordinadorUsuarios.login("1", "123"));
        }
    }
}
