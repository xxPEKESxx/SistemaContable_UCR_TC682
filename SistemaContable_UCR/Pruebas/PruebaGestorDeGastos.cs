using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContable_UCR_Model;
using SistemaContable_UCR_Busisness;
namespace Pruebas
{
    [TestClass]
    public class PruebaGestorDeGastos
    {
        [TestMethod]
        public void save()
        {
            Gastos nuevoGasto = new Gastos();
            CoordinadorDeGastos coordinadorDeGasto = new CoordinadorDeGastos();
            nuevoGasto.Descripcion = "Agua";
            nuevoGasto.Total = 3000;
            Console.Write(coordinadorDeGasto.save(nuevoGasto));
        }
    }
}
