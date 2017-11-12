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

        public bool Save(SistemaContable_UCR_Model.Transacciones laNuevaTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();

            Productos producto = coordinadorDeProductos.getById(laNuevaTransaccion.IdProducto);

            laNuevaTransaccion.Total = laNuevaTransaccion.Cantidad * producto.Precio;
            laNuevaTransaccion.Fecha = DateTimeSQLite(DateTime.Now);

            if (gestor.Save(laNuevaTransaccion) > 0)
                return true;
            else return false;
        }

        private string DateTimeSQLite(DateTime datetime)
        {
            string dateTimeFormat = "{0}-{1}-{2}";

            return string.Format(dateTimeFormat, datetime.Year, datetime.Month, datetime.Day);
        }

        public bool Update(SistemaContable_UCR_Model.Transacciones laTransaccion)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();
            CoordinadorDeProductos coordinadorDeProductos = new CoordinadorDeProductos();

            Productos producto = coordinadorDeProductos.getById(laTransaccion.IdProducto);

            laTransaccion.Total = laTransaccion.Cantidad * producto.Precio;

            DateTime fecha = DateTime.Parse(laTransaccion.Fecha);
            laTransaccion.Fecha = DateTimeSQLite(fecha);

            if (gestor.Update(laTransaccion) > 0)
                return true;
            else return false;
        }

        public Transacciones getById(int Id)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getById(Id);
        }

        public bool Delete(int Id)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            if (gestor.Delete(Id) > 0)
                return true;
            else return false;
        }

        public List<Transacciones> getAll() {

            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getAll();
        }

        public List<Transacciones> getComprasByDate(DateTime Desde, DateTime Hasta)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            string buscarDesde = DateTimeSQLite(Desde);
            string buscarHasta = DateTimeSQLite(Hasta.AddDays(1));
            int tipo = (int)Tipos.Compra;

            return gestor.getByDateInterval(buscarDesde, buscarHasta, tipo);
        }

        public List<Transacciones> getVentasByDate(DateTime Desde, DateTime Hasta)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            string buscarDesde = DateTimeSQLite(Desde);
            string buscarHasta = DateTimeSQLite(Hasta.AddDays(1));
            int tipo = (int)Tipos.Venta;

            return gestor.getByDateInterval(buscarDesde, buscarHasta, tipo);
        }

        public float[] getUtilityByMonth(DateTime Fecha)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();
            float[] utilidad;

            string dateTimeFormat = "{0}-{1}-{2}";

            string desde = string.Format(dateTimeFormat, Fecha.Year, Fecha.Month, 1);
            string hasta = string.Format(dateTimeFormat, Fecha.Year, Fecha.Month, 31);

            utilidad = gestor.getUtilityByMonth(desde, hasta);

            float utilidadTotal = float.Parse(utilidad[1].ToString()) - float.Parse(utilidad[0].ToString());
            utilidad.SetValue(utilidadTotal, 2);

            return utilidad;
        }

        public List<Transacciones> getByType(int Tipo)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getByType(Tipo);
        }

        public List<Transacciones> getComprasByProductName(string Nombre)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getByProductName(Nombre, 2);
        }

        public List<Transacciones> getVentasByProductName(string Nombre)
        {
            GestorDeTransacciones gestor = new GestorDeTransacciones();

            return gestor.getByProductName(Nombre, 1);
        }
    }
}
