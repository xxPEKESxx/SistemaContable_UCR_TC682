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
        private Conection Conection = new Conection();

        

        public void Save(Transacciones laNuevaTransaccion)
        {
            try
            {
                SQLiteConnection stringConection = Conection.getConection();
                stringConection.Open();

                string query = "insert into Transacciones (IdProducto, Cantidad, Total, Fecha, IdTipo) values ('" + 
                    laNuevaTransaccion.IdProducto + "', '" + laNuevaTransaccion.Cantidad + "', '" + 
                    laNuevaTransaccion.Total + "', '" + laNuevaTransaccion.Fecha + "', '" + laNuevaTransaccion.IdTipo + "')";

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                int result = command.ExecuteNonQuery();

                stringConection.Close();
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
                SQLiteConnection stringConection = Conection.getConection();
                stringConection.Open();

                string query = "update Transacciones set IdProducto='" + laTransaccion.IdProducto +
                    "', Cantidad='" + laTransaccion.Cantidad + "', Total='" + laTransaccion.Total +
                    "', Fecha='" + laTransaccion.Fecha + "', IdTipo='" + laTransaccion.IdTipo +
                    "' where ID='" + laTransaccion.ID + "'";

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                int result = command.ExecuteNonQuery();

                stringConection.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Transacciones getById(int Id)
        {
            Transacciones transaccion = null;
            try
            {
                SQLiteConnection stringConection = Conection.getConection();
                stringConection.Open();

                string query = "select * from Transacciones where ID="+ Id;

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                SQLiteDataReader datos = command.ExecuteReader();

                command.Dispose();

                while (datos.Read())
                {
                    transaccion = fillTransaction(datos);
                }
                datos.Close();

                stringConection.Close();
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
                SQLiteConnection stringConection = Conection.getConection();
                stringConection.Open();

                string query = "delete from Transacciones where ID=" + Id;

                SQLiteCommand command = new SQLiteCommand(query, stringConection);

                int result = command.ExecuteNonQuery();

                stringConection.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return transaccion;
        }

        public List<Transacciones> getAll() {

            List<Transacciones> laListaDeTransaccciones = null;


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

        public List<Transacciones> getByDate(String Desde, String Hasta)
        {
            List<Transacciones> laListaDeTransaccciones = null;

            try {
                SQLiteConnection stringConection = Conection.getConection();
                stringConection.Open();

                string query = "select * from Transacciones where Fecha BETWEEN '" + Desde + "' AND '" + Hasta + "'";
                
                SQLiteCommand command = new SQLiteCommand(query, stringConection);
                SQLiteDataReader datos = command.ExecuteReader();

                command.Dispose();

                laListaDeTransaccciones = new List<Transacciones>();

                while (datos.Read())
                {
                    laListaDeTransaccciones.Add(fillTransaction(datos));
                }

                datos.Close();
                stringConection.Close();
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }


            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByType(int Tipo)
        {
            List<Transacciones> laListaDeTransaccciones = null;

            try
            {
                SQLiteConnection stringConection = Conection.getConection();
                stringConection.Open();

                string query = "select * from Transacciones where IdTipo='" + Tipo + "'";

                SQLiteCommand command = new SQLiteCommand(query, stringConection);
                SQLiteDataReader datos = command.ExecuteReader();

                command.Dispose();

                laListaDeTransaccciones = new List<Transacciones>();

                while (datos.Read())
                {
                    laListaDeTransaccciones.Add(fillTransaction(datos));
                }

                datos.Close();
                stringConection.Close();
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
