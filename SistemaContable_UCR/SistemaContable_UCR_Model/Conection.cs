using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;


namespace SistemaContable_UCR_Model
{
    public class Conection
    {

        private SQLiteConnection stringConection;

   

        public bool StartSesion(string idUser,string password) {

            bool exists = false;
               
                stringConection = new SQLiteConnection("Data Source=SC_UCR_TC682.s3db");
                stringConection.Open();
            string query = "select * from Users";
                SQLiteCommand command = new SQLiteCommand(query, stringConection);
                SQLiteDataReader datos = command.ExecuteReader();
            while (datos.Read()) {

                if (datos.GetString(1).Equals(idUser) && datos.GetString(4).Equals(password))
                {
                    exists = true;

                }
                else
                {
                    exists = false;
                }
            }
                


           
      


         


            return exists;

        }
    }
}
