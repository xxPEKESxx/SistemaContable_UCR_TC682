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

            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();

            Productos producto = coordinadorDeProductos.getById(laNuevaTransaccion.IdProducto);

            laNuevaTransaccion.Total = laNuevaTransaccion.Cantidad * producto.Precio;
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
            DateTime fecha = DateTime.Parse(laTransaccion.Fecha);
            laTransaccion.Fecha = DateTimeSQLite(fecha);

            gestor.Update(laTransaccion);
        }

        public Transacciones getById(int Id)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getById(Id);
        }

        public void Delete(int Id)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            gestor.Delete(Id);
        }

        public List<Transacciones> getAll() {

            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getAll();
        }

        public List<Transacciones> getByDate(DateTime Desde, DateTime Hasta)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            string buscarDesde = DateTimeSQLite(Desde);
            string buscarHasta = DateTimeSQLite(Hasta.AddDays(1));

            Console.WriteLine(buscarHasta);

            return gestor.getByDate(buscarDesde, buscarHasta);
        }

        public List<Transacciones> getByType(int Tipo)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getByType(Tipo);
        }
    }
}
