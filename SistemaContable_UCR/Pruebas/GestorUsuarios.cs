using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;
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
        [TestMethod]
        public void AddUser()
        {
            CoordinadorDeUsuarios coordinadorUsuarios = new CoordinadorDeUsuarios();
            Usuarios user = new Usuarios();
            user.DNI = "123";
            user.UserName = "Alexander";
            user.UserLastName = "Canales";
            user.UserPassword = "222";
            Console.Write(coordinadorUsuarios.register(user));
        }
    }

}
