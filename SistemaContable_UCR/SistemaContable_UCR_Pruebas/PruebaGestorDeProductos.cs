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
            producto.Precio = 1;
            producto.Producto = "Leche";
            producto.IdTipo = Tipos.Venta;
            producto.Descripcion = "1";
            coordinadorDeProductos.saveProduct(producto);
        }
    }
}
