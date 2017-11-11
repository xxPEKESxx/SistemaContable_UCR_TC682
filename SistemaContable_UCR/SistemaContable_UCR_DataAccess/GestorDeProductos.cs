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
        
        public int saveProduct(Productos producto)
        {
            Conection conection = new Conection();
            string query = "insert into Productos (Producto, Precio, Descripcion) values('"+
                   producto.Producto + "','" + producto.Precio + "','" + producto.Descripcion + "')";
            using (SQLiteConnection stringConection = new SQLiteConnection(conection.getConection()))
            {
                stringConection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, stringConection))
                {
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                stringConection.Close();
            }
            return 1;
        }
        public bool validateProducto(string producto)
        {
            Conection conection = new Conection();
            string query = "select * from Productos where Producto='" + producto + "'";
            using (SQLiteConnection stringConection = new SQLiteConnection(conection.getConection()))
            {
                stringConection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, stringConection))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        cmd.Dispose();

                        if (rdr.Read())
                        {
                            rdr.Close();

                            return true;
                        }
                        rdr.Close();
                    }
                }
                stringConection.Close();
            }
            return false;
        }
        public Productos getById(int id)
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
            Conection conection = new Conection();

            List<Productos> listaProductos = new List<Productos>();
            string query = "select * from Productos";
            using (SQLiteConnection stringConection = new SQLiteConnection(conection.getConection()))
            {
                stringConection.Open();
                using (SQLiteCommand cmd = new SQLiteCommand(query, stringConection))
                {
                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        cmd.Dispose();

                        while (rdr.Read())
                        {
                            listaProductos.Add(fillProduct(rdr));
                        }
                        rdr.Close();
                    }
                }
                stringConection.Close();
            }
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
