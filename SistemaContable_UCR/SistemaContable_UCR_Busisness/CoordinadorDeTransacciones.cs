using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaContable_UCR_Model;
using SistemaContable_UCR_DataAccess;


namespace SistemaContable_UCR_Busisness
{
    public class CoordinadorDeTransacciones
    {

        public void Save(SistemaContable_UCR_Model.Transacciones laNuevaTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();


            laNuevaTransaccion.Fecha = DateTimeSQLite(DateTime.Now);

            gestor.Save(laNuevaTransaccion);
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";

            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day);
        }

        public void Update(SistemaContable_UCR_Model.Transacciones laTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            gestor.Update(laTransaccion);
        }

        public List<Transacciones> getAll() {

            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getAll();
        }
    }
}
