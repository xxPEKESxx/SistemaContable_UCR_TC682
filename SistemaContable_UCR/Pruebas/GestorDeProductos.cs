using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;
namespace Pruebas
{
    [TestClass]
    public class GestorDeProductos
    {
        [TestMethod]
        public void TestMethod1()
        {
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            Productos producto = new Productos();
            producto.Producto = "Salchichon";
            producto.Precio = 2000;
            producto.IdTipo = Tipos.Venta;
            producto.Descripcion = "Sabroson";
            if (coordinadorDeProductos.saveProduct(producto))
            {
                Console.Write("Exito");
            }
        }
    }
}
