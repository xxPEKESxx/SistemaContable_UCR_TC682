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

        public bool update(SistemaContable_UCR_Model.Transacciones laTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();

            Productos producto = coordinadorDeProductos.getById(laTransaccion.IdProducto);

            laTransaccion.Total = laTransaccion.Cantidad * producto.Precio;

            DateTime fecha = DateTime.Parse(laTransaccion.Fecha);
            laTransaccion.Fecha = dateTimeSQLite(fecha);

            int filasActualizadas = gestor.Update(laTransaccion);

            if (filasActualizadas > 0)
                return true;
            else return false;
        }

        private string dateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";

            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day);
        }
    }
}
