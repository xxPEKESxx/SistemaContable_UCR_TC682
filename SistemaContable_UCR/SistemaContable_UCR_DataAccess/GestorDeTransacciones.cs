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

        public void Save(Transacciones laNuevaTransaccion)
        {
            try
            {
                SQLiteConnection stringConection;
                Conection Conection = new Conection();

                stringConection = Conection.getConection();
                stringConection.Open();
                string query = "insert into Transacciones (IdProducto, Cantidad, Total, Fecha, IdTipo) values ('" + laNuevaTransaccion.IdProducto +
                    "', '" + laNuevaTransaccion.Cantidad + "', '" + laNuevaTransaccion.Total + "', '" +
                    laNuevaTransaccion.Fecha + "', '" + laNuevaTransaccion.IdTipo + "')";

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Update(Transacciones laTransaccion)
        {
            try
            {
                SQLiteConnection stringConection;
                Conection Conection = new Conection();

                stringConection = Conection.getConection();
                stringConection.Open();

                string query = "update Transacciones set IdProducto=" + laTransaccion.IdProducto +
                    ", Cantidad=" + laTransaccion.Cantidad + ", Total=" + laTransaccion.Total +
                    ", Fecha=" + laTransaccion.Fecha + ", IdTipo=" + laTransaccion.IdTipo +
                    "where ID=" + laTransaccion.ID;

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                command.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Transacciones Find(int Id)
        {
            Transacciones transaccion = null;
            try
            {
                SQLiteConnection stringConection;
                Conection Conection = new Conection();

                stringConection = Conection.getConection();
                stringConection.Open();

                string query = "select * from Transacciones where ID="+ Id;

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                SQLiteDataReader datos = command.ExecuteReader();
                
                while (datos.Read())
                {
                    transaccion = new Transacciones
                    {
                        ID = datos.GetInt32(0),
                        IdProducto = datos.GetInt32(1),
                        Cantidad = datos.GetInt32(2),
                        Total = datos.GetFloat(3),
                        Fecha = datos[4].ToString(),
                        IdTipo = datos.GetInt32(5),
                    };

                    Console.WriteLine(datos.GetInt32(0));
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return transaccion;
        }

        public Transacciones Delete(int Id)
        {
            Transacciones transaccion = null;
            try
            {
                SQLiteConnection stringConection;
                Conection Conection = new Conection();

                stringConection = Conection.getConection();
                stringConection.Open();

                string query = "delete from Transacciones where ID=" + Id;

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                int result = command.ExecuteNonQuery();

                Console.WriteLine(result);
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return transaccion;
        }

        public List<Transacciones> getAll() {

            List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();

            SQLiteConnection stringConection;
            Conection Conection = new Conection();

            stringConection = Conection.getConection();
            stringConection.Open();

            string query = "select * from Transacciones";

            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();

            while (datos.Read()) {

                Transacciones transaccion = new Transacciones
                {
                    ID = datos.GetInt32(0),
                    IdProducto = datos.GetInt32(1),
                    Cantidad = datos.GetInt32(2),
                    Total = datos.GetFloat(3),
                    Fecha = datos[4].ToString(),
                    IdTipo = datos.GetInt32(5),
                };

                laListaDeTransaccciones.Add(transaccion);
            }

            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByDate(String Fecha)
        {

            List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();

            SQLiteConnection stringConection;
            Conection Conection = new Conection();

            stringConection = Conection.getConection();
            stringConection.Open();

            string query = "select * from Transacciones where Fecha="+ Fecha;

            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();

            while (datos.Read())
            {

                Transacciones transaccion = new Transacciones
                {
                    ID = datos.GetInt32(0),
                    IdProducto = datos.GetInt32(1),
                    Cantidad = datos.GetInt32(2),
                    Total = datos.GetFloat(3),
                    Fecha = datos[4].ToString(),
                    IdTipo = datos.GetInt32(5),
                };

                laListaDeTransaccciones.Add(transaccion);
            }

            return laListaDeTransaccciones;
        }
    }
}
