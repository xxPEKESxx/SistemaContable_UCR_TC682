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

                int result;
                string query = "insert into Transacciones values (" + laNuevaTransaccion.IdProducto +
                    ", " + laNuevaTransaccion.Cantidad + ", " + laNuevaTransaccion.Total + ", " +
                    laNuevaTransaccion.Fecha + ", " + laNuevaTransaccion.IdTipo + ")";

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                result = command.ExecuteNonQuery();

                if (result != 0)
                {
                    Console.WriteLine("exito");
                }
                else
                {
                    Console.WriteLine("ocurrió un error");
                }
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

                int result;
                string query = "update Transacciones set IdProducto=" + laTransaccion.IdProducto +
                    ", Cantidad=" + laTransaccion.Cantidad + ", Total=" + laTransaccion.Total +
                    ", Fecha=" + laTransaccion.Fecha + ", IdTipo=" + laTransaccion.IdTipo +
                    "where ID=" + laTransaccion.ID;

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                result = command.ExecuteNonQuery();

                if (result != 0)
                {
                    Console.WriteLine("exito");
                }
                else
                {
                    Console.WriteLine("ocurrió un error");
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
