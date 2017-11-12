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

        public int ExecuteNonQuery(string query) {

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

        public int Save(Transacciones laNuevaTransaccion)
        {
            string query = "insert into Transacciones (IdProducto, Cantidad, Total, Fecha, IdTipo) values ('" + 
                    laNuevaTransaccion.IdProducto + "', '" + laNuevaTransaccion.Cantidad + "', '" + 
                    laNuevaTransaccion.Total + "', '" + laNuevaTransaccion.Fecha + "', '" + laNuevaTransaccion.IdTipo + "')";

            int filasInsertadas = ExecuteNonQuery(query);  

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

        public List<Transacciones> ExecuteReader(string query) {

            List<Transacciones> laListaDeTransaccciones = new List<Transacciones>();

            try {
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

        public List<Transacciones> getAll() {

            string query = "select tr.*, pr.Producto from Transacciones tr JOIN Productos pr ON " +
                "tr.IdProducto = pr.ID";

            List<Transacciones> laListaDeTransaccciones = ExecuteReader(query);

            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByDateInterval(String Desde, String Hasta, int Tipo)
        {
            string query = "select tr.*, pr.Producto from Transacciones tr JOIN Productos pr ON " +
                "tr.IdProducto = pr.ID where Fecha BETWEEN '" + Desde + "' AND '" + Hasta + "'"+
                " AND IdTipo="+Tipo;

            List<Transacciones> laListaDeTransaccciones = ExecuteReader(query);

            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByType(int Tipo)
        {

            string query = "select tr.*, pr.Producto from Transacciones tr JOIN Productos pr ON "+
                "tr.IdProducto = pr.ID WHERE tr.IdTipo='" + Tipo + "'";

            List<Transacciones> laListaDeTransaccciones = ExecuteReader(query);

            return laListaDeTransaccciones;
        }

        public List<Transacciones> getByProductName(string Nombre, int Tipo)
        {
            string query = "select tr.*, pr.Producto from Transacciones tr JOIN Productos pr "+
                    "ON tr.IdProducto = pr.ID WHERE pr.Producto LIKE '%"+Nombre+"%' AND tr.Idtipo="+Tipo;

            List<Transacciones> laListaDeTransaccciones = ExecuteReader(query);

            return laListaDeTransaccciones;
        }

        public float[] getUtility(string query) {

            float[] utilidad = new float[3];

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

                            if (datos.GetValue(0).ToString() != "")
                            {
                                float totalCompra = float.Parse(datos.GetValue(0).ToString());
                                utilidad.SetValue(totalCompra, 0);
                            }
                            if (datos.GetValue(1).ToString() != "")
                            {
                                float totalVenta = float.Parse(datos.GetValue(1).ToString());
                                utilidad.SetValue(totalVenta, 1);
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

            return utilidad;
        }

        public float[] getUtilityByDateInterval(string desde, string hasta)
        {

           string query = "select SUM(CASE WHEN IdTipo = 2 THEN Total END) totalCompras, "+
                    "SUM(CASE WHEN IdTipo = 1 THEN Total END) totalVentas from Transacciones where Fecha BETWEEN '" + 
                    desde + "' AND '" + hasta + "'";

            float[] utilidad = getUtility(query);

            return utilidad;
        }

        public float[] getTotalUtility()
        {

            string query = "select SUM(CASE WHEN IdTipo = 2 THEN Total END) totalCompras, " +
                     "SUM(CASE WHEN IdTipo = 1 THEN Total END) totalVentas from Transacciones";

            float[] utilidad = getUtility(query);

            return utilidad;
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
                Producto = datos.GetString(6),
            };

            return transaccion;
        }
    }
}
