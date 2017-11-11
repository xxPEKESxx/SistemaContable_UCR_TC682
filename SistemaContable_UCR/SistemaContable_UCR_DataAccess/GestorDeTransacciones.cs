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
            Conection Conection = new Conection();
            string query = "insert into Transacciones (IdProducto, Cantidad, Total, Fecha, IdTipo) values ('" + 
                    laNuevaTransaccion.IdProducto + "', '" + laNuevaTransaccion.Cantidad + "', '" + 
                    laNuevaTransaccion.Total + "', '" + laNuevaTransaccion.Fecha + "', '" + laNuevaTransaccion.IdTipo + "')";
                
                using (SQLiteConnection stringConection = new SQLiteConnection(Conection.getConection()))
                {
                    stringConection.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, stringConection))
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    stringConection.Close();
                }
        }

        public void Update(Transacciones laTransaccion)
        {
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
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                    }
                    c.Close();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
            }
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

        public Transacciones Delete(int Id)
        {
        Conection Conection = new Conection();
        Transacciones transaccion = null;
            try
            {
                string query = "delete from Transacciones where ID=" + Id;

                using (SQLiteConnection c = new SQLiteConnection(Conection.getConection()))
                {
                    c.Open();
                    using (SQLiteCommand cmd = new SQLiteCommand(query, c))
                    {
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
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

        public List<Transacciones> getAll() {
        Conection Conection = new Conection();
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
        Conection Conection = new Conection();
        List<Transacciones> laListaDeTransaccciones = null;

            try {

                string query = "select * from Transacciones where Fecha BETWEEN '" + Desde + "' AND '" + Hasta + "'";

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
        List<Transacciones> laListaDeTransaccciones = null;

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
