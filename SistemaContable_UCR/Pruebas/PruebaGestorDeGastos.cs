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
        [TestMethod]
        public void update()
        {
            Gastos nuevoGasto = new Gastos();
            CoordinadorDeGastos coordinadorDeGasto = new CoordinadorDeGastos();
            nuevoGasto.ID = 1;
            nuevoGasto.Descripcion = "Carro";
            nuevoGasto.Total = 3000;
            Console.Write(coordinadorDeGasto.update(nuevoGasto));
        }
        [TestMethod]
        public void delete()
        {
            CoordinadorDeGastos coordinadorDeGasto = new CoordinadorDeGastos();
            Console.Write(coordinadorDeGasto.delete(1));
        }
        [TestMethod]
        public void getById()
        {
            CoordinadorDeGastos coordinadorDeGasto = new CoordinadorDeGastos();
            Console.Write(coordinadorDeGasto.getById(2).Descripcion);
        }
        [TestMethod]
        public void getAll()
        {
            CoordinadorDeGastos coordinadorDeGasto = new CoordinadorDeGastos();
            Console.Write(coordinadorDeGasto.getAll().Count);
        }

        [TestMethod]
        public void getByDateInterval()
        {
            CoordinadorDeGastos coordinadorDeGasto = new CoordinadorDeGastos();
            Console.Write(coordinadorDeGasto.getByDateInterval(DateTime.Now, DateTime.Now.AddDays(1)).Count);
        }
        
    }
}
