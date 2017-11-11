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
            producto.Producto = "Yuca";
            producto.Precio = 2000;
            producto.Descripcion = "Sabroson";
            coordinadorDeProductos.saveProduct(producto);
        }
        [TestMethod]
        public void getById()
        {
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            Console.Write(coordinadorDeProductos.getById("8").Producto);
        }
        [TestMethod]
        public void listarProductos()
        {
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            Console.Write(coordinadorDeProductos.getAllProducts().Count.ToString());
        }
        [TestMethod]
        public void listarPorProducto()
        {
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            Console.Write(coordinadorDeProductos.getByProducto("n").Count);
        }
        [TestMethod]
        public void eliminarProducto()
        {
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            Console.Write(coordinadorDeProductos.deleteProduct(8));
        }
        [TestMethod]
        public void update()
        {
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();
            Productos producto = new Productos();
            producto.ID = 2;
            producto.Producto = "Papas";
            producto.Precio = 2000;
            producto.Descripcion = "Sabroson";
            Console.Write(coordinadorDeProductos.updateProduct(producto));
        }
    }
}
