using System;
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
            IdProducto = 1,
            Cantidad = 1,
            Total = 1,
            Fecha = DateTime.Now,
            IdTipo = 1,
        };

            coordinadorTransacciones.Save(transaccion);
        }
    }
}
