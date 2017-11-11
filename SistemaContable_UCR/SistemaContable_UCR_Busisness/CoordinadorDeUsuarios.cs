using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaContable_UCR_DataAccess;
namespace SistemaContable_UCR_Busisness
{
    public class CoordinadorDeUsuarios
    {
        public bool login(string dni, string password)
        {
            GestorDeUsuarios gestorUsuario = new GestorDeUsuarios();
            return gestorUsuario.login(dni,password);
        }
    }
}
