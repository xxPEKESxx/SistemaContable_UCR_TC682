using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;
using System.Globalization;

namespace SistemaContable_UCR_Pruebas
{
    [TestClass]
    public class PruebaGestorDeTransacciones
    {
        [TestMethod]
        public void TestMethod1()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();
            

            Transacciones transaccion = new Transacciones
            {
            IdProducto = 1,
            Cantidad = 1,
            Total = 1,
            IdTipo = 1,
        };

            coordinadorTransacciones.Save(transaccion);
        }

        [TestMethod]
        public void TestMethod2()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            coordinadorTransacciones.getAll();
        }

        [TestMethod]
        public void TestMethod3()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            coordinadorTransacciones.Find(25);
        }

        [TestMethod]
        public void TestMethod4()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            coordinadorTransacciones.Delete(1);
        }

        [TestMethod]
        public void TestMethod5()
        {
            
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            coordinadorTransacciones.getByDate(DateTime.Now);
        }
    }
}
