using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaContable_UCR_Model
{
    public class Conection
    {
     public SQLiteConnection stringConection = new SQLiteConnection("Data Source = C:/Proyecto_Sistema_Contable_UCR/SistemaContable_UCR_TC682/SistemaContable_UCR/DB/SC_UCR_TC682.s3db");


        public bool StartSesion(string idUser,string password) {
            bool exists = false;
            stringConection.Open();

            string query = "select * from Users where IdUsers="+ idUser;
            SQLiteCommand command = new SQLiteCommand(query,stringConection);
            SQLiteDataReader datos = command.ExecuteReader();

            if (datos.GetString(1).Equals(idUser) && datos.GetString(4).Equals(password))
            {
                exists = true;

            }
            else {
                exists = false;
            }

             
       

            return exists;

        }
    }
}
