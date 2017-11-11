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
            Transacciones transaccion = new Transacciones();

            transaccion.IdProducto = 1;
            transaccion.Cantidad = 1;
            transaccion.Total = 1;
            transaccion.Fecha = DateTime.Now;
            transaccion.IdTipo = 1;

            coordinadorTransacciones.Save(transaccion);
        }
    }
}
