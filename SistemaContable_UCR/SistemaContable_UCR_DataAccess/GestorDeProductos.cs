using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaContable_UCR_Model;
using System.Data.SQLite;

namespace SistemaContable_UCR_DataAccess
{
    public class GestorDeProductos
    {
        Conection conection = new Conection();

        public int saveProduct(Productos producto)
        {
            SQLiteConnection stringConection = conection.getConection();

            int result;
            try
            {
                stringConection.Open();
                string query = "insert into Productos (Producto, Precio, IdTipo, Descripcion) values('" +
                     producto.Producto + "','" + producto.Precio + "','" + producto.IdTipo + "','" + producto.Descripcion + "')";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = stringConection;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
                stringConection.Close();
                return result;
             }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }
        }
    }
}
