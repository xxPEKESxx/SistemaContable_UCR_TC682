﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;

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
            IdProducto = 4,
            Cantidad = 1,
            Total = 1,
            IdTipo = 2,
        };

            coordinadorTransacciones.Save(transaccion);
        }

        [TestMethod]
        public void TestMethod2()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            Console.WriteLine(coordinadorTransacciones.getAll().Count);
        }

        [TestMethod]
        public void TestMethod3()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            coordinadorTransacciones.getById(26);
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

            Console.WriteLine(coordinadorTransacciones.getComprasByDate(DateTime.Now, DateTime.Now.AddDays(1)).Count);
            Console.WriteLine(coordinadorTransacciones.getVentasByDate(DateTime.Now, DateTime.Now.AddDays(1)).Count);
        }

        [TestMethod]
        public void TestMethod6()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            Transacciones transaccion = coordinadorTransacciones.getById(29);

            transaccion.IdProducto = 4;

            coordinadorTransacciones.Update(transaccion);
        }

        [TestMethod]
        public void TestMethod7()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            Console.WriteLine(coordinadorTransacciones.getByType(1).Count);
        }

        [TestMethod]
        public void TestMethod8()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            Console.WriteLine(coordinadorTransacciones.getVentasByProductName("Yu").Count);
        }

        [TestMethod]
        public void TestMethod9()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            Console.WriteLine(coordinadorTransacciones.getUtilityByMonth(DateTime.Now)[2].ToString());
            
        }

        [TestMethod]
        public void TestMethod10()
        {
            CoordinadorDeTransacciones coordinadorTransacciones = new CoordinadorDeTransacciones();

            Console.WriteLine(coordinadorTransacciones.getTotalUtility()[2].ToString());

        }
    }
}
