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
            SQLiteConnection stringConection;
            Conection myconection = new Conection();

            stringConection = myconection.getConection();

            stringConection.Open();
            string query = "select * from Users Where DNI='"+ DNI +"'AND UserPassword='"+password +"'";
            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();
            if (datos.Read())
            {
                stringConection.Close();
                return true;
            }
            else
            {
                stringConection.Close();
                return false;
            }
        }

        public int saveUser(Usuarios user)
        {
            Conection conection = new Conection();
            SQLiteConnection stringConection = conection.getConection();

            int result;
            try
            {
                stringConection.Open();
                string query = "insert into Users (DNI,UserName,UserLastName,UserPassword) values('" +
                     user.DNI + "','" + user.UserName + "','" + user.UserLastName + "','" + user.UserPassword + "')";
                SQLiteCommand cmd = new SQLiteCommand();
                cmd.Connection = stringConection;
                cmd.CommandText = query;
                result = cmd.ExecuteNonQuery();
                stringConection.Close();
                return result;
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine(ex.Message);
                return 1;
            }

        }
        public Usuarios getUserForDNI(string DNI)
        {
            Usuarios user = new Usuarios();
            SQLiteConnection stringConection;
            Conection myconection = new Conection();

            stringConection = myconection.getConection();

            stringConection.Open();
            string query = "select * from Users Where DNI='" + DNI + "'";
            SQLiteCommand command = new SQLiteCommand(query, stringConection);
            SQLiteDataReader datos = command.ExecuteReader();
            if (datos.Read())
            {
                user.ID = datos.GetInt32(0);
                user.DNI = datos.GetString(1);
                user.UserName = datos.GetString(2);
                user.UserLastName = datos.GetString(3);
                user.UserPassword = datos.GetString(4);
                stringConection.Close();
                return user;
            }
            else
            {
                stringConection.Close();
                return user;
            }
        }
    }
}
