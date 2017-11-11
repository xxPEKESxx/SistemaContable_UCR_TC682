using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaContable_UCR_DataAccess;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_Busisness
{
    public class CoordinadorDeProductos
    {
        public bool saveProduct(Productos producto)
        {
            GestorDeProductos gestordeProductos = new GestorDeProductos();
            if (!gestordeProductos.validateProducto(producto.Producto))
            {
                if (gestordeProductos.saveProduct(producto) > 0)
                    return true;
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
        public Productos getById(int id)
        {
            GestorDeProductos gestordeProductos = new GestorDeProductos();
            return gestordeProductos.getById(id);

        }
        public List<Productos> getAllProducts()
        {
            GestorDeProductos gestordeProductos = new GestorDeProductos();
            List<Productos> listaProductos = new List<Productos>();
            listaProductos = gestordeProductos.getAllProducts();
            return listaProductos;
        }
      
        public List<Productos> getByProducto(string producto)
        {
            GestorDeProductos gestordeProductos = new GestorDeProductos();
            List<Productos> listaProductos = new List<Productos>();
            listaProductos = gestordeProductos.getByProduct(producto);
            return listaProductos;
        }
        public bool updateProduct(Productos producto)
        {
            GestorDeProductos gestordeProductos = new GestorDeProductos();
            if (gestordeProductos.update(producto)>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool deleteProduct(int id)
        {
            GestorDeProductos gestordeProductos = new GestorDeProductos();
            if (gestordeProductos.delete(id) > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
