using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaContable_UCR_DataAccess;
using SistemaContable_UCR_Model;
namespace SistemaContable_UCR_Busisness
{
    public class CoordinadorDeGastos
    {
        public bool save(Gastos nuevoGasto)
        {
            GestorDeGastos gestorDeGasto = new GestorDeGastos();
            nuevoGasto.Fecha = dateTimeSQLite(DateTime.Now);

            int filasInsertadas = gestorDeGasto.save(nuevoGasto);

            if (filasInsertadas > 0)
                return true;
            else return false;
        }

        public bool update(Gastos nuevoGasto)
        {
            GestorDeGastos gestorDeGasto = new GestorDeGastos();
            nuevoGasto.Fecha = dateTimeSQLite(DateTime.Now);

            if (gestorDeGasto.update(nuevoGasto) > 0) return true;
            else return false;
        }

        private string dateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";

            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day);
        }

        public bool delete(int idGasto)
        {
            GestorDeGastos gestorDeGasto = new GestorDeGastos();
            if (gestorDeGasto.delete(idGasto) > 0) return true;
            else return false;
        }

        public Gastos getById(int idGasto)
        {
            GestorDeGastos gestorDeGasto = new GestorDeGastos();
            return gestorDeGasto.getById(idGasto);
        }

        public List<Gastos> getAll()
        {
            GestorDeGastos gestorDeGasto = new GestorDeGastos();
            return gestorDeGasto.getAll();
        }

        public List<Gastos> getByDateInterval(DateTime from, DateTime to)
        {
            GestorDeGastos gestorDeGasto = new GestorDeGastos();
            string searchFrom = dateTimeSQLite(from);
            string searchTo = dateTimeSQLite(to.AddDays(1));
            return gestorDeGasto.getByDateInterval(searchFrom, searchTo);
        }
    }
}
