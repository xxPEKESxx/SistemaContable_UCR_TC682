using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_DataAccess
{
    public class GestorDeGastos
    {
        public int executeNonQuery(string query)
        {
            int filasAfectadas = 0;
            try
            {
                Conection Conection = new Conection();            
                using (SQLiteConnection stringConection = new SQLiteConnection(Conection.getConection()))
                {
                    stringConection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, stringConection))
                    {
                        filasAfectadas = cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    stringConection.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return filasAfectadas;
        }
        public int save(Gastos nuevoGasto)
        {
            string query = "insert into Gastos (Descripcion, Total, Fecha) values ('" +
                    nuevoGasto.Descripcion + "', '" + nuevoGasto.Total + "', '" + 
                    nuevoGasto.Fecha + "')";
            int filasInsertadas = executeNonQuery(query);
            return filasInsertadas;
        }
        public int Update(Transacciones laTransaccion)
        {
            string query = "update Transacciones set IdProducto='" + laTransaccion.IdProducto +
                "', Cantidad='" + laTransaccion.Cantidad + "', Total='" + laTransaccion.Total +
                "', Fecha='" + laTransaccion.Fecha + "', IdTipo='" + laTransaccion.IdTipo +
                "' where ID='" + laTransaccion.ID + "'";

            int filasActualizadas = ExecuteNonQuery(query);

            return filasActualizadas;
        }

        public int Delete(int Id)
        {
            string query = "delete from Transacciones where ID=" + Id;

            int filasEliminadas = ExecuteNonQuery(query);

            return filasEliminadas;
        }

        public Transacciones getById(int Id)
        {
            Conection Conection = new Conection();
            Transacciones transaccion = null;
            try
            {
                string query = "select tr.*, pr.Producto from Transacciones tr JOIN Productos pr ON " +
                "tr.IdProducto = pr.ID where tr.ID=" + Id;

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

        public List<Transacciones> ExecuteReader(string query)
        {

            List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();

            try
            {
                Conection Conection = new Conection();

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

        public List<Transacciones> getAll()
        {

            string query = "select tr.*, pr.Producto from Transacciones tr JOIN Productos pr ON " +
                "tr.IdProducto = pr.ID";

            List<Transacciones> laListaDeTransaccciones = ExecuteReader(query);

            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByDateInterval(String Desde, String Hasta, int Tipo)
        {
            string query = "select tr.*, pr.Producto from Transacciones tr JOIN Productos pr ON " +
                "tr.IdProducto = pr.ID where Fecha BETWEEN '" + Desde + "' AND '" + Hasta + "'" +
                " AND IdTipo=" + Tipo;

            List<Transacciones> laListaDeTransaccciones = ExecuteReader(query);

            return laListaDeTransaccciones;
        }

    }
}
