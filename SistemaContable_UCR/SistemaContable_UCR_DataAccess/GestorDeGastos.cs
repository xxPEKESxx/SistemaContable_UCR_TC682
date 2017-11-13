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
        public int update(Gastos nuevoGasto)
        {
            string query = "update Gastos set Descripcion='" + nuevoGasto.Descripcion +
                "', Total='" + nuevoGasto.Total + "', Fecha='" + nuevoGasto.Fecha +
                "' where ID='" + nuevoGasto.ID + "'";
            int filasActualizadas = executeNonQuery(query);
            return filasActualizadas;
        }

        public int delete(int Id)
        {
            string query = "delete from Gastos where ID=" + Id;
            int filasEliminadas = executeNonQuery(query);
            return filasEliminadas;
        }

        public Gastos getById(int id)
        {
            Conection Conection = new Conection();
            Gastos gasto = null;
            try
            {
                string query = "select * from Gastos where ID=" + id;

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
                                gasto = fillGasto(datos);
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

            return gasto;
        }

        public List<Gastos> getAll()
        {

            string query = "select * from Gastos";

            List<Gastos> listaDeGastos = executeReader(query);

            return listaDeGastos;
        }

        public List<Gastos> getByDateInterval(String Desde, String Hasta)
        {
            string query = "select * from Gastos where Fecha BETWEEN '" + Desde + "' AND '" + Hasta + "'" ;

            List<Gastos> listaDeGastos = executeReader(query);

            return listaDeGastos;
        }

        private List<Gastos> executeReader(string query)
        {

            List<Gastos> listaDeGastos = new List<Gastos>();

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

                                listaDeGastos.Add(fillGasto(datos));
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
            return listaDeGastos;
        }

        private Gastos fillGasto(SQLiteDataReader dato)
        {
            Gastos gasto = new Gastos();
            gasto.ID = dato.GetInt32(0);
            gasto.Descripcion = dato.GetString(1);
            gasto.Total = dato.GetFloat(2);
            gasto.Fecha = dato.GetString(3);
            return gasto;
        }

    }
}
