using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_DataAccess
{
    public class GestorDeTransacciones
    {


        public int Save(Transacciones laNuevaTransaccion)
        {
            int result = 0;

            Conection Conection = new Conection();
            string query = "insert into Transacciones (IdProducto, Cantidad, Total, Fecha, IdTipo) values ('" + 
                    laNuevaTransaccion.IdProducto + "', '" + laNuevaTransaccion.Cantidad + "', '" + 
                    laNuevaTransaccion.Total + "', '" + laNuevaTransaccion.Fecha + "', '" + laNuevaTransaccion.IdTipo + "')";
                
                using (SQLiteConnection stringConection = new SQLiteConnection(Conection.getConection()))
                {
                    stringConection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, stringConection))
                    {
                       result = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    stringConection.Close();
                }

            return result;
        }

        public int Update(Transacciones laTransaccion)
        {
            int result = 0;
            Conection Conection = new Conection();
            try
            {
                string query = "update Transacciones set IdProducto='" + laTransaccion.IdProducto +
                    "', Cantidad='" + laTransaccion.Cantidad + "', Total='" + laTransaccion.Total +
                    "', Fecha='" + laTransaccion.Fecha + "', IdTipo='" + laTransaccion.IdTipo +
                    "' where ID='" + laTransaccion.ID + "'";

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        result = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public Transacciones getById(int Id)
        {
            Conection Conection = new Conection();
        Transacciones transaccion = null;
            try
            {
                string query = "select * from Transacciones where ID="+ Id;

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader datos = cmd.ExecuteReader())
                        {
                            cmd.Dispose();

                            while (datos.Read())
                            {
                                transaccion = fillTransaction(datos);
                            }
                            datos.Close();
                        }
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return transaccion;
        }

        public int Delete(int Id)
        {
            int result = 0;
        Conection Conection = new Conection();
            try
            {
                string query = "delete from Transacciones where ID=" + Id;

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        result = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return result;
        }

        public List<Transacciones> getAll() {
        Conection Conection = new Conection();
        List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();


            try {

                string query = "select * from Transacciones";

                laListaDeTransaccciones = new List<Transacciones>();

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader datos = cmd.ExecuteReader())
                        {
                            cmd.Dispose();

                            while (datos.Read()){

                    laListaDeTransaccciones.Add(fillTransaction(datos));
                }
                            datos.Close();
        }
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByDate(String Desde, String Hasta, int Tipo)
        {
        Conection Conection = new Conection();
        List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();

            try {

                string query = "select * from Transacciones where Fecha BETWEEN '" + Desde + "' AND '" + Hasta + "'"+
                    " AND IdTipo="+Tipo;

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader datos = cmd.ExecuteReader())
                        {
                            cmd.Dispose();

                            while (datos.Read())
                            {

                                laListaDeTransaccciones.Add(fillTransaction(datos));
                            }
                            datos.Close();
                        }
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByType(int Tipo)
        {
        Conection Conection = new Conection();
        List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();

            try
            {

                string query = "select * from Transacciones where IdTipo='" + Tipo + "'";

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader datos = cmd.ExecuteReader())
                        {
                            cmd.Dispose();

                            while (datos.Read())
                            {

                                laListaDeTransaccciones.Add(fillTransaction(datos));
                            }
                            datos.Close();
                        }
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByProductName(string Nombre, int Tipo)
        {
            Conection Conection = new Conection();
            List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();

            try
            {

                string query = "select tr.ID, tr.IdProducto, tr.Cantidad, tr.Total, tr.Fecha, tr.IdTipo, pr.Producto "+
                    "from Transacciones tr JOIN Productos pr ON tr.IdProducto = pr.ID WHERE pr.Producto LIKE '%"+Nombre+"%' AND tr.Idtipo="+Tipo;

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        using (SQLiteDataReader datos = cmd.ExecuteReader())
                        {
                            cmd.Dispose();

                            while (datos.Read())
                            {

                                laListaDeTransaccciones.Add(fillTransaction(datos));
                            }
                            datos.Close();
                        }
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return laListaDeTransaccciones;
        }

        public Transacciones fillTransaction(SQLiteDataReader datos) {

            Transacciones transaccion = new Transacciones
            {
                ID = datos.GetInt32(0),
                IdProducto = datos.GetInt32(1),
                Cantidad = datos.GetInt32(2),
                Total = datos.GetFloat(3),
                Fecha = datos[4].ToString(),
                IdTipo = datos.GetInt32(5),
            };

            return transaccion;
        }
    }
}
