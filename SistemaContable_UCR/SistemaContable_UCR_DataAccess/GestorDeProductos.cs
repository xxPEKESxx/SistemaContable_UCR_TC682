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
                string query = "insert into Productos (Producto, Precio, Descripcion) values('" +
                     producto.Producto + "','" + producto.Precio + "','" + producto.Descripcion + "')";
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
        public Productos getById(string id)
        {
            Productos producto = new Productos();
            SQLiteConnection stringConection;
            Conection myconection = new Conection();

            stringConection = myconection.getConection();

            stringConection.Open();
            string query = "select * from Productos where ID='"+id+"'";
            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();
            if (datos.Read())
            {
                producto.ID = datos.GetInt32(0);
                producto.Producto = datos.GetString(1);
                producto.Precio = datos.GetFloat(2);
                producto.Descripcion = datos.GetString(3);
            }
            stringConection.Close();
            return producto;
        }
        public List<Productos> getAllProducts()
        {
            List<Productos> listaProductos = new List<Productos>();
            SQLiteConnection stringConection;
            Conection myconection = new Conection();

            stringConection = myconection.getConection();

            stringConection.Open();
            string query = "select * from Productos";
            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();
            while (datos.Read())
            {
                listaProductos.Add(fillProduct(datos));
            }
            stringConection.Close();
            return listaProductos;
        }
        public List<Productos> getByProduct(string product)
        {
            Productos producto;
            List<Productos> listaProductos = new List<Productos>();
            SQLiteConnection stringConection;
            Conection myconection = new Conection();

            stringConection = myconection.getConection();

            stringConection.Open();
            string query = "select * from Productos where Producto like '%" + product + "%'";
            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();
            while (datos.Read())
            {
                listaProductos.Add(fillProduct(datos));
            }
            stringConection.Close();
            return listaProductos;
        }
        public int update(Productos producto)
        {
            try
            {
                SQLiteConnection stringConection;
                Conection Conection = new Conection();

                stringConection = Conection.getConection();
                stringConection.Open();

                string query = "update Productos set Producto = '" + producto.Producto + 
                    "', Precio = '" + producto.Precio + "', Descripcion='" + producto.Descripcion 
                    + "'where ID='" + producto.ID+"'";

                SQLiteCommand command = new SQLiteCommand(query, stringConection);
                int result = command.ExecuteNonQuery();
                stringConection.Close();
                return result;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        public int delete(int Id)
        {
            SQLiteConnection stringConection;
            try
            {
                Conection Conection = new Conection();

                stringConection = Conection.getConection();
                stringConection.Open();

                string query = "delete from Productos where ID='" + Id+"'";

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                int result = command.ExecuteNonQuery();

                stringConection.Close();
                return result;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }
        private Productos fillProduct(SQLiteDataReader datos)
        {
            Productos producto = new Productos();
            producto.ID = datos.GetInt32(0);
            producto.Producto = datos.GetString(1);
            producto.Precio = datos.GetFloat(2);
            producto.Descripcion = datos.GetString(3);
            return producto;
        }
    }
}
