using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaContable_UCR_Busisness;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_Pruebas
{
    [TestClass]
    public class PruebaGestorDeProductos
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
            coordinadorDeProductos.saveProduct(producto);
        }
    }
}
