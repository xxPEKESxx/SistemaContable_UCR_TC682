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
            if (gestordeProductos.saveProduct(producto) > 0)
                return true;
            else
                return false;
        }
        public List<Productos> getAllProducts()
        {
            GestorDeProductos gestordeProductos = new GestorDeProductos();
            List<Productos> listaProductos = new List<Productos>();
            listaProductos = gestordeProductos.getAllProducts();
            return listaProductos;
        }
    }
}
