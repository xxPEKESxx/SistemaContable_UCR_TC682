using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace SistemaContable_UCR_DataAccess
{
    public class Conection
    {
        public SQLiteConnection getConection()
        {
             return new SQLiteConnection("Data Source=SC_UCR_TC682.s3db");
        }
    }
}
