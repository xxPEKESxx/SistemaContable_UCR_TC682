using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using SistemaContable_UCR_Model;

namespace SistemaContable_UCR_DataAccess
{
    public class GestorDeUsuarios
    {
        public bool login(string DNI, string password)
        {
            List<Usuarios> listaUsuarios = new List<Usuarios>();
            SQLiteConnection stringConection;
            Conection myconection = new Conection();

            stringConection = myconection.getConection();

            stringConection.Open();
            string query = "select * from Users Where DNI='"+ DNI +"'AND UserPassword='"+password +"'";
            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();
            if (datos.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
